 
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
    public class RotatingFlipping : System.Windows.Forms.Form
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
            this.drawRotatingFlippingBtn = new CustomControls_dll.MetalButton();
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(12, 378);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(249, 12);
            this.instructionLbl.TabIndex = 32;
            this.instructionLbl.Text = "RotateFlipType 열거형을 이용한 회전과 대칭";
            // 
            // drawRotatingFlippingBtn
            // 
            this.drawRotatingFlippingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawRotatingFlippingBtn.Location = new System.Drawing.Point(357, 395);
            this.drawRotatingFlippingBtn.Name = "drawRotatingFlippingBtn";
            this.drawRotatingFlippingBtn.Size = new System.Drawing.Size(159, 28);
            this.drawRotatingFlippingBtn.TabIndex = 31;
            this.drawRotatingFlippingBtn.Text = "Draw RotatingFlipping";
            this.drawRotatingFlippingBtn.UseVisualStyleBackColor = true;
            this.drawRotatingFlippingBtn.Click += new System.EventHandler(this.drawRotatingFlippingBtn_Click);
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
            // RotatingFlipping
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(524, 431);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.drawRotatingFlippingBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "RotatingFlipping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RotatingFlipping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label instructionLbl;
        private CustomControls_dll.MetalButton drawRotatingFlippingBtn;
        private CustomControls_dll.MetalButton closeBtn;
        #endregion  Windows Form Designer generated code. 끝.


        // 생성자
        public RotatingFlipping()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }


        public Rectangle rect;
        public Rectangle[] rects;
        public void InitRects()
        {
            if (rects == null) rects = new Rectangle[16];
            int x = 0;
            int y = 0;
            int width = this.ClientSize.Width / 4;
            int height = (this.ClientSize.Height - 100) / 4; // 아래 여백 -80
            for (int i = 0; i < rects.Length; i++)
            {
                rects[i] = new Rectangle(x, y, width, height);
                if(this.ClientSize.Width - width < x+width) // x에 너비를 더한 위치가 다음 사각형의 시작X위치인데, 사각형의 너비를 더했을 때, 경계를 벗어난다면, 줄을 바꿈.
                {
                    x = 0;
                    y += height;
                }
                else
                    x += width; // 딱 붙어서 사각형을 3개로 설정
            }
        }


        private void drawRotatingFlippingBtn_Click(object sender, EventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
            Graphics g = this.CreateGraphics();

            string[] rotationFlipName = Enum.GetNames(typeof(RotateFlipType));
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Center;
            sFormat.LineAlignment = StringAlignment.Far;
            System.Diagnostics.Debug.Assert(rotationFlipName.Length % 4 == 0); // 4의 배수가 아니면, 호출 스택 나열 후 멈춤
            Array.Sort(rotationFlipName);                                      // 정렬

            using (Bitmap bmp = new Bitmap(Properties.Resources.BEANY))
            {
                for (int i = 0; i < rotationFlipName.Length; i++)
                {
                    RotateFlipType rfType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), rotationFlipName[i]);
                    bmp.RotateFlip(rfType);
                    g.DrawImage(bmp, rects[i]);
                    g.DrawRectangle(Pens.Black, rects[i]);
                    //                string rfTypeStr = rfType.ToString();   // rfTypeStr은 rotationFlipName[i]와 조금 다름. 그림은 같지만, 로테이션 한 결과가 플립과 같으면 플립으로 문자열을 표시하는 듯 함.
                    g.DrawString(rotationFlipName[i], new Font(this.Font.Name, 9), Brushes.Black, rects[i], sFormat);
                }
            }



            this.Paint -= RotatingFlippingForm_Paint;
            this.Paint += RotatingFlippingForm_Paint;
        }

        private void RotatingFlippingForm_Paint(object sender, PaintEventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
            Graphics g = this.CreateGraphics();

            string[] rotationFlipName = Enum.GetNames(typeof(RotateFlipType));
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Center;
            sFormat.LineAlignment = StringAlignment.Far;
            System.Diagnostics.Debug.Assert(rotationFlipName.Length % 4 == 0); // 4의 배수가 아니면, 호출 스택 나열 후 멈춤
            Array.Sort(rotationFlipName);                                      // 정렬

            for (int i = 0; i < rotationFlipName.Length; i++)
            {
                RotateFlipType rfType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), rotationFlipName[i]);
                Bitmap bmp = new Bitmap(Properties.Resources.BEANY);
                bmp.RotateFlip(rfType);
                g.DrawImage(bmp, rects[i]);
                g.DrawRectangle(Pens.Black, rects[i]);
                //                string rfTypeStr = rfType.ToString();   // rfTypeStr은 rotationFlipName[i]와 조금 다름. 그림은 같지만, 로테이션 한 결과가 플립과 같으면 플립으로 문자열을 표시하는 듯 함.
                g.DrawString(rotationFlipName[i], new Font(this.Font.Name, 9), Brushes.Black, rects[i], sFormat);
            }
        }

    }
}