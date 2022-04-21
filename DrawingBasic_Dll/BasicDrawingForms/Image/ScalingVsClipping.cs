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
    public class ScalingVsClipping : System.Windows.Forms.Form
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
            this.drawScalingVsClippingBtn = new CustomControls_dll.MetalButton();
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new ResizingPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new ResizingPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(12, 24);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(213, 12);
            this.instructionLbl.TabIndex = 32;
            this.instructionLbl.Text = "이미지의 크기 조정(Scaling)과 클리핑";
            // 
            // drawScalingVsClippingBtn
            // 
            this.drawScalingVsClippingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawScalingVsClippingBtn.Location = new System.Drawing.Point(291, 11);
            this.drawScalingVsClippingBtn.Name = "drawScalingVsClippingBtn";
            this.drawScalingVsClippingBtn.Size = new System.Drawing.Size(132, 38);
            this.drawScalingVsClippingBtn.TabIndex = 31;
            this.drawScalingVsClippingBtn.Text = "Draw ScalingVsClipping";
            this.drawScalingVsClippingBtn.UseVisualStyleBackColor = true;
            this.drawScalingVsClippingBtn.Click += new System.EventHandler(this.drawScalingVsClippingBtn_Click);
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
            this.panel1.Controls.Add(this.drawScalingVsClippingBtn);
            this.panel1.Controls.Add(this.instructionLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 58);
            this.panel1.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scaling";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 233);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(203, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 253);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clipping";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 233);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 253);
            this.splitter1.TabIndex = 36;
            this.splitter1.TabStop = false;
            // 
            // ScalingVsClipping
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(435, 311);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panel1);
            this.Name = "ScalingVsClipping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ScalingVsClipping";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label instructionLbl;
        private CustomControls_dll.MetalButton drawScalingVsClippingBtn;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ResizingPanel panel2;
        private ResizingPanel panel3;
        private Splitter splitter1;
        private CustomControls_dll.MetalButton closeBtn;
        #endregion  Windows Form Designer generated code. 끝.


        // 생성자
        public ScalingVsClipping()
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
            if (rects == null) rects = new Rectangle[2];
            // 왼쪽 판넬과 오른쪽 판넬의 크기대로 사각형을 설정
            for (int i = 0; i < rects.Length; i++)
            {
                int x = (i == 0 ? panel2 : panel3).Location.X;
                int y = (i == 0 ? panel2 : panel3).Location.Y;
                int width = (i == 0 ? panel2 : panel3).Size.Width;
                int height = (i == 0 ? panel2 : panel3).Size.Height;
                rects[i] = new Rectangle(x, y, width, height);
            }
        }


        public void InitRect()
        {
            int x = 10;
            int y = 10;
            int width = this.ClientSize.Width - 20;
            int height = this.ClientSize.Height - 100; // 아래 여백 -100
            rect = new Rectangle(x, y, width, height);
        }


        private void drawScalingVsClippingBtn_Click(object sender, EventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
            Rectangle destRect = rects[0];

            panel2.CreateGraphics().Clear(Color.White);
            panel3.CreateGraphics().Clear(Color.White);

            using(Bitmap bubbleBmp = new Bitmap(Properties.Resources.Soap_Bubbles))
            {
                // destRect는 srcRect와 다르다.
                panel2.CreateGraphics().DrawImage(bubbleBmp, destRect);     // 이미지를 대상 영역에 맞게 조정
                destRect = rects[1];
                // destRect는 srcRect와 같다.(클리핑)
                Rectangle srcRect = rects[1];
                Graphics g = panel3.CreateGraphics();
                g.DrawImage(bubbleBmp, destRect, srcRect, GraphicsUnit.Pixel); // srcRect매개변수가 사용하는 측정단위. GraphicsUnit열거형.
            }

            

            // Resize이벤트 말고, Paint이벤트를 위해, 잠시 주석
            //this.panel2.Resize -= ScalingVsClipping_Resize;
            //this.panel2.Resize += ScalingVsClipping_Resize;
            
//            this.Paint += ScalingVsClippingForm_Paint;
        }

        private void ScalingVsClipping_Resize(object sender, EventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
            Rectangle destRect = rects[0];

            panel2.CreateGraphics().Clear(Color.White);
            panel3.CreateGraphics().Clear(Color.White);

            using (Bitmap bubbleBmp = new Bitmap(Properties.Resources.Soap_Bubbles))
            {
                // destRect는 srcRect와 다르다.
                panel2.CreateGraphics().DrawImage(bubbleBmp, destRect);     // 이미지를 대상 영역에 맞게 조정
                destRect = rects[1];
                // destRect는 srcRect와 같다.(클리핑)
                Rectangle srcRect = rects[1];
                Graphics g = panel3.CreateGraphics();
                g.DrawImage(bubbleBmp, destRect, srcRect, GraphicsUnit.Pixel); // srcRect매개변수가 사용하는 측정단위. GraphicsUnit열거형.
            }

            //            this.Refresh();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using(Bitmap bmp = new Bitmap(Properties.Resources.Soap_Bubbles))
            {
                Rectangle rect = new Rectangle(10, 10, this.panel2.ClientRectangle.Width - 20, this.panel3.ClientRectangle.Height - 20);
                g.DrawImage(bmp, rect);
                g.DrawRectangle(Pens.Black, rect);
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Bitmap bmp = new Bitmap(Properties.Resources.Soap_Bubbles))
            {
                Rectangle destRect = new Rectangle(10, 10, this.panel3.ClientRectangle.Width - 20, panel3.ClientRectangle.Height - 20);
                Rectangle srcRect = new Rectangle(0, 0, destRect.Width, destRect.Height);
                g.DrawImage(bmp, destRect, srcRect, g.PageUnit);
                g.DrawRectangle(Pens.Black, rect);
            }
        }

        class ResizingPanel : Panel
        {
            public ResizingPanel()
            {
                this.SetStyle(ControlStyles.ResizeRedraw, true);
            }
        }
    }
}