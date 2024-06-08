namespace WAX_converter
{
    partial class WxxBuilderWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WxxBuilderWindow));
            openWaxDialog = new System.Windows.Forms.OpenFileDialog();
            sourceImagesDialog = new System.Windows.Forms.OpenFileDialog();
            btnSourceImages = new System.Windows.Forms.Button();
            btnQuit = new System.Windows.Forms.Button();
            listBoxWaxImages = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            pictureBoxWaxImage = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            listBoxSourceImages = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            pictureBoxSourceImages = new System.Windows.Forms.PictureBox();
            pictureBoxHighRes = new System.Windows.Forms.PictureBox();
            btnApplyImage = new System.Windows.Forms.Button();
            labelWaxImageSize = new System.Windows.Forms.Label();
            labelSourceImageSize = new System.Windows.Forms.Label();
            btnAutoSet = new System.Windows.Forms.Button();
            btnCreateWxx = new System.Windows.Forms.Button();
            saveWxxDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWaxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSourceImages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHighRes).BeginInit();
            SuspendLayout();
            // 
            // openWaxDialog
            // 
            openWaxDialog.Filter = "WAX filfes|*.WAX";
            openWaxDialog.Title = "Open WAX file";
            openWaxDialog.FileOk += openWaxDialog_FileOk;
            // 
            // sourceImagesDialog
            // 
            sourceImagesDialog.Filter = "PNG images|*.PNG";
            sourceImagesDialog.Title = "Select directory containing high-res images";
            sourceImagesDialog.FileOk += sourceImagesDialog_FileOk;
            // 
            // btnSourceImages
            // 
            btnSourceImages.Location = new System.Drawing.Point(235, 423);
            btnSourceImages.Name = "btnSourceImages";
            btnSourceImages.Size = new System.Drawing.Size(141, 40);
            btnSourceImages.TabIndex = 0;
            btnSourceImages.Text = "Get Source Images";
            btnSourceImages.UseVisualStyleBackColor = true;
            btnSourceImages.Click += btnSourceImages_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new System.Drawing.Point(939, 722);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new System.Drawing.Size(126, 40);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Exit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // listBoxWaxImages
            // 
            listBoxWaxImages.FormattingEnabled = true;
            listBoxWaxImages.ItemHeight = 15;
            listBoxWaxImages.Location = new System.Drawing.Point(30, 39);
            listBoxWaxImages.Name = "listBoxWaxImages";
            listBoxWaxImages.Size = new System.Drawing.Size(64, 349);
            listBoxWaxImages.TabIndex = 2;
            listBoxWaxImages.SelectedIndexChanged += listBoxWaxImages_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 15);
            label1.TabIndex = 3;
            label1.Text = "WAX images";
            // 
            // pictureBoxWaxImage
            // 
            pictureBoxWaxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxWaxImage.Location = new System.Drawing.Point(146, 39);
            pictureBoxWaxImage.Name = "pictureBoxWaxImage";
            pictureBoxWaxImage.Size = new System.Drawing.Size(412, 349);
            pictureBoxWaxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxWaxImage.TabIndex = 4;
            pictureBoxWaxImage.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(778, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 15);
            label2.TabIndex = 5;
            label2.Text = "High res version";
            // 
            // listBoxSourceImages
            // 
            listBoxSourceImages.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBoxSourceImages.FormattingEnabled = true;
            listBoxSourceImages.Location = new System.Drawing.Point(30, 508);
            listBoxSourceImages.Name = "listBoxSourceImages";
            listBoxSourceImages.Size = new System.Drawing.Size(92, 433);
            listBoxSourceImages.TabIndex = 6;
            listBoxSourceImages.SelectedIndexChanged += listBoxSourceImages_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(30, 481);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 15);
            label3.TabIndex = 7;
            label3.Text = "Source images";
            // 
            // pictureBoxSourceImages
            // 
            pictureBoxSourceImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxSourceImages.Location = new System.Drawing.Point(146, 508);
            pictureBoxSourceImages.Name = "pictureBoxSourceImages";
            pictureBoxSourceImages.Size = new System.Drawing.Size(412, 349);
            pictureBoxSourceImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxSourceImages.TabIndex = 8;
            pictureBoxSourceImages.TabStop = false;
            // 
            // pictureBoxHighRes
            // 
            pictureBoxHighRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxHighRes.Cursor = System.Windows.Forms.Cursors.No;
            pictureBoxHighRes.Location = new System.Drawing.Point(778, 39);
            pictureBoxHighRes.Name = "pictureBoxHighRes";
            pictureBoxHighRes.Size = new System.Drawing.Size(412, 349);
            pictureBoxHighRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxHighRes.TabIndex = 9;
            pictureBoxHighRes.TabStop = false;
            // 
            // btnApplyImage
            // 
            btnApplyImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnApplyImage.Location = new System.Drawing.Point(584, 508);
            btnApplyImage.Name = "btnApplyImage";
            btnApplyImage.Size = new System.Drawing.Size(164, 75);
            btnApplyImage.TabIndex = 10;
            btnApplyImage.Text = "Set Image";
            btnApplyImage.UseVisualStyleBackColor = true;
            btnApplyImage.Click += btnApplyImage_Click;
            // 
            // labelWaxImageSize
            // 
            labelWaxImageSize.AutoSize = true;
            labelWaxImageSize.Location = new System.Drawing.Point(146, 12);
            labelWaxImageSize.Name = "labelWaxImageSize";
            labelWaxImageSize.Size = new System.Drawing.Size(38, 15);
            labelWaxImageSize.TabIndex = 11;
            labelWaxImageSize.Text = "Size =";
            // 
            // labelSourceImageSize
            // 
            labelSourceImageSize.AutoSize = true;
            labelSourceImageSize.Location = new System.Drawing.Point(146, 481);
            labelSourceImageSize.Name = "labelSourceImageSize";
            labelSourceImageSize.Size = new System.Drawing.Size(38, 15);
            labelSourceImageSize.TabIndex = 12;
            labelSourceImageSize.Text = "Size =";
            // 
            // btnAutoSet
            // 
            btnAutoSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAutoSet.Location = new System.Drawing.Point(584, 603);
            btnAutoSet.Name = "btnAutoSet";
            btnAutoSet.Size = new System.Drawing.Size(164, 75);
            btnAutoSet.TabIndex = 13;
            btnAutoSet.Text = "AUTO Set";
            btnAutoSet.UseVisualStyleBackColor = true;
            btnAutoSet.Click += btnAutoSet_Click;
            // 
            // btnCreateWxx
            // 
            btnCreateWxx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCreateWxx.Location = new System.Drawing.Point(939, 603);
            btnCreateWxx.Name = "btnCreateWxx";
            btnCreateWxx.Size = new System.Drawing.Size(126, 96);
            btnCreateWxx.TabIndex = 14;
            btnCreateWxx.Text = "Create WXX / FXX";
            btnCreateWxx.UseVisualStyleBackColor = true;
            btnCreateWxx.Click += btnCreateWxx_Click;
            // 
            // saveWxxDialog
            // 
            saveWxxDialog.DefaultExt = "WXX";
            saveWxxDialog.Filter = "WXX high res WAX|*.WXX|FXX high res FME|*.FXX";
            saveWxxDialog.Title = "Save WXX";
            // 
            // WxxBuilderWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1224, 984);
            ControlBox = false;
            Controls.Add(btnCreateWxx);
            Controls.Add(btnAutoSet);
            Controls.Add(labelSourceImageSize);
            Controls.Add(labelWaxImageSize);
            Controls.Add(btnApplyImage);
            Controls.Add(pictureBoxHighRes);
            Controls.Add(pictureBoxSourceImages);
            Controls.Add(label3);
            Controls.Add(listBoxSourceImages);
            Controls.Add(label2);
            Controls.Add(pictureBoxWaxImage);
            Controls.Add(label1);
            Controls.Add(listBoxWaxImages);
            Controls.Add(btnQuit);
            Controls.Add(btnSourceImages);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(1240, 1000);
            Name = "WxxBuilderWindow";
            Text = "Create WXX";
            Shown += WxxBuilderWindow_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxWaxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSourceImages).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHighRes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openWaxDialog;
        private System.Windows.Forms.OpenFileDialog sourceImagesDialog;
        private System.Windows.Forms.Button btnSourceImages;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListBox listBoxWaxImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxWaxImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSourceImages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxSourceImages;
        private System.Windows.Forms.PictureBox pictureBoxHighRes;
        private System.Windows.Forms.Button btnApplyImage;
        private System.Windows.Forms.Label labelWaxImageSize;
        private System.Windows.Forms.Label labelSourceImageSize;
        private System.Windows.Forms.Button btnAutoSet;
        private System.Windows.Forms.Button btnCreateWxx;
        private System.Windows.Forms.SaveFileDialog saveWxxDialog;
    }
}