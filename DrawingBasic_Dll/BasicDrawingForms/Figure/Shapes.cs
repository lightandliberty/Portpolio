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
    public class Shapes : System.Windows.Forms.Form
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
            this.drawFiguresBtn = new CustomControls_dll.MetalButton();
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(10, 290);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(109, 12);
            this.instructionLbl.TabIndex = 32;
            this.instructionLbl.Text = "기본 도형들을 그림";
            // 
            // drawFiguresBtn
            // 
            this.drawFiguresBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawFiguresBtn.Location = new System.Drawing.Point(235, 290);
            this.drawFiguresBtn.Name = "drawFiguresBtn";
            this.drawFiguresBtn.Size = new System.Drawing.Size(91, 28);
            this.drawFiguresBtn.TabIndex = 31;
            this.drawFiguresBtn.Text = "Draw Figure";
            this.drawFiguresBtn.UseVisualStyleBackColor = true;
            this.drawFiguresBtn.Click += new System.EventHandler(this.drawFiguresBtn_Click);
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
            // Shapes
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(334, 326);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.drawFiguresBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "Shapes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shapes";
            this.Load += new System.EventHandler(this.Shapes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label instructionLbl;
        private CustomControls_dll.MetalButton drawFiguresBtn;
        private CustomControls_dll.MetalButton closeBtn;
        #endregion  Windows Form Designer generated code. 끝.


        // 생성자
        public Shapes()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }


        private void Shapes_Load(object sender, EventArgs e)
        {
            rects = new Rectangle[9];
            rectNames = new string[9]
            {
                "Arc", "Bezier", "Closed Curve", "Curve", "Ellipse", "Lines", "Pie", "Polygon", "Rectangle"
            };

        }
        
        public Rectangle[] rects;
        public string[] rectNames;
        public void InitRects()
        {
            int x = 20;
            int y = 30;
            int width = (this.ClientSize.Width-40-20) / 3; // 좌,우 -10 씩, 사각형 사이 -10 씩
            int height = (this.ClientSize.Height-100-40) / 3; // 아래 여백 -80, 사각형 사이 -20 씩
            for (int i = 0; i < rects.Length; i++)
            {
                rects[i] = new Rectangle(x, y, width, height);
                x += width+10;
                if (x > this.ClientRectangle.Size.Width - width)
                {
                    x = 20;
                    y += height+20;
                }
            }
        }

        private void drawFiguresBtn_Click(object sender, EventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
            Graphics g = this.CreateGraphics();
            using (Pen pen = new Pen(Color.Black, 5))
            {
                using (Brush brush = new SolidBrush(Color.Pink))
                {
                    StringFormat sFormat = new StringFormat();
                    sFormat.Alignment = StringAlignment.Center;
                    sFormat.LineAlignment = StringAlignment.Center;
                    g.DrawArc(pen, rects[0], 180, 180);
                    Point[] points = GetCurvePoints(rects, 1);
                    g.DrawBeziers(pen, points);
                    Point[] closedCurvePs = GetCurvePoints(rects, 2);
                    g.FillClosedCurve(brush, closedCurvePs);
                    g.DrawClosedCurve(pen, closedCurvePs);
                    Point[] curvePs = GetCurvePoints(rects, 3);
                    g.DrawCurve(pen, curvePs);
                    g.FillEllipse(brush, rects[4]);
                    g.DrawEllipse(pen, rects[4]);
                    Point[] linesPs = GetCurvePoints(rects, 5);
                    g.DrawLines(pen, linesPs);
                    g.FillPie(brush, rects[6], 180, 180);
                    g.DrawPie(pen, rects[6], 180, 180);
                    Point[] polygonPs = GetCurvePoints(rects, 7);
                    g.FillPolygon(brush, polygonPs);
                    g.DrawPolygon(pen, polygonPs);
                    g.FillRectangle(brush, rects[8]);
                    g.DrawRectangle(pen, rects[8]);

                    for(int i = 0; i < rectNames.Length; i++)
                        g.DrawString(rectNames[i], new Font(this.Font.Name, 14, FontStyle.Bold), Brushes.Blue, rects[i], sFormat);

                }
            }

            this.Paint -= ShapesForm_Paint;
            this.Paint += ShapesForm_Paint;
        }

        // 해당 사각형 인덱스의 왼쪽 아래, 오른쪽 아래, 왼쪽 위, 오른쪽 위의 포인트를 지정해서 리턴한다.
        public Point[] GetCurvePoints(Rectangle[] rects, int rIdx)
        {
            Point[] curvePoints = new Point[4]
            {
                new Point(rects[rIdx].X, rects[rIdx].Y + rects[rIdx].Height),
                new Point(rects[rIdx].X + rects[rIdx].Width, rects[rIdx].Y + rects[rIdx].Height),
                new Point(rects[rIdx].X, rects[rIdx].Y),
                new Point(rects[rIdx].X + rects[rIdx].Width, rects[rIdx].Y)
            };
            return curvePoints;
        }


        private void ShapesForm_Paint(object sender, PaintEventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
            Graphics g = this.CreateGraphics();
            using (Pen pen = new Pen(Color.Black, 5))
            {
                using (Brush brush = new SolidBrush(Color.Pink))
                {
                    StringFormat sFormat = new StringFormat();
                    sFormat.Alignment = StringAlignment.Center;
                    sFormat.LineAlignment = StringAlignment.Center;
                    g.DrawArc(pen, rects[0], 180, 180);
                    Point[] points = GetCurvePoints(rects, 1);
                    g.DrawBeziers(pen, points);
                    Point[] closedCurvePs = GetCurvePoints(rects, 2);
                    g.FillClosedCurve(brush, closedCurvePs);
                    g.DrawClosedCurve(pen, closedCurvePs);
                    Point[] curvePs = GetCurvePoints(rects, 3);
                    g.DrawCurve(pen, curvePs);
                    g.FillEllipse(brush, rects[4]);
                    g.DrawEllipse(pen, rects[4]);
                    Point[] linesPs = GetCurvePoints(rects, 5);
                    g.DrawLines(pen, linesPs);
                    g.FillPie(brush, rects[6], 180, 180);
                    g.DrawPie(pen, rects[6], 180, 180);
                    Point[] polygonPs = GetCurvePoints(rects, 7);
                    g.FillPolygon(brush, polygonPs);
                    g.DrawPolygon(pen, polygonPs);
                    g.FillRectangle(brush, rects[8]);
                    g.DrawRectangle(pen, rects[8]);

                    for (int i = 0; i < rectNames.Length; i++)
                        g.DrawString(rectNames[i], new Font(this.Font.Name, 14, FontStyle.Bold), Brushes.Blue, rects[i], sFormat);

                }
            }

        }

    }
}