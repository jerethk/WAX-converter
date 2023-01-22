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
        private List<Action> actions;
        private List<Sequence> sequences;
        private List<Frame> frames;
        private List<Bitmap> images;
        private Graphics graphics;
        private int centreX;
        private int centreY;

        public AnimationWindow(List<Action> actions, List<Sequence> sequences, List<Frame> frames, List<Bitmap> images, Color transparentColour)
        {
            InitializeComponent();

            this.actions = actions;
            this.sequences = sequences;
            this.frames = frames;
            this.images = FramePositioningWindow.makeCellsTransparent(images, transparentColour).ToList();
        }

        private void AnimationWindow_Load(object sender, EventArgs e)
        {
            this.graphics = pictureBox.CreateGraphics();
            this.centreX = this.pictureBox.Width / 2;
            this.centreY = this.pictureBox.Height / 2;
        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            await PlayAnimation();
        }

        private async Task PlayAnimation()
        {
            // trial
            var sequence = this.sequences[this.actions[0].seqIndexes[0]];
            var numFrames = Array.FindIndex(sequence.frameIndexes, i => i == -1);
            MessageBox.Show($"{numFrames}");

            await Task.Run(() =>
            {
                for (int f = 0; f < numFrames; f++)
                {
                    var frame = this.frames[sequence.frameIndexes[f]];
                    pictureBox.Image = new Bitmap(this.images[frame.CellIndex]);
                    Thread.Sleep(500);
                }
            });
        }
    }
}
