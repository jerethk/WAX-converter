using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace WAX_converter
{
    internal static class RemasterImagesImporter
    {
        public static List<byte[]> LoadDataFromFile(string filename)
        {
            var result = new List<byte[]>();

            try
            {
                using (var fileReader = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    var numImages = fileReader.ReadInt32();
                    var imageSizesinPixels = new int[numImages];

                    for (var i = 0; i < numImages; i++)
                    {
                        imageSizesinPixels[i] = fileReader.ReadInt32();
                    }

                    for (var i = 0; i < numImages; i++)
                    {
                        var imageData = fileReader.ReadBytes(imageSizesinPixels[i] * 4);
                        result.Add(imageData);
                    }
                }
                
                return result;
            }
            catch
            {
                return null;
            }
        }

        public static (List<(int, Bitmap)>, List<(int, Bitmap)>, List<(int, Bitmap)>) CreateBitmapsFromData(Waxfile wax, List<byte[]> data)
        {
            var bitmaps = new List<(int CellAddress, Bitmap Image)>();
            var alphaBitmaps = new List<(int CellAddress, Bitmap Image)>();
            var combinedBitmaps = new List<(int CellAddress, Bitmap Image)>();

            var processedCells = new List<int>();
            var imageCount = 0;

            // Cells are processed in the order in which they are referenced in the WAX hierarchy
            for (var a = 0; a < wax.numActions; a++)
            {
                var action = wax.Actions[a];
                for (var view = 0; view < 32; view++)
                {
                    var sequence = wax.Sequences[action.seqIndexes[view]];
                    for (var f = 0; f < sequence.numFrames; f++)
                    {
                        var frame = wax.Frames[sequence.frameIndexes[f]];
                        
                        if (processedCells.Contains(frame.CellIndex))
                        {
                            continue;
                        }

                        var cell = wax.Cells[frame.CellIndex];
                        var imageWidth = cell.SizeX * 2;
                        var imageHeight = cell.SizeY * 2;

                        if (imageWidth * imageHeight * 4 != data[imageCount].Length)
                        {
                            continue;   // The image in the data doesn't match the cell so pull out
                        }
                        
                        // Put the raw data into an array of pixels
                        var pixelArray = new Pixel[imageWidth, imageHeight];
                        var pixelCount = 0;
                        for (var y = 0; y < imageHeight; y++)
                        {
                            for (var x = imageWidth - 1; x >= 0; x--)
                            {
                                var pxl = new Pixel();
                                pxl.Red = data[imageCount][pixelCount * 4];
                                pxl.Green = data[imageCount][pixelCount * 4 + 1];
                                pxl.Blue = data[imageCount][pixelCount * 4 + 2];
                                pxl.Alpha = data[imageCount][pixelCount * 4 + 3];
                                pixelArray[(x), y] = pxl;

                                pixelCount++;
                            }
                        }

                        // Create image bitmap without alpha
                        var bitmap = new Bitmap(imageWidth, imageHeight);
                        for (var x = 0; x < imageWidth; x++)
                        {
                            for (var y = 0; y < imageHeight; y++)
                            {
                                var colour = Color.FromArgb(
                                    255,
                                    pixelArray[x, y].Red,
                                    pixelArray[x, y].Green,
                                    pixelArray[x, y].Blue);
                                bitmap.SetPixel(x, y, colour);
                            }
                        }

                        // Create the alpha bitmap (greyscale)
                        var alphaBitmap = new Bitmap(imageWidth, imageHeight);
                        for (var x = 0; x < imageWidth; x++)
                        {
                            for (var y = 0; y < imageHeight; y++)
                            {
                                var colour = Color.FromArgb(
                                    255,
                                    pixelArray[x, y].Alpha,
                                    pixelArray[x, y].Alpha,
                                    pixelArray[x, y].Alpha);
                                alphaBitmap.SetPixel(x, y, colour);
                            }
                        }

                        // Create combined bitmap
                        var combinedBitmap = new Bitmap(imageWidth, imageHeight);
                        for (var x = 0; x < imageWidth; x++)
                        {
                            for (var y = 0; y < imageHeight; y++)
                            {
                                var colour = Color.FromArgb(
                                    pixelArray[x, y].Alpha,
                                    pixelArray[x, y].Red,
                                    pixelArray[x, y].Green,
                                    pixelArray[x, y].Blue);
                                combinedBitmap.SetPixel(x, y, colour);                                    
                            }
                        }
                                
                        bitmaps.Add((cell.address, bitmap));
                        alphaBitmaps.Add((cell.address, alphaBitmap));
                        combinedBitmaps.Add((cell.address, combinedBitmap));
                        processedCells.Add(frame.CellIndex);
                        imageCount++;
                    }
                }
            }
            
            return (bitmaps, alphaBitmaps, combinedBitmaps);
        }

        public static bool SaveBitmapsAsPngs(List<(int cellAddress, Bitmap bitmap)> bitmaps, string directory, string baseSaveName)
        {
            try
            {
                for (int b = 0; b < bitmaps.Count; b++)
                {
                    var saveName = $"{directory}\\{baseSaveName}_{b}.PNG";
                    bitmaps[b].bitmap.Save(saveName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
