using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
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
        private Action action;
        private List<Sequence> sequences;
        private List<Frame> frames;
        private List<Bitmap> images;
        private Graphics graphics;
        private int centreX;
        private int centreY;
        private bool isPlaying;
        private bool isLooping;

        public AnimationWindow(Action action, List<Sequence> sequences, List<Frame> frames, List<Bitmap> images, Color transparentColour)
        {
            InitializeComponent();

            this.action = action;
            this.sequences = sequences;
            this.frames = frames;
            this.images = FramePositioningWindow.makeCellsTransparent(images, transparentColour).ToList();
        }

        private void AnimationWindow_Load(object sender, EventArgs e)
        {
            this.graphics = pictureBox.CreateGraphics();
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;
            numericFrameRate.Value = this.action.FrameRate;

            drawFirstFrame();
        }

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            this.graphics.Dispose();
            this.graphics = pictureBox.CreateGraphics();
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;

            drawFirstFrame();
        }

        private void numericView_ValueChanged(object sender, EventArgs e)
        {
            drawFirstFrame();
        }

        private void drawFirstFrame()
        {
            var sequence = this.sequences[this.action.seqIndexes[(int)numericView.Value]];
            var frameIndex = sequence.frameIndexes[0];

            if (frameIndex >= 0)
            {
                var frame = this.frames[frameIndex];
                var positionX = this.centreX + frame.InsertX;
                var positionY = this.centreY + frame.InsertY;
                var imageToDraw = new Bitmap(this.images[frame.CellIndex]);
                if (frame.Flip == 1) imageToDraw.RotateFlip(RotateFlipType.RotateNoneFlipX);

                graphics.Clear(Color.LightGray);
                graphics.DrawImage(imageToDraw, new Point(positionX, positionY));
            }

        }

        // ------------------------------------------------------------------------------------------------------------------------------
        
        private async void btnPlay_Click(object sender, EventArgs e)
        {
            await PlayAnimation();
        }

        private async Task PlayAnimation()
        {
            var sequence = this.sequences[this.action.seqIndexes[(int)numericView.Value]];
            var numFrames = Array.FindIndex(sequence.frameIndexes, i => i == -1);
            var frameRate = this.action.FrameRate;

            await Task.Run(() =>
            {
                for (int f = 0; f < numFrames; f++)
                {
                    var frame = this.frames[sequence.frameIndexes[f]];
                    var positionX = this.centreX + frame.InsertX;
                    var positionY = this.centreY + frame.InsertY;
                    var imageToDraw = new Bitmap(this.images[frame.CellIndex]);
                    if (frame.Flip == 1) imageToDraw.RotateFlip(RotateFlipType.RotateNoneFlipX);

                    graphics.Clear(Color.LightGray);
                    graphics.DrawImage(imageToDraw, new Point(positionX, positionY));
                    Thread.Sleep(1000 / frameRate);
                }
            });
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {

        }

        private void numericFrameRate_ValueChanged(object sender, EventArgs e)
        {
            this.action.FrameRate = (int)numericFrameRate.Value;
        }

    }
}
