using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace DrawingProject_Dll
{
    public class Path : System.Windows.Forms.Form
    {
        #region Windows Form Designer generated code
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.instructionLbl = new System.Windows.Forms.Label();
            this.drawPathBtn = new CustomControls_dll.MetalButton();
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(5, 290);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(177, 12);
            this.instructionLbl.TabIndex = 32;
            this.instructionLbl.Text = "장력에 따른 곡선의 변화를 그림";
            // 
            // drawPathBtn
            // 
            this.drawPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPathBtn.Location = new System.Drawing.Point(183, 279);
            this.drawPathBtn.Name = "drawPathBtn";
            this.drawPathBtn.Size = new System.Drawing.Size(143, 39);
            this.drawPathBtn.TabIndex = 31;
            this.drawPathBtn.Text = "Draw Path";
            this.drawPathBtn.UseVisualStyleBackColor = true;
            this.drawPathBtn.Click += new System.EventHandler(this.drawPathBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(12, 226);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(0, 0);
            this.closeBtn.TabIndex = 30;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // Path
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(334, 326);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.drawPathBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "Path";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Path";
            this.Load += new System.EventHandler(this.Path_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Path_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Path_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Path_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label instructionLbl;
        private CustomControls_dll.MetalButton drawPathBtn;
        private CustomControls_dll.MetalButton closeBtn;
        #endregion  Windows Form Designer generated code. 끝.


        // 생성자
        public Path()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }


        private void Path_Load(object sender, EventArgs e)
        {

        }

        public Rectangle rect;
        public void InitRects()
        {
            int x = 10;
            int y = 10;
            int width = this.ClientSize.Width-20;
            int height = this.ClientSize.Height - 100; // 아래 여백 -100
            rect = new Rectangle(x, y, width, height);
        }

        private void drawPathBtn_Click(object sender, EventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정

            Graphics g = this.CreateGraphics();

            using (GraphicsPath path = GetRoundedRectPath(rect, Width / 5)) 
            {
                g.FillPath(Brushes.Yellow, path);
                g.DrawPath(Pens.Black, path);
                this.FormBorderStyle = FormBorderStyle.None;
                this.Region = new Region(path);
            }

            this.Paint -= PathForm_Paint;
            this.Paint += PathForm_Paint;
        }

        private void PathForm_Paint(object sender, PaintEventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정

            Graphics g = this.CreateGraphics();

            using (GraphicsPath path = GetRoundedRectPath(rect, Width / 5))
            {
                g.FillPath(Brushes.Yellow, path);
                g.DrawPath(Pens.Black, path);
                this.Region = new Region(path);

            }
        }

        GraphicsPath GetRoundedRectPath(Rectangle rect, int radius) // 사각형과 반지름
        {
            Rectangle arcRect = new Rectangle(rect.Location, new Size(radius, radius));
            GraphicsPath path = new GraphicsPath();
            path.AddArc(arcRect, 180, 90);      // arcRect크기와 위치로, 시계 방향으로 180도 회전후, 90도만큼 쓸음.
            arcRect.X = rect.Right - radius;  // 호의 윤곽을 나타낼 사각형의 X좌표 위치를 오른쪽에서 지름 길이만큼 뺌.(반지름만큼 빼는 게 아니네?)
            path.AddArc(arcRect, 270, 90);
            arcRect.Y = rect.Bottom - radius;
            path.AddArc(arcRect, 0, 90);
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }

        Point beforeClicked;

        private void Path_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            beforeClicked = new Point(e.X, e.Y);
        }

        private void Path_MouseMove(object sender, MouseEventArgs e)
        {
            if (beforeClicked == Point.Empty)
                return;
            // 현재 위치 - 이전에 클릭했던 위치 = 움직인 위치가 되고, 마우스가 계속 눌려 있으므로, 현재 위치는 다시 이전 위치가 되므로, 창이 움직임
            this.Location = new Point(this.Left + e.X - beforeClicked.X, this.Top + e.Y - beforeClicked.Y);
        }

        private void Path_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            beforeClicked = Point.Empty;
        }
    }
}