namespace WAX_converter
{
    partial class WizardWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizardWindow));
            comboBoxAction = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            folderBrowser2 = new System.Windows.Forms.FolderBrowserDialog();
            btnSourceFolder = new System.Windows.Forms.Button();
            listBoxImages = new System.Windows.Forms.ListBox();
            pictureBoxPreview = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            viewingAngleDiagram = new System.Windows.Forms.PictureBox();
            btnFront = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            btnLeft = new System.Windows.Forms.Button();
            btnRight = new System.Windows.Forms.Button();
            btnBackRight = new System.Windows.Forms.Button();
            btnFrontRight = new System.Windows.Forms.Button();
            btnFrontLeft = new System.Windows.Forms.Button();
            btnBackLeft = new System.Windows.Forms.Button();
            btnApplyImages = new System.Windows.Forms.Button();
            output = new System.Windows.Forms.Label();
            checkBoxFlip = new System.Windows.Forms.CheckBox();
            checkBoxZoom = new System.Windows.Forms.CheckBox();
            listBoxSeq = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnDone = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            sprite7Img = new System.Windows.Forms.PictureBox();
            sprite6Img = new System.Windows.Forms.PictureBox();
            sprite5Img = new System.Windows.Forms.PictureBox();
            sprite4Img = new System.Windows.Forms.PictureBox();
            sprite3Img = new System.Windows.Forms.PictureBox();
            sprite2Img = new System.Windows.Forms.PictureBox();
            sprite1Img = new System.Windows.Forms.PictureBox();
            sprite0Img = new System.Windows.Forms.PictureBox();
            btnQuit = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            btnApplyAllFacings = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            folderBrowser = new System.Windows.Forms.OpenFileDialog();
            saveProjDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewingAngleDiagram).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sprite7Img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprite6Img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprite5Img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprite4Img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprite3Img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprite2Img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprite1Img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprite0Img).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxAction
            // 
            comboBoxAction.FormattingEnabled = true;
            comboBoxAction.Location = new System.Drawing.Point(21, 38);
            comboBoxAction.Name = "comboBoxAction";
            comboBoxAction.Size = new System.Drawing.Size(205, 23);
            comboBoxAction.TabIndex = 0;
            comboBoxAction.SelectedIndexChanged += comboBoxAction_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "WAX Action";
            // 
            // folderBrowser2
            // 
            folderBrowser2.Description = "Select folder containing images";
            folderBrowser2.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            folderBrowser2.ShowNewFolderButton = false;
            folderBrowser2.UseDescriptionForTitle = true;
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.Location = new System.Drawing.Point(260, 20);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new System.Drawing.Size(108, 41);
            btnSourceFolder.TabIndex = 3;
            btnSourceFolder.Text = "*Source images*";
            btnSourceFolder.UseVisualStyleBackColor = true;
            btnSourceFolder.Visible = false;
            btnSourceFolder.Click += btnSourceFolder_Click;
            // 
            // listBoxImages
            // 
            listBoxImages.FormattingEnabled = true;
            listBoxImages.ItemHeight = 15;
            listBoxImages.Location = new System.Drawing.Point(410, 80);
            listBoxImages.Name = "listBoxImages";
            listBoxImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            listBoxImages.Size = new System.Drawing.Size(189, 319);
            listBoxImages.TabIndex = 4;
            listBoxImages.SelectedIndexChanged += listBoxImages_SelectedIndexChanged;
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBoxPreview.BackColor = System.Drawing.Color.Gray;
            pictureBoxPreview.Location = new System.Drawing.Point(856, 56);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new System.Drawing.Size(405, 525);
            pictureBoxPreview.TabIndex = 5;
            pictureBoxPreview.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(21, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 17);
            label2.TabIndex = 6;
            label2.Text = "Viewing angle";
            // 
            // viewingAngleDiagram
            // 
            viewingAngleDiagram.BackColor = System.Drawing.SystemColors.Control;
            viewingAngleDiagram.Image = (System.Drawing.Image)resources.GetObject("viewingAngleDiagram.Image");
            viewingAngleDiagram.InitialImage = (System.Drawing.Image)resources.GetObject("viewingAngleDiagram.InitialImage");
            viewingAngleDiagram.Location = new System.Drawing.Point(145, 215);
            viewingAngleDiagram.Name = "viewingAngleDiagram";
            viewingAngleDiagram.Size = new System.Drawing.Size(100, 130);
            viewingAngleDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            viewingAngleDiagram.TabIndex = 7;
            viewingAngleDiagram.TabStop = false;
            // 
            // btnFront
            // 
            btnFront.BackColor = System.Drawing.Color.Gold;
            btnFront.Location = new System.Drawing.Point(155, 396);
            btnFront.Name = "btnFront";
            btnFront.Size = new System.Drawing.Size(84, 32);
            btnFront.TabIndex = 8;
            btnFront.Text = "front";
            btnFront.UseVisualStyleBackColor = false;
            btnFront.Click += btnFront_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
            btnBack.Location = new System.Drawing.Point(155, 134);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(84, 32);
            btnBack.TabIndex = 9;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            btnLeft.Location = new System.Drawing.Point(284, 259);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new System.Drawing.Size(84, 32);
            btnLeft.TabIndex = 10;
            btnLeft.Text = "left";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.BackColor = System.Drawing.SystemColors.ControlLight;
            btnRight.Location = new System.Drawing.Point(21, 259);
            btnRight.Name = "btnRight";
            btnRight.Size = new System.Drawing.Size(84, 32);
            btnRight.TabIndex = 11;
            btnRight.Text = "right";
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += btnRight_Click;
            // 
            // btnBackRight
            // 
            btnBackRight.BackColor = System.Drawing.SystemColors.ControlLight;
            btnBackRight.Location = new System.Drawing.Point(47, 182);
            btnBackRight.Name = "btnBackRight";
            btnBackRight.Size = new System.Drawing.Size(84, 42);
            btnBackRight.TabIndex = 12;
            btnBackRight.Text = "back - right";
            btnBackRight.UseVisualStyleBackColor = false;
            btnBackRight.Click += btnBackRight_Click;
            // 
            // btnFrontRight
            // 
            btnFrontRight.BackColor = System.Drawing.SystemColors.ControlLight;
            btnFrontRight.Location = new System.Drawing.Point(47, 333);
            btnFrontRight.Name = "btnFrontRight";
            btnFrontRight.Size = new System.Drawing.Size(84, 42);
            btnFrontRight.TabIndex = 13;
            btnFrontRight.Text = "front - right";
            btnFrontRight.UseVisualStyleBackColor = false;
            btnFrontRight.Click += btnFrontRight_Click;
            // 
            // btnFrontLeft
            // 
            btnFrontLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            btnFrontLeft.Location = new System.Drawing.Point(260, 333);
            btnFrontLeft.Name = "btnFrontLeft";
            btnFrontLeft.Size = new System.Drawing.Size(84, 42);
            btnFrontLeft.TabIndex = 15;
            btnFrontLeft.Text = "front - left";
            btnFrontLeft.UseVisualStyleBackColor = false;
            btnFrontLeft.Click += btnFrontLeft_Click;
            // 
            // btnBackLeft
            // 
            btnBackLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            btnBackLeft.Location = new System.Drawing.Point(260, 182);
            btnBackLeft.Name = "btnBackLeft";
            btnBackLeft.Size = new System.Drawing.Size(84, 42);
            btnBackLeft.TabIndex = 14;
            btnBackLeft.Text = "back - left";
            btnBackLeft.UseVisualStyleBackColor = false;
            btnBackLeft.Click += btnBackLeft_Click;
            // 
            // btnApplyImages
            // 
            btnApplyImages.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnApplyImages.Location = new System.Drawing.Point(260, 54);
            btnApplyImages.Name = "btnApplyImages";
            btnApplyImages.Size = new System.Drawing.Size(161, 44);
            btnApplyImages.TabIndex = 16;
            btnApplyImages.Text = "To Selected Angle";
            btnApplyImages.UseVisualStyleBackColor = true;
            btnApplyImages.Click += btnApplyImages_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new System.Drawing.Point(33, 453);
            output.Name = "output";
            output.Size = new System.Drawing.Size(38, 15);
            output.TabIndex = 17;
            output.Text = "label3";
            output.Visible = false;
            // 
            // checkBoxFlip
            // 
            checkBoxFlip.AutoSize = true;
            checkBoxFlip.Location = new System.Drawing.Point(410, 425);
            checkBoxFlip.Name = "checkBoxFlip";
            checkBoxFlip.Size = new System.Drawing.Size(81, 19);
            checkBoxFlip.TabIndex = 18;
            checkBoxFlip.Text = "Flip image";
            checkBoxFlip.UseVisualStyleBackColor = true;
            checkBoxFlip.CheckedChanged += checkBoxFlip_CheckedChanged;
            // 
            // checkBoxZoom
            // 
            checkBoxZoom.AutoSize = true;
            checkBoxZoom.Location = new System.Drawing.Point(856, 19);
            checkBoxZoom.Name = "checkBoxZoom";
            checkBoxZoom.Size = new System.Drawing.Size(58, 19);
            checkBoxZoom.TabIndex = 19;
            checkBoxZoom.Text = "Zoom";
            checkBoxZoom.UseVisualStyleBackColor = true;
            checkBoxZoom.CheckedChanged += checkBoxZoom_CheckedChanged;
            // 
            // listBoxSeq
            // 
            listBoxSeq.FormattingEnabled = true;
            listBoxSeq.ItemHeight = 15;
            listBoxSeq.Location = new System.Drawing.Point(629, 80);
            listBoxSeq.Name = "listBoxSeq";
            listBoxSeq.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            listBoxSeq.Size = new System.Drawing.Size(189, 319);
            listBoxSeq.TabIndex = 20;
            listBoxSeq.SelectedIndexChanged += listBoxSeq_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(629, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 15);
            label3.TabIndex = 21;
            label3.Text = "Images in sequence";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(410, 57);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 15);
            label4.TabIndex = 22;
            label4.Text = "Source images";
            // 
            // btnDone
            // 
            btnDone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDone.Location = new System.Drawing.Point(518, 23);
            btnDone.Name = "btnDone";
            btnDone.Size = new System.Drawing.Size(111, 36);
            btnDone.TabIndex = 23;
            btnDone.Text = "DONE";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(sprite7Img);
            panel1.Controls.Add(sprite6Img);
            panel1.Controls.Add(sprite5Img);
            panel1.Controls.Add(sprite4Img);
            panel1.Controls.Add(sprite3Img);
            panel1.Controls.Add(sprite2Img);
            panel1.Controls.Add(sprite1Img);
            panel1.Controls.Add(sprite0Img);
            panel1.Controls.Add(btnQuit);
            panel1.Controls.Add(btnDone);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 610);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1284, 71);
            panel1.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(73, 23);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(336, 15);
            label6.TabIndex = 20;
            label6.Text = "Note: This tool is usable, but further optimisation is planned";
            // 
            // sprite7Img
            // 
            sprite7Img.Image = (System.Drawing.Image)resources.GetObject("sprite7Img.Image");
            sprite7Img.Location = new System.Drawing.Point(1117, 9);
            sprite7Img.Name = "sprite7Img";
            sprite7Img.Size = new System.Drawing.Size(22, 50);
            sprite7Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            sprite7Img.TabIndex = 32;
            sprite7Img.TabStop = false;
            sprite7Img.Visible = false;
            // 
            // sprite6Img
            // 
            sprite6Img.Image = (System.Drawing.Image)resources.GetObject("sprite6Img.Image");
            sprite6Img.Location = new System.Drawing.Point(1089, 9);
            sprite6Img.Name = "sprite6Img";
            sprite6Img.Size = new System.Drawing.Size(22, 50);
            sprite6Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            sprite6Img.TabIndex = 31;
            sprite6Img.TabStop = false;
            sprite6Img.Visible = false;
            // 
            // sprite5Img
            // 
            sprite5Img.Image = (System.Drawing.Image)resources.GetObject("sprite5Img.Image");
            sprite5Img.Location = new System.Drawing.Point(1061, 8);
            sprite5Img.Name = "sprite5Img";
            sprite5Img.Size = new System.Drawing.Size(22, 50);
            sprite5Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            sprite5Img.TabIndex = 30;
            sprite5Img.TabStop = false;
            sprite5Img.Visible = false;
            // 
            // sprite4Img
            // 
            sprite4Img.Image = (System.Drawing.Image)resources.GetObject("sprite4Img.Image");
            sprite4Img.Location = new System.Drawing.Point(1033, 9);
            sprite4Img.Name = "sprite4Img";
            sprite4Img.Size = new System.Drawing.Size(22, 50);
            sprite4Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            sprite4Img.TabIndex = 29;
            sprite4Img.TabStop = false;
            sprite4Img.Visible = false;
            // 
            // sprite3Img
            // 
            sprite3Img.Image = (System.Drawing.Image)resources.GetObject("sprite3Img.Image");
            sprite3Img.Location = new System.Drawing.Point(1005, 8);
            sprite3Img.Name = "sprite3Img";
            sprite3Img.Size = new System.Drawing.Size(22, 50);
            sprite3Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            sprite3Img.TabIndex = 28;
            sprite3Img.TabStop = false;
            sprite3Img.Visible = false;
            // 
            // sprite2Img
            // 
            sprite2Img.Image = (System.Drawing.Image)resources.GetObject("sprite2Img.Image");
            sprite2Img.Location = new System.Drawing.Point(977, 9);
            sprite2Img.Name = "sprite2Img";
            sprite2Img.Size = new System.Drawing.Size(22, 50);
            sprite2Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            sprite2Img.TabIndex = 27;
            sprite2Img.TabStop = false;
            sprite2Img.Visible = false;
            // 
            // sprite1Img
            // 
            sprite1Img.Image = (System.Drawing.Image)resources.GetObject("sprite1Img.Image");
            sprite1Img.Location = new System.Drawing.Point(947, 9);
            sprite1Img.Name = "sprite1Img";
            sprite1Img.Size = new System.Drawing.Size(22, 50);
            sprite1Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            sprite1Img.TabIndex = 26;
            sprite1Img.TabStop = false;
            sprite1Img.Visible = false;
            // 
            // sprite0Img
            // 
            sprite0Img.Image = (System.Drawing.Image)resources.GetObject("sprite0Img.Image");
            sprite0Img.InitialImage = (System.Drawing.Image)resources.GetObject("sprite0Img.InitialImage");
            sprite0Img.Location = new System.Drawing.Point(919, 9);
            sprite0Img.Name = "sprite0Img";
            sprite0Img.Size = new System.Drawing.Size(22, 50);
            sprite0Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            sprite0Img.TabIndex = 25;
            sprite0Img.TabStop = false;
            sprite0Img.Visible = false;
            // 
            // btnQuit
            // 
            btnQuit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQuit.Location = new System.Drawing.Point(653, 23);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new System.Drawing.Size(111, 36);
            btnQuit.TabIndex = 24;
            btnQuit.Text = "QUIT";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBoxAction);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnSourceFolder);
            panel2.Controls.Add(listBoxSeq);
            panel2.Controls.Add(listBoxImages);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkBoxFlip);
            panel2.Controls.Add(viewingAngleDiagram);
            panel2.Controls.Add(output);
            panel2.Controls.Add(btnFront);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(btnFrontLeft);
            panel2.Controls.Add(btnLeft);
            panel2.Controls.Add(btnBackLeft);
            panel2.Controls.Add(btnRight);
            panel2.Controls.Add(btnFrontRight);
            panel2.Controls.Add(btnBackRight);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(837, 610);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnApplyAllFacings);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnApplyImages);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(0, 483);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(837, 127);
            panel3.TabIndex = 23;
            // 
            // btnApplyAllFacings
            // 
            btnApplyAllFacings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnApplyAllFacings.Location = new System.Drawing.Point(444, 54);
            btnApplyAllFacings.Name = "btnApplyAllFacings";
            btnApplyAllFacings.Size = new System.Drawing.Size(161, 44);
            btnApplyAllFacings.TabIndex = 19;
            btnApplyAllFacings.Text = "To All 8 Angles";
            btnApplyAllFacings.UseVisualStyleBackColor = true;
            btnApplyAllFacings.Click += btnApplyAllFacings_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(260, 15);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(151, 17);
            label5.TabIndex = 18;
            label5.Text = "Apply Selected Images:";
            // 
            // folderBrowser
            // 
            folderBrowser.AddExtension = false;
            folderBrowser.Filter = "All files|*.*|PNG images|*.PNG|BMP images|*.BMP|GIF images|*.GIF|JPEG images|*.JPG";
            folderBrowser.Title = "Select folder containing images";
            // 
            // saveProjDialog
            // 
            saveProjDialog.DefaultExt = "wproj";
            saveProjDialog.Filter = "WAX project files|*.wproj";
            saveProjDialog.Title = "Save WAX Project";
            // 
            // WizardWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1284, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(checkBoxZoom);
            Controls.Add(pictureBoxPreview);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(1300, 720);
            Name = "WizardWindow";
            Text = "Enemy WAX Wizard";
            FormClosing += WizardWindow_FormClosing;
            FormClosed += WizardWindow_FormClosed;
            Load += WizardWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewingAngleDiagram).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sprite7Img).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprite6Img).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprite5Img).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprite4Img).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprite3Img).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprite2Img).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprite1Img).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprite0Img).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSourceFolder;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        public System.Windows.Forms.FolderBrowserDialog folderBrowser2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox viewingAngleDiagram;
        private System.Windows.Forms.Button btnFront;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnBackRight;
        private System.Windows.Forms.Button btnFrontRight;
        private System.Windows.Forms.Button btnFrontLeft;
        private System.Windows.Forms.Button btnBackLeft;
        private System.Windows.Forms.Button btnApplyImages;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.CheckBox checkBoxFlip;
        private System.Windows.Forms.CheckBox checkBoxZoom;
        private System.Windows.Forms.ListBox listBoxSeq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnApplyAllFacings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog folderBrowser;
        private System.Windows.Forms.SaveFileDialog saveProjDialog;
        private System.Windows.Forms.PictureBox sprite7Img;
        private System.Windows.Forms.PictureBox sprite6Img;
        private System.Windows.Forms.PictureBox sprite5Img;
        private System.Windows.Forms.PictureBox sprite4Img;
        private System.Windows.Forms.PictureBox sprite3Img;
        private System.Windows.Forms.PictureBox sprite2Img;
        private System.Windows.Forms.PictureBox sprite1Img;
        private System.Windows.Forms.PictureBox sprite0Img;
        private System.Windows.Forms.Label label6;
    }
}