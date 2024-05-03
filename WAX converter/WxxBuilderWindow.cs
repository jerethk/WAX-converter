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
    public partial class WxxBuilderWindow : Form
    {
        private List<Bitmap> waxImages = new();

        public WxxBuilderWindow(Waxfile wax)
        {
            InitializeComponent();

            this.Setup(wax);
        }

        private void Setup(Waxfile wax)
        {
            if (wax == null)
            {
                return;
            }
            
            wax.ProcessCellsInOrderOfReference((cell, imageCount) =>
            {
                this.waxImages.Add(cell.bitmap);
            });
        }
    }
}
