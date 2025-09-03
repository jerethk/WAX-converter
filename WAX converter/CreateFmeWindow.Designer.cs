namespace WAX_converter
{
    partial class CreateFmeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFmeWindow));
            btnExit = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            transpColourBox = new System.Windows.Forms.PictureBox();
            buttonTransparent = new System.Windows.Forms.Button();
            ButtonPal = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            btnCreateFme = new System.Windows.Forms.Button();
            checkBoxCompress = new System.Windows.Forms.CheckBox();
            sourceImageDisplayBox = new System.Windows.Forms.PictureBox();
            btnPositionFrame = new System.Windows.Forms.Button();
            InsertY = new System.Windows.Forms.NumericUpDown();
            InsertX = new System.Windows.Forms.NumericUpDown();
            checkBoxFlip = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnLoadImage = new System.Windows.Forms.Button();
            loadImageDialog = new System.Windows.Forms.OpenFileDialog();
            loadPalDialog = new System.Windows.Forms.OpenFileDialog();
            saveFmeDialog = new System.Windows.Forms.SaveFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transpColourBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sourceImageDisplayBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InsertY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InsertX).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(985, 27);
            btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(101, 72);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(transpColourBox);
            panel1.Controls.Add(buttonTransparent);
            panel1.Controls.Add(ButtonPal);
            panel1.Controls.Add(btnExit);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1109, 123);
            panel1.TabIndex = 2;
            // 
            // transpColourBox
            // 
            transpColourBox.Location = new System.Drawing.Point(324, 27);
            transpColourBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            transpColourBox.Name = "transpColourBox";
            transpColourBox.Size = new System.Drawing.Size(63, 72);
            transpColourBox.TabIndex = 17;
            transpColourBox.TabStop = false;
            // 
            // buttonTransparent
            // 
            buttonTransparent.Location = new System.Drawing.Point(184, 27);
            buttonTransparent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonTransparent.Name = "buttonTransparent";
            buttonTransparent.Size = new System.Drawing.Size(134, 72);
            buttonTransparent.TabIndex = 16;
            buttonTransparent.Text = "Transparent colour";
            buttonTransparent.UseVisualStyleBackColor = true;
            buttonTransparent.Click += buttonTransparent_Click;
            // 
            // ButtonPal
            // 
            ButtonPal.Location = new System.Drawing.Point(25, 27);
            ButtonPal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonPal.Name = "ButtonPal";
            ButtonPal.Size = new System.Drawing.Size(99, 72);
            ButtonPal.TabIndex = 15;
            ButtonPal.Text = "Load PAL";
            ButtonPal.UseVisualStyleBackColor = true;
            ButtonPal.Click += ButtonPal_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(btnCreateFme);
            panel2.Controls.Add(checkBoxCompress);
            panel2.Controls.Add(sourceImageDisplayBox);
            panel2.Controls.Add(btnPositionFrame);
            panel2.Controls.Add(InsertY);
            panel2.Controls.Add(InsertX);
            panel2.Controls.Add(checkBoxFlip);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnLoadImage);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 123);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1109, 881);
            panel2.TabIndex = 3;
            // 
            // btnCreateFme
            // 
            btnCreateFme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCreateFme.Location = new System.Drawing.Point(882, 433);
            btnCreateFme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCreateFme.Name = "btnCreateFme";
            btnCreateFme.Size = new System.Drawing.Size(177, 56);
            btnCreateFme.TabIndex = 21;
            btnCreateFme.Text = "Create FME";
            btnCreateFme.UseVisualStyleBackColor = true;
            btnCreateFme.Click += btnCreateFme_Click;
            // 
            // checkBoxCompress
            // 
            checkBoxCompress.AutoSize = true;
            checkBoxCompress.Location = new System.Drawing.Point(882, 313);
            checkBoxCompress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxCompress.Name = "checkBoxCompress";
            checkBoxCompress.Size = new System.Drawing.Size(96, 24);
            checkBoxCompress.TabIndex = 20;
            checkBoxCompress.Text = "Compress";
            checkBoxCompress.UseVisualStyleBackColor = true;
            // 
            // sourceImageDisplayBox
            // 
            sourceImageDisplayBox.BackColor = System.Drawing.Color.LightGray;
            sourceImageDisplayBox.Location = new System.Drawing.Point(182, 36);
            sourceImageDisplayBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            sourceImageDisplayBox.Name = "sourceImageDisplayBox";
            sourceImageDisplayBox.Size = new System.Drawing.Size(662, 792);
            sourceImageDisplayBox.TabIndex = 19;
            sourceImageDisplayBox.TabStop = false;
            // 
            // btnPositionFrame
            // 
            btnPositionFrame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPositionFrame.Location = new System.Drawing.Point(882, 143);
            btnPositionFrame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPositionFrame.Name = "btnPositionFrame";
            btnPositionFrame.Size = new System.Drawing.Size(177, 56);
            btnPositionFrame.TabIndex = 18;
            btnPositionFrame.Text = "Position frame";
            btnPositionFrame.UseVisualStyleBackColor = true;
            btnPositionFrame.Click += btnPositionFrame_Click;
            // 
            // InsertY
            // 
            InsertY.Location = new System.Drawing.Point(968, 81);
            InsertY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InsertY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            InsertY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            InsertY.Name = "InsertY";
            InsertY.Size = new System.Drawing.Size(115, 27);
            InsertY.TabIndex = 17;
            InsertY.ValueChanged += InsertY_ValueChanged;
            // 
            // InsertX
            // 
            InsertX.Location = new System.Drawing.Point(968, 36);
            InsertX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InsertX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            InsertX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            InsertX.Name = "InsertX";
            InsertX.Size = new System.Drawing.Size(115, 27);
            InsertX.TabIndex = 16;
            InsertX.ValueChanged += InsertX_ValueChanged;
            // 
            // checkBoxFlip
            // 
            checkBoxFlip.AutoSize = true;
            checkBoxFlip.Location = new System.Drawing.Point(882, 260);
            checkBoxFlip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxFlip.Name = "checkBoxFlip";
            checkBoxFlip.Size = new System.Drawing.Size(55, 24);
            checkBoxFlip.TabIndex = 15;
            checkBoxFlip.Text = "Flip";
            checkBoxFlip.UseVisualStyleBackColor = true;
            checkBoxFlip.CheckedChanged += checkBoxFlip_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(882, 84);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 20);
            label5.TabIndex = 14;
            label5.Text = "Insert Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(882, 39);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 20);
            label4.TabIndex = 13;
            label4.Text = "Insert X";
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new System.Drawing.Point(23, 36);
            btnLoadImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new System.Drawing.Size(122, 56);
            btnLoadImage.TabIndex = 0;
            btnLoadImage.Text = "Load Image";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // loadImageDialog
            // 
            loadImageDialog.Filter = "PNG images|*.PNG|JPEG images|*.JPG|BMP images|*.BMP";
            loadImageDialog.Title = "Load Image";
            loadImageDialog.FileOk += loadImageDialog_FileOk;
            // 
            // loadPalDialog
            // 
            loadPalDialog.Filter = "Dark Forces PAL files|*.PAL";
            loadPalDialog.Title = "Load PAL";
            loadPalDialog.FileOk += loadPalDialog_FileOk;
            // 
            // saveFmeDialog
            // 
            saveFmeDialog.Filter = "FME file|*.fme";
            saveFmeDialog.Title = "Create FME";
            saveFmeDialog.FileOk += saveFmeDialog_FileOk;
            // 
            // CreateFmeWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1109, 1004);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(1127, 1051);
            Name = "CreateFmeWindow";
            ShowIcon = false;
            Text = "Create FME";
            FormClosed += CreateFmeWindow_FormClosed;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)transpColourBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sourceImageDisplayBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InsertY).EndInit();
            ((System.ComponentModel.ISupportInitialize)InsertX).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox transpColourBox;
        private System.Windows.Forms.Button buttonTransparent;
        private System.Windows.Forms.Button ButtonPal;
        private System.Windows.Forms.Button btnPositionFrame;
        private System.Windows.Forms.NumericUpDown InsertY;
        private System.Windows.Forms.NumericUpDown InsertX;
        private System.Windows.Forms.CheckBox checkBoxFlip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox sourceImageDisplayBox;
        private System.Windows.Forms.OpenFileDialog loadImageDialog;
        private System.Windows.Forms.OpenFileDialog loadPalDialog;
        private System.Windows.Forms.SaveFileDialog saveFmeDialog;
        private System.Windows.Forms.CheckBox checkBoxCompress;
        private System.Windows.Forms.Button btnCreateFme;
    }
}