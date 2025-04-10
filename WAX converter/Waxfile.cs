using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WAX_converter
{
    /* WAX header = 160 bytes
     * WAX action = 156 bytes
     * WAX sequence = 144 bytes
     * WAX frame = 32 bytes
     * WAX cell = 24 bytes + data
     * */

    public class Waxfile : object
    {
        // Constructor -------------------------
        public Waxfile()
        {
            this.Version = 0x11000;
            this.actionAddresses = new int[32];
            this.Actions = new List<Action>();
            this.Sequences = new List<Sequence>();
            this.Frames = new List<Frame>();
            this.Cells = new List<Cell>();
        }

        #region Properties
        // Properties  ---------------------------
        public int Version { get; set; }
        public int Nseqs { get; set; }
        public int Nframes { get; set; }
        public int Ncells { get; set; }
        public int Xscale { get; set; }
        public int Yscale { get; set; }
        public int XtraLight { get; set; }
        public int pad4 { get; set; }
        public int[] actionAddresses { get; set; }
        
        public int numActions { get; set; }
        public List<Action> Actions { get; set; }
        public List<Sequence> Sequences { get; set; }
        public List<Frame> Frames { get; set; }
        public List<Cell> Cells { get; set; }

        #endregion

        #region Public Methods        
        // Methods ----------------------------------------------------
        public bool LoadFromFile(string filename)
        {
            try
            {
                using (BinaryReader fileReader = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    // Read the header
                    this.Version = fileReader.ReadInt32();
                    this.Nseqs = fileReader.ReadInt32();
                    this.Nframes = fileReader.ReadInt32();
                    this.Ncells = fileReader.ReadInt32();
                    this.Xscale = fileReader.ReadInt32();
                    this.Yscale = fileReader.ReadInt32();
                    this.XtraLight = fileReader.ReadInt32();
                    this.pad4 = fileReader.ReadInt32();

                    this.numActions = 0;
                    for (int i = 0; i < 32; i++)
                    {
                        this.actionAddresses[i] = fileReader.ReadInt32();
                        if (this.actionAddresses[i] == 0)       // an address of 0 indicates the end of the action list
                        {
                            break;
                        }

                        this.numActions++;
                    }

                    // Read the wax actions
                    for (int i = 0; i < this.numActions; i++)
                    {
                        Action action = new Action();
                        fileReader.BaseStream.Seek(this.actionAddresses[i], SeekOrigin.Begin);
                        action.Wwidth = fileReader.ReadInt32();
                        action.Wheight = fileReader.ReadInt32();
                        action.FrameRate = fileReader.ReadInt32();
                        action.Nframes = fileReader.ReadInt32();
                        action.pad2 = fileReader.ReadInt32();
                        action.pad3 = fileReader.ReadInt32();
                        action.pad4 = fileReader.ReadInt32();

                        for (int v = 0; v < 32; v++)
                        {
                            action.viewAddresses[v] = fileReader.ReadInt32();
                            action.seqIndexes[v] = (action.viewAddresses[v] - 160 - this.numActions * 156) / 144;       // address minus file header minus actions, divided by size of seq header
                        }

                        this.Actions.Add(action);
                    }

                    // Read the sequences
                    fileReader.BaseStream.Seek(160 + this.numActions * 156, SeekOrigin.Begin);
                    for (int s = 0; s < this.Nseqs; s++)
                    {
                        Sequence seq = new Sequence();
                        seq.pad1 = fileReader.ReadInt32();
                        seq.pad2 = fileReader.ReadInt32();
                        seq.pad3 = fileReader.ReadInt32();
                        seq.pad4 = fileReader.ReadInt32();

                        for (int f = 0; f < 32; f++)
                        {
                            seq.frameAddresses[f] = fileReader.ReadInt32();
                            if (seq.frameAddresses[f] > 0)
                            {
                                seq.frameIndexes[f] = (seq.frameAddresses[f] - 160 - this.numActions * 156 - this.Nseqs * 144) / 32;      // address minus file header minus actions minus sequences, divided by size of frame
                            }
                            else            // address of 0 indicates no frame; set index to -1
                            {
                                seq.frameIndexes[f] = -1;
                            }
                        }

                        // set the number of frames for this sequence by finding the first empty frame (if no empty frame found, numFrames = 32)
                        var firstEmptyFrame = Array.FindIndex(seq.frameIndexes, i => i == -1);
                        seq.numFrames = firstEmptyFrame != -1
                            ? firstEmptyFrame
                            : 32;

                        this.Sequences.Add(seq);
                    }

                    // Read the frames
                    fileReader.BaseStream.Seek(160 + this.numActions * 156 + this.Nseqs * 144, SeekOrigin.Begin);
                    for (int f = 0; f < this.Nframes; f++)
                    {
                        this.ReadFrame(fileReader);
                    }

                    // Read the cells
                    fileReader.BaseStream.Seek(160 + this.numActions * 156 + this.Nseqs * 144 + this.Nframes * 32, SeekOrigin.Begin);

                    for (int c = 0; c < this.Ncells; c++)
                    {
                        this.ReadCell(fileReader);
                    }

                    // Assign cell index to each frame by matching to cell addresses
                    for (int f = 0; f < this.Nframes; f++)
                    {
                        for (int c = 0; c < this.Ncells; c++)
                        {
                            if (this.Frames[f].CellAddress == this.Cells[c].address)
                            {
                                this.Frames[f].CellIndex = c;
                                break;
                            }
                        }
                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show($"IOException {e.Message}");
                return false;
            }

            return true;
        }

        public bool ExportToPNG(string filename, BitmapTransparencyOption transparencyOption)
        {
            string dir = Path.GetDirectoryName(filename);
            string baseFilename = Path.GetFileNameWithoutExtension(filename);
            var imageDirectory = dir + "/" + baseFilename + ".cells";

            // Work out logic type
            int logicType = 0;
            switch(this.Actions.Count)
            {
                case 1:
                    logicType = 0;  // anim
                    break;
                case 2:
                    logicType = 1;  // scenery
                    break;
                case 4:
                    logicType = 4;  // remote
                    break;
                case 13:
                    logicType = 2;  // enemy
                    break;
                case 14:
                    logicType = 3;  // dark trooper
                    break;
            }

            // Transparency colour
            Color transparencyColour = new Color();
            switch (transparencyOption)
            {
                case BitmapTransparencyOption.AlphaTransparent:
                    transparencyColour = Color.FromArgb(0, 0, 0, 0);
                    break;

                case BitmapTransparencyOption.White:
                    transparencyColour = Color.FromArgb(255, 255, 255, 255);
                    break;

                case BitmapTransparencyOption.Magenta:
                    transparencyColour = Color.FromArgb(255, 255, 0, 255);
                    break;

                default:
                    transparencyColour = Color.FromArgb(255, 0, 0, 0);
                    break;
            }

            try
            {
                /* save images in subdirectory */
                Directory.CreateDirectory(imageDirectory);

                for (int i = 0; i < this.Ncells; i++)
                {
                    var fileNum = GetExportFileNumber(i);
                    string saveName = imageDirectory + "/" + fileNum + ".PNG";
                    this.Cells[i].bitmap.Save(saveName, ImageFormat.Png);
                } 
            }
            catch (Exception e)
            {
                MessageBox.Show($"Exception {e.Message}");
                return false;
            }

            // Save a project file
            if (!WaxProject.Save($"{dir}/{baseFilename}.wproj", logicType, this.Actions, this.Sequences, this.Frames, this.Cells.Count, transparencyColour))
            {
                return false;
            }

            return true;
        }

        // Returns a file number as a 3 digit string, with appropriate leading zeroes
        public static string GetExportFileNumber(int i)
        {
            if (i < 10)
            {
                return $"00{i}";
            }
            else if (i >= 10 && i < 100) 
            {
                return $"0{i}";
            }
            else
            {
                return $"{i}";
            }
        }
        
        public bool Save(string filename, bool compress)
        {
            try
            {
                using (BinaryWriter fileWriter = new BinaryWriter(File.Open(filename, FileMode.Create)))
                {
                    // write the header
                    fileWriter.Write(this.Version);
                    fileWriter.Write(this.Nseqs);
                    fileWriter.Write(this.Nframes);
                    fileWriter.Write(this.Ncells);
                    fileWriter.Write(this.Xscale);
                    fileWriter.Write(this.Yscale);
                    fileWriter.Write(this.XtraLight);
                    fileWriter.Write(this.pad4);

                    for (int a = 0; a < 32; a++)
                    {
                        fileWriter.Write(this.actionAddresses[a]);
                    }

                    // write the actions
                    for (int a = 0; a < this.numActions; a++)
                    {
                        fileWriter.Write(this.Actions[a].Wwidth);
                        fileWriter.Write(this.Actions[a].Wheight);
                        fileWriter.Write(this.Actions[a].FrameRate);
                        fileWriter.Write(this.Actions[a].Nframes);
                        fileWriter.Write(this.Actions[a].pad2);
                        fileWriter.Write(this.Actions[a].pad3);
                        fileWriter.Write(this.Actions[a].pad4);

                        for (int v = 0; v < 32; v++)
                        {
                            fileWriter.Write(this.Actions[a].viewAddresses[v]);
                        }
                    }

                    // write the sequences
                    for (int s = 0; s < this.Nseqs; s++)
                    {
                        fileWriter.Write(this.Sequences[s].pad1);
                        fileWriter.Write(this.Sequences[s].pad2);
                        fileWriter.Write(this.Sequences[s].pad3);
                        fileWriter.Write(this.Sequences[s].pad4);

                        for (int f = 0; f < 32; f++)
                        {
                            fileWriter.Write(this.Sequences[s].frameAddresses[f]);
                        }
                    }

                    // write the frames
                    for (int f = 0; f < this.Nframes; f++)
                    {
                        fileWriter.Write(this.Frames[f].InsertX);
                        fileWriter.Write(this.Frames[f].InsertY);
                        fileWriter.Write(this.Frames[f].Flip);
                        fileWriter.Write(this.Frames[f].CellAddress);
                        fileWriter.Write(this.Frames[f].UnitWidth);
                        fileWriter.Write(this.Frames[f].UnitHeight);
                        fileWriter.Write(this.Frames[f].pad3);
                        fileWriter.Write(this.Frames[f].pad4);
                    }

                    // write the cells
                    for (int c = 0; c < this.Ncells; c++)
                    {
                        this.Cells[c].WriteToFile(fileWriter, compress);
                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show($"IOException {e.Message}");
                return false;
            }

            return true;
        }


        public bool LoadFromFME(string filename)
        {
            // a FME is a single frame and a single cell
            this.Nframes = 1;
            this.Ncells = 1;
            BinaryReader FMEReader = null;

            try
            {
                using (FMEReader = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    this.ReadFrame(FMEReader);
                    this.ReadCell(FMEReader);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show($"IOException {e.Message}");
                return false;
            }

            // Create a pseudo Action and Sequence (needed for the WXX/FXX import code)
            this.numActions = 1;
            this.Nseqs = 1;
            this.Actions.Add(new Action());
            this.Sequences.Add(new Sequence());
            this.Sequences[0].numFrames = 1;
            this.Sequences[0].frameIndexes[0] = 0;
            return true;
        }

        public void GenerateAllCellBitmaps(DFPal pal, BitmapTransparencyOption transparencyOption)
        {
            foreach (Cell cell in this.Cells)
            {
                cell.CreateBitmap(pal, transparencyOption);
            }
        }

        #endregion

        #region Private Methods
        private void ReadFrame(BinaryReader fileReader)
        {
            Frame frame = new Frame();
            frame.InsertX = fileReader.ReadInt32();
            frame.InsertY = fileReader.ReadInt32();
            frame.Flip = fileReader.ReadInt32();
            frame.CellAddress = fileReader.ReadInt32();
            frame.UnitWidth = fileReader.ReadInt32();
            frame.UnitHeight = fileReader.ReadInt32();
            frame.pad3 = fileReader.ReadInt32();
            frame.pad4 = fileReader.ReadInt32();

            this.Frames.Add(frame);
        }

        private void ReadCell(BinaryReader fileReader)
        {
            Cell Cell = new Cell();
            Cell.address = (int)fileReader.BaseStream.Position;
            Cell.SizeX = fileReader.ReadInt32();
            Cell.SizeY = fileReader.ReadInt32();
            Cell.Compressed = fileReader.ReadInt32();
            Cell.DataSize = fileReader.ReadInt32();
            Cell.ColOffs = fileReader.ReadInt32();
            Cell.pad1 = fileReader.ReadInt32();

            Cell.Pixels = new short[Cell.SizeX, Cell.SizeY];

            // Read the image data
            if (Cell.Compressed == 0)
            {
                // uncompressed
                for (int x = 0; x < Cell.SizeX; x++)
                {
                    for (int y = 0; y < Cell.SizeY; y++)
                    {
                        var colour = fileReader.ReadByte();
                        Cell.Pixels[x, y] = colour == 0 ? (short)-1 : colour;      // colour 0 is transparent
                    }
                }
            }
            else if (Cell.Compressed == 1)
            {
                // read column offsets
                Cell.columnOffsets = new int[Cell.SizeX];
                for (int x = 0; x < Cell.SizeX; x++)
                {
                    Cell.columnOffsets[x] = fileReader.ReadInt32();
                }

                // read compressed data
                int compressedDataLength = Cell.DataSize - 24 - (Cell.SizeX * 4);   // DataSize minus header minus offset table
                Cell.compressedData = new List<byte>();

                for (int i = 0; i < compressedDataLength; i++)
                {
                    Cell.compressedData.Add(fileReader.ReadByte());
                }

                // uncompress data
                Cell.UncompressImage();
            }

            this.Cells.Add(Cell);
        }

        #endregion
    }

    public static class WaxExtensions
    {
        /// <summary>
        /// Iterate through Wax cells in order of their reference in the Wax (walking through the
        /// actions, sequences and frames), and perform a function on them.
        /// </summary>
        public static void ProcessCellsInOrderOfReference(this Waxfile wax, Action<Cell, int> process)
        {
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
                        process(cell, imageCount);

                        processedCells.Add(frame.CellIndex);
                        imageCount++;
                    }
                }
            }
        }
    }

    public class Action
    {
        // Constructor
        public Action()
        {
            Wwidth = 65536;             // set default values
            Wheight = 65536;
            FrameRate = 6;
            Nframes = 0;
            pad2 = 0;
            pad3 = 0;
            pad4 = 0;
            viewAddresses = new int[32];      
            seqIndexes = new int[32];       
        }

        // Properties & fields
        public int Wwidth { get; set; }
        public int Wheight { get; set; }
        public int FrameRate { get; set; }
        public int Nframes { get; set; }
        public int pad2 { get; set; }
        public int pad3 { get; set; }
        public int pad4 { get; set; }
        public int[] viewAddresses { get; set; }    // address in WAX file for the 32 views

        public int[] seqIndexes { get; set; }       // sequence# corresponding to each view
    }

    public class Sequence
    {
        public Sequence()
        {
            frameAddresses = new int[32];       
            frameIndexes = new int[32];
            pad1 = 0;
            pad2 = 0;
            pad3 = 0;
            pad4 = 0;

            for (int i = 0; i < 32; i++)
            {
                this.frameIndexes[i] = -1;      // set to -1 by default (empty)
            }
        }

        // Properties & fields
        public int pad1 { get; set; }
        public int pad2 { get; set; }
        public int pad3 { get; set; }
        public int pad4 { get; set; }
        public int[] frameAddresses { get; set; }       // address in WAX file for frames (up to 32 per sequence)

        public int numFrames { get; set; }
        public int[] frameIndexes { get; set; }
    }

    public class Frame
    {
        public Frame()
        {
            UnitWidth = 0;
            UnitHeight = 0;
            pad3 = 0;
            pad4 = 0;
        }

        // Properties & fields
        public int InsertX {get; set;}
        public int InsertY { get; set; }
        public int Flip { get; set; }
        public int CellAddress { get; set; }        // address in WAX file
        public int UnitWidth { get; set; }
        public int UnitHeight { get; set; }
        public int pad3 { get; set; }
        public int pad4 { get; set; }

        public int CellIndex { get; set; }
    }

}
