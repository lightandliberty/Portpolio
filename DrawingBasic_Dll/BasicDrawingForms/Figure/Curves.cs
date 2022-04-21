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
    public class Curves : System.Windows.Forms.Form
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
            this.drawCurvesBtn = new CustomControls_dll.MetalButton();
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
            this.instructionLbl.Text = "장력에 따른 곡선의 변화를 그림";
            // 
            // drawCurvesBtn
            // 
            this.drawCurvesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawCurvesBtn.Location = new System.Drawing.Point(235, 290);
            this.drawCurvesBtn.Name = "drawCurvesBtn";
            this.drawCurvesBtn.Size = new System.Drawing.Size(91, 28);
            this.drawCurvesBtn.TabIndex = 31;
            this.drawCurvesBtn.Text = "Draw Curves";
            this.drawCurvesBtn.UseVisualStyleBackColor = true;
            this.drawCurvesBtn.Click += new System.EventHandler(this.drawCurvesBtn_Click);
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
            // Curves
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(334, 326);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.drawCurvesBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "Curves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Curves";
            this.Load += new System.EventHandler(this.Curves_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label instructionLbl;
        private CustomControls_dll.MetalButton drawCurvesBtn;
        private CustomControls_dll.MetalButton closeBtn;
        #endregion  Windows Form Designer generated code. 끝.


        // 생성자
        public Curves()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }


        private void Curves_Load(object sender, EventArgs e)
        {
            rects = new Rectangle[3];

        }

        public Rectangle[] rects;
        public void InitRects()
        {
            int x = 0;
            int y = 0;
            int width = this.ClientSize.Width / 3; 
            int height = this.ClientSize.Height - 80; // 아래 여백 -80
            for (int i = 0; i < rects.Length; i++)
            {
                rects[i] = new Rectangle(x, y, width, height);
                x += width; // 딱 붙어서 사각형을 3개로 설정
            }
        }

        private void drawCurvesBtn_Click(object sender, EventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
            Graphics g = this.CreateGraphics();
            using (Pen pen = new Pen(Color.Red, 4))
            using (Pen pointPen = new Pen(Color.Black, 3))
            {
                using (Brush brush = new SolidBrush(Color.Pink))
                {
                    StringFormat sFormat = new StringFormat();
                    sFormat.Alignment = StringAlignment.Center;
                    sFormat.LineAlignment = StringAlignment.Center;
                    pointPen.StartCap = pointPen.EndCap = LineCap.Square;
                    
                    float tension = 0f;

                    for(int i = 0; i < rects.Length; i++)
                    { 
                        g.DrawRectangle(Pens.Black, rects[i]);
                        Point[] curvePsTen = GetCurvePoints(rects, i);
                        g.DrawCurve(pen, curvePsTen, tension);
                        foreach (Point p in curvePsTen) g.DrawLine(pointPen, p, new Point(p.X + 1, p.Y)); // 점 4개의 꼭지점에 각각 길이 1인 선을 그음
                        for (int j = 0; j < curvePsTen.Length; j++) g.DrawString(j.ToString(), new Font(this.Font.Name, 12), Brushes.Black, curvePsTen[j]);
                        g.DrawString(string.Format("Tension = {0}", tension), new Font(this.Font.Name, 12), Brushes.Black, rects[i], sFormat);

                        tension += 0.5f;
                    }
                }
            }

            this.Paint -= CurvesForm_Paint;
            this.Paint += CurvesForm_Paint;
        }

        // 해당 사각형 인덱스의 왼쪽 아래, 오른쪽 아래, 왼쪽 위, 오른쪽 위의 포인트를 지정해서 리턴한다.
        public Point[] GetCurvePoints(Rectangle[] rects, int rIdx)
        {
            // 사각영역의 끝에서 안쪽으로 여백을 조금씩 줌.
            rects[rIdx].X += 25;
            rects[rIdx].Y += 25;
            rects[rIdx].Width += -50;
            rects[rIdx].Height += -50;
            Point[] curvePoints = new Point[4]
            {
                new Point(rects[rIdx].X, rects[rIdx].Y + rects[rIdx].Height),
                new Point(rects[rIdx].X + rects[rIdx].Width, rects[rIdx].Y + rects[rIdx].Height),
                new Point(rects[rIdx].X, rects[rIdx].Y),
                new Point(rects[rIdx].X + rects[rIdx].Width, rects[rIdx].Y)
            };
            return curvePoints;
        }


        private void CurvesForm_Paint(object sender, PaintEventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
            Graphics g = this.CreateGraphics();
            using (Pen pen = new Pen(Color.Red, 4))
            using (Pen pointPen = new Pen(Color.Black, 3))
            {
                using (Brush brush = new SolidBrush(Color.Pink))
                {
                    StringFormat sFormat = new StringFormat();
                    sFormat.Alignment = StringAlignment.Center;
                    sFormat.LineAlignment = StringAlignment.Center;
                    pointPen.StartCap = pointPen.EndCap = LineCap.Square;

                    float tension = 0f;

                    for (int i = 0; i < rects.Length; i++)
                    {
                        g.DrawRectangle(Pens.Black, rects[i]);
                        Point[] curvePsTen = GetCurvePoints(rects, i);
                        g.DrawCurve(pen, curvePsTen, tension);
                        foreach (Point p in curvePsTen) g.DrawLine(pointPen, p, new Point(p.X + 1, p.Y)); // 점 4개의 꼭지점에 각각 길이 1인 선을 그음
                        for (int j = 0; j < curvePsTen.Length; j++) g.DrawString(j.ToString(), new Font(this.Font.Name, 12), Brushes.Black, curvePsTen[j]);
                        g.DrawString(string.Format("Tension = {0}", tension), new Font(this.Font.Name, 12), Brushes.Black, rects[i], sFormat);

                        tension += 0.5f;
                    }
                }
            }
        }

    }
}