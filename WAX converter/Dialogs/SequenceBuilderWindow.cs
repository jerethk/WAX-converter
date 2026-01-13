using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAX_converter
{
    public partial class SequenceBuilderWindow : Form
    {
        private List<Bitmap> ImageList;
        private List<Frame> FrameList;
        private Sequence Sequence;
        
        private int[] frameIndexes;
        private BindingSource seqFramesBindingSource;
        
        public SequenceBuilderWindow(List<Bitmap> images, List<Frame> frames, Sequence seq)
        {
            InitializeComponent();

            this.ImageList = images;
            this.FrameList = frames;
            this.Sequence = seq;

            this.frameIndexes = new int[32];
            for (int i = 0; i < 32; i++)
            {
                this.frameIndexes[i] = this.Sequence.frameIndexes[i];
            }

            this.seqFramesBindingSource = new BindingSource(this.frameIndexes, "");
        }

        private void SequenceBuilderWindow_Load(object sender, EventArgs e)
        {
            for (int f = 0; f < this.FrameList.Count; f++)
            {
                listBoxFrames.Items.Add(f.ToString());
            }

            listBoxSeqFrames.DataSource = this.seqFramesBindingSource;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Sequence.frameIndexes = this.frameIndexes;
            this.Close();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void checkBoxZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxZoom.Checked)
            {
                displayBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                displayBox.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        // ListBox controls ----------------------------------------------------------------------------

        private void listBoxSeqFrames_Enter(object sender, EventArgs e)
        {
            // Turn off multi-select in Frame listbox
            listBoxFrames.SelectionMode = SelectionMode.One;
        }

        private void listBoxFrames_Enter(object sender, EventArgs e)
        {
            // Turn ON multi-select in Frame listbox
            listBoxFrames.SelectionMode = SelectionMode.MultiExtended;
        }

        private void listBoxFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxFrames.SelectedIndex;

            if (index >= 0)
            {
                int cellIndex = FrameList[index].CellIndex;

                var img = new Bitmap(ImageList[cellIndex]);
                if (FrameList[index].Flip == 1)
                {
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                }
                displayBox.Image = img;
            }
            else
            {
                displayBox.Image = null;
            }
        }

        private void listBoxSeqFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxSeqFrames.SelectedIndex;

            if (index >= 0)
            {
                listBoxFrames.SelectedIndex = this.frameIndexes[index];
            }
        }

        // Edit buttons ----------------------------------------------------------------------------

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBoxFrames.SelectedIndex >= 0)
            {
                // find the first empty frame in sequence
                int startPosition = Array.IndexOf(this.frameIndexes, -1);
                if (startPosition == -1)
                {
                    MessageBox.Show("Your sequence already has the maximum number of frames (32).", "Unable to add frames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                    
                // Add the selected frames
                int nextPosition = startPosition;
                foreach (int i in listBoxFrames.SelectedIndices)
                {
                    this.frameIndexes[nextPosition] = i;
                    nextPosition += 1;

                    if (nextPosition == 32) break;
                }

                this.seqFramesBindingSource.ResetBindings(false);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = listBoxSeqFrames.SelectedIndex;
            int frameNumber = this.frameIndexes[index];
            
            if (frameNumber >= 0)
            {
                var answer = MessageBox.Show($"Are you sure you want to remove frame {frameNumber} from the sequence?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    // shift subsequent frames up
                    for (int i = index; i < 32; i++)
                    {
                        if (i == 31)
                        {
                            this.frameIndexes[i] = -1;
                        }
                        else
                        {
                            this.frameIndexes[i] = this.frameIndexes[i + 1];
                        }
                    }

                    this.seqFramesBindingSource.ResetBindings(false);
                }
            }
        }

        private void btnClearSeq_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure you want to clear this entire sequence?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                for (int i = 0; i < 32; i++)
                {
                    this.frameIndexes[i] = -1;
                }

                this.seqFramesBindingSource.ResetBindings(false);
            }
        }

    }
}
