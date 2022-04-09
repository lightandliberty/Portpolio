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
    // CellPaintEvent에 연결하는 방식으로 처리
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

        // TLP에 컨트롤을 붙이려면,
        // .Add(컨트롤 이름, 열, 행) 하면 붙여 짐.

        private void tlpDashes_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            // e는 ClipRectangle 0,0,434,162를 반환
            if (e.Row == 0 || e.Row == 2 || e.Row == 4 || e.Row == 6) // Label이 위치한 경우, 아무 것도 안 함.
                return;
            using (Pen pen = new Pen(Color.Black, 12))
            {
                // 그러니까 e.CellBounds의 x,y,width,height는 tlp안에서의 좌표 및 rect크기임.
                int x = e.CellBounds.Location.X + 5; // 처음 Custom일 경우, 0, 26 , 두번째는 0,78
                int y = e.CellBounds.Location.Y + 5;

                pen.DashStyle = GetDashStyleFromTLCPaintEventArgs(e);
                //// 늘어나는 대시 길이와 일정한 공간 크기
                if(pen.DashStyle == System.Drawing.Drawing2D.DashStyle.Custom)
                    pen.DashPattern = new float[] { 1f, 1f, 2f, 1f, 3f, 1f, 4f, 1f, };
                e.Graphics.DrawLine( // e.CellBounds.Width는 217
                    pen, x, y, x+ e.CellBounds.Width - 20, y);
            }
        }

        private System.Drawing.Drawing2D.DashStyle GetDashStyleFromTLCPaintEventArgs(TableLayoutCellPaintEventArgs e)
        {
            switch(e.Row)
            {
                case 1:
                    return e.Column == 0 ? System.Drawing.Drawing2D.DashStyle.Custom : System.Drawing.Drawing2D.DashStyle.Dash;
                case 3:
                    return e.Column == 0 ? System.Drawing.Drawing2D.DashStyle.DashDot : System.Drawing.Drawing2D.DashStyle.DashDotDot;
                case 5:
                    return e.Column == 0 ? System.Drawing.Drawing2D.DashStyle.Dot : System.Drawing.Drawing2D.DashStyle.Solid;
                default:
                    return System.Drawing.Drawing2D.DashStyle.Dash;
            }
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

        public bool isAddCellPaintEvent = false;
        private void drawDashesBtn_Click(object sender, EventArgs e)
        {
            if (isAddCellPaintEvent)
            {
                this.tlpDashes.CellPaint -= new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpDashes_CellPaint);
                isAddCellPaintEvent = false;
            }
            else
            {
                this.tlpDashes.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpDashes_CellPaint);
                isAddCellPaintEvent = true;
            }
            tlpDashes.Invalidate();

        }
    }
}
