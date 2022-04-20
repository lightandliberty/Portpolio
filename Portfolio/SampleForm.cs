using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace _ProjectName_
{
    public class ClassName_ : System.Windows.Forms.Form
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
            this.drawClassName_Btn = new CustomControls_dll.MetalButton();
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
            // drawClassName_Btn
            // 
            this.drawClassName_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawClassName_Btn.Location = new System.Drawing.Point(235, 290);
            this.drawClassName_Btn.Name = "drawClassName_Btn";
            this.drawClassName_Btn.Size = new System.Drawing.Size(91, 28);
            this.drawClassName_Btn.TabIndex = 31;
            this.drawClassName_Btn.Text = "Draw ClassName_";
            this.drawClassName_Btn.UseVisualStyleBackColor = true;
            this.drawClassName_Btn.Click += new System.EventHandler(this.drawClassName_Btn_Click);
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
            // ClassName_
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(334, 326);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.drawClassName_Btn);
            this.Controls.Add(this.closeBtn);
            this.Name = "ClassName_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClassName_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label instructionLbl;
        private CustomControls_dll.MetalButton drawClassName_Btn;
        private CustomControls_dll.MetalButton closeBtn;
        #endregion  Windows Form Designer generated code. 끝.


        // 생성자
        public ClassName_()
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
            if (rects == null) rects = new Rectangle[3];
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

        public void InitRect()
        {
            int x = 10;
            int y = 10;
            int width = this.ClientSize.Width - 20;
            int height = this.ClientSize.Height - 100; // 아래 여백 -100
            rect = new Rectangle(x, y, width, height);
        }


        private void drawClassName_Btn_Click(object sender, EventArgs e)
        {
            InitRect(); // 사각형 영역을 창 크기에 맞게 다시 설정
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
            Graphics g = this.CreateGraphics();

            this.Paint -= ClassName_Form_Paint;
            this.Paint += ClassName_Form_Paint;
        }

        private void ClassName_Form_Paint(object sender, PaintEventArgs e)
        {
            InitRect(); // 사각형 영역을 창 크기에 맞게 다시 설정
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
        }

    }
}