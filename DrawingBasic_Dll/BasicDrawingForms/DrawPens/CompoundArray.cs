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
    public partial class CompoundArray : Form
    {
        public CompoundArray()
        {
            InitializeComponent();
        }

        private void CompoundArray_Load(object sender, EventArgs e)
        {

        }

        // 펜 하나로, 여러 사각형을 그린 효과
        /// <summary>
        /// 선과 공간의 비율 설정
        /// 0.0f부터 0.25f까지가 가장 바깥 선, 
        /// 0.25f~0.45f까지 선 사이의 공간
        /// 이런 식으로 1.0f까지 선과 공간이 시작하는 지점을 설정
        /// </summary>
        /// <param name="g"></param>
        private void DrawRectWithCompoundArray(Graphics g)
        {
            using (Pen pen = new Pen(Color.Black, 20))
            {                                  //     선    공간    선    공간    선
                pen.CompoundArray = new float[] { 0.0f, 0.25f, 0.45f, 0.55f, 0.75f, 1.0f };
                g.DrawRectangle(pen, new Rectangle(20, 20, 200, 100));
            }
        }

        private void drawRectBtn_Click(object sender, EventArgs e)
        {
            DrawRectWithCompoundArray(this.CreateGraphics());
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompoundArray_Shown(object sender, EventArgs e)
        {
            DrawRectWithCompoundArray(this.CreateGraphics());
        }
    }
}
