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
    public partial class DrawDashesForm : Form
    {
        public DrawDashesForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawDashesForm_Load(object sender, EventArgs e)
        {

        }

        private void DrawDashesForm_Shown(object sender, EventArgs e)
        {
            DrawDashes(this.CreateGraphics());
        }

        private void DrawDashes(Graphics g)
        {
            using (Pen pen = new Pen(Color.Black, 12))
            {
                int x = 20;
                int y = 20;
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                // 늘어나는 대시 길이와 일정한 공간 크기
                pen.DashPattern = new float[] { 1f, 1f, 2f, 1f, 3f, 1f, 4f, 1f, };
                g.DrawLine(
                    pen, x, y, x + Width / 2 - 20, y);
                
            }
        }

    }
}
