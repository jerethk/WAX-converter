using System;
using System.Collections.Generic;
using System.Text;

namespace WAX_converter
{
    partial class BuildWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildWindow));
            listboxImages = new System.Windows.Forms.ListBox();
            ButtonAddImage = new System.Windows.Forms.Button();
            ButtonPal = new System.Windows.Forms.Button();
            openPalDialog = new System.Windows.Forms.OpenFileDialog();
            loadImageDialog = new System.Windows.Forms.OpenFileDialog();
            cellDisplayBox = new System.Windows.Forms.PictureBox();
            ButtonExit = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btnHelp = new System.Windows.Forms.Button();
            buttonSaveWIP = new System.Windows.Forms.Button();
            buttonLoadWIP = new System.Windows.Forms.Button();
            transpColourBox = new System.Windows.Forms.PictureBox();
            buttonTransparent = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            btnDoneAddingFrames = new System.Windows.Forms.Button();
            labelNCells = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ButtonRemoveImage = new System.Windows.Forms.Button();
            ButtonMoveUp = new System.Windows.Forms.Button();
            ButtonMoveDown = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            btnPositionFrames = new System.Windows.Forms.Button();
            frameDisplayBox = new System.Windows.Forms.PictureBox();
            labelNFrames = new System.Windows.Forms.Label();
            InsertY = new System.Windows.Forms.NumericUpDown();
            InsertX = new System.Windows.Forms.NumericUpDown();
            checkBoxFlip = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBoxCell = new System.Windows.Forms.TextBox();
            buttonRemoveFrame = new System.Windows.Forms.Button();
            buttonAddFrame = new System.Windows.Forms.Button();
            listboxFrames = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            buttonEditSequence = new System.Windows.Forms.Button();
            listboxSeqFrames = new System.Windows.Forms.ListBox();
            labelNSeqs = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            labelNotes = new System.Windows.Forms.Label();
            listboxSeqs = new System.Windows.Forms.ListBox();
            label7 = new System.Windows.Forms.Label();
            buttonRemoveSequence = new System.Windows.Forms.Button();
            buttonAddSequence = new System.Windows.Forms.Button();
            panel6 = new System.Windows.Forms.Panel();
            btnAnimate = new System.Windows.Forms.Button();
            dataGridViews = new System.Windows.Forms.DataGridView();
            ViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buttonSetAllViews = new System.Windows.Forms.Button();
            FRate = new System.Windows.Forms.NumericUpDown();
            label15 = new System.Windows.Forms.Label();
            Wheight = new System.Windows.Forms.NumericUpDown();
            label14 = new System.Windows.Forms.Label();
            Wwidth = new System.Windows.Forms.NumericUpDown();
            label13 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            comboBoxAction = new System.Windows.Forms.ComboBox();
            comboBoxLogic = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            panel7 = new System.Windows.Forms.Panel();
            checkBoxCompress = new System.Windows.Forms.CheckBox();
            labelPal = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            buttonCreateWAX = new System.Windows.Forms.Button();
            saveWaxDialog = new System.Windows.Forms.SaveFileDialog();
            saveWIPDialog = new System.Windows.Forms.SaveFileDialog();
            openWIPDialog = new System.Windows.Forms.OpenFileDialog();
            panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)cellDisplayBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transpColourBox).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)frameDisplayBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InsertY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InsertX).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViews).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Wheight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Wwidth).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // listboxImages
            // 
            listboxImages.FormattingEnabled = true;
            listboxImages.ItemHeight = 20;
            listboxImages.Location = new System.Drawing.Point(30, 40);
            listboxImages.Name = "listboxImages";
            listboxImages.Size = new System.Drawing.Size(100, 784);
            listboxImages.TabIndex = 1;
            listboxImages.SelectedIndexChanged += listboxImages_SelectedIndexChanged;
            // 
            // ButtonAddImage
            // 
            ButtonAddImage.Location = new System.Drawing.Point(167, 40);
            ButtonAddImage.Name = "ButtonAddImage";
            ButtonAddImage.Size = new System.Drawing.Size(156, 36);
            ButtonAddImage.TabIndex = 2;
            ButtonAddImage.Text = "Add Image(s)";
            ButtonAddImage.UseVisualStyleBackColor = true;
            ButtonAddImage.Click += ButtonAddImage_Click;
            // 
            // ButtonPal
            // 
            ButtonPal.Location = new System.Drawing.Point(32, 12);
            ButtonPal.Name = "ButtonPal";
            ButtonPal.Size = new System.Drawing.Size(87, 54);
            ButtonPal.TabIndex = 3;
            ButtonPal.Text = "Load PAL";
            ButtonPal.UseVisualStyleBackColor = true;
            ButtonPal.Click += ButtonPal_Click;
            // 
            // openPalDialog
            // 
            openPalDialog.DefaultExt = "PAL";
            openPalDialog.Filter = "DF Palette files|*.PAL";
            openPalDialog.Title = "Load PAL";
            openPalDialog.FileOk += openPalDialog_FileOk;
            // 
            // loadImageDialog
            // 
            loadImageDialog.Filter = "PNG file|*.PNG|Bitmap file|*.BMP|GIF file|*.GIF|JPEG file|*.JPG|All files|*.*";
            loadImageDialog.Multiselect = true;
            loadImageDialog.Title = "Add Image(s)";
            loadImageDialog.FileOk += loadImageDialog_FileOk;
            // 
            // cellDisplayBox
            // 
            cellDisplayBox.BackColor = System.Drawing.Color.Gray;
            cellDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            cellDisplayBox.Location = new System.Drawing.Point(167, 307);
            cellDisplayBox.Name = "cellDisplayBox";
            cellDisplayBox.Size = new System.Drawing.Size(400, 420);
            cellDisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            cellDisplayBox.TabIndex = 4;
            cellDisplayBox.TabStop = false;
            // 
            // ButtonExit
            // 
            ButtonExit.Location = new System.Drawing.Point(1027, 12);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new System.Drawing.Size(127, 54);
            ButtonExit.TabIndex = 5;
            ButtonExit.Text = "Exit build window";
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHelp);
            panel1.Controls.Add(buttonSaveWIP);
            panel1.Controls.Add(buttonLoadWIP);
            panel1.Controls.Add(transpColourBox);
            panel1.Controls.Add(buttonTransparent);
            panel1.Controls.Add(ButtonExit);
            panel1.Controls.Add(ButtonPal);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1424, 84);
            panel1.TabIndex = 6;
            // 
            // btnHelp
            // 
            btnHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHelp.Location = new System.Drawing.Point(1191, 12);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new System.Drawing.Size(45, 54);
            btnHelp.TabIndex = 13;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // buttonSaveWIP
            // 
            buttonSaveWIP.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSaveWIP.Location = new System.Drawing.Point(648, 12);
            buttonSaveWIP.Name = "buttonSaveWIP";
            buttonSaveWIP.Size = new System.Drawing.Size(123, 54);
            buttonSaveWIP.TabIndex = 11;
            buttonSaveWIP.Text = "SAVE PROJECT";
            buttonSaveWIP.UseVisualStyleBackColor = true;
            buttonSaveWIP.Click += buttonSaveWIP_Click;
            // 
            // buttonLoadWIP
            // 
            buttonLoadWIP.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonLoadWIP.Location = new System.Drawing.Point(787, 12);
            buttonLoadWIP.Name = "buttonLoadWIP";
            buttonLoadWIP.Size = new System.Drawing.Size(122, 54);
            buttonLoadWIP.TabIndex = 10;
            buttonLoadWIP.Text = "LOAD PROJECT";
            buttonLoadWIP.UseVisualStyleBackColor = true;
            buttonLoadWIP.Click += buttonLoadWIP_Click;
            // 
            // transpColourBox
            // 
            transpColourBox.Location = new System.Drawing.Point(292, 12);
            transpColourBox.Name = "transpColourBox";
            transpColourBox.Size = new System.Drawing.Size(55, 54);
            transpColourBox.TabIndex = 9;
            transpColourBox.TabStop = false;
            // 
            // buttonTransparent
            // 
            buttonTransparent.Location = new System.Drawing.Point(169, 12);
            buttonTransparent.Name = "buttonTransparent";
            buttonTransparent.Size = new System.Drawing.Size(117, 54);
            buttonTransparent.TabIndex = 8;
            buttonTransparent.Text = "Transparent colour";
            buttonTransparent.UseVisualStyleBackColor = true;
            buttonTransparent.Click += buttonTransparent_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(btnDoneAddingFrames);
            panel2.Controls.Add(labelNCells);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ButtonRemoveImage);
            panel2.Controls.Add(ButtonMoveUp);
            panel2.Controls.Add(ButtonMoveDown);
            panel2.Controls.Add(ButtonAddImage);
            panel2.Controls.Add(listboxImages);
            panel2.Controls.Add(cellDisplayBox);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 84);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(534, 877);
            panel2.TabIndex = 7;
            // 
            // btnDoneAddingFrames
            // 
            btnDoneAddingFrames.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDoneAddingFrames.Location = new System.Drawing.Point(358, 40);
            btnDoneAddingFrames.Name = "btnDoneAddingFrames";
            btnDoneAddingFrames.Size = new System.Drawing.Size(97, 52);
            btnDoneAddingFrames.TabIndex = 10;
            btnDoneAddingFrames.Text = "DONE";
            btnDoneAddingFrames.UseVisualStyleBackColor = true;
            btnDoneAddingFrames.Visible = false;
            btnDoneAddingFrames.Click += btnDoneAddingFrames_Click;
            // 
            // labelNCells
            // 
            labelNCells.AutoSize = true;
            labelNCells.Location = new System.Drawing.Point(118, 15);
            labelNCells.Name = "labelNCells";
            labelNCells.Size = new System.Drawing.Size(43, 20);
            labelNCells.TabIndex = 9;
            labelNCells.Text = "n = 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(30, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "CELLS";
            // 
            // ButtonRemoveImage
            // 
            ButtonRemoveImage.Location = new System.Drawing.Point(167, 188);
            ButtonRemoveImage.Name = "ButtonRemoveImage";
            ButtonRemoveImage.Size = new System.Drawing.Size(156, 36);
            ButtonRemoveImage.TabIndex = 7;
            ButtonRemoveImage.Text = "Remove cell";
            ButtonRemoveImage.UseVisualStyleBackColor = true;
            ButtonRemoveImage.Click += ButtonRemoveImage_Click;
            // 
            // ButtonMoveUp
            // 
            ButtonMoveUp.Location = new System.Drawing.Point(167, 92);
            ButtonMoveUp.Name = "ButtonMoveUp";
            ButtonMoveUp.Size = new System.Drawing.Size(156, 36);
            ButtonMoveUp.TabIndex = 6;
            ButtonMoveUp.Text = "Move up";
            ButtonMoveUp.UseVisualStyleBackColor = true;
            ButtonMoveUp.Click += ButtonMoveUp_Click;
            // 
            // ButtonMoveDown
            // 
            ButtonMoveDown.Location = new System.Drawing.Point(167, 134);
            ButtonMoveDown.Name = "ButtonMoveDown";
            ButtonMoveDown.Size = new System.Drawing.Size(156, 36);
            ButtonMoveDown.TabIndex = 5;
            ButtonMoveDown.Text = "Move down";
            ButtonMoveDown.UseVisualStyleBackColor = true;
            ButtonMoveDown.Click += ButtonMoveDown_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel4.Controls.Add(btnPositionFrames);
            panel4.Controls.Add(frameDisplayBox);
            panel4.Controls.Add(labelNFrames);
            panel4.Controls.Add(InsertY);
            panel4.Controls.Add(InsertX);
            panel4.Controls.Add(checkBoxFlip);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBoxCell);
            panel4.Controls.Add(buttonRemoveFrame);
            panel4.Controls.Add(buttonAddFrame);
            panel4.Controls.Add(listboxFrames);
            panel4.Controls.Add(label1);
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(546, 418);
            panel4.TabIndex = 8;
            // 
            // btnPositionFrames
            // 
            btnPositionFrames.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPositionFrames.Location = new System.Drawing.Point(346, 325);
            btnPositionFrames.Name = "btnPositionFrames";
            btnPositionFrames.Size = new System.Drawing.Size(155, 42);
            btnPositionFrames.TabIndex = 12;
            btnPositionFrames.Text = "Position frames";
            btnPositionFrames.UseVisualStyleBackColor = true;
            btnPositionFrames.Click += btnPositionFrames_Click;
            // 
            // frameDisplayBox
            // 
            frameDisplayBox.BackColor = System.Drawing.Color.Gray;
            frameDisplayBox.Location = new System.Drawing.Point(329, 43);
            frameDisplayBox.Name = "frameDisplayBox";
            frameDisplayBox.Size = new System.Drawing.Size(188, 240);
            frameDisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            frameDisplayBox.TabIndex = 11;
            frameDisplayBox.TabStop = false;
            // 
            // labelNFrames
            // 
            labelNFrames.AutoSize = true;
            labelNFrames.Location = new System.Drawing.Point(97, 15);
            labelNFrames.Name = "labelNFrames";
            labelNFrames.Size = new System.Drawing.Size(43, 20);
            labelNFrames.TabIndex = 10;
            labelNFrames.Text = "n = 0";
            // 
            // InsertY
            // 
            InsertY.Enabled = false;
            InsertY.Location = new System.Drawing.Point(204, 294);
            InsertY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            InsertY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            InsertY.Name = "InsertY";
            InsertY.Size = new System.Drawing.Size(101, 27);
            InsertY.TabIndex = 10;
            InsertY.ValueChanged += InsertY_ValueChanged;
            // 
            // InsertX
            // 
            InsertX.Enabled = false;
            InsertX.Location = new System.Drawing.Point(204, 260);
            InsertX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            InsertX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            InsertX.Name = "InsertX";
            InsertX.Size = new System.Drawing.Size(101, 27);
            InsertX.TabIndex = 9;
            InsertX.ValueChanged += InsertX_ValueChanged;
            // 
            // checkBoxFlip
            // 
            checkBoxFlip.AutoSize = true;
            checkBoxFlip.Enabled = false;
            checkBoxFlip.Location = new System.Drawing.Point(129, 338);
            checkBoxFlip.Name = "checkBoxFlip";
            checkBoxFlip.Size = new System.Drawing.Size(55, 24);
            checkBoxFlip.TabIndex = 8;
            checkBoxFlip.Text = "Flip";
            checkBoxFlip.UseVisualStyleBackColor = true;
            checkBoxFlip.CheckedChanged += checkBoxFlip_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(129, 296);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 20);
            label5.TabIndex = 7;
            label5.Text = "Insert Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(129, 262);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 20);
            label4.TabIndex = 6;
            label4.Text = "Insert X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(129, 224);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 20);
            label3.TabIndex = 5;
            label3.Text = "Cell";
            // 
            // textBoxCell
            // 
            textBoxCell.Location = new System.Drawing.Point(204, 221);
            textBoxCell.Name = "textBoxCell";
            textBoxCell.ReadOnly = true;
            textBoxCell.Size = new System.Drawing.Size(101, 27);
            textBoxCell.TabIndex = 4;
            // 
            // buttonRemoveFrame
            // 
            buttonRemoveFrame.Location = new System.Drawing.Point(129, 95);
            buttonRemoveFrame.Name = "buttonRemoveFrame";
            buttonRemoveFrame.Size = new System.Drawing.Size(167, 36);
            buttonRemoveFrame.TabIndex = 3;
            buttonRemoveFrame.Text = "Remove frame";
            buttonRemoveFrame.UseVisualStyleBackColor = true;
            buttonRemoveFrame.Click += buttonRemoveFrame_Click;
            // 
            // buttonAddFrame
            // 
            buttonAddFrame.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonAddFrame.Location = new System.Drawing.Point(129, 43);
            buttonAddFrame.Name = "buttonAddFrame";
            buttonAddFrame.Size = new System.Drawing.Size(167, 36);
            buttonAddFrame.TabIndex = 2;
            buttonAddFrame.Text = "CHOOSE CELLS";
            buttonAddFrame.UseVisualStyleBackColor = true;
            buttonAddFrame.Click += buttonAddFrame_Click;
            // 
            // listboxFrames
            // 
            listboxFrames.FormattingEnabled = true;
            listboxFrames.ItemHeight = 20;
            listboxFrames.Location = new System.Drawing.Point(30, 43);
            listboxFrames.Name = "listboxFrames";
            listboxFrames.Size = new System.Drawing.Size(69, 344);
            listboxFrames.TabIndex = 1;
            listboxFrames.SelectedIndexChanged += listboxFrames_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(30, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "FRAMES";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(546, 877);
            panel3.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel5.Controls.Add(buttonEditSequence);
            panel5.Controls.Add(listboxSeqFrames);
            panel5.Controls.Add(labelNSeqs);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(labelNotes);
            panel5.Controls.Add(listboxSeqs);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(buttonRemoveSequence);
            panel5.Controls.Add(buttonAddSequence);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(0, 418);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(546, 459);
            panel5.TabIndex = 9;
            // 
            // buttonEditSequence
            // 
            buttonEditSequence.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonEditSequence.Location = new System.Drawing.Point(262, 168);
            buttonEditSequence.Name = "buttonEditSequence";
            buttonEditSequence.Size = new System.Drawing.Size(167, 40);
            buttonEditSequence.TabIndex = 18;
            buttonEditSequence.Text = "Edit Sequence";
            buttonEditSequence.UseVisualStyleBackColor = true;
            buttonEditSequence.Click += buttonEditSequence_Click;
            // 
            // listboxSeqFrames
            // 
            listboxSeqFrames.Enabled = false;
            listboxSeqFrames.FormattingEnabled = true;
            listboxSeqFrames.ItemHeight = 20;
            listboxSeqFrames.Location = new System.Drawing.Point(129, 168);
            listboxSeqFrames.Name = "listboxSeqFrames";
            listboxSeqFrames.Size = new System.Drawing.Size(106, 264);
            listboxSeqFrames.TabIndex = 17;
            listboxSeqFrames.SelectedIndexChanged += listboxSeqFrames_SelectedIndexChanged;
            // 
            // labelNSeqs
            // 
            labelNSeqs.AutoSize = true;
            labelNSeqs.Location = new System.Drawing.Point(129, 19);
            labelNSeqs.Name = "labelNSeqs";
            labelNSeqs.Size = new System.Drawing.Size(43, 20);
            labelNSeqs.TabIndex = 11;
            labelNSeqs.Text = "n = 0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(129, 144);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(118, 20);
            label6.TabIndex = 16;
            label6.Text = "Frames (max 32)";
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new System.Drawing.Point(279, 377);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new System.Drawing.Size(51, 20);
            labelNotes.TabIndex = 1;
            labelNotes.Text = "Notes:";
            labelNotes.Visible = false;
            // 
            // listboxSeqs
            // 
            listboxSeqs.FormattingEnabled = true;
            listboxSeqs.ItemHeight = 20;
            listboxSeqs.Location = new System.Drawing.Point(30, 52);
            listboxSeqs.Name = "listboxSeqs";
            listboxSeqs.Size = new System.Drawing.Size(69, 384);
            listboxSeqs.TabIndex = 12;
            listboxSeqs.SelectedIndexChanged += listboxSeqs_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(30, 19);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(92, 20);
            label7.TabIndex = 11;
            label7.Text = "SEQUENCES";
            // 
            // buttonRemoveSequence
            // 
            buttonRemoveSequence.Location = new System.Drawing.Point(129, 94);
            buttonRemoveSequence.Name = "buttonRemoveSequence";
            buttonRemoveSequence.Size = new System.Drawing.Size(167, 32);
            buttonRemoveSequence.TabIndex = 14;
            buttonRemoveSequence.Text = "Remove sequence";
            buttonRemoveSequence.UseVisualStyleBackColor = true;
            buttonRemoveSequence.Click += buttonRemoveSequence_Click;
            // 
            // buttonAddSequence
            // 
            buttonAddSequence.Location = new System.Drawing.Point(129, 52);
            buttonAddSequence.Name = "buttonAddSequence";
            buttonAddSequence.Size = new System.Drawing.Size(167, 32);
            buttonAddSequence.TabIndex = 13;
            buttonAddSequence.Text = "Add sequence";
            buttonAddSequence.UseVisualStyleBackColor = true;
            buttonAddSequence.Click += buttonAddSequence_Click;
            // 
            // panel6
            // 
            panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel6.Controls.Add(btnAnimate);
            panel6.Controls.Add(dataGridViews);
            panel6.Controls.Add(buttonSetAllViews);
            panel6.Controls.Add(FRate);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(Wheight);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(Wwidth);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(comboBoxAction);
            panel6.Controls.Add(comboBoxLogic);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label9);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(344, 693);
            panel6.TabIndex = 10;
            // 
            // btnAnimate
            // 
            btnAnimate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAnimate.Location = new System.Drawing.Point(89, 627);
            btnAnimate.Name = "btnAnimate";
            btnAnimate.Size = new System.Drawing.Size(155, 42);
            btnAnimate.TabIndex = 25;
            btnAnimate.Text = "Animation Preview";
            btnAnimate.UseVisualStyleBackColor = true;
            btnAnimate.Click += btnAnimate_Click;
            // 
            // dataGridViews
            // 
            dataGridViews.AllowUserToAddRows = false;
            dataGridViews.AllowUserToDeleteRows = false;
            dataGridViews.AllowUserToResizeColumns = false;
            dataGridViews.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ViewColumn, Sequence });
            dataGridViews.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            dataGridViews.Enabled = false;
            dataGridViews.Location = new System.Drawing.Point(34, 115);
            dataGridViews.MultiSelect = false;
            dataGridViews.Name = "dataGridViews";
            dataGridViews.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViews.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViews.RowHeadersVisible = false;
            dataGridViews.RowHeadersWidth = 51;
            dataGridViews.RowTemplate.Height = 25;
            dataGridViews.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dataGridViews.Size = new System.Drawing.Size(247, 310);
            dataGridViews.TabIndex = 24;
            dataGridViews.CellValidated += dataGridViews_CellValidated;
            dataGridViews.CellValidating += dataGridViews_CellValidating;
            dataGridViews.RowEnter += dataGridViews_RowEnter;
            // 
            // ViewColumn
            // 
            ViewColumn.HeaderText = "View";
            ViewColumn.MinimumWidth = 6;
            ViewColumn.Name = "ViewColumn";
            ViewColumn.ReadOnly = true;
            ViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            ViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ViewColumn.Width = 60;
            // 
            // Sequence
            // 
            Sequence.HeaderText = "Sequence";
            Sequence.MinimumWidth = 6;
            Sequence.Name = "Sequence";
            Sequence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Sequence.Width = 125;
            // 
            // buttonSetAllViews
            // 
            buttonSetAllViews.Enabled = false;
            buttonSetAllViews.Location = new System.Drawing.Point(89, 444);
            buttonSetAllViews.Name = "buttonSetAllViews";
            buttonSetAllViews.Size = new System.Drawing.Size(143, 36);
            buttonSetAllViews.TabIndex = 23;
            buttonSetAllViews.Text = "Set all views";
            buttonSetAllViews.UseVisualStyleBackColor = true;
            buttonSetAllViews.Click += buttonSetAllViews_Click;
            // 
            // FRate
            // 
            FRate.Enabled = false;
            FRate.Location = new System.Drawing.Point(160, 579);
            FRate.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            FRate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            FRate.Name = "FRate";
            FRate.Size = new System.Drawing.Size(121, 27);
            FRate.TabIndex = 21;
            FRate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            FRate.ValueChanged += FRate_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(34, 581);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(80, 20);
            label15.TabIndex = 22;
            label15.Text = "Frame rate";
            // 
            // Wheight
            // 
            Wheight.Enabled = false;
            Wheight.Location = new System.Drawing.Point(160, 539);
            Wheight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Wheight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Wheight.Name = "Wheight";
            Wheight.Size = new System.Drawing.Size(121, 27);
            Wheight.TabIndex = 12;
            Wheight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Wheight.ValueChanged += Wheight_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(34, 541);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(120, 20);
            label14.TabIndex = 20;
            label14.Text = "WorldHeight (%)";
            // 
            // Wwidth
            // 
            Wwidth.Enabled = false;
            Wwidth.Location = new System.Drawing.Point(160, 497);
            Wwidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Wwidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Wwidth.Name = "Wwidth";
            Wwidth.Size = new System.Drawing.Size(121, 27);
            Wwidth.TabIndex = 11;
            Wwidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Wwidth.ValueChanged += Wwidth_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(34, 499);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(115, 20);
            label13.TabIndex = 19;
            label13.Text = "WorldWidth (%)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(34, 76);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(52, 20);
            label10.TabIndex = 14;
            label10.Text = "Action";
            // 
            // comboBoxAction
            // 
            comboBoxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxAction.FormattingEnabled = true;
            comboBoxAction.Location = new System.Drawing.Point(106, 73);
            comboBoxAction.Name = "comboBoxAction";
            comboBoxAction.Size = new System.Drawing.Size(175, 28);
            comboBoxAction.TabIndex = 13;
            comboBoxAction.SelectedIndexChanged += comboBoxAction_SelectedIndexChanged;
            // 
            // comboBoxLogic
            // 
            comboBoxLogic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxLogic.FormattingEnabled = true;
            comboBoxLogic.Items.AddRange(new object[] { "Anim", "Scenery / Barrel", "Enemy", "Dark Trooper", "Remote", "Sewer creature", "Mohc", "Custom (32 anims)" });
            comboBoxLogic.Location = new System.Drawing.Point(106, 40);
            comboBoxLogic.Name = "comboBoxLogic";
            comboBoxLogic.Size = new System.Drawing.Size(175, 28);
            comboBoxLogic.TabIndex = 12;
            comboBoxLogic.SelectedIndexChanged += comboBoxLogic_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(34, 43);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(45, 20);
            label8.TabIndex = 0;
            label8.Text = "Logic";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(34, 15);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(74, 20);
            label9.TabIndex = 11;
            label9.Text = "ACTIONS";
            // 
            // panel7
            // 
            panel7.Controls.Add(checkBoxCompress);
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(labelPal);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(buttonCreateWAX);
            panel7.Dock = System.Windows.Forms.DockStyle.Right;
            panel7.Location = new System.Drawing.Point(546, 0);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(344, 877);
            panel7.TabIndex = 11;
            // 
            // checkBoxCompress
            // 
            checkBoxCompress.AutoSize = true;
            checkBoxCompress.Location = new System.Drawing.Point(112, 721);
            checkBoxCompress.Name = "checkBoxCompress";
            checkBoxCompress.Size = new System.Drawing.Size(129, 24);
            checkBoxCompress.TabIndex = 11;
            checkBoxCompress.Text = "Compress cells";
            checkBoxCompress.UseVisualStyleBackColor = true;
            // 
            // labelPal
            // 
            labelPal.AutoSize = true;
            labelPal.Location = new System.Drawing.Point(116, 839);
            labelPal.Name = "labelPal";
            labelPal.Size = new System.Drawing.Size(151, 20);
            labelPal.TabIndex = 3;
            labelPal.Text = "Secbase.PAL (default)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(54, 839);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(57, 20);
            label17.TabIndex = 2;
            label17.Text = "Palette:";
            // 
            // buttonCreateWAX
            // 
            buttonCreateWAX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonCreateWAX.Location = new System.Drawing.Point(102, 756);
            buttonCreateWAX.Name = "buttonCreateWAX";
            buttonCreateWAX.Size = new System.Drawing.Size(115, 56);
            buttonCreateWAX.TabIndex = 0;
            buttonCreateWAX.Text = "Create WAX!";
            buttonCreateWAX.UseVisualStyleBackColor = true;
            buttonCreateWAX.Click += buttonCreateWAX_Click;
            // 
            // saveWaxDialog
            // 
            saveWaxDialog.DefaultExt = "WAX";
            saveWaxDialog.Filter = "WAX file|*.wax";
            saveWaxDialog.FileOk += saveWaxDialog_FileOk;
            // 
            // saveWIPDialog
            // 
            saveWIPDialog.DefaultExt = "wproj";
            saveWIPDialog.Filter = "WAX project file|*.wproj";
            saveWIPDialog.Title = "Save WAX project";
            saveWIPDialog.FileOk += saveWIPDialog_FileOk;
            // 
            // openWIPDialog
            // 
            openWIPDialog.DefaultExt = "wproj";
            openWIPDialog.Filter = "WAX project file|*.wproj";
            openWIPDialog.Title = "Open WAX project";
            openWIPDialog.FileOk += openWIPDialog_FileOk;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel3);
            panel8.Controls.Add(panel7);
            panel8.Dock = System.Windows.Forms.DockStyle.Right;
            panel8.Location = new System.Drawing.Point(534, 84);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(890, 877);
            panel8.TabIndex = 0;
            // 
            // BuildWindow
            // 
            ClientSize = new System.Drawing.Size(1424, 961);
            Controls.Add(panel2);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(1280, 1000);
            Name = "BuildWindow";
            Text = "Build WAX";
            FormClosing += BuildWindow_FormClosing;
            FormClosed += BuildWindow_FormClosed;
            Load += BuildWindow_Load;
            ((System.ComponentModel.ISupportInitialize)cellDisplayBox).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)transpColourBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)frameDisplayBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InsertY).EndInit();
            ((System.ComponentModel.ISupportInitialize)InsertX).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViews).EndInit();
            ((System.ComponentModel.ISupportInitialize)FRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)Wheight).EndInit();
            ((System.ComponentModel.ISupportInitialize)Wwidth).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listboxImages;
        private System.Windows.Forms.Button ButtonAddImage;
        private System.Windows.Forms.Button ButtonPal;
        private System.Windows.Forms.OpenFileDialog openPalDialog;
        private System.Windows.Forms.OpenFileDialog loadImageDialog;
        private System.Windows.Forms.PictureBox cellDisplayBox;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonMoveUp;
        private System.Windows.Forms.Button ButtonMoveDown;
        private System.Windows.Forms.Button ButtonRemoveImage;
        private System.Windows.Forms.Button buttonTransparent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listboxFrames;
        private System.Windows.Forms.Button buttonAddFrame;
        private System.Windows.Forms.Button buttonRemoveFrame;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCell;
        private System.Windows.Forms.CheckBox checkBoxFlip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown InsertY;
        private System.Windows.Forms.NumericUpDown InsertX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listboxSeqs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRemoveSequence;
        private System.Windows.Forms.Button buttonAddSequence;
        private System.Windows.Forms.Label labelNCells;
        private System.Windows.Forms.Label labelNFrames;
        private System.Windows.Forms.Label labelNSeqs;
        private System.Windows.Forms.ListBox listboxSeqFrames;
        private System.Windows.Forms.Button buttonEditSequence;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxLogic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown Wheight;
        private System.Windows.Forms.NumericUpDown Wwidth;
        private System.Windows.Forms.NumericUpDown FRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonCreateWAX;
        private System.Windows.Forms.SaveFileDialog saveWaxDialog;
        private System.Windows.Forms.Button buttonSetAllViews;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelPal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox transpColourBox;
        private System.Windows.Forms.Button buttonSaveWIP;
        private System.Windows.Forms.Button buttonLoadWIP;
        private System.Windows.Forms.SaveFileDialog saveWIPDialog;
        private System.Windows.Forms.OpenFileDialog openWIPDialog;
        private System.Windows.Forms.DataGridView dataGridViews;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox checkBoxCompress;
        private System.Windows.Forms.Button btnDoneAddingFrames;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequence;
        private System.Windows.Forms.PictureBox frameDisplayBox;
        private System.Windows.Forms.Button btnPositionFrames;
        private System.Windows.Forms.Button btnAnimate;
    }
}
