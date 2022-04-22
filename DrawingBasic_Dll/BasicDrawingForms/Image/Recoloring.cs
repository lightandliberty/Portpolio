using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Imaging;

/// <summary>
/// ColorMap[] 배열을 만들고, 그 원소의 .OldColor속성과 .NewColor속성을 지정한 후,
/// ImageAttributes개체를 생성하여, .SetRemapTable()에 ColorMap[]배열을 인수로 전달하여,
/// g.DrawImage()메서드의 인수로 전달하면 된다.
/// </summary>

namespace DrawingProject_Dll
{
    public class Recoloring : System.Windows.Forms.Form
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
            this.drawRecoloringBtn = new CustomControls_dll.MetalButton();
            this.closeBtn = new CustomControls_dll.MetalButton();
            this.bottomPn = new ResizePanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leftPn = new ResizePanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rightPn = new ResizePanel();
            this.bottomPn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(3, 18);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(223, 12);
            this.instructionLbl.TabIndex = 32;
            this.instructionLbl.Text = "Color.Lime 색을 ColorWhite색으로 매핑";
            // 
            // drawRecoloringBtn
            // 
            this.drawRecoloringBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawRecoloringBtn.Location = new System.Drawing.Point(271, 10);
            this.drawRecoloringBtn.Name = "drawRecoloringBtn";
            this.drawRecoloringBtn.Size = new System.Drawing.Size(115, 28);
            this.drawRecoloringBtn.TabIndex = 31;
            this.drawRecoloringBtn.Text = "Draw Recoloring";
            this.drawRecoloringBtn.UseVisualStyleBackColor = true;
            this.drawRecoloringBtn.Click += new System.EventHandler(this.drawRecoloringBtn_Click);
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
            // bottomPn
            // 
            this.bottomPn.Controls.Add(this.instructionLbl);
            this.bottomPn.Controls.Add(this.drawRecoloringBtn);
            this.bottomPn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPn.Location = new System.Drawing.Point(0, 276);
            this.bottomPn.Name = "bottomPn";
            this.bottomPn.Size = new System.Drawing.Size(398, 50);
            this.bottomPn.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.leftPn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 276);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // leftPn
            // 
            this.leftPn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPn.Location = new System.Drawing.Point(3, 17);
            this.leftPn.Name = "leftPn";
            this.leftPn.Size = new System.Drawing.Size(172, 256);
            this.leftPn.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(178, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 276);
            this.splitter1.TabIndex = 35;
            this.splitter1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rightPn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(181, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 276);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rightPn
            // 
            this.rightPn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightPn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPn.Location = new System.Drawing.Point(3, 17);
            this.rightPn.Name = "rightPn";
            this.rightPn.Size = new System.Drawing.Size(211, 256);
            this.rightPn.TabIndex = 0;
            // 
            // Recoloring
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(398, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bottomPn);
            this.Controls.Add(this.closeBtn);
            this.Name = "Recoloring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recoloring";
            this.bottomPn.ResumeLayout(false);
            this.bottomPn.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label instructionLbl;
        private CustomControls_dll.MetalButton drawRecoloringBtn;
        private ResizePanel bottomPn;
        private GroupBox groupBox1;
        private ResizePanel leftPn;
        private Splitter splitter1;
        private GroupBox groupBox2;
        private ResizePanel rightPn;
        private CustomControls_dll.MetalButton closeBtn;
        #endregion  Windows Form Designer generated code. 끝.


        // 생성자
        public Recoloring()
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
            rects[0] = leftPn.ClientRectangle;
            rects[1] = rightPn.ClientRectangle;
        }



        private void drawRecoloringBtn_Click(object sender, EventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
            Graphics gLeft = leftPn.CreateGraphics();
            Graphics gRight = rightPn.CreateGraphics();

            using (Bitmap bmp = new Bitmap(Properties.Resources.INTL_NO))
            {
                ColorMap[] colorMap = new ColorMap[1];    // DrawImage()메서드의 인수가 ImageAttributes인데, ImageAttributes.SetRemapTable()의 인수가 ColorMap[]배열이므로,
                colorMap[0] = new ColorMap();
//                colorMap[0].OldColor = Color.FromArgb(0, 255, 0); // Color.Lime; // Just Color Picker로 추출해서 지정해도 됨.
                colorMap[0].OldColor = bmp.GetPixel(0, bmp.Height -1); // 이미지의 좌측 하단 픽셀의 색을 얻음
                colorMap[0].NewColor = Color.LightSkyBlue;
                ImageAttributes attr = new ImageAttributes();   // DrawImage()에 인수로 넘길 ImageAttributes의 SetRemapTable 설정을 위해,
                attr.SetRemapTable(colorMap);   // ColorMap[]을 인수로 넘김

                rects[0].Offset(rects[0].Width/2 - bmp.Width/2, rects[0].Height/2 - bmp.Height/2);
                rects[1].Offset(rects[1].Width/2 - bmp.Width/2, rects[1].Height/2 - bmp.Height/2);
                gLeft.DrawImage(bmp, rects[0], 0, 0, rects[0].Width, rects[0].Height, GraphicsUnit.Pixel);
                gRight.DrawImage(bmp, rects[1], 0, 0, rects[1].Width, rects[1].Height, GraphicsUnit.Pixel, attr);

            }




            this.Paint -= RecoloringForm_Paint;
            this.Paint += RecoloringForm_Paint;
        }

        private void RecoloringForm_Paint(object sender, PaintEventArgs e)
        {
            InitRects(); // 사각형 배열의 사각형 영역을 창 크기에 맞게 다시 설정
        }

        public class ResizePanel : Panel
        {
            public ResizePanel()
            {
                this.SetStyle(ControlStyles.ResizeRedraw, true);
            }

        }

    }
}