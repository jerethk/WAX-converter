using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAX_converter
{
    public partial class CreateFmeWindow : Form
    {
        public CreateFmeWindow()
        {
            InitializeComponent();

            transparentColour = Color.FromArgb(255, 0, 0, 0);
            transpColourBox.BackColor = transparentColour;
        }

        private DFPal pal = new DFPal();
        private Color transparentColour;
        private Bitmap sourceImage;

        private void CreateFmeWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.sourceImage.Dispose();
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
                this.InsertX.Value = bitmap.Width / 2 * -1;
                this.InsertY.Value = bitmap.Height * -1 + (int)(0.06 * bitmap.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
