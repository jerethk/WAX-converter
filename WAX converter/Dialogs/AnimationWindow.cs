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

        private Frame currentFrame;
        private int frameRate = 1;
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
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;
            numericFrameRate.Value = this.action.FrameRate;
        }

        private void AnimationWindow_Shown(object sender, EventArgs e)
        {
            this.DrawFirstFrame();
        }

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;

            this.pictureBox.Invalidate();
        }

        private void numericView_ValueChanged(object sender, EventArgs e)
        {
            if (this.isPlaying || this.isLooping)
            {
                return;
            }

            this.DrawFirstFrame();
        }

        private void DrawFirstFrame()
        {
            var sequence = this.sequences[this.action.seqIndexes[(int)numericView.Value]];
            var frameIndex = sequence.frameIndexes[0];

            if (frameIndex >= 0)
            {
                this.currentFrame = this.frames[frameIndex];
                this.pictureBox.Invalidate();
            }
        }

        // ------------------------------------------------------------------------------------------------------------------------------

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            if (!this.isPlaying && !this.isLooping)
            {
                this.isPlaying = true;
                await this.PlayAnimation();
                this.isPlaying = false;
                this.DrawFirstFrame();
            }
        }

        private async Task PlayAnimation()
        {
            var sequence = this.sequences[this.action.seqIndexes[(int)numericView.Value]];
            var numFrames = Array.FindIndex(sequence.frameIndexes, i => i == -1);

            await Task.Run(() =>
            {
                for (int f = 0; f < numFrames; f++)
                {
                    this.UpdateFrame(sequence.frameIndexes[f]);
                }
            });
        }

        private void UpdateFrame(int frameIndex)
        {
            this.currentFrame = this.frames[frameIndex];
            this.pictureBox.Invalidate();
            Thread.Sleep(1000 / this.frameRate);
        }

        private async void btnLoop_Click(object sender, EventArgs e)
        {
            if (!this.isPlaying)
            {
                if (!this.isLooping)
                {
                    this.isLooping = true;
                    btnLoop.Text = "Stop";
                    btnPlay.Enabled = false;
                    numericView.Enabled = false;
                    numericFrameRate.Enabled = false;
                    await this.LoopAnimation();
                }
                else
                {
                    this.isLooping = false;
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

            await Task.Run(() =>
            {
                int f = 0;

                while (this.isLooping)
                {
                    this.UpdateFrame(sequence.frameIndexes[f]);
                    f++;
                    if (f == numFrames) f = 0;
                }
            });

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            var scaleFactor = this.isHiRes ? 2 : 1;
            var positionX = this.centreX + this.currentFrame.InsertX * scaleFactor;
            var positionY = this.centreY + this.currentFrame.InsertY * scaleFactor;
            var imageToDraw = new Bitmap(this.images[this.currentFrame.CellIndex]);
            if (this.currentFrame.Flip == 1) imageToDraw.RotateFlip(RotateFlipType.RotateNoneFlipX);

            e.Graphics.Clear(Color.LightGray);
            e.Graphics.DrawImage(imageToDraw, new Point(positionX, positionY));
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
            this.DisposeBitmaps();
            this.Close();
            this.Dispose();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.DisposeBitmaps();
            this.Close();
            this.Dispose();
        }

        private void DisposeBitmaps()
        {
            foreach (var img in this.images)
            {
                img.Dispose();
            }
        }
    }
}
