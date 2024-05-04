using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace WAX_converter
{
    internal static class RemasterImagesImporterExporter
    {
        public static List<byte[]> LoadDataFromWxx(string filename)
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

            wax.ProcessCellsInOrderOfReference((cell, imageCount) =>
            {
                var imageWidth = cell.SizeX * 2;
                var imageHeight = cell.SizeY * 2;

                if (imageWidth * imageHeight * 4 != data[imageCount].Length)
                {
                    return;   // The image in the data doesn't match the cell so pull out
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

                // Create bitmaps
                var bitmap = new Bitmap(imageWidth, imageHeight);
                var alphaBitmap = new Bitmap(imageWidth, imageHeight);
                var combinedBitmap = new Bitmap(imageWidth, imageHeight);
                for (var x = 0; x < imageWidth; x++)
                {
                    for (var y = 0; y < imageHeight; y++)
                    {
                        // RGB only
                        var colourRgb = Color.FromArgb(
                            255,
                            pixelArray[x, y].Red,
                            pixelArray[x, y].Green,
                            pixelArray[x, y].Blue);
                        bitmap.SetPixel(x, y, colourRgb);

                        // alpha (as greyscale)
                        var colourAlpha = Color.FromArgb(
                                255,
                                pixelArray[x, y].Alpha,
                                pixelArray[x, y].Alpha,
                                pixelArray[x, y].Alpha);
                        alphaBitmap.SetPixel(x, y, colourAlpha);

                        // combined
                        var colourCombined = Color.FromArgb(
                            pixelArray[x, y].Alpha,
                            pixelArray[x, y].Red,
                            pixelArray[x, y].Green,
                            pixelArray[x, y].Blue);
                        combinedBitmap.SetPixel(x, y, colourCombined);
                    }
                }

                bitmaps.Add((cell.address, bitmap));
                alphaBitmaps.Add((cell.address, alphaBitmap));
                combinedBitmaps.Add((cell.address, combinedBitmap));
                return;
            });


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

        public static bool CreateWxx(Bitmap[] images, string filename)
        {
            try
            {
                using (var fileWriter = new BinaryWriter(File.Open(filename, FileMode.Create)))
                {
                    fileWriter.Write((Int32)images.Length);

                    // Table of image sizes
                    for (var i = 0; i < images.Length; i++)
                    {
                        Int32 imageSize = images[i].Width * images[i].Height;
                        fileWriter.Write(imageSize);
                    }

                    // Image data
                    for (var i = 0; i < images.Length; i++)
                    {
                        images[i].RotateFlip(RotateFlipType.RotateNoneFlipX);     // WXX images are flipped horizontally

                        for (var y = 0; y < images[i].Height; y++)
                        {
                            for (var x = 0; x < images[i].Width; x++)
                            {
                                var red = images[i].GetPixel(x, y).R;
                                var green = images[i].GetPixel(x, y).G;
                                var blue = images[i].GetPixel(x, y).B;
                                var alpha = images[i].GetPixel(x, y).A;

                                fileWriter.Write(red);
                                fileWriter.Write(green);
                                fileWriter.Write(blue);
                                fileWriter.Write(alpha);
                            }
                        }

                        images[i].RotateFlip(RotateFlipType.RotateNoneFlipX);
                    }
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
