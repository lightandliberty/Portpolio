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
    public partial class DrawFigure_MainForm : Form
    {
        public DrawFigure_MainForm()
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

        private void drawFigureBtn_Click(object sender, EventArgs e)
        {
            (new Shapes()).ShowDialog();
        }

        private void drawCurveBtn_Click(object sender, EventArgs e)
        {
            (new Curves()).ShowDialog();
        }

        private void drawBeziersBtn_Click(object sender, EventArgs e)
        {
            (new Beziers()).ShowDialog();
        }

        private void drawSmoothingModesBtn_Click(object sender, EventArgs e)
        {
            (new SmoothingModes()).ShowDialog();
        }

        private void drawPathBtn_Click(object sender, EventArgs e)
        {
            (new Path()).ShowDialog();
        }

        private void drawPath2_Click(object sender, EventArgs e)
        {
            (new Path2()).ShowDialog();
        }
    }
}
