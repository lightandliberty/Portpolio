using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// UserControl을 : Form으로 바꿈
namespace DrawingProject_Dll
{
    public partial class DrawingMain: Form
    {
        public DrawingMain()
        {
            InitializeComponent();
        }

        private void BasicDrawingMetalBtn_MouseEnter(object sender, EventArgs e)
        {
            instructionTextBox.Text = "그리기 객체 얻기, 화면에 그리기, 그리기 객체 해제" +
                "\r\n";
        }

        private void BasicDrawingMetalBtn_Click(object sender, EventArgs e)
        {
            BasicDrawingForm basicDrawingForm = new BasicDrawingForm();
            basicDrawingForm.ShowDialog();
        }

        private void 종료ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelMetalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkMetalBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
