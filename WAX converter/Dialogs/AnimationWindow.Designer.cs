namespace WAX_converter
{
    partial class AnimationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationWindow));
            btnPlay = new System.Windows.Forms.Button();
            pictureBox = new System.Windows.Forms.PictureBox();
            btnLoop = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            numericView = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            numericFrameRate = new System.Windows.Forms.NumericUpDown();
            panel1 = new System.Windows.Forms.Panel();
            comboBoxZoom = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnAccept = new System.Windows.Forms.Button();
            btnDiscard = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericFrameRate).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new System.Drawing.Point(47, 328);
            btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new System.Drawing.Size(99, 48);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox.BackColor = System.Drawing.Color.LightGray;
            pictureBox.Location = new System.Drawing.Point(18, 28);
            pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(680, 852);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.SizeChanged += pictureBox_SizeChanged;
            pictureBox.Paint += pictureBox_Paint;
            // 
            // btnLoop
            // 
            btnLoop.Location = new System.Drawing.Point(47, 421);
            btnLoop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoop.Name = "btnLoop";
            btnLoop.Size = new System.Drawing.Size(99, 48);
            btnLoop.TabIndex = 2;
            btnLoop.Text = "Loop";
            btnLoop.UseVisualStyleBackColor = true;
            btnLoop.Click += btnLoop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "View angle";
            // 
            // numericView
            // 
            numericView.Location = new System.Drawing.Point(23, 64);
            numericView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericView.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericView.Name = "numericView";
            numericView.Size = new System.Drawing.Size(137, 27);
            numericView.TabIndex = 4;
            numericView.ValueChanged += numericView_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 20);
            label2.TabIndex = 5;
            label2.Text = "Frame rate";
            // 
            // numericFrameRate
            // 
            numericFrameRate.Location = new System.Drawing.Point(14, 64);
            numericFrameRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericFrameRate.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericFrameRate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericFrameRate.Name = "numericFrameRate";
            numericFrameRate.Size = new System.Drawing.Size(137, 27);
            numericFrameRate.TabIndex = 6;
            numericFrameRate.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericFrameRate.ValueChanged += numericFrameRate_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxZoom);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPlay);
            panel1.Controls.Add(btnLoop);
            panel1.Controls.Add(numericView);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(179, 908);
            panel1.TabIndex = 7;
            // 
            // comboBoxZoom
            // 
            comboBoxZoom.FormattingEnabled = true;
            comboBoxZoom.Items.AddRange(new object[] { "100%", "200%", "300%", "400%" });
            comboBoxZoom.Location = new System.Drawing.Point(23, 176);
            comboBoxZoom.Name = "comboBoxZoom";
            comboBoxZoom.Size = new System.Drawing.Size(137, 28);
            comboBoxZoom.TabIndex = 6;
            comboBoxZoom.SelectedIndexChanged += ComboBoxZoom_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(23, 138);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Zoom";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAccept);
            panel2.Controls.Add(btnDiscard);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(numericFrameRate);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(896, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(229, 908);
            panel2.TabIndex = 8;
            // 
            // btnAccept
            // 
            btnAccept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAccept.Location = new System.Drawing.Point(41, 328);
            btnAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new System.Drawing.Size(141, 68);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "Accept changes";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnDiscard
            // 
            btnDiscard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDiscard.Location = new System.Drawing.Point(41, 435);
            btnDiscard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new System.Drawing.Size(141, 68);
            btnDiscard.TabIndex = 6;
            btnDiscard.Text = "Discard changes";
            btnDiscard.UseVisualStyleBackColor = true;
            btnDiscard.Click += btnDiscard_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(179, 0);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(717, 908);
            panel3.TabIndex = 9;
            // 
            // AnimationWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1125, 908);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(1140, 944);
            Name = "AnimationWindow";
            Text = "Animation preview";
            Load += AnimationWindow_Load;
            Shown += AnimationWindow_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericFrameRate).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericFrameRate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxZoom;
    }
}