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
    public class Path2 : System.Windows.Forms.Form
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
            this.drawPath2Btn = new CustomControls_dll.MetalButton();
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.drawBezierBtn = new CustomControls_dll.MetalButton();
            this.drawFillModeAlternateBtn = new CustomControls_dll.MetalButton();
            this.drawFillModeWindingBtn = new CustomControls_dll.MetalButton();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(12, 267);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(0, 12);
            this.instructionLbl.TabIndex = 32;
            // 
            // drawPath2Btn
            // 
            this.drawPath2Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPath2Btn.Location = new System.Drawing.Point(118, 295);
            this.drawPath2Btn.Name = "drawPath2Btn";
            this.drawPath2Btn.Size = new System.Drawing.Size(99, 28);
            this.drawPath2Btn.TabIndex = 31;
            this.drawPath2Btn.Text = "Draw Path2";
            this.drawPath2Btn.UseVisualStyleBackColor = true;
            this.drawPath2Btn.Click += new System.EventHandler(this.drawPath2Btn_Click);
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
            // drawBezierBtn
            // 
            this.drawBezierBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawBezierBtn.Location = new System.Drawing.Point(223, 295);
            this.drawBezierBtn.Name = "drawBezierBtn";
            this.drawBezierBtn.Size = new System.Drawing.Size(99, 28);
            this.drawBezierBtn.TabIndex = 33;
            this.drawBezierBtn.Text = "Draw Bezier";
            this.drawBezierBtn.UseVisualStyleBackColor = true;
            this.drawBezierBtn.Click += new System.EventHandler(this.drawBezierBtn_Click);
            // 
            // drawFillModeAlternateBtn
            // 
            this.drawFillModeAlternateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawFillModeAlternateBtn.Location = new System.Drawing.Point(118, 329);
            this.drawFillModeAlternateBtn.Name = "drawFillModeAlternateBtn";
            this.drawFillModeAlternateBtn.Size = new System.Drawing.Size(99, 36);
            this.drawFillModeAlternateBtn.TabIndex = 34;
            this.drawFillModeAlternateBtn.Text = "Draw FillMode Alternate";
            this.drawFillModeAlternateBtn.UseVisualStyleBackColor = true;
            this.drawFillModeAlternateBtn.Click += new System.EventHandler(this.drawFillModeAlternateBtn_Click);
            // 
            // drawFillModeWindingBtn
            // 
            this.drawFillModeWindingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawFillModeWindingBtn.Location = new System.Drawing.Point(223, 329);
            this.drawFillModeWindingBtn.Name = "drawFillModeWindingBtn";
            this.drawFillModeWindingBtn.Size = new System.Drawing.Size(99, 36);
            this.drawFillModeWindingBtn.TabIndex = 35;
            this.drawFillModeWindingBtn.Text = "Draw FillMode Winding";
            this.drawFillModeWindingBtn.UseVisualStyleBackColor = true;
            this.drawFillModeWindingBtn.Click += new System.EventHandler(this.drawFillModeWindingBtn_Click);
            // 
            // Path2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(334, 369);
            this.Controls.Add(this.drawFillModeWindingBtn);
            this.Controls.Add(this.drawFillModeAlternateBtn);
            this.Controls.Add(this.drawBezierBtn);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.drawPath2Btn);
            this.Controls.Add(this.closeBtn);
            this.Name = "Path2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Path2";
            this.Load += new System.EventHandler(this.Path2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label instructionLbl;
        private CustomControls_dll.MetalButton drawPath2Btn;
        private CustomControls_dll.MetalButton drawBezierBtn;
        private CustomControls_dll.MetalButton drawFillModeAlternateBtn;
        private CustomControls_dll.MetalButton drawFillModeWindingBtn;
        private CustomControls_dll.MetalButton closeBtn;
        #endregion  Windows Form Designer generated code. 끝.


        // 생성자
        public Path2()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }


        private void Path2_Load(object sender, EventArgs e)
        {

        }

        public Rectangle rect;
        public void InitRect()
        {
            int x = 10;
            int y = 10;
            int width = this.ClientSize.Width - 20;
            int height = this.ClientSize.Height - 120; // 아래 여백 -120
            rect = new Rectangle(x, y, width, height);
        }

        public void InitHorizontalRect()
        {
            int x = 10;
            int y = (this.ClientRectangle.Height - 120)/2;
            int width = this.ClientSize.Width - 20;
            int height = (this.ClientSize.Height - 120) /2/2; // (아래 여백 -115 ) / 2
            rect = new Rectangle(x, y, width, height);
        }

        private void drawPath2Btn_Click(object sender, EventArgs e)
        {
            instructionLbl.Text = "피겨를 닫지 않고,\r\n새 피겨를 그렸을 때의 모습";
            InitRect(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정

            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            using (GraphicsPath path = GetExamplePath(rect, Width / 5))
            {
                g.FillPath(Brushes.Yellow, path);
                g.DrawPath(Pens.Black, path);
            }

            this.Paint -= Path2Form_Paint;
            this.Paint += Path2Form_Paint;
        }

        private void Path2Form_Paint(object sender, PaintEventArgs e)
        {
        }


        GraphicsPath GetExamplePath(Rectangle rect, int radius)
        {
            Rectangle arcRect = new Rectangle(rect.Location, new Size(radius, radius));
            GraphicsPath path = new GraphicsPath();
            path.AddArc(arcRect, 180, 90);
            arcRect.X = rect.Right - radius;
            path.AddArc(arcRect, 270, 90);
            path.StartFigure();
            arcRect.Y = rect.Bottom - radius;
            path.AddArc(arcRect, 0, 90);
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
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

        GraphicsPath GetClosedBezierPath(Rectangle rect, Point[] points)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddBeziers(points);
            path.CloseFigure();
            return path;
        }

        private void drawBezierBtn_Click(object sender, EventArgs e)
        {
            instructionLbl.Text = "닫힌 베지어 곡선 생성";

            InitRect(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정

            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            using (
            GraphicsPath path = GetClosedBezierPath(rect, new Point[4] {
                new Point(20,20),
                new Point(this.ClientRectangle.Width - 20, 20),
                new Point(20,this.ClientRectangle.Height - 120),
                new Point(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 100),
                }))
            {
                g.FillPath(Brushes.Yellow, path);
                g.DrawPath(Pens.Black, path);
            }
        }

        private void drawFillModeAlternateBtn_Click(object sender, EventArgs e)
        {
            instructionLbl.Text = "피겨를 중복시켜 가운데 부분을 잘라냄";
            InitHorizontalRect();
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            using (GraphicsPath path = GetDonutPath(rect, rect.Width / 4))
            {
                path.FillMode = FillMode.Alternate;
                g.FillPath(Brushes.Yellow, path);
                g.DrawPath(Pens.Black, path);
            }
        }

        GraphicsPath GetDonutPath(Rectangle rect, int holeRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            Point centerPoint = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            Rectangle holeRect = new Rectangle(centerPoint.X - holeRadius, centerPoint.Y - holeRadius, holeRadius * 2, holeRadius * 2);
            path.StartFigure();
            path.AddEllipse(holeRect);
            return path;
        }

        private void drawFillModeWindingBtn_Click(object sender, EventArgs e)
        {
            instructionLbl.Text = "중복된 가운데 부분을 칠 함";
            InitHorizontalRect();

            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            using (GraphicsPath path = GetCrossDonutPath(rect, rect.Width / 4))
            {
                path.FillMode = FillMode.Winding;
                g.FillPath(Brushes.Yellow, path);
                g.DrawPath(Pens.Black, path);
            }
        }

        GraphicsPath GetCrossDonutPath(Rectangle rect, int holeRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            Point centerPoint = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            Rectangle holeRect = new Rectangle(centerPoint.X - holeRadius, centerPoint.Y - holeRadius, holeRadius * 2, holeRadius * 2);
            path.StartFigure();
            path.AddEllipse(holeRect);
            return path;
        }
    }
}