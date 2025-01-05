using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAX_converter
{
    public partial class FramePositioningWindow : Form
    {
        private List<Bitmap> cells;
        private List<Frame> frameList;
        private List<Frame> backupFrameList;
        private Graphics graphics;
        private int centreX;
        private int centreY;

        public FramePositioningWindow(List<Frame> frames, List<Bitmap> images, Color transparentColour)
        {
            InitializeComponent();

            this.frameList = frames;
            this.cells = makeCellsTransparent(images, transparentColour).ToList();

            this.backupFrameList = new List<Frame>();
            for (int f = 0; f < frames.Count; f++)
            {
                backupFrameList.Add(new Frame()
                {
                    InsertX = frames[f].InsertX,
                    InsertY = frames[f].InsertY,
                    Flip = frames[f].Flip,
                    CellIndex = frames[f].CellIndex,
                    CellAddress = frames[f].CellAddress,
                });
            }
        }

        private void FramePositioningWindow_Load(object sender, EventArgs e)
        {
            this.graphics = this.pictureBox.CreateGraphics();
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;

            for (int f = 0; f < this.frameList.Count; f++)
            {
                listBoxFrames.Items.Add(f.ToString());
            }
        }

        private async void FramePositioningWindow_Shown(object sender, EventArgs e)
        {
            if (this.frameList.Count > 0)
            {
                await Task.Delay(100);  // a small delay is needed to make the initial draw happen
                this.listBoxFrames.SelectedIndex = 0;
            }
        }

        public static IEnumerable<Bitmap> makeCellsTransparent(List<Bitmap> images, Color transparentColour)
        {
            foreach (var image in images)
            {
                var newImage = new Bitmap(image);

                for (var x = 0; x < newImage.Width; x++)
                {
                    for (var y = 0; y < newImage.Height; y++)
                    {
                        if (newImage.GetPixel(x, y) == transparentColour)
                        {
                            newImage.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                        }
                    }
                }

                yield return newImage;
            }
        }

        private void listBoxFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = listBoxFrames.SelectedIndex;

            if (i >= 0)
            {
                numericInsertX.Value = this.frameList[i].InsertX;
                numericInsertY.Value = this.frameList[i].InsertY;
                drawFrame();
            }
        }

        private void numericInsertX_ValueChanged(object sender, EventArgs e)
        {
            var i = listBoxFrames.SelectedIndex;

            if (i >= 0)
            {
                this.frameList[i].InsertX = (int)numericInsertX.Value;
                drawFrame();
            }
        }

        private void numericInsertY_ValueChanged(object sender, EventArgs e)
        {
            var i = listBoxFrames.SelectedIndex;

            if (i >= 0)
            {
                this.frameList[i].InsertY = (int)numericInsertY.Value;
                drawFrame();
            }
        }

        private void drawFrame()
        {
            if (this.listBoxFrames.SelectedIndex < 0)
            {
                return;
            }

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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            disposeBitmaps();
            this.Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < this.frameList.Count; f++)
            {
                this.frameList[f] = this.backupFrameList[f];
            }

            disposeBitmaps();
            this.Close();
        }

        private void disposeBitmaps()
        {
            foreach (var img in this.cells)
            {
                img.Dispose();
            }
        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;
            this.graphics.Dispose();
            this.graphics = pictureBox.CreateGraphics();

            if (this.listBoxFrames.SelectedIndex >= 0)
            {
                drawFrame();
            }
        }
    }
}
