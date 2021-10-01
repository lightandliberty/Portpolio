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
    // 이벤트 전달 객체의 매개변수에 전달할 정보
    public class BrushInfo
    {
        public System.Drawing.Drawing2D.HatchBrush h;
    }

    // 이벤트 발생 시 전달할 이벤트 객체. (아까 정보 객체로부터 멤버를 채움)
    public class HatchBrushEventArgs : EventArgs
    {
        public System.Drawing.Drawing2D.HatchBrush mHB { get; private set; }
        public HatchBrushEventArgs(BrushInfo bi)
        {
            mHB = bi.h;
        }
    }

    public partial class DrawHatchBrushes : Form
    {
        public Dictionary<Rectangle, System.Drawing.Drawing2D.HatchBrush> mHatchRectangles;

        public delegate void HatchBrushSelectEventHandler(Object sender, HatchBrushEventArgs hb);   // 이벤트 함수 형태 선언

        // 이벤트 함수 포인터 배열 생성. (여기에 부모 폼에서 함수를 추가함)
        public event HatchBrushSelectEventHandler Selected;

        public DrawHatchBrushes()
        {
            InitializeComponent();
        }

        private void HatchBrushes_Load(object sender, EventArgs e)
        {
            mHatchRectangles = new Dictionary<Rectangle, System.Drawing.Drawing2D.HatchBrush>() {
            };
            this.Text = "마우스로 패턴을 선택할 수 있습니다.";

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
                            // 아래 칸 칠하고, 사각형을 배열에 저장.
                            g.FillRectangle(brush, x, y, width, height);
                            // rects에 저장하고, 마지막 요소를 key로 해서 HatchBrush를 저장
                            rects.Add(new Rectangle(x, y, width, height));
                            mHatchRectangles.Add(rects.Last(), new System.Drawing.Drawing2D.HatchBrush((System.Drawing.Drawing2D.HatchStyle)j + (i * 4), Color.DarkBlue, Color.White));
                        };
                        x += width;
                        y -= height;
                    }
                    x = 0;
                    y += height * 2;
                }
            };

        }
        public BrushInfo mBrushInfo;

        public List<Rectangle> rects = new List<Rectangle>();
        private void DrawHatchBrushes_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                foreach(Rectangle r in rects)
                {
                    if(r.Contains(new Point(e.X, e.Y)))
                    {
                        //                        MessageBox.Show("선택하신 Brush는 " + mHatchRectangles[r].HatchStyle.ToString() + "입니다.");
                        if (Selected != null)
                        {
                            Selected(this, new HatchBrushEventArgs(new BrushInfo() { h = mHatchRectangles[r] })); // 주어진 인수로 함수 포인터 배열 실행.
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    }
                    
                }
            }
        }
    }
}
