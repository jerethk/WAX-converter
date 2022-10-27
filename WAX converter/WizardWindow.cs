using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WAX_converter
{
    public partial class WizardWindow : Form
    {
        private class SourceImage
        {
            public string Name { get; set; }
            public Bitmap Image { get; set; }
        }

        private string[] actionList = new string[] { "Stationary", "Moving", "Attack 1", "Recoil", "Attack 2", "Pain", "Dying 1", "Dying 2", "Dead", "Kell jump", "DT special" };
        
        private List<SourceImage> imageList;
        private List<Frame> frameList;

        public WizardWindow()
        {
            InitializeComponent();

            comboBoxAction.DataSource = actionList;
            imageList = new List<SourceImage>();
        }

        private void WizardWindow_Load(object sender, EventArgs e)
        {
            getSourceImages();
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            // TODO check if work has already begun
            
            getSourceImages();
        }

        private void getSourceImages()
        {
            var result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                var files = Directory.EnumerateFiles(folderBrowser.SelectedPath);
                this.imageList.Clear();
                
                if (files != null)
                {
                    foreach (var file in files)
                    {
                        var fileExt = Path.GetExtension(file);

                        if (fileExt.Equals(".PNG"))
                        {
                            var image = new SourceImage();
                            image.Name = Path.GetFileName(file);
                            image.Image = new Bitmap(file);
                            this.imageList.Add(image);
                        }
                    }

                    listBoxImages.DataSource = this.imageList;
                    listBoxImages.DisplayMember = "Name";
                }
            }
        }

        private void comboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = imageList[listBoxImages.SelectedIndex].Image;
        }
    }
}
