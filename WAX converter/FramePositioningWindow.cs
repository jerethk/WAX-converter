using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WAX_converter
{
    public partial class FramePositioningWindow : Form
    {
        private List<Bitmap> cells;
        private List<Frame> frameList;
        private Color transparentColour;
        private Graphics graphics;
        private int centreX;
        private int centreY;
        
        public FramePositioningWindow(List<Frame> frames, List<Bitmap> images, Color transparentColour)
        {
            InitializeComponent();

            this.frameList = frames;
            this.cells = images;
            this.transparentColour = transparentColour;
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;
        }

        private void FramePositioningWindow_Load(object sender, EventArgs e)
        {
            makeCellsTransparent();
            this.graphics = pictureBox.CreateGraphics();

            for (int f = 0; f < this.frameList.Count; f++)
            {
                listBoxFrames.Items.Add(f.ToString());
            }

            if (this.frameList.Count > 0)
            {
                listBoxFrames.SelectedIndex = 0;
                drawCurrentFrame();
            }
        }

        private void makeCellsTransparent()
        {
            foreach (var cell in this.cells)
            {
                for (var x = 0; x < cell.Width; x++)
                {
                    for (var y = 0; y < cell.Height; y++)
                    {
                        if (cell.GetPixel(x, y) == this.transparentColour)
                        {
                            cell.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                        }
                    }
                }
            }
        }

        private void listBoxFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = listBoxFrames.SelectedIndex;
            
            if (i >= 0)
            {
                drawCurrentFrame();
            }
        }

        private void drawCurrentFrame()
        {
            this.graphics.Clear(Color.LightGray);

            var frame = this.frameList[listBoxFrames.SelectedIndex];
            var image = new Bitmap(this.cells[frame.CellIndex]);
            if (frame.Flip == 1)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }

            var xOrigin = this.centreX + frame.InsertX;
            var yOrigin = this.centreY + frame.InsertY;
            this.graphics.DrawImage(image, new Point(xOrigin, yOrigin));

            var redPen = new Pen(Color.FromArgb(128, 255, 0, 0));
            var xAxisLeft = new Point(0, this.centreY);
            var XAxisRight = new Point(pictureBox.Width, this.centreY);
            var yAxisTop = new Point(this.centreX, 0);
            var yAxisBot = new Point(this.centreX, pictureBox.Height);
            this.graphics.DrawLine(redPen, xAxisLeft, XAxisRight);
            this.graphics.DrawLine(redPen, yAxisTop, yAxisBot);
        }
    }
}
