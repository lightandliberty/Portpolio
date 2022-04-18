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
    }
}
