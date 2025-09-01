
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFrames = new System.Windows.Forms.ListBox();
            this.listBoxSeqFrames = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.PictureBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClearSeq = new System.Windows.Forms.Button();
            this.checkBoxZoom = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALL FRAMES";
            // 
            // listBoxFrames
            // 
            this.listBoxFrames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFrames.FormattingEnabled = true;
            this.listBoxFrames.ItemHeight = 15;
            this.listBoxFrames.Location = new System.Drawing.Point(14, 34);
            this.listBoxFrames.Name = "listBoxFrames";
            this.listBoxFrames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxFrames.Size = new System.Drawing.Size(85, 499);
            this.listBoxFrames.TabIndex = 1;
            this.listBoxFrames.SelectedIndexChanged += new System.EventHandler(this.listBoxFrames_SelectedIndexChanged);
            this.listBoxFrames.Enter += new System.EventHandler(this.listBoxFrames_Enter);
            // 
            // listBoxSeqFrames
            // 
            this.listBoxSeqFrames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxSeqFrames.FormattingEnabled = true;
            this.listBoxSeqFrames.ItemHeight = 15;
            this.listBoxSeqFrames.Location = new System.Drawing.Point(222, 34);
            this.listBoxSeqFrames.Name = "listBoxSeqFrames";
            this.listBoxSeqFrames.Size = new System.Drawing.Size(85, 499);
            this.listBoxSeqFrames.TabIndex = 3;
            this.listBoxSeqFrames.SelectedIndexChanged += new System.EventHandler(this.listBoxSeqFrames_SelectedIndexChanged);
            this.listBoxSeqFrames.Enter += new System.EventHandler(this.listBoxSeqFrames_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(185, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "FRAMES IN SEQUENCE";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 82);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add to Sequence >>>>>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(124, 215);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(77, 82);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove from  Sequence <<<<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // displayBox
            // 
            this.displayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayBox.BackColor = System.Drawing.Color.Gray;
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayBox.Location = new System.Drawing.Point(19, 56);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(412, 418);
            this.displayBox.TabIndex = 6;
            this.displayBox.TabStop = false;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDone.Location = new System.Drawing.Point(122, 15);
            this.btnDone.Name = "btnDone";
            this.btnDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDone.Size = new System.Drawing.Size(89, 37);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Accept";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(240, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(89, 37);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Discard";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClearSeq
            // 
            this.btnClearSeq.Location = new System.Drawing.Point(124, 311);
            this.btnClearSeq.Name = "btnClearSeq";
            this.btnClearSeq.Size = new System.Drawing.Size(77, 82);
            this.btnClearSeq.TabIndex = 9;
            this.btnClearSeq.Text = "CLEAR  Sequence";
            this.btnClearSeq.UseVisualStyleBackColor = true;
            this.btnClearSeq.Click += new System.EventHandler(this.btnClearSeq_Click);
            // 
            // checkBoxZoom
            // 
            this.checkBoxZoom.AutoSize = true;
            this.checkBoxZoom.Location = new System.Drawing.Point(19, 16);
            this.checkBoxZoom.Name = "checkBoxZoom";
            this.checkBoxZoom.Size = new System.Drawing.Size(58, 19);
            this.checkBoxZoom.TabIndex = 10;
            this.checkBoxZoom.Text = "Zoom";
            this.checkBoxZoom.UseVisualStyleBackColor = true;
            this.checkBoxZoom.CheckedChanged += new System.EventHandler(this.checkBoxZoom_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBoxFrames);
            this.panel2.Controls.Add(this.btnClearSeq);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.listBoxSeqFrames);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 561);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDone);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(327, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 80);
            this.panel3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxZoom);
            this.panel1.Controls.Add(this.displayBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(327, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 481);
            this.panel1.TabIndex = 13;
            // 
            // SequenceBuilderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SequenceBuilderWindow";
            this.Text = "SequenceBuilderWindow";
            this.Load += new System.EventHandler(this.SequenceBuilderWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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