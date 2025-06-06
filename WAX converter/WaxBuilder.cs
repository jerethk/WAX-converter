﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WAX_converter
{

    // A static class containing static methods used to create a new WAX file //
    public static class WaxBuilder
    {
        public static Waxfile BuildWax(int LogicType, List<Action> sourceActionList, List<Sequence> sourceSequenceList, List<Frame> sourceFrameList, List<Bitmap> sourceImageList, DFPal palette, Color transparentColour, bool includeIlluminatedColours, bool onlyCommonColours, bool compress)
        {
            ProgressBarWindow progressMeter = new ProgressBarWindow();
            progressMeter.Show();
            
            Waxfile newWax = new Waxfile();

            switch (LogicType)
            {
                case 0: // anim
                    newWax.numActions = 1;
                    break;
                case 1: // scenery
                    newWax.numActions = 2;
                    break;
                case 2: // enemy
                    newWax.numActions = 13;
                    break;
                case 4: // remote
                    newWax.numActions = 4;
                    break;
                case 3: // dark trooper
                case 5: // sewer creature
                case 6: // mohc
                    newWax.numActions = 14;
                    break;
                case 7: // all 32
                default:
                    newWax.numActions = 32;
                    break;
            }

            // Header
            newWax.Nseqs = sourceSequenceList.Count;
            newWax.Nframes = sourceFrameList.Count;
            newWax.Ncells = sourceImageList.Count;

            newWax.actionAddresses = new int[32];

            for (int a = 0; a < newWax.numActions; a++)     // used action addresses
            {
                newWax.actionAddresses[a] = 160 + a * 156;
            }

            for (int a = newWax.numActions; a < 32; a++)    // empty action addresses
            {
                newWax.actionAddresses[a] = 0;
            }

            // Set a default sequence - to use in place of any that have been left empty
            var defaultSequenceIndex = sourceSequenceList.FindIndex(s => s.frameIndexes[0] != -1);
                
            // Actions
            newWax.Actions = sourceActionList;
            for (int a = 0; a < newWax.numActions; a++)
            {
                for (int v = 0; v < 32; v++)    // calculate the address for each view (x32)
                {
                    // If the view has been assigned an empty sequence, use the default sequence instead
                    var assignedSequenceIndex = newWax.Actions[a].seqIndexes[v];
                    bool assignedSequenceIsEmpty = sourceSequenceList[assignedSequenceIndex].frameIndexes[0] == -1;
                    newWax.Actions[a].viewAddresses[v] = assignedSequenceIsEmpty
                        ? 160 + newWax.numActions * 156 + (defaultSequenceIndex * 144)
                        : 160 + newWax.numActions * 156 + (newWax.Actions[a].seqIndexes[v] * 144);
                }
            }

            // Sequences
            newWax.Sequences = sourceSequenceList;

            for (int s = 0; s < newWax.Nseqs; s++)
            {
                for (int f = 0; f < 32; f++)    // calculate the frame addresses
                {
                    if (newWax.Sequences[s].frameIndexes[f] == -1)  // empty frame
                    {
                        newWax.Sequences[s].frameAddresses[f] = 0;
                    }
                    else
                    {
                        newWax.Sequences[s].frameAddresses[f] = 160 + newWax.numActions * 156 + newWax.Nseqs * 144 + (newWax.Sequences[s].frameIndexes[f] * 32);
                    }
                }
            }

            // create Cells from bitmap images. Show progress meter because this can be lengthy
            progressMeter.progressBar.Maximum = sourceImageList.Count + 1;
            progressMeter.progressBar.Value = 1;

            int firstCellAddress = 160 + newWax.numActions * 156 + newWax.Nseqs * 144 + newWax.Nframes * 32;
            for (int i = 0; i < sourceImageList.Count; i++)  
            {
                Cell newCell = new Cell();
                newCell.SizeX = sourceImageList[i].Width;
                newCell.SizeY = sourceImageList[i].Height;
                newCell.ColOffs = 0;    // always zero

                newCell.Pixels = new short[newCell.SizeX, newCell.SizeY];
                newCell.CreateCellImage(sourceImageList[i], palette, transparentColour, includeIlluminatedColours, onlyCommonColours);       // result is stored in the cell object's Pixels property

                if (compress)
                {
                    newCell.CompressCell();     // result is stored in the cell object's compressedData property (List of bytes)
                }
                else
                {
                    newCell.Compressed = 0;
                    newCell.DataSize = 0;
                }
                
                if (i == 0)
                {
                    newCell.address = firstCellAddress;
                }
                else
                {
                    if (compress)
                    {
                        newCell.address = newWax.Cells[i - 1].address + newWax.Cells[i - 1].DataSize;   // address of prev cell + datasize of previous cell
                    }
                    else // not compressed
                    {
                        newCell.address = newWax.Cells[i - 1].address + 24 + newWax.Cells[i - 1].SizeX * newWax.Cells[i - 1].SizeY;   // header (24 bytes) + image size (x * y)
                    }
                }

                newWax.Cells.Add(newCell);
                progressMeter.progressBar.Value++;
            }

            // Frames
            newWax.Frames = sourceFrameList;
            for (int f = 0; f < sourceFrameList.Count; f++)
            {
                // set cell addresses
                int cellIndex = newWax.Frames[f].CellIndex;
                newWax.Frames[f].CellAddress = newWax.Cells[cellIndex].address;  
            }

            progressMeter.Close();
            progressMeter.Dispose();
            return newWax;
        }
        
        public static short MatchPixeltoPal(Color pixelColour, DFPal palette, bool includeIlluminatedColours, bool onlyCommonColours)
        {
            // Color quantizes to the DF PAL using Euclidean distance technique
            int sourceRed = pixelColour.R;
            int sourceGreen = pixelColour.G;
            int sourceBlue = pixelColour.B;

            short startColour;

            if (includeIlluminatedColours)
            {
                startColour = 1;        // first 32 colours are always bright / illuminated
            }
            else
            {
                startColour = 32;
            }

            double smallestDistance = 500;
            short bestMatch = 0;

            for (short i = startColour; i < 256; i++)    
            {
                if (i >= 24 && i <= 31) continue;                           // skip the special (HUD) colours
                if (onlyCommonColours && i >= 208 && i <= 254) continue;    // colours 208-254 are different in different PALs
                
                int deltaRed = sourceRed - palette.Colours[i].R;
                int deltaGreen = sourceGreen - palette.Colours[i].G;
                int deltaBlue = sourceBlue - palette.Colours[i].B;
                double distance = Math.Sqrt(deltaRed * deltaRed + deltaGreen * deltaGreen + deltaBlue * deltaBlue);

                if (distance < smallestDistance)
                {
                    smallestDistance = distance;
                    bestMatch = i;
                }
            }

            return bestMatch;
        }



        /*
        public static Bitmap quantizeBitmap(Bitmap sourceImage, DFPal palette)
        {
            // Color quantizes to the PAL using Euclidean distance technique
            
            Bitmap newImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int x = 0; x < sourceImage.Width; x ++ )
            {
                for (int y = 0; y < sourceImage.Height; y++ )
                {
                    int sourceRed = sourceImage.GetPixel(x, y).R;
                    int sourceGreen = sourceImage.GetPixel(x, y).G;
                    int sourceBlue = sourceImage.GetPixel(x, y).B;

                    double smallestDistance = 500;
                    int bestMatch = 0;

                    for (int i = 32; i < 256; i++)     // exclude first 32 colours because these are usually always bright on the colourmap
                    {
                        int deltaRed = sourceRed - palette.Colours[i].R;
                        int deltaGreen = sourceGreen - palette.Colours[i].G;
                        int deltaBlue = sourceBlue - palette.Colours[i].B;
                        double distance = Math.Sqrt(deltaRed * deltaRed + deltaGreen * deltaGreen + deltaBlue * deltaBlue);

                        if (distance < smallestDistance)
                        {
                            smallestDistance = distance;
                            bestMatch = i;
                        }
                    }

                    int newRed = palette.Colours[bestMatch].R;
                    int newGreen = palette.Colours[bestMatch].G;
                    int newBlue = palette.Colours[bestMatch].B;

                    newImage.SetPixel(x, y, Color.FromArgb(255, newRed, newGreen, newBlue));
                }
            }

            return newImage;
        }
        */
    }
}
