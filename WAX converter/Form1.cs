using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WAX_converter
{
    public partial class MainWindow : Form
    {
        private Waxfile wax;
        private DFPal palette;
        private int SeqFrame = 0;       // the sequence frame currently being viewed
        private BitmapTransparencyOption transparencyOption = BitmapTransparencyOption.AlphaTransparent;
        private string waxDialogPath;
        private string remasterFilesPath;
        private string exportDialogPath;
        private string exportType;
        private string currentOpenedFilename;
        private List<(int CellAddress, Bitmap Image)> remasterImages = new();
        private List<(int CellAddress, Bitmap Image)> remasterAlphaImages = new();
        private List<(int CellAddress, Bitmap Image)> remasterCombinedImages = new();


        public MainWindow(string[] args)
        {
            InitializeComponent();
            palette = new DFPal();
            comboBoxTransparencyOptions.SelectedIndex = 0;

            if (args.Length > 0)
            {
                // Attempt to load WAX or FME from command line argument
                string fileName = args[0];
                string extension = Path.GetExtension(fileName).ToUpper();

                switch (extension)
                {
                    case ".WAX":
                        LoadWAX(fileName);
                        break;

                    case ".FME":
                        LoadFME(fileName);
                        break;

                    default:
                        MessageBox.Show("Not a valid file type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        #region Menu

        // MENU 
        private void MenuLoadPal_Click(object sender, EventArgs e)
        {
            openPalDialog.ShowDialog();
        }

        private void MenuCloseWax_Click(object sender, EventArgs e)
        {
            CloseWax();
        }

        private void MenuOpenWax_Click(object sender, EventArgs e)
        {
            openWaxDialog.InitialDirectory = !string.IsNullOrWhiteSpace(this.waxDialogPath) ? this.waxDialogPath : openWaxDialog.InitialDirectory;
            openWaxDialog.ShowDialog();
        }

        private void MenuOpenFme_Click(object sender, EventArgs e)
        {
            openFmeDialog.InitialDirectory = !string.IsNullOrWhiteSpace(this.waxDialogPath) ? this.waxDialogPath : openFmeDialog.InitialDirectory;
            openFmeDialog.ShowDialog();
        }

        private void MenuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuExportWax_Click(object sender, EventArgs e)
        {
            this.exportType = "LO";
            exportDialog.InitialDirectory = !string.IsNullOrWhiteSpace(this.exportDialogPath) ? this.exportDialogPath : exportDialog.InitialDirectory;
            exportDialog.ShowDialog();
        }

        private void MenuExportWXX_Click(object sender, EventArgs e)
        {
            this.exportType = "HI";
            exportDialog.InitialDirectory = !string.IsNullOrWhiteSpace(this.exportDialogPath) ? this.exportDialogPath : exportDialog.InitialDirectory;
            exportDialog.ShowDialog();
        }

        private void MenuBuild_Click(object sender, EventArgs e)
        {
            BuildWindow buildWindow = new BuildWindow();
            buildWindow.Show();
        }

        private void MenuEnemyWizard_Click(object sender, EventArgs e)
        {
            WizardWindow WizardWindow = new WizardWindow();
            WizardWindow.ShowDialog();
        }

        private void MenuCreateFme_Click(object sender, EventArgs e)
        {
            var createFmeWindow = new CreateFmeWindow();
            createFmeWindow.Show();
        }

        private void MenuBuildWxx_Click(object sender, EventArgs e)
        {
            var wxxBuilderWindow = new WxxBuilderWindow(this.wax);

            if (!wxxBuilderWindow.IsDisposed)
            {
                wxxBuilderWindow.Show();
            }
        }

        private void MenuRemasterDirectory_Click(object sender, EventArgs e)
        {
            this.openRemasterDirectoryDialog.InitialDirectory = !string.IsNullOrWhiteSpace(this.remasterFilesPath) ? Path.GetDirectoryName(this.remasterFilesPath) : openRemasterDirectoryDialog.InitialDirectory;
            this.openRemasterDirectoryDialog.ShowDialog(this);
        }

        private void menuHelp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == MenuAbout)
            {
                MessageBox.Show("This utility was written by Jereth K. Find me on the DF-21 Discord.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.ClickedItem == MenuHelphelp)
            {
                HelpWindow helpwin = new HelpWindow();
                helpwin.ShowDialog();
                helpwin.Close();
                helpwin.Dispose();
            }
        }

        #endregion

        // -------------------------------------------------------------------------------------

        private void openPalDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (palette.LoadfromFile(openPalDialog.FileName))
            {
                LabelPal.Text = $"{Path.GetFileName(openPalDialog.FileName)}";

                if (this.wax != null)
                {
                    this.wax.GenerateAllCellBitmaps(this.palette, this.transparencyOption);
                    UpdateCell();
                }
            }
            else
            {
                MessageBox.Show("Error loading PAL. The file may not have been a valid PAL file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openWaxDialog_FileOk(object sender, CancelEventArgs e)
        {
            LoadWAX(openWaxDialog.FileName);
        }

        private void LoadWAX(string path)
        {
            Waxfile tryOpenWax = new Waxfile();
            if (tryOpenWax.LoadFromFile(path))
            {
                this.remasterImages.Clear();
                this.remasterAlphaImages.Clear();
                this.remasterCombinedImages.Clear();
                this.comboBoxImageCategory.Enabled = false;

                this.wax = tryOpenWax;
                this.wax.GenerateAllCellBitmaps(this.palette, this.transparencyOption);
                this.waxDialogPath = Path.GetDirectoryName(path);
                this.currentOpenedFilename = Path.GetFileName(path);
                exportDialog.FileName = Path.GetFileNameWithoutExtension(path);
                this.loadRemasterImages();

                // remove event handlers (to prevent exceptions when resetting values)
                this.ActionNumber.ValueChanged -= this.ActionNumber_ValueChanged;
                this.ViewNumber.ValueChanged -= this.ViewNumber_ValueChanged;
                this.SeqNumber.ValueChanged -= this.SeqNumber_ValueChanged;
                this.FrameNumber.ValueChanged -= this.FrameNumber_ValueChanged;

                labelWax.Text = Path.GetFileName(path);
                RadioGroup.Enabled = true;
                panel1.Enabled = true;
                SeqFrame = 0;
                ActionNumber.Value = 0;
                ViewNumber.Value = 0;
                SeqNumber.Value = 0;
                FrameNumber.Value = 0;
                CellNumber.Value = 0;
                ActionNumber.Maximum = wax.numActions - 1;
                SeqNumber.Maximum = wax.Nseqs - 1;
                FrameNumber.Maximum = wax.Nframes - 1;
                CellNumber.Maximum = wax.Ncells - 1;
                radioAction.Checked = false;
                radioAction.Checked = true;

                // add event handlers
                this.ActionNumber.ValueChanged += new System.EventHandler(this.ActionNumber_ValueChanged);
                this.ViewNumber.ValueChanged += new System.EventHandler(this.ViewNumber_ValueChanged);
                this.SeqNumber.ValueChanged += new System.EventHandler(this.SeqNumber_ValueChanged);
                this.FrameNumber.ValueChanged += new System.EventHandler(this.FrameNumber_ValueChanged);

                // display Wax details
                string[] strings = new string[9];
                strings[0] = $"Version: 0x{Convert.ToString(wax.Version, 16)}";
                strings[1] = $"Num actions: {wax.numActions}";
                strings[2] = $"Num sequences: {wax.Nseqs}";
                strings[3] = $"Num frames: {wax.Nframes}";
                strings[4] = $"Num cells: {wax.Ncells}";
                //strings[5] = $"Xscale: {wax.Xscale}, Yscale: {wax.Yscale}";
                //strings[6] = $"XtraLight: {wax.XtraLight}";
                //strings[7] = $"{wax.pad4}";
                WaxDetails.Lines = strings;

                UpdateActionInfo();
                UpdateSeqInfo();
                UpdateFrame();
                MenuCloseWax.Enabled = true;
                MenuSaveBMP.Enabled = true;
            }
            else
            {
                MessageBox.Show($"Error loading WAX file {path}.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxTransparencyOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxTransparencyOptions.SelectedIndex)
            {
                case 0:
                    this.transparencyOption = BitmapTransparencyOption.AlphaTransparent;
                    break;

                case 1:
                    this.transparencyOption = BitmapTransparencyOption.Black;
                    break;

                case 2:
                    this.transparencyOption = BitmapTransparencyOption.White;
                    break;

                case 3:
                    this.transparencyOption = BitmapTransparencyOption.Magenta;
                    break;
            }

            if (this.wax != null)
            {
                this.wax.GenerateAllCellBitmaps(this.palette, this.transparencyOption);
                UpdateCell();
            }
        }

        // ---------------------------------------------------------------------------------------------------------

        private void radioAction_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActionInfo();

            //ActionNumber.Value = 0;

            ActionNumber.Enabled = true;
            ViewNumber.Enabled = true;
            SeqNumber.Enabled = false;
            SeqNextFrame.Enabled = true;
            SeqPrevFrame.Enabled = true;
            FrameNumber.Enabled = false;
            CellNumber.Enabled = false;
            btnAnimate.Enabled = true;
        }

        private void radioSequence_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSeqInfo();
            UpdateFrame();

            ActionInfo.Text = "";
            ActionNumber.Enabled = false;
            ViewNumber.Enabled = false;
            SeqNumber.Enabled = true;
            SeqNextFrame.Enabled = true;
            SeqPrevFrame.Enabled = true;
            FrameNumber.Enabled = false;
            CellNumber.Enabled = false;
            btnAnimate.Enabled = false;
        }

        private void radioFrame_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFrame();

            ActionInfo.Text = "";
            SeqInfo.Text = "";

            ActionNumber.Enabled = false;
            ViewNumber.Enabled = false;
            SeqNumber.Enabled = false;
            SeqNextFrame.Enabled = false;
            SeqPrevFrame.Enabled = false;
            FrameNumber.Enabled = true;
            CellNumber.Enabled = false;
            btnAnimate.Enabled = false;
        }

        private void radioCell_CheckedChanged(object sender, EventArgs e)
        {
            ActionInfo.Text = "";
            SeqInfo.Text = "";
            FrameInfo.Text = "";

            ActionNumber.Enabled = false;
            ViewNumber.Enabled = false;
            SeqNextFrame.Enabled = false;
            SeqPrevFrame.Enabled = false;
            SeqNumber.Enabled = false;
            FrameNumber.Enabled = false;
            CellNumber.Enabled = true;
            btnAnimate.Enabled = false;
        }


        // ---------------------------------------------------------------------------------------------------------

        private void ActionNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateActionInfo();
        }

        private void UpdateActionInfo()
        {
            int thisAction = (int)ActionNumber.Value;

            // display Action info
            var wWidth = wax.Actions[thisAction].Wwidth;
            var wHeight = wax.Actions[thisAction].Wheight;

            string[] strings = new string[5];
            strings[0] = $"Wwidth: {Math.Round(wWidth / 65536m * 100m)}% ({wWidth})";
            strings[1] = $"Wheight: {Math.Round(wHeight / 65536m * 100m)}% ({wHeight})";
            strings[2] = $"Framerate: {wax.Actions[thisAction].FrameRate}";
            //strings[3] = $"{wax.Actions[thisAction].Nframes}";
            //strings[4] = $"{wax.Actions[thisAction].pad2} {wax.Actions[thisAction].pad3} {wax.Actions[thisAction].pad4}";
            ActionInfo.Lines = strings;

            ViewNumber.Value = 0;
            UpdateView();
        }

        private void ViewNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void UpdateView()
        {
            int thisSequence = wax.Actions[(int)ActionNumber.Value].seqIndexes[(int)ViewNumber.Value];
            SeqNumber.Value = thisSequence;

            UpdateSeqInfo();
        }

        private void SeqNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateSeqInfo();
        }

        private void UpdateSeqInfo()
        {
            if (wax.Sequences.Count > 0)
            {
                int thisSequence = (int)SeqNumber.Value;

                string[] s = new string[3];
                s[0] = $"This sequence has {wax.Sequences[thisSequence].numFrames} frames";
                //s[2] = $"{wax.Sequences[thisSequence].pad1} {wax.Sequences[thisSequence].pad2} {wax.Sequences[thisSequence].pad3} {wax.Sequences[thisSequence].pad4}";
                SeqInfo.Lines = s;

                if (wax.Sequences[thisSequence].numFrames > 0)
                {
                    int thisFrame = wax.Sequences[thisSequence].frameIndexes[0];
                    FrameNumber.Value = thisFrame;
                    SeqFrame = 0;
                    labelSeqFrame.Text = SeqFrame.ToString();
                    UpdateFrame();
                }
                else
                {
                    // empty sequence!
                    FrameInfo.Text = "";
                    CellInfo.Text = "";
                    displayBox.Image = null;
                    labelSeqFrame.Text = "";
                }
            }
        }

        private void SeqNextFrame_Click(object sender, EventArgs e)
        {
            int thisSequence = (int)SeqNumber.Value;

            if (wax.Sequences[thisSequence].numFrames < 1)
            {
                return;     // empty sequence
            }

            int maxFrame = wax.Sequences[thisSequence].numFrames - 1;
            if (SeqFrame < maxFrame)
            {
                SeqFrame++;
            }
            else
            {
                SeqFrame = 0;
            }

            labelSeqFrame.Text = SeqFrame.ToString();
            int thisFrame = wax.Sequences[thisSequence].frameIndexes[SeqFrame];
            FrameNumber.Value = thisFrame;
            UpdateFrame();
        }

        private void SeqPrevFrame_Click(object sender, EventArgs e)
        {
            int thisSequence = (int)SeqNumber.Value;

            if (wax.Sequences[thisSequence].numFrames < 1)
            {
                return;     // empty sequence
            }

            if (SeqFrame > 0)
            {
                SeqFrame--;
            }
            else
            {
                SeqFrame = wax.Sequences[thisSequence].numFrames - 1;
            }

            labelSeqFrame.Text = SeqFrame.ToString();
            int thisFrame = wax.Sequences[thisSequence].frameIndexes[SeqFrame];
            FrameNumber.Value = thisFrame;
            UpdateFrame();
        }

        // ---------------------------------------------------------------------------------------------------------

        private void FrameNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateFrame();
        }

        private void UpdateFrame()
        {
            int thisFrame = (int)FrameNumber.Value;

            string[] strings = new string[7];
            strings[0] = $"InsertX: {wax.Frames[thisFrame].InsertX}";
            strings[1] = $"InsertY: {wax.Frames[thisFrame].InsertY}";
            strings[2] = $"Flip: {(wax.Frames[thisFrame].Flip == 1 ? "Yes" : "No")}";
            strings[3] = $"Cell Address: 0x{Convert.ToString(wax.Frames[thisFrame].CellAddress, 16)}";
            //strings[4] = $"{wax.Frames[thisFrame].UnitWidth} {wax.Frames[thisFrame].UnitHeight}";
            //strings[5] = $"{wax.Frames[thisFrame].pad3} {wax.Frames[thisFrame].pad4}";
            FrameInfo.Lines = strings;

            CellNumber.Value = wax.Frames[thisFrame].CellIndex;
            UpdateCell();
        }

        private void CellNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateCell();
        }

        private void UpdateCell()
        {
            int thisCell = (int)CellNumber.Value;

            string[] strings = new string[8];
            strings[0] = $"SizeX: {this.wax.Cells[thisCell].SizeX}";
            strings[1] = $"SizeY: {this.wax.Cells[thisCell].SizeY}";
            strings[2] = $"Compressed: {(this.wax.Cells[thisCell].Compressed == 1 ? "Yes" : "No")}";
            strings[3] = $"DataSize: {this.wax.Cells[thisCell].DataSize}";
            //strings[4] = $"ColOffs: {this.wax.Cells[thisCell].ColOffs}";
            //strings[5] = $"{this.wax.Cells[thisCell].pad1}";
            //strings[6] = $"ADDRESS: 0x{Convert.ToString(this.wax.Cells[thisCell].address, 16)}";
            CellInfo.Lines = strings;

            Bitmap displayedImage;
            if (this.comboBoxImageCategory.SelectedIndex == 1
                && this.remasterCombinedImages.Count > 0)
            {
                // Remaster image - combined
                var img = this.remasterCombinedImages.FirstOrDefault(r => r.CellAddress == this.wax.Cells[thisCell].address).Image;
                displayedImage = img != null ? new Bitmap(img) : new Bitmap(1, 1);
            }

            else if (this.comboBoxImageCategory.SelectedIndex == 2
                && this.remasterImages.Count > 0)
            {
                // Remaster image - no alpha
                var img = this.remasterImages.FirstOrDefault(r => r.CellAddress == this.wax.Cells[thisCell].address).Image;
                displayedImage = img != null ? new Bitmap(img) : new Bitmap(1, 1);
            }
            else if (this.comboBoxImageCategory.SelectedIndex == 3
                && this.remasterAlphaImages.Count > 0)
            {
                // Remaster alpha
                var img = this.remasterAlphaImages.FirstOrDefault(r => r.CellAddress == this.wax.Cells[thisCell].address).Image;
                displayedImage = img != null ? new Bitmap(img) : new Bitmap(1, 1);
            }
            else
            {
                // Original wax image
                this.comboBoxImageCategory.SelectedIndex = 0;
                displayedImage = new Bitmap(this.wax.Cells[thisCell].bitmap);
            }

            if (!radioCell.Checked && this.wax.Frames[(int)FrameNumber.Value].Flip == 1)
            {
                displayedImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            displayBox.Image = displayedImage;
        }

        // ---------------------------------------------------------------------------------------------------------

        private void CloseWax()
        {
            this.wax = null;
            this.remasterImages.Clear();
            this.remasterAlphaImages.Clear();
            this.remasterCombinedImages.Clear();
            this.currentOpenedFilename = "";
            labelWax.Text = "";
            RadioGroup.Enabled = false;
            ActionNumber.Enabled = false;
            ViewNumber.Enabled = false;
            SeqNumber.Enabled = false;
            SeqNextFrame.Enabled = false;
            SeqPrevFrame.Enabled = false;
            FrameNumber.Enabled = false;
            CellNumber.Enabled = false;
            WaxDetails.Text = "";
            ActionInfo.Text = "";
            SeqInfo.Text = "";
            FrameInfo.Text = "";
            CellInfo.Text = "";
            displayBox.Image = null;
            MenuCloseWax.Enabled = false;
            MenuSaveBMP.Enabled = false;
            MenuExportWXX.Enabled = false;
            this.comboBoxImageCategory.Enabled = false;
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            var exportDirectory = Path.GetDirectoryName(exportDialog.FileName);
            this.exportDialogPath = exportDirectory;

            switch (this.exportType)
            {
                case "LO":
                    if (wax.ExportToPNG(exportDialog.FileName, this.transparencyOption))
                    {
                        MessageBox.Show("Successfully exported images to PNGs, and created a project file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error exporting.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "HI":
                    var response = MessageBox.Show("Do you wish to save the alpha channel separately? The alpha data will be saved as a greyscale image.", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (response == DialogResult.Cancel)
                    {
                        break;
                    }

                    var baseFileName = Path.GetFileNameWithoutExtension(exportDialog.FileName);

                    if (response == DialogResult.Yes)
                    {
                        var imageGroup1FileName = $"{baseFileName}_remaster";
                        var imageGroup2FileName = $"{baseFileName}_remaster_alpha";
                        var success =
                            RemasterImagesImporterExporter.SaveBitmapsAsPngs(this.remasterImages, exportDirectory, imageGroup1FileName) &&
                            RemasterImagesImporterExporter.SaveBitmapsAsPngs(this.remasterAlphaImages, exportDirectory, imageGroup2FileName);

                        if (success)
                        {
                            MessageBox.Show("Successfully exported remaster images to PNGs.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error exporting.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }

                    if (response == DialogResult.No)
                    {
                        var imageGroupFileName = $"{baseFileName}_remaster";
                        if (RemasterImagesImporterExporter.SaveBitmapsAsPngs(this.remasterCombinedImages, exportDirectory, imageGroupFileName))
                        {
                            MessageBox.Show("Successfully exported remaster images to PNGs.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error exporting.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }

                    break;
            }
        }

        private void checkBoxZoom_CheckedChanged(object sender, EventArgs e)
        {
            displayBox.SizeMode = checkBoxZoom.Checked ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.Normal;
        }

        // -----------------------------------------------------------------------------------------------
        private void openFmeDialog_FileOk(object sender, CancelEventArgs e)
        {
            LoadFME(openFmeDialog.FileName);
        }

        private void LoadFME(string path)
        {
            // Load a FME file as a Waxfile object
            Waxfile tryOpenFme = new Waxfile();

            if (tryOpenFme.LoadFromFME(path))
            {
                this.remasterImages.Clear();
                this.remasterAlphaImages.Clear();
                this.remasterCombinedImages.Clear();
                this.comboBoxImageCategory.Enabled = false;

                this.wax = tryOpenFme;
                this.wax.GenerateAllCellBitmaps(this.palette, this.transparencyOption);
                this.waxDialogPath = Path.GetDirectoryName(path);
                this.currentOpenedFilename = Path.GetFileName(path);
                exportDialog.FileName = Path.GetFileNameWithoutExtension(path);
                this.loadRemasterImages();

                // remove event handlers (to prevent exceptions when resetting values)
                this.ActionNumber.ValueChanged -= this.ActionNumber_ValueChanged;
                this.ViewNumber.ValueChanged -= this.ViewNumber_ValueChanged;
                this.SeqNumber.ValueChanged -= this.SeqNumber_ValueChanged;
                this.FrameNumber.ValueChanged -= this.FrameNumber_ValueChanged;

                // display FME details
                string[] strings = new string[2];
                strings[0] = $"FME file";
                WaxDetails.Lines = strings;

                panel1.Enabled = false;
                RadioGroup.Enabled = false;
                MenuSaveBMP.Enabled = true;
                FrameNumber.Value = 0;
                FrameNumber.Maximum = 0;
                CellNumber.Value = 0;
                CellNumber.Maximum = 0;
                labelWax.Text = Path.GetFileName(path);
                ActionInfo.Text = "";
                SeqInfo.Text = "";
                UpdateFrame();
            }
            else
            {
                MessageBox.Show("Error loading FME file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------------------------------------------------------------------------------------------

        #region Remaster / High Res Assets

        private void openRemasterDirectoryDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (Path.GetExtension(this.openRemasterDirectoryDialog.FileName).Equals(".gob", StringComparison.OrdinalIgnoreCase))
            {
                this.remasterFilesPath = this.openRemasterDirectoryDialog.FileName;
            }
            else
            {
                this.remasterFilesPath = Path.GetDirectoryName(this.openRemasterDirectoryDialog.FileName);
            }
            
            MessageBox.Show($"High res (DF Remaster) images will automatically be loaded from [{this.remasterFilesPath}] when you open a WAX or FME.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.loadRemasterImages();
        }

        private void loadRemasterImages()
        {
            this.comboBoxImageCategory.Enabled = false;
            this.comboBoxImageCategory.SelectedIndex = 0;
            this.MenuExportWXX.Enabled = false;

            if (this.wax == null || this.wax.Ncells == 0 || string.IsNullOrEmpty(this.currentOpenedFilename))
            {
                return;
            }

            if (string.IsNullOrEmpty(this.remasterFilesPath))
            {
                return;
            }

            var remasterFileName = "";
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(this.currentOpenedFilename);
            var currentFileExtension = Path.GetExtension(this.currentOpenedFilename);
            if (currentFileExtension.Equals(".FME", StringComparison.OrdinalIgnoreCase))
            {
                remasterFileName = $"{fileNameWithoutExtension}.FXX";
            }
            else if (currentFileExtension.Equals(".WAX", StringComparison.OrdinalIgnoreCase))
            {
                remasterFileName = $"{fileNameWithoutExtension}.WXX";
            }
            else
            {
                return;
            }

            List<byte[]> data;
            if (Path.GetExtension(this.remasterFilesPath).Equals(".gob", StringComparison.OrdinalIgnoreCase))
            {
                // Path is a GOB
                if (!Gob.GobContainsFile(this.remasterFilesPath, remasterFileName))
                {
                    return;
                }

                data = RemasterImagesImporterExporter.LoadDataFromWxxInsideGob(this.remasterFilesPath, remasterFileName);
            }
            else
            {
                // Path a directory
                var remasterFilePath = $"{this.remasterFilesPath}\\{remasterFileName}";
                if (!File.Exists(remasterFilePath))
                {
                    return;
                }

                data = RemasterImagesImporterExporter.LoadDataFromWxxFile(remasterFilePath);
            }

            if (data == null || data.Count == 0)
            {
                return;
            }

            var (bitmaps, alphaBitmaps, combinedBitmaps) = RemasterImagesImporterExporter.CreateBitmapsFromData(this.wax, data);
            this.remasterImages = bitmaps;
            this.remasterAlphaImages = alphaBitmaps;
            this.remasterCombinedImages = combinedBitmaps;
            this.comboBoxImageCategory.Enabled = true;
            this.MenuExportWXX.Enabled = true;
        }

        private void comboBoxImageCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.wax != null)
            {
                UpdateCell();
            }
        }

        #endregion

        // ------------------------------------------------------------------------------------------------------

        private void btnAnimate_Click(object sender, EventArgs e)
        {
            if (this.wax == null || this.wax.Sequences.Count == 0)
            {
                return;
            }

            var bitmaps = new List<Bitmap>();
            var hiresMode = this.comboBoxImageCategory.SelectedIndex > 0 && this.remasterCombinedImages.Any();

            if (hiresMode)
            {
                for (int c = 0; c < this.wax.Cells.Count; c++)
                {
                    var img = this.remasterCombinedImages.FirstOrDefault(i => i.CellAddress == this.wax.Cells[c].address).Image;
                    if (img != null)
                    {
                        bitmaps.Add(img);
                    }
                    else
                    {
                        bitmaps.Add(new Bitmap(1, 1));
                    }
                }
            }
            else
            {
                for (int c = 0; c < this.wax.Cells.Count; c++)
                {
                    bitmaps.Add(this.wax.Cells[c].bitmap);
                }
            }

            var animationWindow = new AnimationWindow(true, hiresMode, this.wax.Actions[(int)this.ActionNumber.Value], this.wax.Sequences, this.wax.Frames, bitmaps, Color.FromArgb(0, 0, 0, 0));
            animationWindow.ShowDialog();
            animationWindow.Dispose();
        }
    }
}
