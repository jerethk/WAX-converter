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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FramePositioningWindow));
            label1 = new System.Windows.Forms.Label();
            listBoxFrames = new System.Windows.Forms.ListBox();
            pictureBox = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            numericInsertX = new System.Windows.Forms.NumericUpDown();
            numericInsertY = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            btnAccept = new System.Windows.Forms.Button();
            btnDiscard = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            groupBoxAutoPosition = new System.Windows.Forms.GroupBox();
            checkBoxAutoY = new System.Windows.Forms.CheckBox();
            checkBoxAutoX = new System.Windows.Forms.CheckBox();
            btnSetAll = new System.Windows.Forms.Button();
            btnSetCurrent = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            numYOff = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            numXOff = new System.Windows.Forms.NumericUpDown();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericInsertX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericInsertY).BeginInit();
            panel1.SuspendLayout();
            groupBoxAutoPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numXOff).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Frames";
            // 
            // listBoxFrames
            // 
            listBoxFrames.FormattingEnabled = true;
            listBoxFrames.ItemHeight = 15;
            listBoxFrames.Location = new System.Drawing.Point(30, 56);
            listBoxFrames.Name = "listBoxFrames";
            listBoxFrames.Size = new System.Drawing.Size(94, 604);
            listBoxFrames.TabIndex = 1;
            listBoxFrames.SelectedIndexChanged += listBoxFrames_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox.BackColor = System.Drawing.Color.LightGray;
            pictureBox.Location = new System.Drawing.Point(31, 27);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(683, 663);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            pictureBox.Resize += PictureBox_Resize;
            pictureBox.Paint += PictureBox_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "InsertX";
            // 
            // numericInsertX
            // 
            numericInsertX.Location = new System.Drawing.Point(6, 54);
            numericInsertX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericInsertX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numericInsertX.Name = "numericInsertX";
            numericInsertX.Size = new System.Drawing.Size(120, 23);
            numericInsertX.TabIndex = 4;
            numericInsertX.ValueChanged += numericInsertX_ValueChanged;
            // 
            // numericInsertY
            // 
            numericInsertY.Location = new System.Drawing.Point(6, 126);
            numericInsertY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericInsertY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numericInsertY.Name = "numericInsertY";
            numericInsertY.Size = new System.Drawing.Size(120, 23);
            numericInsertY.TabIndex = 6;
            numericInsertY.ValueChanged += numericInsertY_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 99);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "InsertY";
            // 
            // btnAccept
            // 
            btnAccept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAccept.Location = new System.Drawing.Point(6, 524);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new System.Drawing.Size(120, 63);
            btnAccept.TabIndex = 7;
            btnAccept.Text = "Accept Changes";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnDiscard
            // 
            btnDiscard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDiscard.Location = new System.Drawing.Point(6, 611);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new System.Drawing.Size(120, 63);
            btnDiscard.TabIndex = 8;
            btnDiscard.Text = "Discard Changes";
            btnDiscard.UseVisualStyleBackColor = true;
            btnDiscard.Click += btnDiscard_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxAutoPosition);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDiscard);
            panel1.Controls.Add(numericInsertX);
            panel1.Controls.Add(btnAccept);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericInsertY);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(888, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(176, 724);
            panel1.TabIndex = 9;
            // 
            // groupBoxAutoPosition
            // 
            groupBoxAutoPosition.Controls.Add(checkBoxAutoY);
            groupBoxAutoPosition.Controls.Add(checkBoxAutoX);
            groupBoxAutoPosition.Controls.Add(btnSetAll);
            groupBoxAutoPosition.Controls.Add(btnSetCurrent);
            groupBoxAutoPosition.Controls.Add(label5);
            groupBoxAutoPosition.Controls.Add(numYOff);
            groupBoxAutoPosition.Controls.Add(label4);
            groupBoxAutoPosition.Controls.Add(numXOff);
            groupBoxAutoPosition.Location = new System.Drawing.Point(0, 193);
            groupBoxAutoPosition.Name = "groupBoxAutoPosition";
            groupBoxAutoPosition.Size = new System.Drawing.Size(146, 280);
            groupBoxAutoPosition.TabIndex = 9;
            groupBoxAutoPosition.TabStop = false;
            groupBoxAutoPosition.Text = "Auto Position";
            // 
            // checkBoxAutoY
            // 
            checkBoxAutoY.AutoSize = true;
            checkBoxAutoY.Checked = true;
            checkBoxAutoY.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxAutoY.Location = new System.Drawing.Point(117, 121);
            checkBoxAutoY.Name = "checkBoxAutoY";
            checkBoxAutoY.Size = new System.Drawing.Size(15, 14);
            checkBoxAutoY.TabIndex = 12;
            checkBoxAutoY.UseVisualStyleBackColor = true;
            checkBoxAutoY.CheckedChanged += checkBoxAutoY_CheckedChanged;
            // 
            // checkBoxAutoX
            // 
            checkBoxAutoX.AutoSize = true;
            checkBoxAutoX.Checked = true;
            checkBoxAutoX.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxAutoX.Location = new System.Drawing.Point(117, 53);
            checkBoxAutoX.Name = "checkBoxAutoX";
            checkBoxAutoX.Size = new System.Drawing.Size(15, 14);
            checkBoxAutoX.TabIndex = 11;
            checkBoxAutoX.UseVisualStyleBackColor = true;
            checkBoxAutoX.CheckedChanged += checkBoxAutoX_CheckedChanged;
            // 
            // btnSetAll
            // 
            btnSetAll.Location = new System.Drawing.Point(6, 222);
            btnSetAll.Name = "btnSetAll";
            btnSetAll.Size = new System.Drawing.Size(120, 38);
            btnSetAll.TabIndex = 10;
            btnSetAll.Text = "All frames";
            btnSetAll.UseVisualStyleBackColor = true;
            btnSetAll.Click += btnSetAll_Click;
            // 
            // btnSetCurrent
            // 
            btnSetCurrent.Location = new System.Drawing.Point(6, 166);
            btnSetCurrent.Name = "btnSetCurrent";
            btnSetCurrent.Size = new System.Drawing.Size(120, 38);
            btnSetCurrent.TabIndex = 9;
            btnSetCurrent.Text = "Current frame";
            btnSetCurrent.UseVisualStyleBackColor = true;
            btnSetCurrent.Click += btnSetCurrent_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 93);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 15);
            label5.TabIndex = 7;
            label5.Text = "% of height";
            // 
            // numYOff
            // 
            numYOff.Location = new System.Drawing.Point(6, 118);
            numYOff.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numYOff.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            numYOff.Name = "numYOff";
            numYOff.Size = new System.Drawing.Size(93, 23);
            numYOff.TabIndex = 8;
            numYOff.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 25);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 15);
            label4.TabIndex = 5;
            label4.Text = "% of width";
            // 
            // numXOff
            // 
            numXOff.Location = new System.Drawing.Point(6, 50);
            numXOff.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numXOff.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            numXOff.Name = "numXOff";
            numXOff.Size = new System.Drawing.Size(93, 23);
            numXOff.TabIndex = 6;
            numXOff.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBoxFrames);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(140, 724);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(140, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(748, 724);
            panel3.TabIndex = 11;
            // 
            // FramePositioningWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1064, 724);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(1080, 740);
            Name = "FramePositioningWindow";
            Text = "Position frames";
            Load += FramePositioningWindow_Load;
            Shown += FramePositioningWindow_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericInsertX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericInsertY).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxAutoPosition.ResumeLayout(false);
            groupBoxAutoPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)numXOff).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxAutoPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numYOff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numXOff;
        private System.Windows.Forms.Button btnSetAll;
        private System.Windows.Forms.Button btnSetCurrent;
        private System.Windows.Forms.CheckBox checkBoxAutoY;
        private System.Windows.Forms.CheckBox checkBoxAutoX;
    }
}