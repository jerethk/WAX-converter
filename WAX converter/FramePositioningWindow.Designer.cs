namespace WAX_converter
{
    partial class FramePositioningWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFrames = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frames";
            // 
            // listBoxFrames
            // 
            this.listBoxFrames.FormattingEnabled = true;
            this.listBoxFrames.ItemHeight = 15;
            this.listBoxFrames.Location = new System.Drawing.Point(20, 59);
            this.listBoxFrames.Name = "listBoxFrames";
            this.listBoxFrames.Size = new System.Drawing.Size(94, 604);
            this.listBoxFrames.TabIndex = 1;
            this.listBoxFrames.SelectedIndexChanged += new System.EventHandler(this.listBoxFrames_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox.Location = new System.Drawing.Point(174, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 640);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // FramePositioningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 761);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.listBoxFrames);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "FramePositioningWindow";
            this.Text = "Position frames";
            this.Load += new System.EventHandler(this.FramePositioningWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFrames;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}