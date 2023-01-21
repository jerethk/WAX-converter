using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WAX_converter
{
    class ColourChooser : Form
    {
        public Color FinalColour { get; set; }

        private Color previousColour;
        private Color selectedColour;

        private NumericUpDown numRed;
        private Label label1;
        private Label label2;
        private NumericUpDown numGreen;
        private NumericUpDown numBlue;
        private Label label3;
        private PictureBox colourBox;
        private Button btnDone;
        private Button btnCancel;
        private PictureBox pictureBox1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourChooser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numGreen = new System.Windows.Forms.NumericUpDown();
            this.numBlue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.colourBox = new System.Windows.Forms.PictureBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(13, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // numRed
            // 
            this.numRed.Location = new System.Drawing.Point(33, 16);
            this.numRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRed.Name = "numRed";
            this.numRed.Size = new System.Drawing.Size(65, 23);
            this.numRed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "G";
            // 
            // numGreen
            // 
            this.numGreen.Location = new System.Drawing.Point(140, 18);
            this.numGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreen.Name = "numGreen";
            this.numGreen.Size = new System.Drawing.Size(65, 23);
            this.numGreen.TabIndex = 4;
            // 
            // numBlue
            // 
            this.numBlue.Location = new System.Drawing.Point(252, 16);
            this.numBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlue.Name = "numBlue";
            this.numBlue.Size = new System.Drawing.Size(65, 23);
            this.numBlue.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // colourBox
            // 
            this.colourBox.Location = new System.Drawing.Point(354, 16);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(40, 40);
            this.colourBox.TabIndex = 7;
            this.colourBox.TabStop = false;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(140, 61);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(77, 33);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Location = new System.Drawing.Point(240, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ColourChooser
            // 
            this.ClientSize = new System.Drawing.Size(464, 481);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.numBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numGreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRed);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 520);
            this.Name = "ColourChooser";
            this.Text = "Choose transparent colour";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //-------------------------------------------------------------------------

        // Form constructor        
        public ColourChooser(Bitmap sampleImage, Color existingTransparentColour)
        {
            InitializeComponent();

            pictureBox1.Image = sampleImage;
            this.previousColour = existingTransparentColour;
            this.selectedColour = Color.FromArgb(255, existingTransparentColour.R, existingTransparentColour.G, existingTransparentColour.B);
            this.FinalColour = existingTransparentColour;
            
            numRed.Value = selectedColour.R;
            numGreen.Value = selectedColour.G;
            numBlue.Value = selectedColour.B;
            colourBox.BackColor = selectedColour;

            // event handlers for RGB number spiners
            this.numRed.ValueChanged += new System.EventHandler(this.numRed_ValueChanged);
            this.numGreen.ValueChanged += new System.EventHandler(this.numGreen_ValueChanged);
            this.numBlue.ValueChanged += new System.EventHandler(this.numBlue_ValueChanged);
        }

        private void numRed_ValueChanged(object sender, EventArgs e)
        {
            this.selectedColour = Color.FromArgb(255, (int)numRed.Value, (int)numGreen.Value, (int)numBlue.Value);
            colourBox.BackColor = selectedColour;
        }

        private void numGreen_ValueChanged(object sender, EventArgs e)
        {
            this.selectedColour = Color.FromArgb(255, (int)numRed.Value, (int)numGreen.Value, (int)numBlue.Value);
            colourBox.BackColor = selectedColour;

        }

        private void numBlue_ValueChanged(object sender, EventArgs e)
        {
            this.selectedColour = Color.FromArgb(255, (int)numRed.Value, (int)numGreen.Value, (int)numBlue.Value);
            colourBox.BackColor = selectedColour;

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (e.X < pictureBox1.Image.Width && e.Y < pictureBox1.Image.Height)
                {
                    Bitmap bitmap = new Bitmap(pictureBox1.Image);
                    this.selectedColour = bitmap.GetPixel(e.X, e.Y);

                    // remove the event handlers to change the values, then re-add them (otherwise it stuffs up)
                    this.numRed.ValueChanged -= this.numRed_ValueChanged; 
                    this.numGreen.ValueChanged -= this.numGreen_ValueChanged; 
                    this.numBlue.ValueChanged -= this.numBlue_ValueChanged;   

                    numRed.Value = selectedColour.R;
                    numGreen.Value = selectedColour.G;
                    numBlue.Value = selectedColour.B;

                    this.numRed.ValueChanged += new System.EventHandler(this.numRed_ValueChanged);
                    this.numGreen.ValueChanged += new System.EventHandler(this.numGreen_ValueChanged);
                    this.numBlue.ValueChanged += new System.EventHandler(this.numBlue_ValueChanged);            
                    colourBox.BackColor = selectedColour;

                    bitmap.Dispose();
                }
            }

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.FinalColour = this.selectedColour;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
