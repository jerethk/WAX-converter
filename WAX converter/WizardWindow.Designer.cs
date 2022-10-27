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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Location = new System.Drawing.Point(22, 37);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(205, 23);
            this.comboBoxAction.TabIndex = 0;
            this.comboBoxAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxAction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
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
            this.btnSourceFolder.Location = new System.Drawing.Point(344, 19);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(146, 41);
            this.btnSourceFolder.TabIndex = 3;
            this.btnSourceFolder.Text = "Image source folder";
            this.btnSourceFolder.UseVisualStyleBackColor = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // listBoxImages
            // 
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 15;
            this.listBoxImages.Location = new System.Drawing.Point(344, 79);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(189, 379);
            this.listBoxImages.TabIndex = 4;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPreview.Location = new System.Drawing.Point(559, 19);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(405, 449);
            this.pictureBoxPreview.TabIndex = 5;
            this.pictureBoxPreview.TabStop = false;
            // 
            // WizardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 557);
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
    }
}