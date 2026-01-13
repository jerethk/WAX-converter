
namespace WAX_converter
{
    partial class SequenceBuilderWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SequenceBuilderWindow));
            label1 = new System.Windows.Forms.Label();
            listBoxFrames = new System.Windows.Forms.ListBox();
            listBoxSeqFrames = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            displayBox = new System.Windows.Forms.PictureBox();
            btnDone = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnClearSeq = new System.Windows.Forms.Button();
            checkBoxZoom = new System.Windows.Forms.CheckBox();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)displayBox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(16, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "ALL FRAMES";
            // 
            // listBoxFrames
            // 
            listBoxFrames.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            listBoxFrames.FormattingEnabled = true;
            listBoxFrames.ItemHeight = 20;
            listBoxFrames.Location = new System.Drawing.Point(16, 45);
            listBoxFrames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listBoxFrames.Name = "listBoxFrames";
            listBoxFrames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            listBoxFrames.Size = new System.Drawing.Size(97, 684);
            listBoxFrames.TabIndex = 1;
            listBoxFrames.SelectedIndexChanged += listBoxFrames_SelectedIndexChanged;
            listBoxFrames.Enter += listBoxFrames_Enter;
            // 
            // listBoxSeqFrames
            // 
            listBoxSeqFrames.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            listBoxSeqFrames.FormattingEnabled = true;
            listBoxSeqFrames.ItemHeight = 20;
            listBoxSeqFrames.Location = new System.Drawing.Point(254, 45);
            listBoxSeqFrames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listBoxSeqFrames.Name = "listBoxSeqFrames";
            listBoxSeqFrames.Size = new System.Drawing.Size(97, 684);
            listBoxSeqFrames.TabIndex = 3;
            listBoxSeqFrames.SelectedIndexChanged += listBoxSeqFrames_SelectedIndexChanged;
            listBoxSeqFrames.Enter += listBoxSeqFrames_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label2.Location = new System.Drawing.Point(211, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(168, 20);
            label2.TabIndex = 2;
            label2.Text = "FRAMES IN SEQUENCE";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(142, 160);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(88, 109);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add to Sequence >>>>>";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new System.Drawing.Point(142, 287);
            btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(88, 109);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove from  Sequence <<<<<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // displayBox
            // 
            displayBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            displayBox.BackColor = System.Drawing.Color.Gray;
            displayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            displayBox.Location = new System.Drawing.Point(22, 75);
            displayBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            displayBox.Name = "displayBox";
            displayBox.Size = new System.Drawing.Size(470, 584);
            displayBox.TabIndex = 6;
            displayBox.TabStop = false;
            // 
            // btnDone
            // 
            btnDone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDone.Location = new System.Drawing.Point(139, 20);
            btnDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDone.Name = "btnDone";
            btnDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnDone.Size = new System.Drawing.Size(102, 49);
            btnDone.TabIndex = 7;
            btnDone.Text = "Accept";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(274, 20);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnCancel.Size = new System.Drawing.Size(102, 49);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Discard";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClearSeq
            // 
            btnClearSeq.Location = new System.Drawing.Point(142, 415);
            btnClearSeq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClearSeq.Name = "btnClearSeq";
            btnClearSeq.Size = new System.Drawing.Size(88, 109);
            btnClearSeq.TabIndex = 9;
            btnClearSeq.Text = "CLEAR  Sequence";
            btnClearSeq.UseVisualStyleBackColor = true;
            btnClearSeq.Click += btnClearSeq_Click;
            // 
            // checkBoxZoom
            // 
            checkBoxZoom.AutoSize = true;
            checkBoxZoom.Location = new System.Drawing.Point(22, 21);
            checkBoxZoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxZoom.Name = "checkBoxZoom";
            checkBoxZoom.Size = new System.Drawing.Size(71, 24);
            checkBoxZoom.TabIndex = 10;
            checkBoxZoom.Text = "Zoom";
            checkBoxZoom.UseVisualStyleBackColor = true;
            checkBoxZoom.CheckedChanged += checkBoxZoom_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBoxFrames);
            panel2.Controls.Add(btnClearSeq);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnRemove);
            panel2.Controls.Add(listBoxSeqFrames);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(374, 776);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDone);
            panel3.Controls.Add(btnCancel);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(374, 669);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(522, 107);
            panel3.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxZoom);
            panel1.Controls.Add(displayBox);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(374, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(522, 669);
            panel1.TabIndex = 13;
            // 
            // SequenceBuilderWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(896, 776);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(912, 784);
            Name = "SequenceBuilderWindow";
            Text = "SequenceBuilderWindow";
            Load += SequenceBuilderWindow_Load;
            ((System.ComponentModel.ISupportInitialize)displayBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFrames;
        private System.Windows.Forms.ListBox listBoxSeqFrames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClearSeq;
        private System.Windows.Forms.CheckBox checkBoxZoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}