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
    public class SmoothingModes : System.Windows.Forms.Form
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
            this.drawSmoothingModesBtn = new CustomControls_dll.MetalButton();
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
            // drawSmoothingModesBtn
            // 
            this.drawSmoothingModesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawSmoothingModesBtn.Location = new System.Drawing.Point(183, 279);
            this.drawSmoothingModesBtn.Name = "drawSmoothingModesBtn";
            this.drawSmoothingModesBtn.Size = new System.Drawing.Size(143, 39);
            this.drawSmoothingModesBtn.TabIndex = 31;
            this.drawSmoothingModesBtn.Text = "Draw SmoothingModes";
            this.drawSmoothingModesBtn.UseVisualStyleBackColor = true;
            this.drawSmoothingModesBtn.Click += new System.EventHandler(this.drawSmoothingModesBtn_Click);
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
            // SmoothingModes
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(334, 326);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.drawSmoothingModesBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "SmoothingModes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SmoothingModes";
            this.Load += new System.EventHandler(this.SmoothingModes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label instructionLbl;
        private CustomControls_dll.MetalButton drawSmoothingModesBtn;
        private CustomControls_dll.MetalButton closeBtn;
        #endregion  Windows Form Designer generated code. 끝.


        // 생성자
        public SmoothingModes()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }


        private void SmoothingModes_Load(object sender, EventArgs e)
        {
            rects = new Rectangle[3];

        }

        public Rectangle[] rects;
        public void InitRects()
        {
            int x = 0;
            int y = 0;
            int width = this.ClientSize.Width / 2;
            int height = this.ClientSize.Height - 80; // 아래 여백 -80
            for (int i = 0; i < rects.Length; i++)
            {
                rects[i] = new Rectangle(x, y, width, height);
                x += width; // 딱 붙어서 사각형을 3개로 설정
            }
        }

        private void drawSmoothingModesBtn_Click(object sender, EventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정



            Graphics g = this.CreateGraphics();

            GraphicsState oldState = g.Save();

            using (Pen pen = new Pen(Color.Red, 4))
            using (Pen pointPen = new Pen(Color.Black, 3))
            {
                using (Brush brush = new SolidBrush(Color.Pink))
                {
                    StringFormat sFormat = new StringFormat();
                    sFormat.Alignment = StringAlignment.Center;
                    sFormat.LineAlignment = StringAlignment.Center;
                    pointPen.StartCap = pointPen.EndCap = LineCap.Square;

                    float tension = 0.5f;
                    string antiAliasOrNot = string.Empty;
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    for (int i = 0; i < rects.Length; i++)
                    {
                        antiAliasOrNot = g.SmoothingMode == SmoothingMode.AntiAlias ? "AntiAlias" : "None";
                        g.DrawRectangle(Pens.Black, rects[i]);
                        Point[] curvePsTen = GetCurvePoints(rects, i);
                        g.DrawCurve(pen, curvePsTen, tension);
                        g.DrawString(string.Format("{0}", antiAliasOrNot), new Font(this.Font.Name, 15 * this.ClientRectangle.Width / 350), Brushes.Black, rects[i], sFormat);
                        // g.SmoothingMode = SmoothingMode.None; // 그래픽 개체 저장, 불러오기로 구현하기 위해, 주석처리 함.
                        g.Restore(oldState);    // 이러면, 이전 설정을 현재 설정에 저장하여, 안티 앨리어싱 효과가 사라진다.
                    }
                }
            }

            this.Paint -= SmoothingModesForm_Paint;
            this.Paint += SmoothingModesForm_Paint;
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


        private void SmoothingModesForm_Paint(object sender, PaintEventArgs e)
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

                    float tension = 0.5f;
                    string antiAliasOrNot = string.Empty;
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    for (int i = 0; i < rects.Length; i++)
                    {
                        antiAliasOrNot = g.SmoothingMode == SmoothingMode.AntiAlias ? "AntiAlias" : "None";
                        g.DrawRectangle(Pens.Black, rects[i]);
                        Point[] curvePsTen = GetCurvePoints(rects, i);
                        g.DrawCurve(pen, curvePsTen, tension);
                        g.DrawString(string.Format("{0}", antiAliasOrNot), new Font(this.Font.Name, 15 * this.ClientRectangle.Width / 350), Brushes.Black, rects[i], sFormat);
                        g.SmoothingMode = SmoothingMode.None;
                    }
                }
            }

        }

    }
}