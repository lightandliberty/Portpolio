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
    public partial class TransparentForm : Form
    {
        public TransparentForm()
        {
            InitializeComponent();
            //this.TransparencyKey = System.Drawing.SystemColors.Control; // 디자이너 모드의 속성에서 직접 설정해 주었음

        }

        // 폼을 다시 그려야 할 때 발생
        private void TransparentForm_Paint(object sender, PaintEventArgs e)
        {
            //System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Brown);
            //System.Drawing.Graphics formGraphics;
            //formGraphics = this.CreateGraphics();
            //formGraphics.FillEllipse(myBrush, new Rectangle(0, 0, this.ClientSize.Width / 2, this.ClientSize.Height / 2));
            //formGraphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Blue), new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            //// Brush, Graphics 객체는 항상 Dispose()해주는 게 좋음.(MSDN에서 추천)
            ////            formGraphics.DrawEllipse(System.Drawing.Pens.Black, new Rectangle(0, 0, 150, 100));
            //myBrush.Dispose();
            //formGraphics.Dispose();
        }

        private void TransparentForm_Load(object sender, EventArgs e)
        {
            // 폼이 로드될 때 구역(region)을 다시 설정.
            SetEllipseRegion();
        }

        private void TransparentForm_SizeChanged(object sender, EventArgs e)
        {
            // 폼의 크기가 변경될 때, 구역(region)을 다시 설정.
            SetEllipseRegion();
        }

        void SetEllipseRegion()
        {
            // FormBorderStyle속성이 None으로 설정되어 있다고 가정한다.
            Rectangle rect = this.ClientRectangle;
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddEllipse(rect);  // 현재 경로에 타원을 추가합니다.
                this.Region = new Region(path);     // 타원 영역을 구역으로 직접 설정
            }
        }

        public Point downPoint = Point.Empty;       // 누른 마우스의 좌표

        private void TransparentForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return; // 왼쪽 버튼을 누른 게 아니면, 종료
            downPoint = new Point(e.X, e.Y); // 현재 마우스의 X, Y좌표를 downPoint에 설정함.

        }

        private void TransparentForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty) return;
            // 이동한 후의 위치 = 이동한 포인터의 위치 + 폼의 왼쪽 경계선 위치.(이동한 거리 + 폼의 왼쪽 위 좌표)
            Point location = new Point(this.Left + e.X - downPoint.X, this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        private void TransparentForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = Point.Empty;
        }

        private void TransparentForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
