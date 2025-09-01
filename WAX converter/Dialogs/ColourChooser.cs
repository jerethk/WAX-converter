using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WAX_converter.Dialogs
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
        private Label label4;
        private PictureBox pictureBox1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourChooser));
            pictureBox1 = new PictureBox();
            numRed = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            numGreen = new NumericUpDown();
            numBlue = new NumericUpDown();
            label3 = new Label();
            colourBox = new PictureBox();
            btnDone = new Button();
            btnCancel = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colourBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(13, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 376);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // numRed
            // 
            numRed.Location = new Point(33, 68);
            numRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numRed.Name = "numRed";
            numRed.Size = new Size(65, 23);
            numRed.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 70);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 2;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 70);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 3;
            label2.Text = "G";
            // 
            // numGreen
            // 
            numGreen.Location = new Point(140, 70);
            numGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numGreen.Name = "numGreen";
            numGreen.Size = new Size(65, 23);
            numGreen.TabIndex = 4;
            // 
            // numBlue
            // 
            numBlue.Location = new Point(252, 68);
            numBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numBlue.Name = "numBlue";
            numBlue.Size = new Size(65, 23);
            numBlue.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 70);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 5;
            label3.Text = "B";
            // 
            // colourBox
            // 
            colourBox.Location = new Point(354, 68);
            colourBox.Name = "colourBox";
            colourBox.Size = new Size(40, 40);
            colourBox.TabIndex = 7;
            colourBox.TabStop = false;
            // 
            // btnDone
            // 
            btnDone.Location = new Point(140, 113);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(77, 33);
            btnDone.TabIndex = 8;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.OK;
            btnCancel.Location = new Point(240, 113);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 33);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.Location = new Point(13, 16);
            label4.Name = "label4";
            label4.Size = new Size(436, 41);
            label4.TabIndex = 10;
            label4.Text = "Any pixels set to this colour will be made transparent. Note: All pixels with alpha 0 will also be made transparent.";
            // 
            // ColourChooser
            // 
            ClientSize = new Size(464, 561);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnDone);
            Controls.Add(colourBox);
            Controls.Add(numBlue);
            Controls.Add(label3);
            Controls.Add(numGreen);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numRed);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(480, 600);
            Name = "ColourChooser";
            Text = "Choose transparent colour";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)colourBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
