using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicProperties_dll
{
    public partial class ProcessLayoutEventForm : Form
    {
        public ProcessLayoutEventForm()
        {
            InitializeComponent();
        }

        private void ProcessLayoutEventForm_Load(object sender, EventArgs e)
        {

        }

        private void ProcessLayoutEventForm_Layout(object sender, LayoutEventArgs e)
        {
            // 모든 사항이 변경되지 전까지 레이아웃 변경을 보류시킨다.
            this.SuspendLayout();

            // 폼 안의 그리드 형태로 버튼을 정렬한다.
            Button[] buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            int cx = ClientRectangle.Width / 3;
            int cy = ClientRectangle.Height / 3;
            for(int row = 0; row < 3; ++row)
            {
                for(int col = 0; col < 3; ++col)
                {
                    Button button = buttons[col * 3 + row]; // x좌표의 위치가 col에 의해 영향을 받고, y좌표의 위치가 row에 영형을 받으므로
                    button.SetBounds(cx * row, cy * col, cx, cy);
                }
            }

            // 버튼 컨트롤의 폭과 높이로부터 폼 클라이언트 크기를 설정한다.
            SetClientSizeCore(cx * 3, cy * 3);

            // 레이아웃 변경이 가능하게 한다.
            this.ResumeLayout();
        }
    }
}
