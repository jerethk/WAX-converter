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
            this.label2 = new System.Windows.Forms.Label();
            this.numericInsertX = new System.Windows.Forms.NumericUpDown();
            this.numericInsertY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInsertX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInsertY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frames";
            // 
            // listBoxFrames
            // 
            this.listBoxFrames.FormattingEnabled = true;
            this.listBoxFrames.ItemHeight = 15;
            this.listBoxFrames.Location = new System.Drawing.Point(29, 56);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(853, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "InsertX";
            // 
            // numericInsertX
            // 
            this.numericInsertX.Location = new System.Drawing.Point(853, 56);
            this.numericInsertX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericInsertX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericInsertX.Name = "numericInsertX";
            this.numericInsertX.Size = new System.Drawing.Size(120, 23);
            this.numericInsertX.TabIndex = 4;
            this.numericInsertX.ValueChanged += new System.EventHandler(this.numericInsertX_ValueChanged);
            // 
            // numericInsertY
            // 
            this.numericInsertY.Location = new System.Drawing.Point(853, 147);
            this.numericInsertY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericInsertY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericInsertY.Name = "numericInsertY";
            this.numericInsertY.Size = new System.Drawing.Size(120, 23);
            this.numericInsertY.TabIndex = 6;
            this.numericInsertY.ValueChanged += new System.EventHandler(this.numericInsertY_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "InsertY";
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccept.Location = new System.Drawing.Point(853, 434);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(120, 63);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Accept Changes";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiscard.Location = new System.Drawing.Point(853, 526);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(120, 63);
            this.btnDiscard.TabIndex = 8;
            this.btnDiscard.Text = "Discard Changes";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // FramePositioningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 701);
            this.ControlBox = false;
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.numericInsertY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericInsertX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.listBoxFrames);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1020, 740);
            this.Name = "FramePositioningWindow";
            this.Text = "Position frames";
            this.Load += new System.EventHandler(this.FramePositioningWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInsertX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInsertY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFrames;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericInsertX;
        private System.Windows.Forms.NumericUpDown numericInsertY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDiscard;
    }
}