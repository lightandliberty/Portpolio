using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingProject_Dll
{
    public partial class DrawImage_MainForm : Form
    {
        public DrawImage_MainForm()
        {
            InitializeComponent();
        }

        private void CancelMetalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okMetalBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void drawScalingClippingBtn_Click(object sender, EventArgs e)
        {
            (new ScalingVsClipping()).ShowDialog();
        }

        private void drawPanningBtn_Click(object sender, EventArgs e)
        {
            (new Panning()).ShowDialog();
        }

        private void drawSkewingBtn_Click(object sender, EventArgs e)
        {
            (new Skewing()).ShowDialog();
        }

        private void drawRotatingFlippingBtn_Click(object sender, EventArgs e)
        {
            (new RotatingFlipping()).ShowDialog();
        }

        private void drawRecoloringBtn_Click(object sender, EventArgs e)
        {
            (new Recoloring()).ShowDialog();
        }
    }
}
