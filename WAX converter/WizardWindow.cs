using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace WAX_converter
{
    public partial class WizardWindow : Form
    {
        // NESTED CLASSES ---------------------------------------------------------------------------------------

        private class SourceImage
        {
            public string Name { get; set; }
            public int Index { get; set; }          // index in the containing collection or array
            public Bitmap Image { get; set; }
        }

        // The WizardAction class is just an array of 8 sequences (representing 8 viewing angles)
        private class WizardAction
        {
            public WizardSequence[] sequences { get; set; }

            public WizardAction()
            {
                // initialise the array then each of the 8 sequences in it
                this.sequences = new WizardSequence[8];
                for (int n = 0; n < 8; n++)
                {
                    sequences[n] = new WizardSequence();
                }
            }
        }

        private class WizardSequence
        {
            public WizardFrame[] frames { get; set; }
            public bool isFlipped { get; set; }

            public WizardSequence()
            {
                this.frames = new WizardFrame[32];
                for (int n = 0; n < 32; n++)
                {
                    frames[n] = new WizardFrame();
                    frames[n].imageIndex = -1;
                    frames[n].waxFrameNumber = -1;
                }
            }
        }

        private class WizardFrame
        {
            public int imageIndex { get; set; }
            public int waxFrameNumber { get; set; }     // the frame number in the final WAX
        }

        // ---------------------------------------------------------------------------------------------

        private string[] actionLabelList = new string[] { "Stationary", "Moving", "Attack 1", "Recoil 1", "Attack 2", "Recoil 2", "Pain", "Dying 1", "Dying 2", "Dead", "Dark Trooper block / fly" };
        private string[] actionKeyList = new string[] { "Stationary", "Moving", "Attack1", "Recoil", "Attack2", "Recoil2", "Pain", "Dying1", "Dying2", "Dead", "DTSpecial" };

        private Dictionary<string, WizardAction> actionDictionary;
        private List<SourceImage> sourceImages = new List<SourceImage>();
        private List<SourceImage> currentSequenceImages = new List<SourceImage>();
        private string selectedAction;
        private int selectedViewAngle = 0;
        private Image[] viewingAngleDiagramImages = new Image[8];

        private bool showCloseWindowPrompt = false;

        public WizardWindow()
        {
            InitializeComponent();

            // Initialise Action dictionary
            this.actionDictionary = new Dictionary<string, WizardAction>();
            foreach (var key in actionKeyList)
            {
                actionDictionary.Add(key, new WizardAction());
            }

            comboBoxAction.DataSource = actionLabelList;
            comboBoxAction.SelectedIndex = 0;
            this.selectedAction = actionKeyList[0];

            listBoxImages.DisplayMember = "Name";
            listBoxImages.ValueMember = "Index";
            listBoxSeq.DisplayMember = "Name";
            listBoxSeq.ValueMember = "Index";
        }

        private void WizardWindow_Load(object sender, EventArgs e)
        {
            getSourceImages();

            this.viewingAngleDiagramImages[0] = this.sprite0Img.Image;
            this.viewingAngleDiagramImages[1] = this.sprite1Img.Image;
            this.viewingAngleDiagramImages[2] = this.sprite2Img.Image;
            this.viewingAngleDiagramImages[3] = this.sprite3Img.Image;
            this.viewingAngleDiagramImages[4] = this.sprite4Img.Image;
            this.viewingAngleDiagramImages[5] = this.sprite5Img.Image;
            this.viewingAngleDiagramImages[6] = this.sprite6Img.Image;
            this.viewingAngleDiagramImages[7] = this.sprite7Img.Image;
            this.viewingAngleDiagram.Image = this.viewingAngleDiagramImages[this.selectedViewAngle];
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            getSourceImages();
        }

        private void getSourceImages()
        {
            var result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                var dir = Path.GetDirectoryName(folderBrowser.FileName);
                var files = Directory.EnumerateFiles(dir);
                
                if (files != null)
                {
                    this.sourceImages.Clear();
                    int counter = 0;

                    foreach (var file in files)
                    {
                        try
                        {
                            var fileExt = Path.GetExtension(file).ToUpper();

                            if (fileExt.Equals(".PNG") || fileExt.Equals(".JPG") || fileExt.Equals(".JPEG") || fileExt.Equals(".BMP"))
                            {
                                var image = new SourceImage();
                                image.Name = Path.GetFileName(file);
                                image.Index = counter;
                                image.Image = new Bitmap(file);
                                this.sourceImages.Add(image);
                                counter++;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show($"Error loading file '{Path.GetFileName(file)}'. \n{exception.Message}");
                        }
                    }

                    if (this.sourceImages.Count == 0)
                    {
                        MessageBox.Show("There are no source images in this directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                        return;
                    }

                    listBoxImages.DataSource = null;
                    listBoxImages.DataSource = this.sourceImages;
                    listBoxImages.DisplayMember = "Name";
                    listBoxImages.ValueMember = "Index";

                    this.showCloseWindowPrompt = true;
                }
            }
            else
            {
                this.Close();
            }
        }

        // --------------------------------------------------------------------------------------------------------------------

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WizardWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.showCloseWindowPrompt)
            {
                var response = MessageBox.Show("You will lose any work you have done. Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (response == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        // --------------------------------------------------------------------------------------------------------------------

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedItem != null)
            {
                int imageIndex = (int)listBoxImages.SelectedValue;
                pictureBoxPreview.Image = sourceImages[imageIndex].Image;
            }
            else
            {
                pictureBoxPreview.Image = null;
            }
        }

        private void listBoxSeq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSeq.SelectedItem != null)
            {
                int imageIndex = (int)listBoxSeq.SelectedValue;
                pictureBoxPreview.Image = sourceImages[imageIndex].Image;
            }
        }
        
        private void checkBoxFlip_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var i in sourceImages)
            {
                i.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }

            pictureBoxPreview.Image = null;
            if (listBoxImages.SelectedItem != null)
            {
                int imageIndex = (int)listBoxImages.SelectedValue;
                pictureBoxPreview.Image = sourceImages[imageIndex].Image;
            }
        }

        private void checkBoxZoom_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.SizeMode = checkBoxZoom.Checked ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.Normal;
        }

        // --------------------------------------------------------------------------------------------------------------------

        private void comboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = comboBoxAction.SelectedIndex;

            if (i >= 0)
            {
                this.selectedAction = actionKeyList[comboBoxAction.SelectedIndex];
                updateSelectedSequence();
            }
        }

        private void btnFront_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnFront.BackColor = Color.Gold;
            this.selectedViewAngle = 0;
            updateSelectedSequence();
        }

        private void btnFrontLeft_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnFrontLeft.BackColor = Color.Gold;
            this.selectedViewAngle = 1;
            updateSelectedSequence();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnLeft.BackColor = Color.Gold;
            this.selectedViewAngle = 2;
            updateSelectedSequence();
        }

        private void btnBackLeft_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnBackLeft.BackColor = Color.Gold;
            this.selectedViewAngle = 3;
            updateSelectedSequence();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnBack.BackColor = Color.Gold;
            this.selectedViewAngle = 4;
            updateSelectedSequence();
        }

        private void btnBackRight_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnBackRight.BackColor = Color.Gold;
            this.selectedViewAngle = 5;
            updateSelectedSequence();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnRight.BackColor = Color.Gold;
            this.selectedViewAngle = 6;
            updateSelectedSequence();
        }

        private void btnFrontRight_Click(object sender, EventArgs e)
        {
            resetAllViewAngleButtons();
            btnFrontRight.BackColor = Color.Gold;
            this.selectedViewAngle = 7;
            updateSelectedSequence();
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

        private void updateSelectedSequence()
        {
            output.Text = $"{selectedAction} {selectedViewAngle}";

            this.viewingAngleDiagram.Image = this.viewingAngleDiagramImages[this.selectedViewAngle];
            var seq = actionDictionary[selectedAction].sequences[selectedViewAngle];
            checkBoxFlip.Checked = seq.isFlipped;
            listBoxImages.SelectedItems.Clear();
            currentSequenceImages.Clear();

            foreach (var frame in seq.frames)
            {
                var index = frame.imageIndex;

                if (index >= 0)
                {
                    listBoxImages.SelectedIndices.Add(index);           // select the item in the source listbox
                    currentSequenceImages.Add(sourceImages[index]);
                }
            }

            listBoxSeq.DataSource = null;
            listBoxSeq.DataSource = currentSequenceImages;
            listBoxSeq.DisplayMember = "Name";
            listBoxSeq.ValueMember = "Index";

        }

        // APPLY buttons --------------------------------------------------------------------------------------------------

        private void btnApplyImages_Click(object sender, EventArgs e)
        {
            int numberSelectedImages = listBoxImages.SelectedIndices.Count;

            if (numberSelectedImages > 0)
            {
                actionDictionary[selectedAction].sequences[selectedViewAngle] = new WizardSequence();
                actionDictionary[selectedAction].sequences[selectedViewAngle].isFlipped = checkBoxFlip.Checked;

                int n = 0;
                foreach (int index in listBoxImages.SelectedIndices)
                {
                    actionDictionary[selectedAction].sequences[selectedViewAngle].frames[n].imageIndex = index;
                    
                    // max number of frames in a sequence is 32 so break loop if n == 31
                    n++;
                    if (n == 31) break;         
                }

                updateSelectedSequence();
                btnSourceFolder.Enabled = false;    // disable ability to change source folder
            }
        }

        private void btnApplyAllFacings_Click(object sender, EventArgs e)
        {
            // Apply the currently selected images to all 8 facings of selected action
            int numberSelectedImages = listBoxImages.SelectedIndices.Count;

            if (numberSelectedImages > 0)
            {
                for (var s = 0; s < 8; s++)
                {
                    actionDictionary[selectedAction].sequences[s] = new WizardSequence();
                    actionDictionary[selectedAction].sequences[s].isFlipped = this.checkBoxFlip.Checked;
                }

                int n = 0;
                foreach (int index in listBoxImages.SelectedIndices)
                {
                    foreach (var viewAngle in actionDictionary[selectedAction].sequences)
                    {
                        viewAngle.frames[n].imageIndex = index;
                    }

                    // max number of frames in a sequence is 32 so break loop if n == 31
                    n++;
                    if (n == 31) break;
                }

                updateSelectedSequence();
                btnSourceFolder.Enabled = false;    // disable ability to change source folder
            }
        }

        // DONE button --------------------------------------------------------------------------------------------------

        private void btnDone_Click(object sender, EventArgs e)
        {
            var actionList = new List<Action>();
            var sequenceList = new List<Sequence>();
            var frameList = new List<Frame>();

            // Generate frames
            this.GenerateFrames(actionDictionary["Moving"], frameList);
            this.GenerateFrames(actionDictionary["Attack1"], frameList);
            this.GenerateFrames(actionDictionary["Dying1"], frameList);
            this.GenerateFrames(actionDictionary["Dying2"], frameList);
            this.GenerateFrames(actionDictionary["Dead"], frameList);
            this.GenerateFrames(actionDictionary["Stationary"], frameList);
            this.GenerateFrames(actionDictionary["Recoil"], frameList);
            this.GenerateFrames(actionDictionary["Attack2"], frameList);
            this.GenerateFrames(actionDictionary["Recoil2"], frameList);
            this.GenerateFrames(actionDictionary["Pain"], frameList);
            this.GenerateFrames(actionDictionary["DTSpecial"], frameList);

            // Calculate wwidth and wheight based on height of "stationary" frame (this will hopefully give a reasonable value...)
            int ww = 70000;
            int wh = 70000;
            var sampleImageIndex = this.actionDictionary["Stationary"].sequences[0].frames[0].imageIndex;

            if (sampleImageIndex >= 0)
            {
                var sampleImage = this.sourceImages[sampleImageIndex].Image;
                if (sampleImage != null)
                {
                    float scaleFactor = 70f / sampleImage.Height;
                    ww = (int)(70000 * scaleFactor);
                    wh = (int)(70000 * scaleFactor);
                }
            }
            
            // Initialise then create actions (11 will be used)
            for (var a = 0; a < 14; a++)
            {
                var newAction = new Action()
                {
                    Wheight = wh,
                    Wwidth = ww,
                    FrameRate = 6       // default
                };
                actionList.Add(newAction);
            }

            this.CreateAction(actionList[0], 0);        // Moving
            this.CreateAction(actionList[1], 8);        // Attack1
            this.CreateAction(actionList[2], 16);       // Dying1
            this.CreateAction(actionList[3], 24);       // Dying2
            this.CreateAction(actionList[4], 32);       // Dead
            this.CreateAction(actionList[5], 40);       // Stationary
            this.CreateAction(actionList[6], 48);       // Recoil1
            this.CreateAction(actionList[7], 56);       // Attack2
            this.CreateAction(actionList[8], 64);       // Recoil2
            this.CreateAction(actionList[12], 72);      // Pain
            this.CreateAction(actionList[13], 80);      // DT Special

            // Initialise 11 x 8 = 88 sequences, then create each one
            for (var s = 0; s < 88; s++)
            {
                sequenceList.Add(new Sequence());
            }

            // Moving
            for (var s = 0; s < 8; s++)
            {
                for (var f = 0; f < 32; f++)
                {
                    sequenceList[s].frameIndexes[f] = actionDictionary["Moving"].sequences[s].frames[f].waxFrameNumber;
                }
            }

            // Attack1
            for (var s = 0; s < 8; s++)
            {
                for (var f = 0; f < 32; f++)
                {
                    sequenceList[s + 8].frameIndexes[f] = actionDictionary["Attack1"].sequences[s].frames[f].waxFrameNumber;
                }
            }

            // Dying1
            for (var s = 0; s < 8; s++)
            {
                for (var f = 0; f < 32; f++)
                {
                    sequenceList[s + 16].frameIndexes[f] = actionDictionary["Dying1"].sequences[s].frames[f].waxFrameNumber;
                }
            }

            // Dying2
            for (var s = 0; s < 8; s++)
            {
                for (var f = 0; f < 32; f++)
                {
                    sequenceList[s + 24].frameIndexes[f] = actionDictionary["Dying2"].sequences[s].frames[f].waxFrameNumber;
                }
            }

            // Dead
            for (var s = 0; s < 8; s++)
            {
                for (var f = 0; f < 32; f++)
                {
                    sequenceList[s + 32].frameIndexes[f] = actionDictionary["Dead"].sequences[s].frames[f].waxFrameNumber;
                }
            }

            // Stationary
            for (var s = 0; s < 8; s++)
            {
                for (var f = 0; f < 32; f++)
                {
                    sequenceList[s + 40].frameIndexes[f] = actionDictionary["Stationary"].sequences[s].frames[f].waxFrameNumber;
                }
            }

            // REcoil
            for (var s = 0; s < 8; s++)
            {
                for (var f = 0; f < 32; f++)
                {
                    sequenceList[s + 48].frameIndexes[f] = actionDictionary["Recoil"].sequences[s].frames[f].waxFrameNumber;
                }
            }

            // Attack2
            for (var s = 0; s < 8; s++)
            {
                for (var f = 0; f < 32; f++)
                {
                    sequenceList[s + 56].frameIndexes[f] = actionDictionary["Attack2"].sequences[s].frames[f].waxFrameNumber;
                }
            }

            // Recoil2
            for (var s = 0; s < 8; s++)
            {
                for (var f = 0; f < 32; f++)
                {
                    sequenceList[s + 64].frameIndexes[f] = actionDictionary["Recoil2"].sequences[s].frames[f].waxFrameNumber;
                }
            }

            // Pain
            for (var s = 0; s < 8; s++)
            {
                for (var f = 0; f < 32; f++)
                {
                    sequenceList[s + 72].frameIndexes[f] = actionDictionary["Pain"].sequences[s].frames[f].waxFrameNumber;
                }
            }

            // DTSpecial
            for (var s = 0; s < 8; s++)
            {
                for (var f = 0; f < 32; f++)
                {
                    sequenceList[s + 80].frameIndexes[f] = actionDictionary["DTSpecial"].sequences[s].frames[f].waxFrameNumber;
                }
            }

            // Ask user to save as Wax project
            var dialogResult = this.saveProjDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string FileNameNoExtension = Path.GetFileNameWithoutExtension(saveProjDialog.FileName);
                string Dir = Path.GetDirectoryName(saveProjDialog.FileName);
                string imageDirectory = Dir + "/" + FileNameNoExtension;

                try
                {
                    bool success = WaxProject.Save(this.saveProjDialog.FileName, 3, actionList, sequenceList, frameList, this.sourceImages.Count);
                    Directory.CreateDirectory(imageDirectory);

                    for (int i = 0; i < this.sourceImages.Count; i++)
                    {
                        var fileNum = Waxfile.GetExportFileNumber(i);
                        string imageSavePath = imageDirectory + "/" + fileNum + ".png";
                        this.sourceImages[i].Image.Save(imageSavePath, System.Drawing.Imaging.ImageFormat.Png);
                    }

                    if (success)
                    {
                        MessageBox.Show("Wax project file saved.", "Project Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while saving: {ex.Message}");
                }
            }

            // Create build window and put everything in
            BuildWindow newBuildWindow = new BuildWindow();
            newBuildWindow.FrameList = frameList;
            newBuildWindow.SequenceList = sequenceList;
            newBuildWindow.ActionList = actionList;
            
            foreach (var img in this.sourceImages)
            {
                newBuildWindow.ImageList.Add(img.Image);
            }

            newBuildWindow.PopulateUI();
            newBuildWindow.Show();
            newBuildWindow.SetComboBoxLogic(3);     // Set to Dark Trooper so all 14 actions are visible
        }

        private void GenerateFrames(WizardAction wizardAction, List<Frame> frameList)
        {
            // Iterate thru each wizframe in each wizsequence; if it points to an image, create a frame for it in the frameList
            foreach (var ws in wizardAction.sequences)
            {
                for (int f = 0; f < 32; f++)
                {
                    var imageIndex = ws.frames[f].imageIndex;
                    
                    // If the wizardFrame is set to an image, create a frame for it
                    if (imageIndex != -1)
                    {
                        Frame newFrame = new Frame();
                        newFrame.InsertX = -(this.sourceImages[imageIndex].Image.Width / 2);
                        newFrame.InsertY = -this.sourceImages[imageIndex].Image.Height;
                        newFrame.Flip = ws.isFlipped ? 1 : 0;          // check
                        newFrame.CellIndex = imageIndex;

                        frameList.Add(newFrame);
                        ws.frames[f].waxFrameNumber = frameList.Count - 1;
                    }
                    else
                    {
                        ws.frames[f].waxFrameNumber = -1;
                    }
                }
            }
        }
        
        private void CreateAction(Action action, int firstSequence)
        {
            for (var s = 0; s < 32; s++)
            {
                var sPlusTwo = s + 2;
                if (sPlusTwo >= 32) sPlusTwo -= 32;

                action.seqIndexes[s] = firstSequence + (sPlusTwo / 4);
            }
        }
    }
}
