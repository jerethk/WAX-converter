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

        public static (List<Bitmap>, List<Bitmap>) CreateBitmapsFromData(List<Cell> cells, List<byte[]> data)
        {
            var bitmaps = new List<Bitmap>();
            var alphaBitmaps = new List<Bitmap>();

            var imageDataTable = data.Select(d => (Id: Guid.NewGuid(), ImageData: d)).ToList();
            var usedIds = new List<Guid>();

            foreach (var cell in cells)
            {
                var imageWidth = cell.SizeX * 2;
                var imageHeight = cell.SizeY * 2;

                // Find the corresponding image
                var item = imageDataTable.FirstOrDefault(
                    dt => !usedIds.Contains(dt.Id) && dt.ImageData.Length == imageWidth * imageHeight * 4);

                if (item == default)
                {
                    continue;   // not found, so continue to next cell
                }

                usedIds.Add(item.Id);

                // Put the raw data into an array of pixels
                var pixelArray = new Pixel[imageWidth, imageHeight];
                var pixelCount = 0;
                for (var y = 0; y < imageHeight; y++)
                {
                    for (var x = imageWidth - 1; x >= 0; x--)
                    {
                        var pxl = new Pixel();
                        pxl.Red = item.ImageData[pixelCount * 4];
                        pxl.Green = item.ImageData[pixelCount * 4 + 1];
                        pxl.Blue = item.ImageData[pixelCount * 4 + 2];
                        pxl.Alpha = item.ImageData[pixelCount * 4 + 3];
                        pixelArray[(x), y] = pxl;

                        pixelCount++;
                    }
                }

                // Create image bitmap
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

                bitmaps.Add(bitmap);
                alphaBitmaps.Add(alphaBitmap);
            }

            return (bitmaps, alphaBitmaps);
        }
    }
}
