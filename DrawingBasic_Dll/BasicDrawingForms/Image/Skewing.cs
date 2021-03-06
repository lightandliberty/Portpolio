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
    public class Skewing : System.Windows.Forms.Form
    {
        public enum ButtonState : int
        {
            UP = 0,
            DOWN,
            LEFT,
            RIGHT,
            NONE
        }


        private System.ComponentModel.IContainer components;
        #region Windows Form Designer generated code

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
            this.components = new System.ComponentModel.Container();
            this.instructionLbl = new System.Windows.Forms.Label();
            this.drawSkewingBtn = new CustomControls_dll.MetalButton();
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.panel1 = new DrawingProject_Dll.Skewing.ResizePanel();
            this.moveUpBtn = new CustomControls_dll.MetalButton();
            this.moveDownBtn = new CustomControls_dll.MetalButton();
            this.moveLeftBtn = new CustomControls_dll.MetalButton();
            this.moveRightBtn = new CustomControls_dll.MetalButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.ForeColor = System.Drawing.Color.White;
            this.instructionLbl.Location = new System.Drawing.Point(12, 307);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(157, 24);
            this.instructionLbl.TabIndex = 32;
            this.instructionLbl.Text = "timer를 이용해 그림을 \r\n연속으로 이동할 수 있게 함.";
            // 
            // drawSkewingBtn
            // 
            this.drawSkewingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawSkewingBtn.Location = new System.Drawing.Point(248, 307);
            this.drawSkewingBtn.Name = "drawSkewingBtn";
            this.drawSkewingBtn.Size = new System.Drawing.Size(91, 39);
            this.drawSkewingBtn.TabIndex = 31;
            this.drawSkewingBtn.Text = "Draw Skewing";
            this.drawSkewingBtn.UseVisualStyleBackColor = true;
            this.drawSkewingBtn.Click += new System.EventHandler(this.drawSkewingBtn_Click);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(47, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 201);
            this.panel1.TabIndex = 33;
            // 
            // moveUpBtn
            // 
            this.moveUpBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moveUpBtn.Location = new System.Drawing.Point(159, 12);
            this.moveUpBtn.Name = "moveUpBtn";
            this.moveUpBtn.Size = new System.Drawing.Size(28, 28);
            this.moveUpBtn.TabIndex = 34;
            this.moveUpBtn.Text = "↑";
            this.moveUpBtn.UseVisualStyleBackColor = true;
            this.moveUpBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveUpBtn_MouseDown);
            this.moveUpBtn.MouseLeave += new System.EventHandler(this.moveDownBtn_MouseLeave);
            this.moveUpBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveBtn_MouseUp);
            // 
            // moveDownBtn
            // 
            this.moveDownBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.moveDownBtn.Location = new System.Drawing.Point(159, 267);
            this.moveDownBtn.Name = "moveDownBtn";
            this.moveDownBtn.Size = new System.Drawing.Size(28, 28);
            this.moveDownBtn.TabIndex = 35;
            this.moveDownBtn.Text = "↓";
            this.moveDownBtn.UseVisualStyleBackColor = true;
            this.moveDownBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveDownBtn_MouseDown);
            this.moveDownBtn.MouseLeave += new System.EventHandler(this.moveDownBtn_MouseLeave);
            this.moveDownBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveBtn_MouseUp);
            // 
            // moveLeftBtn
            // 
            this.moveLeftBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.moveLeftBtn.Location = new System.Drawing.Point(6, 140);
            this.moveLeftBtn.Name = "moveLeftBtn";
            this.moveLeftBtn.Size = new System.Drawing.Size(28, 28);
            this.moveLeftBtn.TabIndex = 36;
            this.moveLeftBtn.Text = "←";
            this.moveLeftBtn.UseVisualStyleBackColor = true;
            this.moveLeftBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveLeftBtn_MouseDown);
            this.moveLeftBtn.MouseLeave += new System.EventHandler(this.moveDownBtn_MouseLeave);
            this.moveLeftBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveBtn_MouseUp);
            // 
            // moveRightBtn
            // 
            this.moveRightBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.moveRightBtn.Location = new System.Drawing.Point(312, 140);
            this.moveRightBtn.Name = "moveRightBtn";
            this.moveRightBtn.Size = new System.Drawing.Size(28, 28);
            this.moveRightBtn.TabIndex = 37;
            this.moveRightBtn.Text = "→";
            this.moveRightBtn.UseVisualStyleBackColor = true;
            this.moveRightBtn.Click += new System.EventHandler(this.moveRightBtn_Click);
            this.moveRightBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveRightBtn_MouseDown);
            this.moveRightBtn.MouseLeave += new System.EventHandler(this.moveDownBtn_MouseLeave);
            this.moveRightBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveBtn_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Skewing
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(347, 354);
            this.Controls.Add(this.moveRightBtn);
            this.Controls.Add(this.moveLeftBtn);
            this.Controls.Add(this.moveDownBtn);
            this.Controls.Add(this.moveUpBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.drawSkewingBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "Skewing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Skewing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label instructionLbl;
        private CustomControls_dll.MetalButton drawSkewingBtn;
        private ResizePanel panel1;
        private CustomControls_dll.MetalButton moveUpBtn;
        private CustomControls_dll.MetalButton moveDownBtn;
        private CustomControls_dll.MetalButton moveLeftBtn;
        private CustomControls_dll.MetalButton moveRightBtn;
        private Timer timer1;
        private CustomControls_dll.MetalButton closeBtn;
        #endregion  Windows Form Designer generated code. 끝.


        // 생성자
        public Skewing()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }


        public Rectangle destRect;
        public Rectangle srcRect;
        public Size offset;

        public Point[] InitRect()
        {
            if (offset == null) offset = new Size();
            //int x = 0;
            //int y = 0;
            //int width = this.ClientSize.Width - 20;
            //int height = this.ClientSize.Height - 100; // 아래 여백 -100

            //srcRect = new Rectangle(offset.Width, offset.Height, destRect.Width, destRect.Height);

            destRect = new Rectangle(panel1.ClientRectangle.Width/3 , panel1.ClientRectangle.Top, panel1.ClientRectangle.Width / 3, panel1.ClientRectangle.Height);      // 패널의 사각영역을 가져 옴. (252, 201)
            Point[] points = new Point[3];
            points[0] = new Point(destRect.Left + offset.Width, destRect.Top + offset.Height);   // 왼쪽 위
            points[1] = new Point(destRect.Right + offset.Width, destRect.Top + offset.Height);   // 오른쪽 위
            points[2] = new Point(destRect.Left - offset.Width, destRect.Bottom - offset.Height);   // 왼쪽 아래
            return points;

        }

        

        private void drawSkewingBtn_Click(object sender, EventArgs e)
        {
            InitRect(); // 사각형 영역을 창 크기에 맞게 다시 설정
            Graphics g = panel1.CreateGraphics();

            using (Bitmap bmp = new Bitmap(Properties.Resources.Soap_Bubbles))
            {
                g.DrawImage(bmp, InitRect());
                //g.DrawImage(bmp, destRect, srcRect, GraphicsUnit.Pixel); // PageUnit오류나면, Enum개체로 바꿈.
            }

            this.panel1.Paint -= Panel1_Paint;
            this.panel1.Paint += Panel1_Paint;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            InitRect(); // 사각형 영역을 창 크기에 맞게 다시 설정
            Graphics g = e.Graphics;
            using (Bitmap bmp = new Bitmap(Properties.Resources.Soap_Bubbles))
            {
                g.DrawImage(bmp, InitRect());
                //g.DrawImage(bmp, destRect, srcRect, GraphicsUnit.Pixel); // PageUnit오류나면, Enum개체로 바꿈.
            }
        }



        class ResizePanel : Panel
        {
            public ResizePanel()
            {
                this.SetStyle(ControlStyles.ResizeRedraw, true);
            }
        }

        private void moveUpBtn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentBtn = ButtonState.UP;
                timer1.Start();
            }
        }

        private void moveDownBtn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentBtn = ButtonState.DOWN;
                timer1.Start();
            }
        }

        private void moveLeftBtn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentBtn = ButtonState.LEFT;
                timer1.Start();
            }
        }

        private void moveRightBtn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentBtn = ButtonState.RIGHT;
                timer1.Start();
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (currentBtn)
            {
                case ButtonState.UP:
                    offset.Height -= 10;
                    //offset.Height -= srcRect.Y + offset.Height > 0 ? 1 : 0;
                    break;
                case ButtonState.DOWN:
                    offset.Height += 10;
                    break;
                case ButtonState.LEFT:
                    offset.Width -= 10;
                    //offset.Width -= srcRect.X + offset.Width > 0 ? 1 : 0;
                    break;
                case ButtonState.RIGHT:
                    offset.Width += 10;
                    break;
                case ButtonState.NONE:
                default:
                    break;
            }
            panel1.Refresh();
        }

        public ButtonState currentBtn;

        private void moveBtn_MouseUp(object sender, MouseEventArgs e)
        {
            currentBtn = ButtonState.NONE;
            timer1.Stop();
        }

        private void moveDownBtn_MouseLeave(object sender, EventArgs e)
        {
            currentBtn = ButtonState.NONE;
            timer1.Stop();
        }

        private void moveRightBtn_Click(object sender, EventArgs e)
        {

        }
    }

}
