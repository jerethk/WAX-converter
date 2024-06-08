using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAX_converter
{
    public partial class WxxBuilderWindow : Form
    {
        private List<Bitmap> waxImages = new();
        private List<Bitmap> sourceDirectoryImages = new();
        private Bitmap[] highResImages;

        public WxxBuilderWindow(Waxfile wax)
        {
            InitializeComponent();

            if (wax == null)
            {
                this.openWaxDialog.ShowDialog();
            }
            else
            {
                this.Setup(wax);
            }
        }

        private void openWaxDialog_FileOk(object sender, CancelEventArgs e)
        {
            var wax = new Waxfile();
            var successfulLoad = wax.LoadFromFile(openWaxDialog.FileName);

            if (!successfulLoad)
            {
                MessageBox.Show("Error loading WAX", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                this.Dispose();
            }
            else
            {
                wax.GenerateAllCellBitmaps(new DFPal(), BitmapTransparencyOption.AlphaTransparent);
                this.Setup(wax);
            }
        }

        private void WxxBuilderWindow_Shown(object sender, EventArgs e)
        {
            if (this.waxImages.Count == 0)
            {
                this.Close();
                this.Dispose();
            }
            else
            {
                this.listBoxWaxImages.SelectedIndex = 0;
            }
        }

        private void Setup(Waxfile wax)
        {
            wax.ProcessCellsInOrderOfReference((cell, imageCount) =>
            {
                this.waxImages.Add(cell.bitmap);
                this.listBoxWaxImages.Items.Add(imageCount);
            });

            this.highResImages = new Bitmap[this.waxImages.Count];
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to quit? Any work will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------

        #region SourceImages

        private void btnSourceImages_Click(object sender, EventArgs e)
        {
            this.sourceImagesDialog.ShowDialog();
        }

        private void sourceImagesDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.sourceDirectoryImages.Clear();
            this.listBoxSourceImages.Items.Clear();

            var sourceDirectory = Path.GetDirectoryName(sourceImagesDialog.FileName);
            var allImageFiles = Directory.GetFiles(sourceDirectory)
                .Where(f => Path.GetExtension(f).ToUpper() == ".PNG");

            foreach (var imageFile in allImageFiles)
            {
                try
                {
                    var image = (Bitmap)Image.FromFile(imageFile);

                    if (image.Width % 2 == 1 || image.Height % 2 == 1)
                    {
                        continue;   // exclude images which don't have an even number Wd or Ht
                    }

                    this.sourceDirectoryImages.Add(image);
                    this.listBoxSourceImages.Items.Add(Path.GetFileName(imageFile));
                }
                catch
                {
                    continue;
                }
            }
        }

        #endregion


        // ---------------------------------------------------------------------------------------------------------------------

        #region UI

        private void listBoxWaxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWaxImages.SelectedIndex >= 0 && this.waxImages.Count > listBoxWaxImages.SelectedIndex)
            {
                this.pictureBoxWaxImage.Image = this.waxImages[listBoxWaxImages.SelectedIndex];
                this.pictureBoxHighRes.Image = this.highResImages?[listBoxWaxImages.SelectedIndex] ?? null;

                this.labelWaxImageSize.Text = $"Size = {this.pictureBoxWaxImage.Image.Width} x {this.pictureBoxWaxImage.Image.Height}";
            }
        }

        private void listBoxSourceImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSourceImages.SelectedIndex >= 0 && this.sourceDirectoryImages.Count > listBoxSourceImages.SelectedIndex)
            {
                this.pictureBoxSourceImages.Image = this.sourceDirectoryImages[listBoxSourceImages.SelectedIndex];

                this.labelSourceImageSize.Text = $"Size = {this.pictureBoxSourceImages.Image.Width} x {this.pictureBoxSourceImages.Image.Height}";

                if (this.listBoxWaxImages.SelectedIndex >= 0)
                {
                    var isCorrectSize = IsCorrectSize(this.waxImages[this.listBoxWaxImages.SelectedIndex], this.sourceDirectoryImages[listBoxSourceImages.SelectedIndex]);
                    this.labelSourceImageSize.ForeColor = isCorrectSize ? Color.Green : Color.Red;
                }
            }
        }

        private void btnApplyImage_Click(object sender, EventArgs e)
        {
            if (listBoxSourceImages.SelectedIndex >= 0 && this.sourceDirectoryImages.Count > listBoxSourceImages.SelectedIndex)
            {
                var waxImage = this.waxImages[listBoxWaxImages.SelectedIndex];
                var hiResImage = this.sourceDirectoryImages[listBoxSourceImages.SelectedIndex];

                if (!IsCorrectSize(waxImage, hiResImage))
                {
                    MessageBox.Show("Selected source image has incorrect dimensions", "Invalid image", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    this.highResImages[listBoxWaxImages.SelectedIndex] = new Bitmap(hiResImage);
                    this.pictureBoxHighRes.Image = this.highResImages[listBoxWaxImages.SelectedIndex];
                }
            }
        }

        private void btnAutoSet_Click(object sender, EventArgs e)
        {
            if (this.sourceDirectoryImages.Count == 0)
            {
                return;
            }

            var response = MessageBox.Show("This will attempt to automatically set high res images by matching them based on size. Please check the results and perform manual corrections as needed. Proceed?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == DialogResult.No)
            {
                return;
            }

            var matchedCount = 0;
            var unmatchedCount = 0;
            for (var wi = 0; wi < this.waxImages.Count; wi++)
            {
                var waxImage = this.waxImages[wi];

                var matchingHiresImage = this.sourceDirectoryImages
                    .FirstOrDefault(i => IsCorrectSize(waxImage, i));

                if (matchingHiresImage != null)
                {
                    this.highResImages[wi] = matchingHiresImage;
                    matchedCount++;
                }
                else
                {
                    unmatchedCount++;
                }
            }

            MessageBox.Show($"{matchedCount} images set. {unmatchedCount} images could not be matched.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.pictureBoxHighRes.Image = this.highResImages[listBoxWaxImages.SelectedIndex];
        }

        #endregion

        // ---------------------------------------------------------------------------------------------------------------------

        private void btnCreateWxx_Click(object sender, EventArgs e)
        {
            // Run a check of the images
            for (var i = 0; i < this.waxImages.Count; i++)
            {
                var waxImage = this.waxImages[i];
                var hiresImage = this.highResImages[i];

                if (hiresImage == null || !IsCorrectSize(waxImage, hiresImage))
                {
                    MessageBox.Show("The high res images have not been properly populated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            var response = this.saveWxxDialog.ShowDialog();
            if (response == DialogResult.OK)
            {
                if (RemasterImagesImporterExporter.CreateWxx(this.highResImages, this.saveWxxDialog.FileName))
                {
                    MessageBox.Show("WXX successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create WXX.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static bool IsCorrectSize(Bitmap lowRes, Bitmap highRes)
        {
            if (lowRes == null || highRes == null)
            {
                return false;
            }

            var isWidthCorrect = lowRes.Width * 2 == highRes.Width;
            var isHeightCorrect = lowRes.Height * 2 == highRes.Height;

            return isWidthCorrect && isHeightCorrect;
        }
    }
}
