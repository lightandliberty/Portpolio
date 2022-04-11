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
    public partial class PenAlignmentForm : Form
    {
        public PenAlignmentForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawCircles()
        {
            int x = 10;
            int y = 10;
            int width = 200;
            int height = 100;

            Size centerLblStrSize = GetStrLength(centerLbl.Text, centerLbl.Font);
            centerLbl.Location = new Point(x + width / 2 - centerLblStrSize.Width / 2, y + height / 2 - centerLblStrSize.Height/2);

            Size insetLblStrSize = GetStrLength(insetLbl.Text, insetLbl.Font);
            insetLbl.Location = new Point(x + width / 2 - insetLblStrSize.Width / 2, y+140 + height / 2 - insetLblStrSize.Height / 2);



            Graphics g = this.CreateGraphics();
            using (Pen pen = new Pen(Color.White, 12))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                g.DrawEllipse(pen, x, y, width, height);
                //g.DrawString("Center", this.Font, new SolidBrush(Color.Black), 85, 55);

                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                g.DrawEllipse(pen, x, y + 140, width, height);
                //g.DrawString("Inset", this.Font, new SolidBrush(Color.Black), 85, 155);

                // 두께 1, 정렬 Center펜으로 원을 두 개 그림
                pen.Color = Color.Black;
                pen.Width = 1;
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                g.DrawEllipse(pen, x, y, width, height);
                g.DrawEllipse(pen, x, y + 140, width, height);

            }
        }

        private void drawDashesBtn_Click(object sender, EventArgs e)
        {
            DrawCircles();

        }

        private Size GetStrLength(string str, Font font)
        {
            // 이렇게 하면 뒤의 빈 공간의 크기를 재지 않는다는데,, 실험해보자.
            SizeF originalPlusa = this.CreateGraphics().MeasureString(str + "a", font, 0, StringFormat.GenericTypographic);
            SizeF a             = this.CreateGraphics().MeasureString("a", font, 0, StringFormat.GenericTypographic);
            SizeF original = new SizeF(originalPlusa.Width - a.Width, originalPlusa.Height); // 너비만 뒷 부분이 더 길므로,
            return new Size((int)original.Width, (int)original.Height);
        }


    }
}
