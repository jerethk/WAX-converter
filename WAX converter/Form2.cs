using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WAX_converter
{
    public partial class BuildWindow : Form
    {
        public BuildWindow()
        {
            this.InitializeComponent();

            dataGridViews.Rows.Add(32);
            for (int i = 0; i < 32; i++)
            {
                dataGridViews.Rows[i].Cells[0].Value = i;
                dataGridViews.Rows[i].Cells[1].Value = 0;
            }

            palette = new DFPal();
            ImageList = new List<Bitmap>();
            FrameList = new List<Frame>();
            SequenceList = new List<Sequence>();
            ActionList = new List<Action>();

            transparentColour = Color.FromArgb(255, 0, 0, 0);
            transpColourBox.BackColor = transparentColour;
        }

        private DFPal palette;
        public List<Bitmap> ImageList;
        public List<Frame> FrameList;
        public List<Sequence> SequenceList;
        public List<Action> ActionList;
        private Color transparentColour;

        private string[] logicAnim = new string[1] {"0 Animation"};
        private string[] logicScenery = new string[2] { "0 Start", "1 Destroyed" };
        private string[] logicEnemy = new string[13] { "0 Moving", "1 Attack", "2 Dying1", "3 Dying2", "4 Dead", "5 Stationary", "6 Recoil", "7 Attack2", "8 Recoil2", "9 Kell jump", "10 not used", "11 Kell jump attack", "12 Pain" };
        private string[] logicDT = new string[14] { "0 Moving", "1 Attack", "2 Dying1", "3 Dying2", "4 Dead", "5 Stationary", "6 Recoil", "7 not used", "8 not used", "9 not used", "10 not used", "11 not used", "12 Pain", "13 Blocking / flying" };
        private string[] logicRemote = new string[4] { "0 Searching", "1 Inactive", "2 Dying1", "3 Dying2" };

        // -------------------------------------------------------------------

        private void BuildWindow_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 14; i++)    // create 14 actions, which is the maximum needed
            {
                ActionList.Add(new Action());
            }

            comboBoxLogic.SelectedIndex = 0;
        }

        private void BuildWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to leave? Unsaved work will be lost!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BuildWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var image in this.ImageList)
            {
                image.Dispose();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpWindow hlpwin = new HelpWindow();
            hlpwin.ShowDialog();
        }

        private void ButtonPal_Click(object sender, EventArgs e)
        {
            openPalDialog.ShowDialog();
        }

        private void openPalDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (palette.LoadfromFile(openPalDialog.FileName))
            {
                labelPal.Text = Path.GetFileName(openPalDialog.FileName);
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
                MessageBox.Show("Glow-in-dark colours (PAL indexes 1-23) will be included when performing colour matching.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Bitmap img;
            if (ImageList.Count >= 1)
            {
                img = ImageList[0];     // send the first image to the colour picker
            }
            else
            {
                img = null;
            }
            
            ColourChooser TransparentDialog = new ColourChooser(img, this.transparentColour);
            TransparentDialog.ShowDialog();
            this.transparentColour = TransparentDialog.FinalColour;
            transpColourBox.BackColor = this.transparentColour;
            TransparentDialog.Dispose();
        }

        // --- CELL AREA --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void listboxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImageList.Count >= 1 && listboxImages.SelectedIndex >= 0)
            {
                cellDisplayBox.Image = ImageList[listboxImages.SelectedIndex];
            }
        }

        private void ButtonAddImage_Click(object sender, EventArgs e)
        {
            loadImageDialog.ShowDialog();
        }

        private void loadImageDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                foreach (string fname in loadImageDialog.FileNames)
                {
                    Bitmap newImage = new Bitmap(fname);
                    ImageList.Add(newImage);

                    listboxImages.Items.Add("Cell " + listboxImages.Items.Count);
                }
                
                listboxImages.SelectedIndex = listboxImages.Items.Count - 1;
                labelNCells.Text = "n = " + ImageList.Count;
                buttonAddFrame.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        private void ButtonRemoveImage_Click(object sender, EventArgs e)
        {
            int index = listboxImages.SelectedIndex;
            
            if (ImageList.Count > 0 && index >= 0)
            {
                // Check if cell is already used with any frames
                if (FrameList.Any(f => f.CellIndex == index))
                {
                    MessageBox.Show("The selected cell has been assigned to a frame.", "Cannot remove", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Prompt for confirmation first
                    var answer = MessageBox.Show("Are you sure you want to delete this cell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        if (index > 0)
                        {
                            listboxImages.SelectedIndex -= 1;       // move the selection up 1 unless at position 0
                        }

                        ImageList.RemoveAt(index);
                        listboxImages.Items.RemoveAt(listboxImages.Items.Count - 1);
                        labelNCells.Text = "n = " + ImageList.Count;

                        // Re-index frames
                        foreach (Frame f in FrameList)
                        {
                            if (f.CellIndex > index) f.CellIndex -= 1;
                        }

                        if (listboxFrames.SelectedIndex >= 0)
                        {
                            textBoxCell.Text = FrameList[listboxFrames.SelectedIndex].CellIndex.ToString();
                        }

                        if (ImageList.Count == 0)
                        {
                            cellDisplayBox.Image = null;
                        }
                        else
                        {
                            cellDisplayBox.Image = ImageList[listboxImages.SelectedIndex];
                        }
                    }
                }
            }
        }

        private void ButtonMoveUp_Click(object sender, EventArgs e)
        {
            int index = listboxImages.SelectedIndex;
            
            if (index > 0)
            {
                ImageList.Reverse(index - 1, 2);
                listboxImages.SelectedIndex -= 1;
            }
        }

        private void ButtonMoveDown_Click(object sender, EventArgs e)
        {
            int index = listboxImages.SelectedIndex;
            
            if (index < ImageList.Count - 1)
            {
                ImageList.Reverse(index, 2);
                listboxImages.SelectedIndex += 1;
            }
        }

// --- FRAME AREA --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void listboxFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxFrames.SelectedIndex >= 0)
            {
                var selectedFrame = FrameList[listboxFrames.SelectedIndex];

                listboxImages.SelectedIndex = selectedFrame.CellIndex;
                textBoxCell.Text = selectedFrame.CellIndex.ToString();
                InsertX.Value = selectedFrame.InsertX;
                InsertY.Value = selectedFrame.InsertY;
                checkBoxFlip.Checked = selectedFrame.Flip == 1;

                var frameImage = new Bitmap(this.ImageList[selectedFrame.CellIndex]);
                if (selectedFrame.Flip == 1)
                {
                    frameImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                }
                frameDisplayBox.Image = frameImage;
            }
        }

        private void buttonAddFrame_Click(object sender, EventArgs e)
        {
            if (ImageList.Count > 0)
            {
                MessageBox.Show("Select the cells to turn into frames, then press DONE. Multiselect using CTRL and SHIFT keys.");
                btnDoneAddingFrames.Visible = true;
                listboxImages.SelectionMode = SelectionMode.MultiExtended;    // allow multiselection

                ButtonMoveUp.Enabled = false;
                ButtonMoveDown.Enabled = false;
                ButtonRemoveImage.Enabled = false;
                ButtonAddImage.Enabled = false;
                panel1.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;
                panel6.Enabled = false;
                panel7.Enabled = false;
            }
        }

        private void btnDoneAddingFrames_Click(object sender, EventArgs e)
        {
            if (listboxImages.SelectedItems.Count > 0)
            {
                // makes all selected cells into frames
                foreach (object o in listboxImages.SelectedItems)
                {
                    int selectedCell = listboxImages.Items.IndexOf(o);

                    Frame newFrame = new Frame();
                    newFrame.CellIndex = selectedCell;
                    newFrame.InsertX = ImageList[selectedCell].Width / 2 * -1;      // set sensible default values based on size of image
                    newFrame.InsertY = ImageList[selectedCell].Height * -1 + (int) (0.06 * ImageList[selectedCell].Height);
                    newFrame.Flip = 0;

                    FrameList.Add(newFrame);
                    listboxFrames.Items.Add(listboxFrames.Items.Count);
                    listboxFrames.SelectedIndex = listboxFrames.Items.Count - 1;
                }

                InsertX.Enabled = true;
                InsertY.Enabled = true;
                checkBoxFlip.Enabled = true;
                buttonAddSequence.Enabled = true;
                buttonRemoveSequence.Enabled = true;
                labelNFrames.Text = "n = " + FrameList.Count;
            }

            // once Frames have been added, disable ability to move cells
            if (FrameList.Count == 0)
            {
                ButtonMoveUp.Enabled = true;
                ButtonMoveDown.Enabled = true;
            }

            ButtonAddImage.Enabled = true;
            ButtonRemoveImage.Enabled = true;
            panel1.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
            panel7.Enabled = true;
            btnDoneAddingFrames.Visible = false;
            listboxImages.SelectionMode = SelectionMode.One;
        }

        private void buttonRemoveFrame_Click(object sender, EventArgs e)
        {
            int index = listboxFrames.SelectedIndex;

            if (FrameList.Count > 0 && index >= 0)
            {
                // Check if selected frame is used in any sequences
                bool isUsed = SequenceList.Any(s => s.frameIndexes.Any(i => i == index));
                if (isUsed)
                {
                    MessageBox.Show("The selected frame is used in a Sequence.", "Cannot remove", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Prompt for confirmation 
                    var answer = MessageBox.Show("Are you sure you want to delete this frame?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        if (index > 0)
                        {
                            listboxFrames.SelectedIndex -= 1;       // move the selection up 1 unless at position 0
                        }

                        FrameList.RemoveAt(index);
                        listboxFrames.Items.RemoveAt(listboxFrames.Items.Count - 1);
                        labelNFrames.Text = "n = " + FrameList.Count;

                        // Re-index frame references in sequences
                        foreach (Sequence s in SequenceList)
                        {
                            for (int f = 0; f < 32; f++)
                            {
                                if (s.frameIndexes[f] > index) s.frameIndexes[f] -= 1;
                            }
                        }

                        if (listboxSeqs.SelectedIndex >= 0)
                        {
                            listboxSeqFrames.DataSource = new BindingSource(SequenceList[listboxSeqs.SelectedIndex].frameIndexes, "");
                        }

                        if (FrameList.Count == 0)
                        {
                            ButtonMoveUp.Enabled = true;
                            ButtonMoveDown.Enabled = true;
                            InsertX.Enabled = false;
                            InsertY.Enabled = false;
                            checkBoxFlip.Enabled = false;
                        }
                    }
                }
            }
        }

        private void InsertX_ValueChanged(object sender, EventArgs e)
        {
            int selectedFrame = listboxFrames.SelectedIndex;
            FrameList[selectedFrame].InsertX = (int) InsertX.Value;
        }

        private void InsertY_ValueChanged(object sender, EventArgs e)
        {
            int selectedFrame = listboxFrames.SelectedIndex;
            FrameList[selectedFrame].InsertY = (int)InsertY.Value;
        }

        private void checkBoxFlip_CheckedChanged(object sender, EventArgs e)
        {
            int selectedFrame = listboxFrames.SelectedIndex;
            FrameList[selectedFrame].Flip = checkBoxFlip.Checked ? 1 : 0;

            var frameImage = new Bitmap(this.ImageList[this.FrameList[selectedFrame].CellIndex]);
            if (checkBoxFlip.Checked)
            {
                frameImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            frameDisplayBox.Image = frameImage;
        }

        private void btnPositionFrames_Click(object sender, EventArgs e)
        {
            if (this.FrameList.Count > 0)
            {
                var index = listboxFrames.SelectedIndex;

                var window = new FramePositioningWindow(this.FrameList, this.ImageList, this.transparentColour);
                window.ShowDialog();

                if (index >= 0)
                {
                    InsertX.Value = this.FrameList[index].InsertX;
                    InsertY.Value = this.FrameList[index].InsertY;
                }
            }
        }

        // --- SEQUENCE AREA --------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void listboxSeqs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SequenceList.Count > 0)
            {
                listboxSeqFrames.DataSource = SequenceList[listboxSeqs.SelectedIndex].frameIndexes;
            }
        }

        private void buttonAddSequence_Click(object sender, EventArgs e)
        {
            if (FrameList.Count > 0)
            {
                Sequence newSeq = new Sequence();
                SequenceList.Add(newSeq);
                listboxSeqs.Items.Add(listboxSeqs.Items.Count);
                listboxSeqs.SelectedIndex = listboxSeqs.Items.Count - 1;

                listboxSeqFrames.Enabled = true;
                buttonEditSequence.Enabled = true;
                labelNSeqs.Text = "n = " + SequenceList.Count;

                dataGridViews.Enabled = true;
                buttonSetAllViews.Enabled = true;
                Wwidth.Enabled = true;
                Wheight.Enabled = true;
                FRate.Enabled = true;
            }
        }

        private void buttonRemoveSequence_Click(object sender, EventArgs e)
        {
            int index = listboxSeqs.SelectedIndex;

            if (SequenceList.Count > 1 && index >= 0)
            {
                // Check if used
                bool isUsed = ActionList.Any(a => a.seqIndexes.Any(i => i == index));
                if (isUsed)
                {
                    MessageBox.Show("The selected sequence has been assigned to an action.", "Cannot remove", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Confirm
                    var answer = MessageBox.Show("The entire selected sequence will be deleted. Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (answer == DialogResult.Yes)
                    {
                        if (index > 0)
                        {
                            listboxSeqs.SelectedIndex -= 1;       // move the selection up 1 unless at position 0
                        }

                        SequenceList.RemoveAt(index);
                        listboxSeqs.Items.RemoveAt(listboxSeqs.Items.Count - 1);
                        labelNSeqs.Text = "n = " + SequenceList.Count;

                        // Go through the actions and re-index every sequence after the removed sequence, then update the datagrid
                        foreach (Action a in ActionList)
                        {
                            for (int v = 0; v < 32; v++)
                            {
                                int value = a.seqIndexes[v];
                                if (value > index || value >= SequenceList.Count)
                                {
                                    a.seqIndexes[v] -= 1;
                                }
                            }
                        }

                        for (int i = 0; i < 32; i++)
                        {
                            dataGridViews.Rows[i].Cells[1].Value = ActionList[comboBoxAction.SelectedIndex].seqIndexes[i];
                        }
                    }
                }
            }
        }

        private void listboxSeqFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxSeqFrames.Items.Count > 0)
            {
                int thisSequence = listboxSeqs.SelectedIndex;
                int selectedFrame = SequenceList[thisSequence].frameIndexes[listboxSeqFrames.SelectedIndex];

                if (selectedFrame >= 0)
                {
                    listboxFrames.SelectedIndex = selectedFrame;
                }
            }
        }

        private void buttonEditSequence_Click(object sender, EventArgs e)
        {
            int sequenceNumber = listboxSeqs.SelectedIndex;

            if (sequenceNumber >= 0 && FrameList.Count > 0)
            {
                SequenceBuilderWindow SeqWindow = new SequenceBuilderWindow(this.ImageList, this.FrameList, this.SequenceList[sequenceNumber]);
                SeqWindow.Text = $"Editing Sequence {sequenceNumber}";
                SeqWindow.ShowDialog();
                listboxSeqFrames.DataSource = new BindingSource(SequenceList[listboxSeqs.SelectedIndex].frameIndexes, "");
            }
        }

// --- ACTIONS AREA --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void comboBoxLogic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strings;

            // Change available actions based on logic
            switch (comboBoxLogic.SelectedIndex)
            {
                case 0:
                    strings = logicAnim;
                    break;
                case 1:
                    strings = logicScenery;
                    break;
                case 2:
                    strings = logicEnemy;
                    break;
                case 3:
                    strings = logicDT;
                    break;
                case 4:
                    strings = logicRemote;
                    break;
                default:
                    strings = new string[1] { "" };
                    break;
            }

            comboBoxAction.DataSource = strings;
        }

        private void comboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxAction.SelectedIndex;
            
            Wwidth.Value = ActionList[index].Wwidth;
            Wheight.Value = ActionList[index].Wheight;
            FRate.Value = ActionList[index].FrameRate;

            for (int i = 0; i < 32; i++)
            {
                dataGridViews.Rows[i].Cells[1].Value = ActionList[index].seqIndexes[i];
            }

            if (SequenceList.Count > 0)
            {
                int seq = ActionList[index].seqIndexes[0];
                listboxSeqs.SelectedIndex = seq;
            }

        }

        private void dataGridViews_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // only allow an integer value
            int newValue;
            bool validEntry = Int32.TryParse(e.FormattedValue.ToString(), out newValue);

            if (!validEntry)
            {
                e.Cancel = true;
            }
        }

        private void dataGridViews_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int newValue = Int32.Parse(dataGridViews.Rows[e.RowIndex].Cells[1].Value.ToString());

                if (newValue < 0 || SequenceList.Count == 0)
                {
                    newValue = 0;
                }
                else if (newValue >= SequenceList.Count)
                {
                    newValue = SequenceList.Count - 1;
                }

                dataGridViews.Rows[e.RowIndex].Cells[1].Value = newValue;

                int action = comboBoxAction.SelectedIndex;
                int view = e.RowIndex;
                ActionList[action].seqIndexes[view] = newValue;
            }

        }

        private void dataGridViews_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (SequenceList.Count > 0)
            {
                int action = comboBoxAction.SelectedIndex;
                int view = e.RowIndex;
                
                if (action >= 0)
                {
                    int seq = ActionList[action].seqIndexes[view];
                    listboxSeqs.SelectedIndex = seq;
                }
            }
        }

        private void buttonSetAllViews_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("This will set all 32 views for this action to the selected sequence. Continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (answer == DialogResult.Yes)
            {
                int action = comboBoxAction.SelectedIndex;
                int seq = listboxSeqs.SelectedIndex;

                for (int v = 0; v < 32; v++)
                {
                    ActionList[action].seqIndexes[v] = seq;
                    dataGridViews.Rows[v].Cells[1].Value = seq;
                }
            }
        }

        private void Wwidth_ValueChanged(object sender, EventArgs e)
        {
            ActionList[comboBoxAction.SelectedIndex].Wwidth = (int) Wwidth.Value;
        }

        private void Wheight_ValueChanged(object sender, EventArgs e)
        {
            ActionList[comboBoxAction.SelectedIndex].Wheight = (int)Wheight.Value;
        }

        private void FRate_ValueChanged(object sender, EventArgs e)
        {
            ActionList[comboBoxAction.SelectedIndex].FrameRate = (int)FRate.Value;
        }


