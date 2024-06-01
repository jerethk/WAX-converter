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
            btnExit = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            checkBoxCommonColours = new System.Windows.Forms.CheckBox();
            checkBoxIlluminated = new System.Windows.Forms.CheckBox();
            transpColourBox = new System.Windows.Forms.PictureBox();
            buttonTransparent = new System.Windows.Forms.Button();
            ButtonPal = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
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
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            btnExit.Location = new System.Drawing.Point(862, 20);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(88, 54);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxCommonColours);
            panel1.Controls.Add(checkBoxIlluminated);
            panel1.Controls.Add(transpColourBox);
            panel1.Controls.Add(buttonTransparent);
            panel1.Controls.Add(ButtonPal);
            panel1.Controls.Add(btnExit);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(972, 92);
            panel1.TabIndex = 2;
            // 
            // checkBoxCommonColours
            // 
            checkBoxCommonColours.AutoSize = true;
            checkBoxCommonColours.Location = new System.Drawing.Point(133, 55);
            checkBoxCommonColours.Name = "checkBoxCommonColours";
            checkBoxCommonColours.Size = new System.Drawing.Size(145, 19);
            checkBoxCommonColours.TabIndex = 19;
            checkBoxCommonColours.Text = "Common colours only";
            checkBoxCommonColours.UseVisualStyleBackColor = true;
            checkBoxCommonColours.CheckedChanged += checkBoxCommonColours_CheckedChanged;
            // 
            // checkBoxIlluminated
            // 
            checkBoxIlluminated.AutoSize = true;
            checkBoxIlluminated.Location = new System.Drawing.Point(133, 20);
            checkBoxIlluminated.Name = "checkBoxIlluminated";
            checkBoxIlluminated.Size = new System.Drawing.Size(170, 19);
            checkBoxIlluminated.TabIndex = 18;
            checkBoxIlluminated.Text = "Include illuminated colours";
            checkBoxIlluminated.UseVisualStyleBackColor = true;
            checkBoxIlluminated.CheckedChanged += checkBoxIlluminated_CheckedChanged;
            // 
            // transpColourBox
            // 
            transpColourBox.Location = new System.Drawing.Point(498, 20);
            transpColourBox.Name = "transpColourBox";
            transpColourBox.Size = new System.Drawing.Size(55, 54);
            transpColourBox.TabIndex = 17;
            transpColourBox.TabStop = false;
            // 
            // buttonTransparent
            // 
            buttonTransparent.Location = new System.Drawing.Point(375, 20);
            buttonTransparent.Name = "buttonTransparent";
            buttonTransparent.Size = new System.Drawing.Size(117, 54);
            buttonTransparent.TabIndex = 16;
            buttonTransparent.Text = "Transparent colour";
            buttonTransparent.UseVisualStyleBackColor = true;
            buttonTransparent.Click += buttonTransparent_Click;
            // 
            // ButtonPal
            // 
            ButtonPal.Location = new System.Drawing.Point(22, 20);
            ButtonPal.Name = "ButtonPal";
            ButtonPal.Size = new System.Drawing.Size(87, 54);
            ButtonPal.TabIndex = 15;
            ButtonPal.Text = "Load PAL";
            ButtonPal.UseVisualStyleBackColor = true;
            ButtonPal.Click += ButtonPal_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            panel2.Location = new System.Drawing.Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(972, 692);
            panel2.TabIndex = 3;
            // 
            // checkBoxCompress
            // 
            checkBoxCompress.AutoSize = true;
            checkBoxCompress.Location = new System.Drawing.Point(772, 235);
            checkBoxCompress.Name = "checkBoxCompress";
            checkBoxCompress.Size = new System.Drawing.Size(79, 19);
            checkBoxCompress.TabIndex = 20;
            checkBoxCompress.Text = "Compress";
            checkBoxCompress.UseVisualStyleBackColor = true;
            // 
            // sourceImageDisplayBox
            // 
            sourceImageDisplayBox.BackColor = System.Drawing.Color.LightGray;
            sourceImageDisplayBox.Location = new System.Drawing.Point(159, 27);
            sourceImageDisplayBox.Name = "sourceImageDisplayBox";
            sourceImageDisplayBox.Size = new System.Drawing.Size(579, 594);
            sourceImageDisplayBox.TabIndex = 19;
            sourceImageDisplayBox.TabStop = false;
            // 
            // btnPositionFrame
            // 
            btnPositionFrame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPositionFrame.Location = new System.Drawing.Point(772, 107);
            btnPositionFrame.Name = "btnPositionFrame";
            btnPositionFrame.Size = new System.Drawing.Size(155, 42);
            btnPositionFrame.TabIndex = 18;
            btnPositionFrame.Text = "Position frame";
            btnPositionFrame.UseVisualStyleBackColor = true;
            btnPositionFrame.Click += btnPositionFrame_Click;
            // 
            // InsertY
            // 
            InsertY.Location = new System.Drawing.Point(847, 61);
            InsertY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            InsertY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            InsertY.Name = "InsertY";
            InsertY.Size = new System.Drawing.Size(101, 23);
            InsertY.TabIndex = 17;
            InsertY.ValueChanged += InsertY_ValueChanged;
            // 
            // InsertX
            // 
            InsertX.Location = new System.Drawing.Point(847, 27);
            InsertX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            InsertX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            InsertX.Name = "InsertX";
            InsertX.Size = new System.Drawing.Size(101, 23);
            InsertX.TabIndex = 16;
            InsertX.ValueChanged += InsertX_ValueChanged;
            // 
            // checkBoxFlip
            // 
            checkBoxFlip.AutoSize = true;
            checkBoxFlip.Location = new System.Drawing.Point(772, 195);
            checkBoxFlip.Name = "checkBoxFlip";
            checkBoxFlip.Size = new System.Drawing.Size(45, 19);
            checkBoxFlip.TabIndex = 15;
            checkBoxFlip.Text = "Flip";
            checkBoxFlip.UseVisualStyleBackColor = true;
            checkBoxFlip.CheckedChanged += checkBoxFlip_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(772, 63);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(46, 15);
            label5.TabIndex = 14;
            label5.Text = "Insert Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(772, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 13;
            label4.Text = "Insert X";
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new System.Drawing.Point(20, 27);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new System.Drawing.Size(107, 42);
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
            // CreateFmeWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(972, 784);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new System.Drawing.Size(988, 800);
            Name = "CreateFmeWindow";
            ShowIcon = false;
            Text = "Create FME";
            FormClosed += CreateFmeWindow_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBoxCommonColours;
        private System.Windows.Forms.CheckBox checkBoxIlluminated;
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxCompress;
    }
}