using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WAX_converter.Dialogs;

namespace WAX_converter
{
    public partial class CreateFmeWindow : Form
    {
        public CreateFmeWindow()
        {
            InitializeComponent();

            this.frame.CellAddress = 0x20;
            this.transparentColour = Color.FromArgb(255, 0, 0, 0);
            this.transpColourBox.BackColor = transparentColour;
        }

        private DFPal pal = new DFPal();
        private Color transparentColour;
        private Frame frame = new Frame();
        private Bitmap sourceImage;

        private void CreateFmeWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.sourceImage?.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPal_Click(object sender, EventArgs e)
        {
            this.loadPalDialog.ShowDialog();
        }

        private void loadPalDialog_FileOk(object sender, CancelEventArgs e)
        {
            var newPal = new DFPal();
            if (newPal.LoadfromFile(loadPalDialog.FileName))
            {
                this.pal = newPal;
            }
            else
            {
                MessageBox.Show("Error loading PAL. The file may not have been a valid PAL file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxIlluminated_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIlluminated.Checked)
            {
                MessageBox.Show("Full-bright colours (PAL indexes 1-23) will be included when performing colour matching.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void checkBoxCommonColours_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCommonColours.Checked)
            {
                MessageBox.Show("Only common palette colours (up to index 207) will be used for colour matching.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonTransparent_Click(object sender, EventArgs e)
        {
            var transparentDialog = new ColourChooser(this.sourceImage, this.transparentColour);
            transparentDialog.ShowDialog();
            this.transparentColour = transparentDialog.FinalColour;
            transpColourBox.BackColor = this.transparentColour;
            transparentDialog.Dispose();
        }


    // --- Main editing area -----------------------------------------------------------------------------------------

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            this.loadImageDialog.ShowDialog(this);
        }

        private void loadImageDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var bitmap = Image.FromFile(this.loadImageDialog.FileName);
                this.sourceImage = new Bitmap(bitmap);
                this.sourceImageDisplayBox.Image = this.sourceImage;

                // Set default offsets
                this.frame.InsertX = bitmap.Width / 2 * -1;
                this.frame.InsertY = bitmap.Height * -1 + (int)(0.06 * bitmap.Height);
                this.frame.Flip = 0;

                this.InsertX.Value = this.frame.InsertX;
                this.InsertY.Value = this.frame.InsertY;
                this.checkBoxFlip.Checked = this.frame.Flip == 1;

                bitmap.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxFlip_CheckedChanged(object sender, EventArgs e)
        {
            this.frame.Flip = this.checkBoxFlip.Checked ? 1 : 0;

            if (this.sourceImage != null)
            {
                var img = new Bitmap(this.sourceImage);
                if (this.frame.Flip == 1)
                {
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                }
                this.sourceImageDisplayBox.Image = img;
            }
        }

        private void InsertX_ValueChanged(object sender, EventArgs e)
        {
            this.frame.InsertX = (int)this.InsertX.Value;
        }

        private void InsertY_ValueChanged(object sender, EventArgs e)
        {
            this.frame.InsertY = (int)this.InsertY.Value;
        }

        private void btnPositionFrame_Click(object sender, EventArgs e)
        {
            if (this.sourceImage == null)
            {
                return;
            }

            var frameList = new List<Frame>() { this.frame };

            var framePositioningWindow = new FramePositioningWindow(
                frameList,
                new List<Bitmap>() { this.sourceImage },
                this.transparentColour);

            framePositioningWindow.ShowDialog(this);

            this.frame = frameList[0];
            this.InsertX.Value = this.frame.InsertX;
            this.InsertY.Value = this.frame.InsertY;
        }

        private void btnCreateFme_Click(object sender, EventArgs e)
        {
            if (this.sourceImage != null)
            {
                this.saveFmeDialog.ShowDialog(this);
            }
        }

        private void saveFmeDialog_FileOk(object sender, CancelEventArgs e)
        {
            // Create a cell from the source image
            var cell = new Cell()
            { 
                SizeX = this.sourceImage.Width,
                SizeY = this.sourceImage.Height,
                ColOffs = 0,
            };

            cell.Pixels = new short[cell.SizeX, cell.SizeY];
            cell.CreateCellImage(this.sourceImage, this.pal, this.transparentColour, this.checkBoxIlluminated.Checked, this.checkBoxCommonColours.Checked);
            if (this.checkBoxCompress.Checked)
            {
                cell.CompressCell();
            }
            
            // Save the FME
            if (this.SaveFme(this.saveFmeDialog.FileName, this.frame, cell, this.checkBoxCompress.Checked))
            {
                MessageBox.Show("Successfully saved FME.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while saving FME.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveFme(string filename, Frame frame, Cell cell, bool compressed)
        {
            try
            {
                using (var fmeWriter = new BinaryWriter(File.Open(filename, FileMode.Create)))
                {
                    fmeWriter.Write(frame.InsertX);
                    fmeWriter.Write(frame.InsertY);
                    fmeWriter.Write(frame.Flip);
                    fmeWriter.Write(frame.CellAddress);
                    fmeWriter.Write(frame.UnitWidth);
                    fmeWriter.Write(frame.UnitHeight);
                    fmeWriter.Write(frame.pad3);
                    fmeWriter.Write(frame.pad4);

                    cell.WriteToFile(fmeWriter, compressed);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
