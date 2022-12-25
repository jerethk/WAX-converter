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
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSourceFolder = new System.Windows.Forms.Button();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFront = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnBackRight = new System.Windows.Forms.Button();
            this.btnFrontRight = new System.Windows.Forms.Button();
            this.btnFrontLeft = new System.Windows.Forms.Button();
            this.btnBackLeft = new System.Windows.Forms.Button();
            this.btnApplyImages = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.checkBoxFlip = new System.Windows.Forms.CheckBox();
            this.checkBoxZoom = new System.Windows.Forms.CheckBox();
            this.listBoxSeq = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnApplyAllFacings = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Location = new System.Drawing.Point(21, 38);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(205, 23);
            this.comboBoxAction.TabIndex = 0;
            this.comboBoxAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxAction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "WAX Action";
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Select folder containing images";
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            this.folderBrowser.ShowNewFolderButton = false;
            this.folderBrowser.UseDescriptionForTitle = true;
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.Location = new System.Drawing.Point(260, 20);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(124, 41);
            this.btnSourceFolder.TabIndex = 3;
            this.btnSourceFolder.Text = "Source images";
            this.btnSourceFolder.UseVisualStyleBackColor = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // listBoxImages
            // 
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 15;
            this.listBoxImages.Location = new System.Drawing.Point(410, 80);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxImages.Size = new System.Drawing.Size(189, 319);
            this.listBoxImages.TabIndex = 4;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPreview.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPreview.Location = new System.Drawing.Point(856, 56);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(405, 525);
            this.pictureBoxPreview.TabIndex = 5;
            this.pictureBoxPreview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Viewing angle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(164, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnFront
            // 
            this.btnFront.BackColor = System.Drawing.Color.Gold;
            this.btnFront.Location = new System.Drawing.Point(155, 396);
            this.btnFront.Name = "btnFront";
            this.btnFront.Size = new System.Drawing.Size(84, 32);
            this.btnFront.TabIndex = 8;
            this.btnFront.Text = "front";
            this.btnFront.UseVisualStyleBackColor = false;
            this.btnFront.Click += new System.EventHandler(this.btnFront_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Location = new System.Drawing.Point(155, 134);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 32);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLeft.Location = new System.Drawing.Point(284, 259);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(84, 32);
            this.btnLeft.TabIndex = 10;
            this.btnLeft.Text = "left";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRight.Location = new System.Drawing.Point(21, 259);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(84, 32);
            this.btnRight.TabIndex = 11;
            this.btnRight.Text = "right";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnBackRight
            // 
            this.btnBackRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackRight.Location = new System.Drawing.Point(47, 182);
            this.btnBackRight.Name = "btnBackRight";
            this.btnBackRight.Size = new System.Drawing.Size(84, 42);
            this.btnBackRight.TabIndex = 12;
            this.btnBackRight.Text = "back - right";
            this.btnBackRight.UseVisualStyleBackColor = false;
            this.btnBackRight.Click += new System.EventHandler(this.btnBackRight_Click);
            // 
            // btnFrontRight
            // 
            this.btnFrontRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFrontRight.Location = new System.Drawing.Point(47, 333);
            this.btnFrontRight.Name = "btnFrontRight";
            this.btnFrontRight.Size = new System.Drawing.Size(84, 42);
            this.btnFrontRight.TabIndex = 13;
            this.btnFrontRight.Text = "front - right";
            this.btnFrontRight.UseVisualStyleBackColor = false;
            this.btnFrontRight.Click += new System.EventHandler(this.btnFrontRight_Click);
            // 
            // btnFrontLeft
            // 
            this.btnFrontLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFrontLeft.Location = new System.Drawing.Point(260, 333);
            this.btnFrontLeft.Name = "btnFrontLeft";
            this.btnFrontLeft.Size = new System.Drawing.Size(84, 42);
            this.btnFrontLeft.TabIndex = 15;
            this.btnFrontLeft.Text = "front - left";
            this.btnFrontLeft.UseVisualStyleBackColor = false;
            this.btnFrontLeft.Click += new System.EventHandler(this.btnFrontLeft_Click);
            // 
            // btnBackLeft
            // 
            this.btnBackLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackLeft.Location = new System.Drawing.Point(260, 182);
            this.btnBackLeft.Name = "btnBackLeft";
            this.btnBackLeft.Size = new System.Drawing.Size(84, 42);
            this.btnBackLeft.TabIndex = 14;
            this.btnBackLeft.Text = "back - left";
            this.btnBackLeft.UseVisualStyleBackColor = false;
            this.btnBackLeft.Click += new System.EventHandler(this.btnBackLeft_Click);
            // 
            // btnApplyImages
            // 
            this.btnApplyImages.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApplyImages.Location = new System.Drawing.Point(260, 54);
            this.btnApplyImages.Name = "btnApplyImages";
            this.btnApplyImages.Size = new System.Drawing.Size(161, 44);
            this.btnApplyImages.TabIndex = 16;
            this.btnApplyImages.Text = "To Selected Angle";
            this.btnApplyImages.UseVisualStyleBackColor = true;
            this.btnApplyImages.Click += new System.EventHandler(this.btnApplyImages_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(33, 453);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(38, 15);
            this.output.TabIndex = 17;
            this.output.Text = "label3";
            // 
            // checkBoxFlip
            // 
            this.checkBoxFlip.AutoSize = true;
            this.checkBoxFlip.Location = new System.Drawing.Point(410, 425);
            this.checkBoxFlip.Name = "checkBoxFlip";
            this.checkBoxFlip.Size = new System.Drawing.Size(81, 19);
            this.checkBoxFlip.TabIndex = 18;
            this.checkBoxFlip.Text = "Flip image";
            this.checkBoxFlip.UseVisualStyleBackColor = true;
            this.checkBoxFlip.CheckedChanged += new System.EventHandler(this.checkBoxFlip_CheckedChanged);
            // 
            // checkBoxZoom
            // 
            this.checkBoxZoom.AutoSize = true;
            this.checkBoxZoom.Location = new System.Drawing.Point(856, 19);
            this.checkBoxZoom.Name = "checkBoxZoom";
            this.checkBoxZoom.Size = new System.Drawing.Size(58, 19);
            this.checkBoxZoom.TabIndex = 19;
            this.checkBoxZoom.Text = "Zoom";
            this.checkBoxZoom.UseVisualStyleBackColor = true;
            this.checkBoxZoom.CheckedChanged += new System.EventHandler(this.checkBoxZoom_CheckedChanged);
            // 
            // listBoxSeq
            // 
            this.listBoxSeq.FormattingEnabled = true;
            this.listBoxSeq.ItemHeight = 15;
            this.listBoxSeq.Location = new System.Drawing.Point(629, 80);
            this.listBoxSeq.Name = "listBoxSeq";
            this.listBoxSeq.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSeq.Size = new System.Drawing.Size(189, 319);
            this.listBoxSeq.TabIndex = 20;
            this.listBoxSeq.SelectedIndexChanged += new System.EventHandler(this.listBoxSeq_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Images in sequence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Source images";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDone.Location = new System.Drawing.Point(518, 23);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(111, 36);
            this.btnDone.TabIndex = 23;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 610);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 71);
            this.panel1.TabIndex = 24;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.Location = new System.Drawing.Point(653, 23);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(111, 36);
            this.btnQuit.TabIndex = 24;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxAction);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSourceFolder);
            this.panel2.Controls.Add(this.listBoxSeq);
            this.panel2.Controls.Add(this.listBoxImages);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkBoxFlip);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.output);
            this.panel2.Controls.Add(this.btnFront);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnFrontLeft);
            this.panel2.Controls.Add(this.btnLeft);
            this.panel2.Controls.Add(this.btnBackLeft);
            this.panel2.Controls.Add(this.btnRight);
            this.panel2.Controls.Add(this.btnFrontRight);
            this.panel2.Controls.Add(this.btnBackRight);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 610);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnApplyAllFacings);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnApplyImages);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(837, 127);
            this.panel3.TabIndex = 23;
            // 
            // btnApplyAllFacings
            // 
            this.btnApplyAllFacings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApplyAllFacings.Location = new System.Drawing.Point(444, 54);
            this.btnApplyAllFacings.Name = "btnApplyAllFacings";
            this.btnApplyAllFacings.Size = new System.Drawing.Size(161, 44);
            this.btnApplyAllFacings.TabIndex = 19;
            this.btnApplyAllFacings.Text = "To All 8 Angles";
            this.btnApplyAllFacings.UseVisualStyleBackColor = true;
            this.btnApplyAllFacings.Click += new System.EventHandler(this.btnApplyAllFacings_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(260, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Apply Selected Images:";
            // 
            // WizardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxZoom);
            this.Controls.Add(this.pictureBoxPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 720);
            this.Name = "WizardWindow";
            this.Text = "Wizard";
            this.Load += new System.EventHandler(this.WizardWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSourceFolder;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        public System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}