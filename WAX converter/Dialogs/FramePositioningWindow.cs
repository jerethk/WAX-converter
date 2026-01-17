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
        private static readonly Pen RedPen = new(Color.FromArgb(128, 255, 0, 0));

        private List<Bitmap> cells;
        private List<Frame> frameList;
        private List<Frame> backupFrameList;
        private int centreX;
        private int centreY;
        private float scaleFactor = 1.0f;

        public FramePositioningWindow(List<Frame> frames, List<Bitmap> images, Color transparentColour)
        {
            InitializeComponent();

            this.frameList = frames;
            this.cells = MakeCellsTransparent(images, transparentColour).ToList();

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

            this.comboBoxZoom.SelectedIndex = 0;
        }

        private void FramePositioningWindow_Load(object sender, EventArgs e)
        {
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;

            for (int f = 0; f < this.frameList.Count; f++)
            {
                listBoxFrames.Items.Add(f.ToString());
            }

            if (this.frameList.Count == 1)
            {
                btnSetAll.Enabled = false;
            }

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(groupBoxAutoPosition, "Automatically calculate offsets based on image dimensions.");
        }

        private void FramePositioningWindow_Shown(object sender, EventArgs e)
        {
            if (this.frameList.Count > 0)
            {
                this.listBoxFrames.SelectedIndex = 0;
            }
        }

        public static IEnumerable<Bitmap> MakeCellsTransparent(List<Bitmap> images, Color transparentColour)
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
                this.pictureBox.Invalidate();
            }
        }

        private void comboBoxZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.scaleFactor = this.comboBoxZoom.SelectedIndex switch
            {
                0 => 1.0f,
                1 => 2.0f,
                2 => 3.0f,
                3 => 4.0f,
                _ => 1.0f,
            };

            this.pictureBox.Invalidate();
        }

        private void numericInsertX_ValueChanged(object sender, EventArgs e)
        {
            var i = listBoxFrames.SelectedIndex;

            if (i >= 0)
            {
                this.frameList[i].InsertX = (int)numericInsertX.Value;
                this.pictureBox.Invalidate();
            }
        }

        private void numericInsertY_ValueChanged(object sender, EventArgs e)
        {
            var i = listBoxFrames.SelectedIndex;

            if (i >= 0)
            {
                this.frameList[i].InsertY = (int)numericInsertY.Value;
                this.pictureBox.Invalidate();
            }
        }

        private void DrawFrame(Graphics graphics)
        {
            if (this.listBoxFrames.SelectedIndex < 0)
            {
                return;
            }

            graphics.Clear(Color.LightGray);

            var frame = this.frameList[listBoxFrames.SelectedIndex];
            var image = new Bitmap(this.cells[frame.CellIndex]);
            if (frame.Flip == 1)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }

            var xOrigin = this.centreX + frame.InsertX * this.scaleFactor;
            var yOrigin = this.centreY + frame.InsertY * this.scaleFactor;
            graphics.DrawImage(image, xOrigin, yOrigin, image.Width * this.scaleFactor, image.Height * this.scaleFactor);

            var xAxisLeft = new Point(0, this.centreY);
            var XAxisRight = new Point(pictureBox.Width, this.centreY);
            var yAxisTop = new Point(this.centreX, 0);
            var yAxisBot = new Point(this.centreX, pictureBox.Height);
            graphics.DrawLine(RedPen, xAxisLeft, XAxisRight);
            graphics.DrawLine(RedPen, yAxisTop, yAxisBot);
        }

        private void checkBoxAutoX_CheckedChanged(object sender, EventArgs e)
        {
            this.numXOff.Enabled = checkBoxAutoX.Checked;
        }

        private void checkBoxAutoY_CheckedChanged(object sender, EventArgs e)
        {
            this.numYOff.Enabled = checkBoxAutoY.Checked;
        }

        private void btnSetCurrent_Click(object sender, EventArgs e)
        {
            if (listBoxFrames.SelectedIndex < 0)
            {
                return;
            }

            var frame = this.frameList[listBoxFrames.SelectedIndex];
            var cell = this.cells[frame.CellIndex];
            var (insertX, insertY) = GetAutoPosition(cell.Width, cell.Height, this.numXOff.Value, this.numYOff.Value);

            if (checkBoxAutoX.Checked)
            {
                frame.InsertX = insertX;
                this.numericInsertX.Value = frame.InsertX;
            }

            if (checkBoxAutoY.Checked)
            {
                frame.InsertY = insertY;
                this.numericInsertY.Value = frame.InsertY;
            }
        }

        private void btnSetAll_Click(object sender, EventArgs e)
        {
            if (this.frameList.Count == 0)
            {
                return;
            }

            foreach (var frame in frameList)
            {
                var cell = this.cells[frame.CellIndex];
                var (insertX, insertY) = GetAutoPosition(cell.Width, cell.Height, this.numXOff.Value, this.numYOff.Value);

                if (checkBoxAutoX.Checked)
                {
                    frame.InsertX = insertX;
                }

                if (checkBoxAutoY.Checked)
                {
                    frame.InsertY = insertY;
                }
            }

            if (listBoxFrames.SelectedIndex >= 0)
            {
                this.numericInsertX.Value = this.frameList[listBoxFrames.SelectedIndex].InsertX;
                this.numericInsertY.Value = this.frameList[listBoxFrames.SelectedIndex].InsertY;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DisposeBitmaps();
            this.Close();
            this.Dispose();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < this.frameList.Count; f++)
            {
                this.frameList[f] = this.backupFrameList[f];
            }

            DisposeBitmaps();
            this.Close();
            this.Dispose();
        }

        private void DisposeBitmaps()
        {
            foreach (var img in this.cells)
            {
                img.Dispose();
            }
        }

        private void PictureBox_Resize(object sender, EventArgs e)
        {
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;
            this.pictureBox.Invalidate();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (this.listBoxFrames.SelectedIndex >= 0)
            {
                this.DrawFrame(e.Graphics);
            }
        }

        private static (int, int) GetAutoPosition(int frameWidth, int frameHeight, decimal xOffsetPercent, decimal yOffsetPercent)
        {
            var x = Convert.ToInt32(frameWidth * -(xOffsetPercent / 100));
            var y = Convert.ToInt32(frameHeight * (yOffsetPercent / 100 - 1));
            return (x, y);
        }
    }
}
