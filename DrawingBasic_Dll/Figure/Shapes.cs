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
            this.instructionLbl.Location = new System.Drawing.Point(10, 263);
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
        }


        private void Shapes_Load(object sender, EventArgs e)
        {
            InitRects();
        }
        
        public Rectangle[] rects;
        public void InitRects()
        {
            rects = new Rectangle[9];
            int x = 0;
            int y = 0;
            int width = this.ClientSize.Width / 3;
            int height = (this.ClientSize.Height-80) / 3;
            for (int i = 0; i < rects.Length; i++)
            {
                rects[i] = new Rectangle(x, y, width, height);
                x += width;
                if (x > this.ClientRectangle.Size.Width - width)
                {
                    x = 0;
                    y += height;
                }
            }
        }

        private void drawFiguresBtn_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            for (int i = 0; i < rects.Length; i++)
                g.FillEllipse(Brushes.Black, rects[i]);
        }

    }
}