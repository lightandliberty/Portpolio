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
    public partial class BasicDrawingForm : Form
    {
        public BasicDrawingForm()
        {
            InitializeComponent();
        }

        private void CancelMetalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkMetalBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 종료ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawEllipseBtn_MouseEnter(object sender, EventArgs e)
        {
            instructionTextBox.Text = "Graphics객체를 CreateGraphics()로 얻어, .FillEllipse()로 타원을 그린다." +
                "\r\n또는 기존에 그려진 타원을 시스템 색으로 지운다" +
                "\r\nSystemBrushes.Control로 지우고, finally에선 IDisposable인터페이스를 구현하는 Graphics객체의 자원을 해제한다." +
                "try, finally 블록은 using 블록으로도 대체 가능";
        }

        public bool drawEllipse = false;
        Color mEllipseColor1;
        Color mEllipseColor2;
        private void DrawEllipseBtn_Click(object sender, EventArgs e)
        {
            // 브러쉬를 그리는 모드가 켜있으면, 끝다.
            if (drawBrushes)
            {
                drawBrushes = !drawBrushes;
            }
            // 타원을 그릴지 지울지 여부를 토글(toggle: 껐다 켰다) 한다.
//            Invalidate(true);
            drawEllipse = !drawEllipse;
            mEllipseColor1 = ColorTranslator.FromHtml("#FF0000");
            string htmlColorName = ColorTranslator.ToHtml(mEllipseColor1);
            
            if(drawEllipse)
                instructionTextBox.Text ="현재 설정되어 타원을 칠할 색의 HTML 문자 값은 " + htmlColorName;
            else
                instructionTextBox.Text = "현재 설정되어 타원을 지울 색의 HTML 문자 값은 " + ColorTranslator.ToHtml(SystemColors.Control);
            instructionTextBox.Text += "\r\n현재 설정되어 타원을 지울 색의 HTML 문자 값은 " + ColorTranslator.ToHtml(Color.FromKnownColor(KnownColor.Control));
            mEllipseColor2 = Color.FromKnownColor(KnownColor.Control);
            instructionTextBox.Text += "\r\n현재 설정되어 타원을 지울 색을 저장한 후의 HTML 문자 값은 " + ColorTranslator.ToHtml(mEllipseColor2);
            instructionTextBox.Text += "\r\n한번 더 클릭하면 지워지고, 다시 클릭하면 나타난다. ";
            this.Invalidate(true);      // true : 자식 컨트롤을 무효화 함.
            this.Update();
            //this.Refresh();     // Invalidate(true) + Update()
            // Paint이벤트에서 처리하므로, 주석 처리 함.
            //Graphics g = this.CreateGraphics();
            //try
            //{
            //    if(drawEllipse)
            //    {
            //        g.FillEllipse(Brushes.DarkBlue,
            //            new Rectangle(
            //            this.ClientRectangle.X + this.ClientRectangle.Width / 4,
            //            this.ClientRectangle.Y + this.ClientRectangle.Height / 4,
            //            this.ClientRectangle.Width / 2,
            //            this.ClientRectangle.Height / 2
            //            ));
            //    }
            //    else
            //    {
            //        // 기존에 그려진 타원을 지운다
            //        g.FillEllipse(SystemBrushes.Control,
            //            new Rectangle(
            //            this.ClientRectangle.X + this.ClientRectangle.Width/4,
            //            this.ClientRectangle.Y + this.ClientRectangle.Height/4,
            //            this.ClientRectangle.Width /2 ,
            //            this.ClientRectangle.Height / 2
            //            ));
            //    }
            //}
            //finally
            //{
            //    g.Dispose();
            //}

            //// using 블록으로도 대체 가능
            //using (Graphics g2 = this.CreateGraphics())
            //{
            //    if(drawEllipse)
            //        g2.FillEllipse(Brushes.Pink,
            //            new Rectangle(
            //            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
            //            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
            //            this.ClientRectangle.Width / 4,
            //            this.ClientRectangle.Height / 4
            //            ));
            //    else
            //        g2.FillEllipse(SystemBrushes.Control,
            //            new Rectangle(
            //            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
            //            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
            //            this.ClientRectangle.Width / 4,
            //            this.ClientRectangle.Height / 4
            //            ));
            //}
        }

        private void DrawEllipseBtn_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BasicDrawingForm_Paint(object sender, PaintEventArgs e)
        {
            //if (!drawEllipse) return;
            #region Paint이벤트에서 타원을 그린다.
            if (drawEllipse)
            {
                Brush b1 = new SolidBrush(mEllipseColor1);
                Graphics g3 = e.Graphics;
                g3.FillEllipse(b1, new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
                            this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Height / 4
                            ));
                g3.FillEllipse(Brushes.Pink, new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
                            this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Height / 4
                            ));


                Graphics g = this.CreateGraphics();
                try
                {
                    if (drawEllipse)
                    {
                        g.FillEllipse(b1,
                            new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4,
                            this.ClientRectangle.Width / 2,
                            this.ClientRectangle.Height / 2
                            ));
                    }
                    else
                    {
                        // 기존에 그려진 타원을 지운다
                        g.FillEllipse(SystemBrushes.Control,
                            new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4,
                            this.ClientRectangle.Width / 2,
                            this.ClientRectangle.Height / 2
                            ));
                    }
                }
                finally
                {
                    g.Dispose();
                }

                // using 블록으로도 대체 가능
                using (Graphics g2 = this.CreateGraphics())
                {
                    if (drawEllipse)
                        g2.FillEllipse(Brushes.Pink,
                            new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
                            this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Height / 4
                            ));
                    else
                        g2.FillEllipse(SystemBrushes.Control,
                            new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
                            this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Height / 4
                            ));
                }
            }
            #endregion
            else if(drawBrushes)
            {
                Graphics g = e.Graphics;
                int x = this.ClientRectangle.Width / 4;
                int y = this.ClientRectangle.Height / 4;
                int width = this.ClientRectangle.Width / 2;
                int height = this.ClientRectangle.Height / 5 / 2;
                Brush whiteBrush = System.Drawing.Brushes.White;
                Brush blackBrush = System.Drawing.Brushes.Black;

                using (Brush brush = new SolidBrush(Color.DarkBlue))
                {
                    // 브러쉬, x, y, 너비, 높이
                    g.FillRectangle(brush, x, y, width, height);
                    // 문자열, 폰트, 브러쉬, 시작위치x, 시작위치y
                    g.DrawString(brush.ToString(), this.Font, whiteBrush, x, y+3);  // 위에서 3만큼 띄움. y값에 저장 안 함.
                    y += height;
                }

                // TextureBrush
                using (Brush brush = new TextureBrush(Resource1.flipTest))
                {
                    g.FillRectangle(brush, x, y, width, height);
                    g.DrawString(brush.ToString(), this.Font, blackBrush, x, y+3);  // 위에서 3만큼 띄움. y값에 저장 안 함.
                    y += height;
                }

                // HatchBrush
                using (Brush brush = new System.Drawing.Drawing2D.HatchBrush
                    (System.Drawing.Drawing2D.HatchStyle.Divot, Color.DarkBlue, Color.White))
                {
                    g.FillRectangle(brush, x, y, width, height);
                    g.DrawString(brush.ToString(), this.Font, blackBrush, x, y + 3);
                    y += height;
                }

                //LinearGradientBrush (선형으로 쭉 그려지는 브러쉬)
                using (Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Rectangle(x, y, width, height),
                    Color.DarkBlue,
                    Color.White,
                    45.0f
                    ))
                {
                    g.FillRectangle(brush, x, y, width, height);
                    g.DrawString(brush.ToString(), this.Font, blackBrush, x, y + 3);
                    y += height;
                }

                // PathGradientBrush
                Point[] points = new Point[]
                {
                    new Point(x,y),                       // 왼쪽 위
                    new Point(x + width, y),              // 오른쪽 위
                    new Point(x + width, y + height),     // 오른쪽 아래
                    new Point(x, y + height)              // 왼쪽 아래
                };

                using (Brush brush = new System.Drawing.Drawing2D.PathGradientBrush(points))
                {
                    g.FillRectangle(brush, x, y, width, height);
                    g.DrawString(brush.ToString(), this.Font, blackBrush, x, y);
                    y += height;
                }

                using (Brush brush = new TextureBrush(Resource1.flipTest) {
                    WrapMode = System.Drawing.Drawing2D.WrapMode.TileFlipY })
                {
                    g.FillRectangle(brush, x, y, width, height);
                    g.DrawString(brush.ToString(), this.Font, blackBrush, x, y + 3);
                    y += height;
                }
            }
        }

        public bool drawBrushes = false;
        private void DrawBrushesBtn_Click(object sender, EventArgs e)
        {
            // 타원을 그렸으면, 끈다.
            if (drawEllipse)
            {
                drawEllipse = !drawEllipse;
            }
            drawBrushes = !drawBrushes;
            Invalidate(true);
            DrawHatchBrushes drawHatBrushes = new DrawHatchBrushes();
            drawHatBrushes.ShowDialog();
        }

        private void DrawBrushesBtn_MouseMove(object sender, MouseEventArgs e)
        {
            instructionTextBox.Text = "5가지 브러쉬로 각각 사각형을 그린다." +
                "\r\n새 창을 띄워 HatchBrushes 스타일을 보여 준다.";
        }
    }
}
