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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Location = new System.Drawing.Point(21, 37);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(205, 23);
            this.comboBoxAction.TabIndex = 0;
            this.comboBoxAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxAction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
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
            this.btnSourceFolder.Location = new System.Drawing.Point(410, 19);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(146, 41);
            this.btnSourceFolder.TabIndex = 3;
            this.btnSourceFolder.Text = "Source images";
            this.btnSourceFolder.UseVisualStyleBackColor = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // listBoxImages
            // 
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 15;
            this.listBoxImages.Location = new System.Drawing.Point(410, 79);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxImages.Size = new System.Drawing.Size(189, 319);
            this.listBoxImages.TabIndex = 4;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPreview.Location = new System.Drawing.Point(843, 56);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(405, 457);
            this.pictureBoxPreview.TabIndex = 5;
            this.pictureBoxPreview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 102);
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
            this.pictureBox1.Location = new System.Drawing.Point(164, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnFront
            // 
            this.btnFront.BackColor = System.Drawing.Color.Gold;
            this.btnFront.Location = new System.Drawing.Point(155, 395);
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
            this.btnBack.Location = new System.Drawing.Point(155, 133);
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
            this.btnLeft.Location = new System.Drawing.Point(284, 258);
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
            this.btnRight.Location = new System.Drawing.Point(21, 258);
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
            this.btnBackRight.Location = new System.Drawing.Point(47, 181);
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
            this.btnFrontRight.Location = new System.Drawing.Point(47, 332);
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
            this.btnFrontLeft.Location = new System.Drawing.Point(260, 332);
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
            this.btnBackLeft.Location = new System.Drawing.Point(260, 181);
            this.btnBackLeft.Name = "btnBackLeft";
            this.btnBackLeft.Size = new System.Drawing.Size(84, 42);
            this.btnBackLeft.TabIndex = 14;
            this.btnBackLeft.Text = "back - left";
            this.btnBackLeft.UseVisualStyleBackColor = false;
            this.btnBackLeft.Click += new System.EventHandler(this.btnBackLeft_Click);
            // 
            // btnApplyImages
            // 
            this.btnApplyImages.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApplyImages.Location = new System.Drawing.Point(410, 469);
            this.btnApplyImages.Name = "btnApplyImages";
            this.btnApplyImages.Size = new System.Drawing.Size(189, 44);
            this.btnApplyImages.TabIndex = 16;
            this.btnApplyImages.Text = ">> Apply >>";
            this.btnApplyImages.UseVisualStyleBackColor = true;
            this.btnApplyImages.Click += new System.EventHandler(this.btnApplyImages_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(79, 485);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(38, 15);
            this.output.TabIndex = 17;
            this.output.Text = "label3";
            // 
            // checkBoxFlip
            // 
            this.checkBoxFlip.AutoSize = true;
            this.checkBoxFlip.Location = new System.Drawing.Point(410, 424);
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
            this.checkBoxZoom.Location = new System.Drawing.Point(843, 19);
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
            this.listBoxSeq.Location = new System.Drawing.Point(629, 79);
            this.listBoxSeq.Name = "listBoxSeq";
            this.listBoxSeq.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSeq.Size = new System.Drawing.Size(189, 319);
            this.listBoxSeq.TabIndex = 20;
            this.listBoxSeq.SelectedIndexChanged += new System.EventHandler(this.listBoxSeq_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Images in sequence";
            // 
            // WizardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 557);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxSeq);
            this.Controls.Add(this.checkBoxZoom);
            this.Controls.Add(this.checkBoxFlip);
            this.Controls.Add(this.output);
            this.Controls.Add(this.btnApplyImages);
            this.Controls.Add(this.btnFrontLeft);
            this.Controls.Add(this.btnBackLeft);
            this.Controls.Add(this.btnFrontRight);
            this.Controls.Add(this.btnBackRight);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFront);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.listBoxImages);
            this.Controls.Add(this.btnSourceFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WizardWindow";
            this.Text = "Wizard";
            this.Load += new System.EventHandler(this.WizardWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}