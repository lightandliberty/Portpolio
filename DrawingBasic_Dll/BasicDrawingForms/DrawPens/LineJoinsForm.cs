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
    public partial class LineJoinsForm : Form
    {
        public LineJoinsForm()
        {
            InitializeComponent();
        }

        private void LineJoinsForm_Load(object sender, EventArgs e)
        {
            InitRects();    // 사각형 배열의 위치 등을 초기화
            InitPen();
            SetTabIndex();
            InitLabels();

            // 라벨들의 위치를 사각형의 가운데로 설정
            SetLabelsCenterInRects(labels, rects);
        }

        public Rectangle[] rects;
        public Label[] labels;

        private void InitRects()
        {
            int x = 20;
            int y = 20;
            int width = this.ClientSize.Width/2-20 > 0 ? this.ClientSize.Width / 2 - 40 : 80;
            int height = width / 2;
            int space = 3;
            rects = new Rectangle[] // 윗 줄부터 두 개씩
            {
                new Rectangle(x                  ,y                             , width, height), // 왼쪽위
                new Rectangle(x + width + space  ,y                             , width, height), // 오른쪽위
                new Rectangle(x                  ,y + height + space            , width, height), // 왼쪽 아래
                new Rectangle(x + width + space  ,y + height + space            , width, height)  // 오른쪽 아래
            };
        }

        public void InitLabels()
        {
            labels = new Label[4] {GetLabel(), GetLabel(), GetLabel(), GetLabel() };
            labels[0].Text = System.Drawing.Drawing2D.LineJoin.Bevel.ToString();
            labels[1].Text = System.Drawing.Drawing2D.LineJoin.Miter.ToString();
            labels[2].Text = System.Drawing.Drawing2D.LineJoin.MiterClipped.ToString();
            labels[3].Text = System.Drawing.Drawing2D.LineJoin.Round.ToString();
            for (int i = 0; i < labels.Length; i++)
                this.Controls.Add(labels[i]);
        }
        #region TabIndex 설정 (모든 컨트롤을 담아, 컨트롤의 개수를 셈)
        public int lastTabIndex;
        private void SetTabIndex()
        {
            if (controls == null)
                controls = GetAllControlsRecursive(this);
            lastTabIndex = controls.Length;
        }

        public Control[] controls;
        public Control[] GetAllControlsRecursive(Control containerControl)  // Main object부터 시작
        {
            List<Control> controlList = new List<Control>();
            foreach(Control ctl in containerControl.Controls)   // 자식 컨트롤 하나씩 조회하여
            {
                controlList.Add(ctl);           // list에 넣는다
                if(ctl.Controls.Count > 0)      // 자식 컨트롤의 자식컨트롤이 있으면,
                {
                    // Container이므로,
                    controlList.AddRange(GetAllControlsRecursive(ctl));     // container를 재귀 호출한다. 그리고, 그 값들은 AddRange로 리스트에 추가한다.
                }
            }
            return controlList.ToArray();   // 컨트롤을 리스트로 반환한다.
        }
        #endregion TabIndex 설정 (모든 컨트롤을 담아, 컨트롤의 개수를 셈) 끝.

        private Label GetLabel()
        {
            Label l = new Label();
            l.AutoSize = true;
            l.Location = new System.Drawing.Point(12, 240);
            l.Name = "label1";
            l.Size = new System.Drawing.Size(24, 12);
            l.TabIndex = lastTabIndex++;
            l.Text = "";
            l.Visible = false;
            return l;
        }

        public Pen pen;
        public Pen innerPen;

        private void InitPen()
        {
            pen = new Pen(new SolidBrush(Color.Black),15);
            innerPen = new Pen(new SolidBrush(Color.White), 1);
        }

        private void DrawRects(Graphics g)
        {
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            g.DrawRectangle(pen, rects[0]);
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Miter;
            g.DrawRectangle(pen, rects[1]);
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.MiterClipped;
            g.DrawRectangle(pen, rects[2]);
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            g.DrawRectangle(pen, rects[3]);

            // rect 안에 두께 1의 사각형을 하나 더 그림
            for(int i = 0; i < rects.Length; i++)
                g.DrawRectangle(innerPen, rects[i]);

        }

        // Rects의 가운데 위치에 레이블들을 위치 시킴
        private void SetLabelsCenterInRects(Label[] labels, Rectangle[] rects)
        {
            if (labels.Length != rects.Length)
                return;

            // 모든 라벨의 길이를 재서, rects의 가운데로 위치를 설정.
            for (int i = 0; i < labels.Length; i++)
            {
                // 라벨의 길이를 잰다
                Size labelSize = GetStrLength(labels[i].Text, labels[i].Font);
                // 사각형에서의 가운데 위치를 라벨에 설정한다.
                int x = rects[i].X + rects[i].Width / 2 - labelSize.Width / 2;
                int y = rects[i].Y + rects[i].Height / 2 - labelSize.Height / 2;
                labels[i].Location = new Point(x, y);
            }
        }

        private Size GetStrLength(string str, Font font)
        {
            // 이렇게 하면 뒤의 빈 공간의 크기를 재지 않는다는데,, 실험해보자.
            SizeF originalPlusa = this.CreateGraphics().MeasureString(str + "a", font, 0, StringFormat.GenericTypographic);
            SizeF a = this.CreateGraphics().MeasureString("a", font, 0, StringFormat.GenericTypographic);
            SizeF original = new SizeF(originalPlusa.Width - a.Width, originalPlusa.Height); // 너비만 뒷 부분이 더 길므로,
            return new Size((int)original.Width, (int)original.Height);
        }


        private void drawJoinsBtn_Click(object sender, EventArgs e)
        {
            DrawRects(this.CreateGraphics());
            for (int i = 0; i < labels.Length; i++)
                labels[i].Visible = true;
        }
    }
}
