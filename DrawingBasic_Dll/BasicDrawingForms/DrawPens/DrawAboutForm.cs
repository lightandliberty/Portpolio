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
        public class DrawAboutForm : System.Windows.Forms.Form
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
            this.drawAboutBtn = new CustomControls_dll.MetalButton();
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(10, 263);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(227, 24);
            this.instructionLbl.TabIndex = 32;
            this.instructionLbl.Text = "LinearGradientBrush개체를 생성한 후, \r\nPen개체를 생성할 때, 매개변수로 전달함";
            // 
            // drawAboutBtn
            // 
            this.drawAboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawAboutBtn.Location = new System.Drawing.Point(235, 290);
            this.drawAboutBtn.Name = "drawAboutBtn";
            this.drawAboutBtn.Size = new System.Drawing.Size(91, 28);
            this.drawAboutBtn.TabIndex = 31;
            this.drawAboutBtn.Text = "Draw About";
            this.drawAboutBtn.UseVisualStyleBackColor = true;
            this.drawAboutBtn.Click += new System.EventHandler(this.drawAboutBtn_Click);
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
            // DrawAbout
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(334, 326);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.drawAboutBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "DrawAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DrawAbout";
            this.Load += new System.EventHandler(this.DrawAbout_Load);
            this.SizeChanged += new System.EventHandler(this.DrawAbout_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            private System.Windows.Forms.Label instructionLbl;
            private CustomControls_dll.MetalButton drawAboutBtn;
            private CustomControls_dll.MetalButton closeBtn;
        #endregion  Windows Form Designer generated code. 끝.


        // 생성자
        public DrawAboutForm()
        {
            InitializeComponent();
        }

        Rectangle rect;

        private void DrawAbout_Load(object sender, EventArgs e)
        {
            rect = new Rectangle(new Point(0,0),GetRectSize());
        }

        private Size GetRectSize()
        {
            int bottomPadding = 80;
            int shortSide = this.ClientSize.Width > this.ClientSize.Height - bottomPadding ? this.ClientSize.Height - bottomPadding : this.ClientSize.Width;
            return new Size(shortSide, shortSide);
        }

        private void drawAboutBtn_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Empty, Color.Empty, 45))
            {
                ColorBlend blend = new ColorBlend();
                blend.Colors = new Color[] { Color.Red, Color.Green, Color.Blue };
                blend.Positions = new float[] { 0, .5f, 1 };
                brush.InterpolationColors = blend; // 브러시에 혼합 옵션을 설정
                using (Pen pen = new Pen(brush))
                {
                    Point p1 = new Point(rect.X, rect.Y);
                    Point p2 = new Point(rect.Width, rect.Y);
                    Point p3 = new Point(rect.Width, rect.Height);
                    Point p4 = new Point(rect.X, rect.Height);
                    int step = 3;
                    for(int i = rect.X; i <= rect.Width; i += step)
                    {
                        p1.X += step;   // 왼쪽위 좌표의 X값이 오른쪽으로 이동
                        p2.Y += step;   // 오른쪽 위 좌표의 Y값이 아래로 이동
                        p3.X -= step;   // 오른쪽 아래 좌표의 X값이 왼쪽으로 이동
                        p4.Y -= step;   // 왼쪽 아래 좌표의 Y값이 위쪽으로 이동

                        g.DrawLine(pen, p1, p2);
                        g.DrawLine(pen, p2, p3);
                        g.DrawLine(pen, p3, p4);
                        g.DrawLine(pen, p4, p1);
                    }
                }
            }

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;  // Width가 350일 때, 폰트의 크기는 18의 비율로, 크기에 비례
            g.DrawString("Ain't graphics\r\ncool?", new Font(this.Font.Name, rect.Width * 18 / 350), Brushes.Black, rect, format);

            rect.Inflate(-50, -50);
            rect.X = 0;
            rect.Y = 0;
            g.Clear(SystemColors.Control);
            Color redColor = Color.Red;
            for (int i = 0; i < 15; i++)
            {
                g.FillRectangle(new SolidBrush(redColor), rect);
                rect.X += 15;
                redColor = ControlPaint.Light(redColor);
            }
            rect.X = 0;
            rect.Y += rect.Height;
            redColor = Color.Red;
            for (int i = 0; i < 15; i++)
            {
                g.FillRectangle(new SolidBrush(redColor), rect);
                rect.X += 15;
                redColor = ControlPaint.Dark(redColor);
            }
        }



        private void DrawAbout_SizeChanged(object sender, EventArgs e)
        {
            rect.Size = GetRectSize();
        }
    }
}