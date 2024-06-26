﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace WAX_converter
{
    public class Cell
    {
        // Properties
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public int Compressed { get; set; }
        public int DataSize { get; set; }       // used for compressed cells only. Equals size of entire cell, including 24 byte header
        public int ColOffs { get; set; }
        public int pad1 { get; set; }
        
        public int address { get; set; }        // address where this cell is located in WAX file
        public short[,] Pixels { get; set; }     // the image as an array [x, y] of palette references, from the WAX file (same as FME). Uses short (instead of byte) so transparent pixels can be recorded as -1
        public int[] columnOffsets { get; set; }    // for compressed data
        public List<byte> compressedData { get; set; }   
        public Bitmap bitmap { get; set; }

        // Methods
        public void UncompressImage()
        {
            // uncompress data to the pixel array, column by column
            int dataPosition = 0; 
            for (int x = 0; x < this.SizeX; x++)
            {
                int y = 0;
                int numPixels;

                while (y < this.SizeY)
                {
                    byte b = this.compressedData[dataPosition];
                    if (b >= 128)    // transparent section
                    {
                        numPixels = b - 128;
                        for (int i = 0; i < numPixels; i++)
                        {
                            this.Pixels[x, y] = -1;  
                            y++;
                        }

                        dataPosition++;
                    }
                    else            // non-transparent section
                    {
                        numPixels = b;
                        dataPosition++;
                        for (int i = 0; i < numPixels; i++)
                        {
                            // index 0 is also transparent!
                            this.Pixels[x, y] = this.compressedData[dataPosition] == 0
                                ? (short) -1
                                : this.compressedData[dataPosition];
                            
                            y++;
                            dataPosition++;
                        }
                    }
                }

            }
        }

        public void CreateBitmap(DFPal palette, BitmapTransparencyOption transparencyOption = BitmapTransparencyOption.Black)
        {
            this.bitmap = new Bitmap(this.SizeX, this.SizeY, System.Drawing.Imaging.PixelFormat.Format32bppArgb);   //, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
            
            for (int x = 0; x < this.SizeX; x++)
            {
                for (int y = 0; y < this.SizeY; y++)
                {
                    short n = this.Pixels[x, y];
                    Color pixelColour;

                    if (n == -1)    // transparent pixel
                    {
                        switch (transparencyOption)
                        {
                            case BitmapTransparencyOption.Magenta:
                                pixelColour = Color.FromArgb(255, 255, 0, 255);
                                break;

                            case BitmapTransparencyOption.White:
                                pixelColour = Color.FromArgb(255, 255, 255, 255);
                                break;

                            case BitmapTransparencyOption.AlphaTransparent:
                                pixelColour = Color.FromArgb(0, 0, 0, 0);
                                break;

                            default:
                                pixelColour = Color.FromArgb(255, 0, 0, 0);     // black
                                break;
                        }
                    }
                    else
                    {
                        int r = palette.Colours[n].R;
                        int g = palette.Colours[n].G;
                        int b = palette.Colours[n].B;
                        pixelColour = Color.FromArgb(255, r, g, b);
                    }

                    this.bitmap.SetPixel(x, y, pixelColour);     
                }
            }

            this.bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY); // need to flip it upside down, because wax stores image data from bottom to top
        }

        public void CreateCellImage(Bitmap bitmap, DFPal palette, Color transparentColour, bool includeIlluminatedColours, bool onlyCommonColours)
        {
            
            // flip upside down
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            
            for (int x = 0; x < this.SizeX; x++)
            {
                for (int y = 0; y < this.SizeY; y++)
                {
                    var colour = bitmap.GetPixel(x, y);

                    if (colour == transparentColour || colour.A == 0)
                    {
                        this.Pixels[x, y] = -1;     // transparent
                    }
                    else
                    {
                        short colourIndex = WaxBuilder.MatchPixeltoPal(colour, palette, includeIlluminatedColours, onlyCommonColours);
                        this.Pixels[x, y] = colourIndex;
                    }
                }
            }

            // reflip so can use again
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
        }

        public void CompressCell()
        {
            List<byte>[] columnData = new List<byte>[this.SizeX];   // an array of byte-lists.

            for (int x = 0; x < this.SizeX; x++)    // compress each column of the image
            {
                List<byte> thisColumn = new List<byte>(); 

                int y = 0;
                while (y < this.SizeY)
                {
                    // note: because of the way data is encoded, cannot do a run of more than 127 coloured pixels or transparent pixels
                    byte counter;

                    if (this.Pixels[x, y] == -1)    // transparent run
                    {
                        counter = 1;
                        
                        while (y < this.SizeY - 1 && this.Pixels[x, y+1] == -1 && counter < 127)    
                        {
                            y++;
                            counter++;
                        }

                        // write run of transparent pixels
                        thisColumn.Add((byte) (128 + counter));
                        
                        y += 1; 
                    }
                    else                        // non-transparent run
                    {
                        int startOfRun = y;
                        counter = 1;

                        while (y < this.SizeY - 1 && this.Pixels[x, y + 1] != -1 && counter < 127)
                        {
                            y++;
                            counter++;
                        }

                        thisColumn.Add(counter);    // number of non-transparent pixels

                        // go back to start of run and add the pixels
                        y = startOfRun;
                        for (int i = 0; i < counter; i++)
                        {
                            thisColumn.Add((byte) this.Pixels[x, y]);
                            y++;
                        }
                    }
                }

                columnData[x] = thisColumn;
            }

            // Set column offsets
            this.columnOffsets = new int[this.SizeX];
            this.columnOffsets[0] = 24 + (4 * this.SizeX);      // offset of first column, always 24 + (4 * sizeX)  =  header + offsets table  

            for (int x = 1; x < this.SizeX; x++)        // offsets of remaining columns
            {
                this.columnOffsets[x] = this.columnOffsets[x - 1] + columnData[x - 1].Count; // add the size of the previous column (number of bytes in the list) to the offset of the previous column
            }

            // transfer the compressed columns to a single list of bytes
            this.compressedData = new List<byte>();
            foreach (List<byte> col in columnData)
            {
                foreach (byte b in col)
                {
                    this.compressedData.Add(b);
                }
            }

            // Set Compressed and DataSize
            this.Compressed = 1;
            this.DataSize = 24 + (4 * this.SizeX) + this.compressedData.Count;
        }

        public void WriteToFile(BinaryWriter fileWriter, bool compress)
        {
            fileWriter.Write(this.SizeX);
            fileWriter.Write(this.SizeY);
            fileWriter.Write(this.Compressed);
            fileWriter.Write(this.DataSize);
            fileWriter.Write(this.ColOffs);
            fileWriter.Write(this.pad1);

            if (compress)
            {
                foreach (int i in this.columnOffsets)
                {
                    fileWriter.Write(i);
                }

                foreach (byte b in this.compressedData)
                {
                    fileWriter.Write(b);
                }
            }
            else    // uncompressed
            {
                for (int x = 0; x < this.SizeX; x++)
                {
                    for (int y = 0; y < this.SizeY; y++)
                    {
                        byte b;
                        if (this.Pixels[x, y] == -1)
                        {
                            b = 0;  // transparent = index 0
                        }
                        else
                        {
                            b = (byte)this.Pixels[x, y];
                        }

                        fileWriter.Write(b);
                    }
                }
            }
        }
    }

    public enum BitmapTransparencyOption
    {
        Black,
        Magenta,
        White,
        AlphaTransparent
    }
}
