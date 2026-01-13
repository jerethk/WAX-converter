using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAX_converter
{
    public partial class AnimationWindow : Form
    {
        private bool isReadOnlyMode;
        private bool isHiRes;
        private Action action;
        private List<Sequence> sequences;
        private List<Frame> frames;
        private List<Bitmap> images;
        private int frameRate = 1;
        private Graphics graphics;
        private int centreX;
        private int centreY;
        private bool isPlaying = false;
        private bool isLooping = false;

        public AnimationWindow(bool isReadOnlyMode, bool hiresMode, Action action, List<Sequence> sequences, List<Frame> frames, List<Bitmap> images, Color transparentColour)
        {
            this.action = action;
            this.sequences = sequences;
            this.frames = frames;
            this.images = FramePositioningWindow.MakeCellsTransparent(images, transparentColour).ToList();

            InitializeComponent();

            this.numericFrameRate.Enabled = !isReadOnlyMode;
            this.btnAccept.Visible = !isReadOnlyMode;
            this.btnDiscard.Text = isReadOnlyMode ? "Close" : "Discard";
            this.isReadOnlyMode = isReadOnlyMode;
            this.isHiRes = hiresMode;
        }

        private void AnimationWindow_Load(object sender, EventArgs e)
        {
            this.frameRate = action.FrameRate;
            this.graphics = pictureBox.CreateGraphics();
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;
            numericFrameRate.Value = this.action.FrameRate;
        }

        private async void AnimationWindow_Shown(object sender, EventArgs e)
        {
            await Task.Delay(100);  // a small delay is needed to make the initial draw happen
            DrawFirstFrame();
        }

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            this.graphics?.Dispose();
            this.graphics = pictureBox.CreateGraphics();
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;

            DrawFirstFrame();
        }

        private void numericView_ValueChanged(object sender, EventArgs e)
        {
            DrawFirstFrame();
        }

        private void DrawFirstFrame()
        {
            var sequence = this.sequences[this.action.seqIndexes[(int)numericView.Value]];
            var frameIndex = sequence.frameIndexes[0];
            var scaleFactor = this.isHiRes ? 2 : 1;

            if (frameIndex >= 0)
            {
                var frame = this.frames[frameIndex];
                var positionX = this.centreX + frame.InsertX * scaleFactor;
                var positionY = this.centreY + frame.InsertY * scaleFactor;
                var imageToDraw = new Bitmap(this.images[frame.CellIndex]);
                if (frame.Flip == 1) imageToDraw.RotateFlip(RotateFlipType.RotateNoneFlipX);

                graphics.Clear(Color.LightGray);
                graphics.DrawImage(imageToDraw, new Point(positionX, positionY));
            }

        }

        // ------------------------------------------------------------------------------------------------------------------------------

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            if (!isPlaying && !isLooping)
            {
                isPlaying = true;
                await PlayAnimation();
                isPlaying = false;
            }
        }

        private async Task PlayAnimation()
        {
            var sequence = this.sequences[this.action.seqIndexes[(int)numericView.Value]];
            var numFrames = Array.FindIndex(sequence.frameIndexes, i => i == -1);
            var frameRate = this.frameRate;

            await Task.Run(() =>
            {
                for (int f = 0; f < numFrames; f++)
                {
                    UpdateFrame(sequence.frameIndexes[f], frameRate);
                }
            });
        }

        private void UpdateFrame(int frameIndex, int frameRate)
        {
            var frame = this.frames[frameIndex];
            var scaleFactor = this.isHiRes ? 2 : 1;
            var positionX = this.centreX + frame.InsertX * scaleFactor;
            var positionY = this.centreY + frame.InsertY * scaleFactor;
            var imageToDraw = new Bitmap(this.images[frame.CellIndex]);
            if (frame.Flip == 1) imageToDraw.RotateFlip(RotateFlipType.RotateNoneFlipX);

            graphics.Clear(Color.LightGray);
            graphics.DrawImage(imageToDraw, new Point(positionX, positionY));
            Thread.Sleep(1000 / frameRate);
        }

        private async void btnLoop_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                if (!isLooping)
                {
                    isLooping = true;
                    btnLoop.Text = "Stop";
                    btnPlay.Enabled = false;
                    numericView.Enabled = false;
                    numericFrameRate.Enabled = false;
                    await LoopAnimation();
                }
                else
                {
                    isLooping = false;
                    btnLoop.Text = "Loop";
                    btnPlay.Enabled = true;
                    numericView.Enabled = true;
                    numericFrameRate.Enabled = !this.isReadOnlyMode;
                }
            }
        }

        private async Task LoopAnimation()
        {
            var sequence = this.sequences[this.action.seqIndexes[(int)numericView.Value]];
            var numFrames = Array.FindIndex(sequence.frameIndexes, i => i == -1);
            var frameRate = this.frameRate;

            await Task.Run(() =>
            {
                int f = 0;

                while (isLooping)
                {
                    UpdateFrame(sequence.frameIndexes[f], frameRate);
                    f++;
                    if (f == numFrames) f = 0;
                }
            });

        }

        // ------------------------------------------------------------------------------------------------------------------------------

        private void numericFrameRate_ValueChanged(object sender, EventArgs e)
        {
            if (this.isReadOnlyMode)
            {
                return;
            }

            this.frameRate = (int)numericFrameRate.Value;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.action.FrameRate = this.frameRate;
            this.Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
