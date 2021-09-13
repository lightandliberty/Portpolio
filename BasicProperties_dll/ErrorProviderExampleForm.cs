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
    public partial class ErrorProviderExampleForm : Form
    {
        #region 생성자, 초기화
        public ErrorProviderExampleForm()
        {
            InitializeComponent();
        }

        private void ErrorProviderExampleForm_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region 텍스트 상자 1,2,3 설정 및 유효성 검사
        // 첫번째 Text
        private void ApplicantNameLabel_Click(object sender, EventArgs e)
        {

        }

        // 두번째 Text
        private void ApplicantPhoneLabel_Click(object sender, EventArgs e)
        {

        }

        // 세번째 Text
        private void LoanAmountLabel_Click(object sender, EventArgs e)
        {

        }

        // 첫번째 텍스트 유효성 검사
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if ((sender as TextBox).Text.Length == 0)
            {
                error = "Please enter a name";
                e.Cancel = true;
            }
            // error가 null이면 오류 아이콘 표시 안 됨.
            errorProvider1.SetError((Control)sender, error);
        }
        #endregion


        #region OK 버튼 설정
        // OK버튼

        #endregion

        #region Cancel 버튼 설정
        // OK버튼

        #endregion


        #region 버튼색을 메탈색으로 설정
        public static void DrawThisButtonColorToMetal(object sender, Graphics gra)
        {
            // 전달된 버튼의 색을 변경
            Graphics g = gra;
            g.FillRectangle(
                new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as Button).Height), Color.White, Color.LightGray),
                new RectangleF(new Point(0, 0), new Size((sender as Button).Size.Width, (sender as Button).Size.Height)));
            // 버튼에 표시할 Text 중앙 정렬
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString((sender as Button).Text,
                new Font((sender as Button).Font.Name, 10), System.Drawing.Brushes.Black,
                new Rectangle(new Point(0, 0), new Size((sender as Button).Size.Width, (sender as Button).Size.Height)),
                sf);
        }

        public static void DrawThisButtonColorToClickedMetal(object sender, Graphics gra)
        {
            // 전달된 버튼의 색을 변경
            Graphics g = gra;
            g.FillRectangle(
                new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as Button).Height), Color.LightGray, Color.White),
                new RectangleF(new Point(0, 0), new Size((sender as Button).Size.Width, (sender as Button).Size.Height)));
            // 버튼에 표시할 Text 중앙 정렬
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString((sender as Button).Text,
                new Font((sender as Button).Font.Name, 10), System.Drawing.Brushes.Black,
                new Rectangle(new Point(0, 0), new Size((sender as Button).Size.Width, (sender as Button).Size.Height)),
                sf);
        }
        #endregion
        private void OKMetalBtn_Click(object sender, EventArgs e)
        {

            // 모든 자식 컨트롤에 대해 직접적으로 유효성 검사를 한다.
            foreach (Control control in GetAllControls(this))
            {
                // 이 컨트롤에 대해 유효성 검사를 한다.
                control.Focus();
                if (!this.Validate())   // 유효성 검사의 함수 deligate 객체 배열 실행. 결과. 즉 e.Cancel == false이면,
                {
                    this.DialogResult = DialogResult.None;
                    break;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void CancelMetalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // 모든 컨트롤과 모든 자식 컨트롤을 얻는 메서드 (컬렉션은 queue에만 저장하고, 컨트롤 각각은 ArrayList에 저장 및 리턴)
        public static Control[] GetAllControls(Form form)
        {
            System.Collections.ArrayList allControls = new System.Collections.ArrayList();
            // ControlCollection 배열을 만듦.
            System.Collections.Generic.Queue<Control.ControlCollection> queue = new System.Collections.Generic.Queue<Control.ControlCollection>();
            // queue에는 컨트롤의 컬렉션만 저장하고, 하나하나 까서 개개의 컨트롤을 allControls배열에 저장함.
            queue.Enqueue(form.Controls);
            while (queue.Count > 0)
            {
                // queue의 제잎 앞 원소를 controls에 이동
                Control.ControlCollection controls = (Control.ControlCollection)queue.Dequeue();
                // 저장된 원소 자체가 없거나, 저장된 컬렉션 원소에 컨트롤이 없으면, 큐에 원소가 없으면, 자식 컨트롤을 검사하지 않고, 다음 원소를 확인. 다음 원소가 없으면, 종료
                if (controls == null || controls.Count == 0) continue;
                // 이동한 컨트롤 컬렉션안에 원소들을 allControls배열에 담고, 큐에 추가함.
                foreach (Control control in controls)
                {
                    // 겉으로 보이는 모든 컨트롤을 저장.
                    allControls.Add(control);              // 모든 컨트롤 배열에 컨트롤의 하위 컨트롤을 추가

                    queue.Enqueue(control.Controls);        // queue의 뒤에 추가
                    if(control != null)
                    {
                    }
                }
            }

            return (Control[])allControls.ToArray(typeof(Control));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
