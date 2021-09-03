using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicProperties_dll
{
    public partial class StandardWindow : Form
    {
        public StandardWindow()
        {
            InitializeComponent();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("포트폴리오 2021 v1.0");
        }

        private void StandardWindow_Load(object sender, EventArgs e)
        {
        }
    }
}
