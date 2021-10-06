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
        public LineCapsForm()
        {
            InitializeComponent();
        }

        private void LineCapsForm_Load(object sender, EventArgs e)
        {
            InitLineCapsList();
        }

        
        public Dictionary<int, System.Drawing.Drawing2D.LineCap> mLineCapsList;
        public void InitLineCapsList()
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
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    pen.EndCap = mLineCapsList[lineCapKeyNum++];
                    switch(pen.EndCap)
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
                        x            , y + height * 2 / 3, 
                        x + width / 3 * 2 , y + height * 2 / 3);
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
        #endregion
    }
}
