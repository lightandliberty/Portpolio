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
    public partial class DrawingPensForm : Form
    {
        public DrawingPensForm()
        {
            InitializeComponent();
        }

        private void DrawingPensForm_Load(object sender, EventArgs e)
        {
            LineCapsForm lineCapsForm = new LineCapsForm();
            lineCapsForm.ShowDialog();
        }

        private void DrawLineCapsBtn_Click(object sender, EventArgs e)
        {

        }

        private void CancelMetalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okMetalBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
