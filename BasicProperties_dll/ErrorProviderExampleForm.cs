using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            // 폼 최초 로드시, 모든 컨트롤에 대해 툴팁을 보여 준다.(infoProvider사용)
            foreach(Control control in GetAllControls(this))
            {
                string savedToolTip = toolTip1.GetToolTip(control);  // 툴팁을 얻어서,
                if (savedToolTip.Length == 0) continue;      // 툴팁이 등록되어 있지 않으면, 다음 컨트롤로 넘김.
                infoProvider.SetError(control, savedToolTip);
            }
            textBox1.Text =
                "x64/Release폴더에 html파일이 있으면 F1키를 눌렀을 때 표시됩니다." +
                "\r\n리소소에 포함시켜서는 표시되지 않습니다.";
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
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            string savedToolTip = toolTip1.GetToolTip((Control)sender); // 툴팁을 저장
            
            // 유효성 검사.(ToolTip과 ErrorProvider는 별개의 객체임)
            // 1. TextBox의 칸이 빈칸이면, 2.툴팁의 문자열을 3. ErrorProvider에 전달해서 표시.
            // 2. TextBox의 칸이 빈칸이 아니면, 2.툴팁의 문자열을 3. infoProvider에 전달해서 표시.
            if((sender as TextBox).Text.Length == 0)    // 실패하면
            {
                errorProvider1.SetError((sender as TextBox), savedToolTip);     // 에러 provider 켬
                infoProvider.SetError((sender as TextBox), null);               // 정보 provider 끔
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError((sender as TextBox), null);             // 에러 provider 끔
                infoProvider.SetError((sender as TextBox), savedToolTip);       // 정보 provider 켬.
            }



            //string error = null;
            //if ((sender as TextBox).Text.Length == 0)
            //{
            //    error = "Please enter a name";
            //    e.Cancel = true;
            //}
            //// error가 null이면 오류 아이콘 표시 안 됨.
            //errorProvider1.SetError((Control)sender, error);
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
            StringFormat sf = new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
            Alignment = StringAlignment.Center
            };
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
            StringFormat sf = new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
            Alignment = StringAlignment.Center
            };
            g.DrawString((sender as Button).Text,
                new Font((sender as Button).Font.Name, 10), System.Drawing.Brushes.Black,
                new Rectangle(new Point(0, 0), new Size((sender as Button).Size.Width, (sender as Button).Size.Height)),
                sf);
        }
        #endregion
        private void OKMetalBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // 모든 자식 컨트롤에 대해 직접적으로 유효성 검사를 한다.
            foreach (Control control in GetAllControls(this))
            {
                // 이 컨트롤에 대해 유효성 검사를 한다.
                control.Focus();
                if (!this.Validate())    //마지막으로 포커스를 잃은 컨트롤에 대해서만 유효성 검사를 한다. // 유효성 검사의 함수 deligate 객체 배열 실행. 결과. 즉 e.Cancel == false이면,
                {
                    this.DialogResult = DialogResult.None;
                    break;
                }
            }
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

        // HelpButton == true로 했을 때, 발생하는 HelpRequested이벤트
        private void ErrorProviderExampleForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // 만약 마우스를 클릭한 것이 아니라 <F1>키를 눌렀다면. (Control클래스의 MouseButtons속성 : 이벤트가 발생했을 때, 어느 마우스 버튼이 눌렸는지 알 수 있음.)
            if (Control.MouseButtons == MouseButtons.None)
            {
                
                // 도움말 파일을 연다.
                string file = Path.GetFullPath("errorproviderexampleform.html");
                //MessageBox.Show(file.ToString());
                //MessageBox.Show(Application.StartupPath);
                //                this.Focus();
                try
                {
                    // HTML파일을 열어 도움말을 보여 줌.
                    Help.ShowHelp(this, file);
                }
                catch (Exception e)
                {
                    //MessageBox.Show("멈췄습니다.\n" + file + "이 있는지 확인해 보세요.");
                    Help.ShowPopup(this, "도움말 HTML파일이 없습니다.\n" + file + "이 있는지 확인해 보세요.", hlpevent.MousePos);
//                    this.applicantNameTextBox.Focus();
                }

                hlpevent.Handled = true;
            }
            else // 도움말 버튼을 이용해서 컨트롤을 클릭한 거면,
            {
                // 화면 좌표를 클라이언트 좌표로 변환한다.
                Point pt = this.PointToClient(hlpevent.MousePos);

                // 사용자가 어느 컨트롤을 클릭했는지 찾는다.
                // 주의: GetChildAtPoint 메서드는 (그룹 상자 안에 있는 컨트롤처럼)
                // 다른 컨트롤에 포함된 컨트롤을 제대로 처리하지 못한다.
                Control controlNeedingHelp = null;
                foreach (Control control in GetAllControls(this))
                {
                    // 컨트롤의 영역 안에 클라이언트 마우스 좌표가 포함되어 있으면,
                    if (control.Bounds.Contains(pt))
                    {
                        // 도움말이 필요한 컨트롤에 컨트롤을 복사하고, 루프를 끝냄.(마우스 포인터가 동시에 두 군데에 있을 수는 없으므로)
                        controlNeedingHelp = control;
                        break;
                    }
                }

                // 도움말을 보여준다.
                string help = toolTip1.GetToolTip(controlNeedingHelp);
                if (help.Length == 0) return;

                // ?를 누르고, 칸을 눌렀을 경우, 팝업 도움말로 보여 준다.
                try
                {
                    // 표시할 부모 컨트롤, 메시지, 마우스 포인터 위치
                    Help.ShowPopup(this, help, hlpevent.MousePos);
                }
                catch ( Exception e)
                {
                    MessageBox.Show("멈췄습니다.\n");
                }

                hlpevent.Handled = true;        // Handled속성은 help이벤트를 종료시키는 역할을 함.
            }
        }
    }
}
