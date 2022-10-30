﻿using System;
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

        // The WizardAction class is an array of 8 sequences (representing 8 viewing angles)
        private class WizardAction
        {
            Sequence[] sequences;

            public WizardAction()
            {
                // initialise the array then each of the 8 sequences in it
                sequences = new Sequence[8];
                for (int n = 0; n < 8; n++)
                {
                    sequences[n] = new Sequence();
                }
            }
        }

        private string[] actionLabelList = new string[] { "Stationary", "Moving", "Attack 1", "Recoil", "Attack 2", "Recoil 2", "Pain", "Dying 1", "Dying 2", "Dead", "Kell jump", "DT special" };
        private string[] actionKeyList = new string[] { "Stationary", "Moving", "Attack1", "Recoil", "Attack2", "Recoil2", "Pain", "Dying1", "Dying2", "Dead", "KellJump", "DTSpecial" };

        private Dictionary<string, WizardAction> actionDictionary = new Dictionary<string, WizardAction>();
        private List<SourceImage> imageList = new List<SourceImage>();
        private List<Frame> frameList = new List<Frame>();
        private int selectedViewAngle = 0;

        public WizardWindow()
        {
            InitializeComponent();
            comboBoxAction.DataSource = actionLabelList;

            // Initialise Action dictionary
            foreach (var key in actionKeyList)
            {
                actionDictionary.Add(key, new WizardAction());
            }
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
                        try
                        {
                            var fileExt = Path.GetExtension(file).ToUpper();

                            if (fileExt.Equals(".PNG") || fileExt.Equals(".JPG") || fileExt.Equals(".JPEG") || fileExt.Equals(".BMP"))
                            {
                                var image = new SourceImage();
                                image.Name = Path.GetFileName(file);
                                image.Image = new Bitmap(file);
                                this.imageList.Add(image);
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show($"Error loading file '{Path.GetFileName(file)}'. \n{exception.Message}");
                        }
                    }

                    listBoxImages.DataSource = null;
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
            if (listBoxImages.SelectedItem != null)
            {
                pictureBoxPreview.Image = imageList[listBoxImages.SelectedIndex].Image;
            }
        }

        private void btnFront_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnFront.BackColor = Color.Gold;
            this.selectedViewAngle = 0;
        }

        private void btnFrontLeft_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnFrontLeft.BackColor = Color.Gold;
            this.selectedViewAngle = 1;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnLeft.BackColor = Color.Gold;
            this.selectedViewAngle = 2;
        }

        private void btnBackLeft_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnBackLeft.BackColor = Color.Gold;
            this.selectedViewAngle = 3;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnBack.BackColor = Color.Gold;
            this.selectedViewAngle = 5;
        }

        private void btnBackRight_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnBackRight.BackColor = Color.Gold;
            this.selectedViewAngle = 6;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnRight.BackColor = Color.Gold;
            this.selectedViewAngle = 7;
        }

        private void btnFrontRight_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnFrontRight.BackColor = Color.Gold;
            this.selectedViewAngle = 8;
        }

        private void resetAllViewAngleButtons()
        {
            btnFront.BackColor = System.Drawing.SystemColors.ControlLight;
            btnFrontLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            btnLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            btnBackLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
            btnBackRight.BackColor = System.Drawing.SystemColors.ControlLight;
            btnRight.BackColor = System.Drawing.SystemColors.ControlLight;
            btnFrontRight.BackColor = System.Drawing.SystemColors.ControlLight;
        }
    }
}