// --- CREATE WAX ----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void buttonCreateWAX_Click(object sender, EventArgs e)
        {
            if (ImageList.Count < 1)
            {
                MessageBox.Show("You need to add cells!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (FrameList.Count < 1)
            {
                MessageBox.Show("You need to add frames!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (SequenceList.Count < 1)
            {
                MessageBox.Show("You need to add sequences!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (palette == null)
            {
                MessageBox.Show("Palette not loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (SequenceList.All(s => s.frameIndexes[0] == -1))
            {
                MessageBox.Show("Your sequences are all empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SequenceList.Any(s => s.frameIndexes[0] == -1))
            {
                var response = MessageBox.Show("One or more sequences are empty. If you choose to continue, they will be substituted with the first available non-empty sequence.", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (response == DialogResult.Cancel)
                {
                    return;
                }
            }

            saveWaxDialog.ShowDialog();
        }

        private void saveWaxDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Waxfile newWax = WaxBuilder.BuildWax(comboBoxLogic.SelectedIndex, ActionList, SequenceList, FrameList, ImageList, palette, transparentColour, checkBoxIlluminated.Checked, checkBoxCommonColours.Checked, checkBoxCompress.Checked);

            if (newWax.Save(saveWaxDialog.FileName, checkBoxCompress.Checked))
            {
                MessageBox.Show("Successfully saved!", "WAX saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save new WAX!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            newWax = null;
        }


// --- ----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void buttonSaveWIP_Click(object sender, EventArgs e)
        {
            saveWIPDialog.ShowDialog();
        }

        private void saveWIPDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool success = true;
            string fileNameNoExtension = Path.GetFileNameWithoutExtension(saveWIPDialog.FileName);
            string dir = Path.GetDirectoryName(saveWIPDialog.FileName);
            string cellImageDirectory = dir + "/" + fileNameNoExtension + ".cells";

            try
            {
                // Save images as PNG in subfolder. Clear out subfolder if it already exists (from a previous project save)
                if (Directory.Exists(cellImageDirectory))
                {
                    var files = Directory.EnumerateFiles(cellImageDirectory, "*.png");
                    foreach (var f in files)
                    {
                        File.Delete(f);
                    }
                }
                
                Directory.CreateDirectory(cellImageDirectory);
                for (int i = 0; i < ImageList.Count; i++)
                {
                    var fileNum = Waxfile.GetExportFileNumber(i);
                    string imageSavePath = cellImageDirectory + "/" + fileNum + ".png";
                    ImageList[i].Save(imageSavePath, ImageFormat.Png);
                }

                // save project file
                if (!WaxProject.Save(saveWIPDialog.FileName, comboBoxLogic.SelectedIndex, ActionList, SequenceList, FrameList, ImageList.Count))
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {
                success = false;
                MessageBox.Show($"Error saving project. Exception {ex} occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (success)
            {
                MessageBox.Show($"Project file saved as {Path.GetFileName(saveWIPDialog.FileName)}. Cell images have been saved in {fileNameNoExtension}.cells\\ subdirectory.", "WIP saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

// --- ----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void buttonLoadWIP_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("You will lose any work you have already done here.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (answer == DialogResult.OK)
            {
                openWIPDialog.ShowDialog();
            }
        }

        private void openWIPDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int logicType = 0;
            List<Frame> loadedFrames = new List<Frame>();
            List<Sequence> loadedSeqs = new List<Sequence>();
            List<Action> loadedActions = new List<Action>();
            List<Bitmap> loadedBitmaps = new List<Bitmap>();

            if (!WaxProject.Load(openWIPDialog.FileName, out logicType, loadedActions, loadedSeqs, loadedFrames, loadedBitmaps))
            {
                MessageBox.Show("Failed to load. The project file(s) may have been corrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // If load successful, dispose any previous images, then load everything into the UI
                foreach (var image in ImageList)
                {
                    image.Dispose();
                }

                ImageList.Clear();
                ImageList = loadedBitmaps;
                FrameList = loadedFrames;
                SequenceList = loadedSeqs;
                ActionList = loadedActions;

                this.PopulateUI();
                this.SetComboBoxLogic(logicType);
            }
        }

        public void PopulateUI()
        {
            listboxImages.Items.Clear();
            for (int i = 0; i < ImageList.Count; i++)
            {
                listboxImages.Items.Add("Cell " + i);
            }
            ButtonAddImage.Enabled = true;
            ButtonRemoveImage.Enabled = true;
            ButtonMoveUp.Enabled = false;
            ButtonMoveDown.Enabled = false;

            listboxFrames.Items.Clear();
            for (int f = 0; f < FrameList.Count; f++)
            {
                listboxFrames.Items.Add(f.ToString());
            }
            if (FrameList.Count > 0)
            {
                listboxFrames.SelectedIndex = 0;
            }
            buttonAddFrame.Enabled = true;
            buttonRemoveFrame.Enabled = true;
            InsertX.Enabled = true;
            InsertY.Enabled = true;
            checkBoxFlip.Enabled = true;

            listboxSeqs.Items.Clear();
            for (int s = 0; s < SequenceList.Count; s++)
            {
                listboxSeqs.Items.Add(s.ToString());
            }
            if (SequenceList.Count > 0)
            {
                listboxSeqFrames.Enabled = true;
            }
            buttonAddSequence.Enabled = true;
            buttonRemoveSequence.Enabled = true;

            labelNCells.Text = $"n = {ImageList.Count}";
            labelNFrames.Text = $"n = {FrameList.Count}";
            labelNSeqs.Text = $"n = {SequenceList.Count}";
            comboBoxLogic.SelectedIndex = 0;    //
            comboBoxLogic.SelectedIndex = 1;    // changing this forces an update of the controls
            dataGridViews.Enabled = true;
            buttonSetAllViews.Enabled = true;
            Wwidth.Enabled = true;
            Wheight.Enabled = true;
            FRate.Enabled = true;
            buttonCreateWAX.Enabled = true;
        }

        public void SetComboBoxLogic(int logicType)
        {
            this.comboBoxLogic.SelectedIndex = logicType;
        }
    }
}
