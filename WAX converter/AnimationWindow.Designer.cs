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
            btnPlay.Location = new System.Drawing.Point(41, 246);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new System.Drawing.Size(87, 36);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox.BackColor = System.Drawing.Color.LightGray;
            pictureBox.Location = new System.Drawing.Point(16, 21);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(595, 639);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.SizeChanged += pictureBox_SizeChanged;
            // 
            // btnLoop
            // 
            btnLoop.Location = new System.Drawing.Point(41, 316);
            btnLoop.Name = "btnLoop";
            btnLoop.Size = new System.Drawing.Size(87, 36);
            btnLoop.TabIndex = 2;
            btnLoop.Text = "Loop";
            btnLoop.UseVisualStyleBackColor = true;
            btnLoop.Click += btnLoop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "View angle";
            // 
            // numericView
            // 
            numericView.Location = new System.Drawing.Point(20, 48);
            numericView.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericView.Name = "numericView";
            numericView.Size = new System.Drawing.Size(120, 23);
            numericView.TabIndex = 4;
            numericView.ValueChanged += numericView_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Frame rate";
            // 
            // numericFrameRate
            // 
            numericFrameRate.Location = new System.Drawing.Point(12, 48);
            numericFrameRate.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericFrameRate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericFrameRate.Name = "numericFrameRate";
            numericFrameRate.Size = new System.Drawing.Size(120, 23);
            numericFrameRate.TabIndex = 6;
            numericFrameRate.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericFrameRate.ValueChanged += numericFrameRate_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPlay);
            panel1.Controls.Add(btnLoop);
            panel1.Controls.Add(numericView);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(157, 681);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAccept);
            panel2.Controls.Add(btnDiscard);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(numericFrameRate);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(784, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(200, 681);
            panel2.TabIndex = 8;
            // 
            // btnAccept
            // 
            btnAccept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAccept.Location = new System.Drawing.Point(36, 246);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new System.Drawing.Size(123, 51);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "Accept changes";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnDiscard
            // 
            btnDiscard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDiscard.Location = new System.Drawing.Point(36, 326);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new System.Drawing.Size(123, 51);
            btnDiscard.TabIndex = 6;
            btnDiscard.Text = "Discard changes";
            btnDiscard.UseVisualStyleBackColor = true;
            btnDiscard.Click += btnDiscard_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(157, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(627, 681);
            panel3.TabIndex = 9;
            // 
            // AnimationWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 681);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(1000, 720);
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
    }
}