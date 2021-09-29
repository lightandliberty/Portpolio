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
    public partial class DrawHatchBrushes : Form
    {
        public DrawHatchBrushes()
        {
            InitializeComponent();
        }

        private void HatchBrushes_Load(object sender, EventArgs e)
        {

        }

        // Size를 0,0으로 하였음로, 디자인 화면에선 Ctrl + A 키로 선택할 수 있습니다.
        private void cancelMetalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        private void DrawHatchBrushes_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // HatchStyle은 1 ~ 52까지 있음.
            int x = 0;
            int y = 0;
            int width = this.ClientSize.Width / 4;
            int height = this.ClientSize.Height / 26;
            Font font = new Font("malgun gothic", 8, FontStyle.Regular);
            
            using (Brush solidBrush1 = new System.Drawing.SolidBrush(Color.LightGray))
            {
                for (int i = 0; i < 13; i++)
                {
                    // 4칸 반복해서 그림
                    for (int j = 0; j < 4; j++)
                    {
                        using (Brush brush = new System.Drawing.Drawing2D.HatchBrush((System.Drawing.Drawing2D.HatchStyle)j+(i*4), Color.DarkBlue, Color.White))
                        {
                            // 윗칸 칠하고, 글씨 씀
                            g.FillRectangle(solidBrush1, x, y, width, height);
                            g.DrawString(((System.Drawing.Drawing2D.HatchStyle)j+(i*4)).ToString(), font, System.Drawing.Brushes.Black, x, y + 1);
                            y += height;
                            // 아래 칸 칠하고 글씨 씀.
                            g.FillRectangle(brush, x, y, width, height);
                        };
                        x += width;
                        y -= height;
                    }
                    x = 0;
                    y += height * 2;
                }
            };

        }
    }
}
