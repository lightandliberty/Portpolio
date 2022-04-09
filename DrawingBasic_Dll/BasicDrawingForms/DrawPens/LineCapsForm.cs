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
    public partial class LineCapsForm : Form
    {

        public Pen mPen;

        public LineCapsForm()
        {
            InitializeComponent();
        }

        private void LineCapsForm_Load(object sender, EventArgs e)
        {
            InitLineCapsList();
        }

        
        public Dictionary<int, System.Drawing.Drawing2D.LineCap> mLineCapsList;
        public Dictionary<int, Rectangle> mLineCapsList_RectDic;

        public void InitLineCapsList()
        {
            SetLineCapsList();

        }

        private void SetLineCapsList()
        {
            int keyNum = 0;
            mLineCapsList = new Dictionary<int, System.Drawing.Drawing2D.LineCap>();
            mLineCapsList.Add(keyNum++, System.Drawing.Drawing2D.LineCap.ArrowAnchor);
            mLineCapsList.Add(keyNum++, System.Drawing.Drawing2D.LineCap.DiamondAnchor);
            mLineCapsList.Add(keyNum++, System.Drawing.Drawing2D.LineCap.NoAnchor);
            mLineCapsList.Add(keyNum++, System.Drawing.Drawing2D.LineCap.RoundAnchor);
            mLineCapsList.Add(keyNum++, System.Drawing.Drawing2D.LineCap.SquareAnchor);
            mLineCapsList.Add(keyNum++, System.Drawing.Drawing2D.LineCap.Custom);
            mLineCapsList.Add(keyNum++, System.Drawing.Drawing2D.LineCap.Flat);
            mLineCapsList.Add(keyNum++, System.Drawing.Drawing2D.LineCap.Round);
            mLineCapsList.Add(keyNum++, System.Drawing.Drawing2D.LineCap.Square);
            mLineCapsList.Add(keyNum++, System.Drawing.Drawing2D.LineCap.Triangle);

            keyNum = 0;
            int x = 0;
            int y = 0;
            int width = this.ClientSize.Width / 2;
            int height = this.ClientSize.Height / 6;    // 마지막 1/6은 OK, Cancel 버튼
            mLineCapsList_RectDic = new Dictionary<int, Rectangle>(); // mLineCapsList의 인덱스에 해당하는 rect영역을 저장.

            for (int columnIdx = 0; columnIdx < 2; columnIdx++)     // 2열
            {
                for (int rowIdx = 0; rowIdx < 5; rowIdx++)          // 5줄
                {
                    mLineCapsList_RectDic[keyNum++] = new Rectangle(x, y, width, height);
                    System.Diagnostics.Debug.WriteLine(mLineCapsList_RectDic[keyNum-1].Width.ToString()); // Rect의 ToString()
                    y += height;
                }

                // x좌표를 width만큼 옮기고, height를 가장 위로 당김
                x += width;
                y -= height * 5;
            }

        }

        private void LineCapsForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 12);
            Pen whitePen = new Pen(Color.White, 1);
            int x = 0;
            int y = 0;
            int width = this.ClientSize.Width / 2;
            int height = this.ClientSize.Height / 6;    // 마지막 1/6은 OK, Cancel 버튼
            int lineCapKeyNum = 0;
            for (int columnIdx = 0; columnIdx < 2; columnIdx++)     // 2열
            {

                for (int rowIdx = 0; rowIdx < 5; rowIdx++)          // 5줄
                {
                    pen.EndCap = mLineCapsList[lineCapKeyNum++];    // 펜 끝의 모양을 mLineCapsList에서 지정
                    switch (pen.EndCap)
                    {
                        case System.Drawing.Drawing2D.LineCap.Custom:
                            pen.CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(8f, 1f, true);
                            break;
                        default:
                            break;
                    }
                    // 세로로 다섯개의 선을 그리고, (i == 0, j == 0 ~ 4) , 그옆에 또 다섯줄 그림(i == 1, j == 1 ~ 4)
                    g.DrawString(pen.EndCap.ToString(), this.Font, Brushes.Black, x, y + height / 3);
                    g.DrawLine(pen,
                        x, y + height * 2 / 3,
                        x + width / 3 * 2, y + height * 2 / 3);  // 왜 너비의 3/2, 너비의 2/3의 길이로 선을 두 개 그리지?
                    g.DrawLine(whitePen,
                        x, y + height * 2 / 3,
                        x + width * 2 / 3, y + height * 2 / 3);
                    y += height;
                }
                // x좌표를 width만큼 옮기고, height를 가장 위로 당김
                x += width;
                y -= height * 5;
            }
        }

        #region OK, Cancel 버튼
        private void CancelMetalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okMetalBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion  OK, Cancel 버튼 끝.

    }
}
