using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicProperties_dll
{
    public partial class BasicProperties_MainForm : Form
    {
        public readonly Color mControlColor;        // 초기화 되었지만 내부에서 다시 지정되지 않으므로,
        public BasicProperties_MainForm()
        {
            InitializeComponent();
            mControlColor = System.Drawing.SystemColors.Control;
        }

        private void Properties_Load(object sender, EventArgs e)
        {
            this.TopMostBtn.ContextMenuStrip = contextMenuStrip2;
            this.ControlBoxPropLabel.Text = this.ControlBox.ToString();
            this.FormBorderStylePropLabel.Text = this.FormBorderStyle.ToString();
            this.HelpButtonPropLabel.Text = this.HelpButton.ToString();
            this.MinimizeBoxPropLabel.Text = this.MinimizeBox.ToString();
            this.MaximizePropLabel.Text = this.MaximizeBox.ToString();
            this.ShowInTaskBarPropLabel.Text = this.ShowInTaskbar.ToString();
            this.SizeGripStylePropLabel.Text = this.SizeGripStyle.ToString();
        }


        private void TopMostBtn_Click(object sender, EventArgs e)
        {
            this.TopMost = this.TopMost == false;// false : true;
            //this.TopMost = this.TopMost.Equals(true) ? false : true;

            if (this.TopMost.Equals(true))
                this.TopMostBtn.BackColor = Color.Red;
            else
                this.TopMostBtn.BackColor = mControlColor;
            this.Text = "this.TopMost = " + this.TopMost.ToString();
            this.instructionTextBox.Text = "다른 창들보다 항상 위에 있도록 설정";
        }

        private void ReadFromAppConfigBtn_Click(object sender, EventArgs e)
        {
            System.Configuration.AppSettingsReader appSettings = new System.Configuration.AppSettingsReader();
            try
            {
                object o = appSettings.GetValue("MainFormOpacity", typeof(double));
                if(o != null)
                    MessageBox.Show(((double)o).ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("각 프로젝트의 App.config파일 안에 <configuration>안에 <appSettings> </appSettings>사이에 <add key = \"MainFormOpacity\" value=\".5\" /> 를 추가해 주세요.");
                instructionTextBox.Text = "프로젝트 폴더에 App.config파일안에 key값으로 접근하여 프로그램에서 적재 가능한데\r\n없을 경우, 예외 메시지 표시하고, 설명 표시";
            }
        }

        private void LoadBitmapBtn_Click(object sender, EventArgs e)
        {
            try { Bitmap backgroundImage = new Bitmap(@"C:\cocoa.png"); }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() + @" C:\cocoa.png 파일이 없습니다.");
                MessageBox.Show("1. 추가_기존항목으로 추가. 2.파일 오른쪽 클릭_속성_빌드작업_포함 리소스 선택 후, new Bitmap(this.GetType(), \"cocoa.png\" 하면 됩니다. 그러면, 리소스 이름은 Properties.cocoa.png이 된다.");
                MessageBox.Show("아니면 디자이너에서 [속성]_BackgroundImage옆 ... 을 누른뒤에 선택한다.");
            }
            instructionTextBox.Text = "C:\\cocoa.png파일이 없으면, 예외 메시지를 표시하고, Bitmap 객체로 적재하는 법 설명";
        }

        private void ChangeFormBorderStyleBtn_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = 
                this.FormBorderStyle.Equals(FormBorderStyle.SizableToolWindow) ? FormBorderStyle.FixedToolWindow :
                this.FormBorderStyle.Equals(FormBorderStyle.FixedToolWindow) ? FormBorderStyle.FixedDialog :
                this.FormBorderStyle.Equals(FormBorderStyle.FixedDialog) ? FormBorderStyle.FixedSingle : 
                this.FormBorderStyle.Equals(FormBorderStyle.Sizable) ? FormBorderStyle.SizableToolWindow :
                FormBorderStyle.Sizable;
            if (!this.FormBorderStyle.Equals(FormBorderStyle.Sizable))
            {
                if(FormBorderStyle.Equals(FormBorderStyle.SizableToolWindow))
                    ChangeFormBorderStyleBtn.BackColor = Color.Red;
                else
                    ChangeFormBorderStyleBtn.BackColor = System.Drawing.Color.FromArgb(255, ChangeFormBorderStyleBtn.BackColor.R-15, ChangeFormBorderStyleBtn.BackColor.G + 40, ChangeFormBorderStyleBtn.BackColor.B + 40);
            }
            else
                ChangeFormBorderStyleBtn.BackColor = Color.Silver;
            this.Text = "this.FormBorderStyle = " + this.FormBorderStyle.ToString();
            instructionTextBox.Text = "폼에 테두리가 있는지, 크기 조정이 가능한지\r\n보통크기의 캡션 표시줄인지, 작은 크기의 캡션 표시줄인지";

            this.FormBorderStylePropLabel.Text = this.FormBorderStyle.ToString();
        }

        private void SetControlBoxBtn_Click(object sender, EventArgs e)
        {
            this.ControlBox = this.ControlBox == false;
            if (this.ControlBox.Equals(false))
                this.SetControlBoxBtn.BackColor = Color.Red;
            else
                this.SetControlBoxBtn.BackColor = mControlColor;

            this.Text = "this.ControlBox = " + this.ControlBox.ToString();
            instructionTextBox.Text = "폼의 좌측 상단에 아이콘을 위치시킬지, 우측상단에 종료 버튼을 위치시킬지,\r\n왼쪽상단 왼쪽버튼 클릭시 또는 오른쪽 상단 오른쪽 버튼 클릭시 메뉴 안 뜸";
            this.ControlBoxPropLabel.Text = this.ControlBox.ToString();

        }

        private void SetMaxiMiniBtn_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = this.MaximizeBox == false;
            this.MinimizeBox = this.MinimizeBox == false;
            if (this.MaximizeBox.Equals(false))
                this.SetMaxiMiniBtn.BackColor = Color.Red;
            else
                this.SetMaxiMiniBtn.BackColor = mControlColor;
            this.Text = "this.MaximizeBox = " + this.MaximizeBox.ToString() + ", this.MinimizeBox = " + this.MinimizeBox.ToString();
            instructionTextBox.Text = "최소화, 최대화 버튼 표시";
            this.MinimizeBoxPropLabel.Text = this.MinimizeBox.ToString();
            this.MaximizePropLabel.Text = this.MaximizeBox.ToString();

        }

        private void SetHelpIconBtn_Click(object sender, EventArgs e)
        {
            this.HelpButton = this.HelpButton == false;
            if (this.HelpButton.Equals(false))
                this.SetHelpIconBtn.BackColor = Color.Red;
            else
                this.SetHelpIconBtn.BackColor = mControlColor;
            this.Text = "this.HelpButton = " + this.HelpButton.ToString();
            this.instructionTextBox.Text = "우측 상단에 ?표시의 버튼 표시.(단, ControlBox는 true, Maximize, Minimize는 false여야 함. \r\n?클릭시 HelpRequested이벤트 발생.\r\nfalse여도 <F1>키를 누르면 HelpRequested 이벤트 발생";

            this.HelpButtonPropLabel.Text = this.HelpButton.ToString();

        }

        private void Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void SetSizeGripStyleBtn_Click(object sender, EventArgs e)
        {
            this.SizeGripStyle =
                this.SizeGripStyle.Equals(SizeGripStyle.Auto) ? SizeGripStyle.Hide :
                this.SizeGripStyle.Equals(SizeGripStyle.Hide) ? SizeGripStyle.Show :
                SizeGripStyle.Auto;
            switch(this.SizeGripStyle)
            {
                case SizeGripStyle.Auto:
                    this.SetSizeGripStyleBtn.BackColor = mControlColor;
                    break;
                case SizeGripStyle.Hide:
                    this.SetSizeGripStyleBtn.BackColor = Color.Red;
                    break;
                case SizeGripStyle.Show:
                    this.SetSizeGripStyleBtn.BackColor = Color.FromArgb(255, 150, 150, 0);
                    break;
                default:
                    this.SetSizeGripStyleBtn.BackColor = mControlColor;
                    break;
            };

            this.Text = "this.SizeGripStyle = " + this.SizeGripStyle.ToString();
            this.instructionTextBox.Text = "폼의 우측 하단 크기 조정 그립을 보여주거나 감추거나 함.\r\n폼에 상태 표시줄(status bar) 컨트롤이 있는 경우, 상태 표시줄 자체 속성의 SizingGrip속성에 의해 조정 그립을 보이거나 감춤.";
            this.SizeGripStylePropLabel.Text = this.SizeGripStyle.ToString();

        }

        private void SetShowInTaskbarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ShowInTaskbar.Equals(false))
                {
                    this.ShowInTaskbar = true;
                }
                else if (this.ShowInTaskbar.Equals(true))
                {
                    this.ShowInTaskbar = false;
                }

                if (this.ShowInTaskbar.Equals(false))
                    this.SetShowInTaskbarBtn.BackColor = Color.Red;
                else
                    this.SetShowInTaskbarBtn.BackColor = mControlColor;
                this.Text = "this.ShowInTaskbar = " + this.ShowInTaskbar.ToString();
                this.instructionTextBox.Text = "폼을 최소화 시켰을 때, 폼의 타이틀을 작업 표시줄에 버튼형태로 나타낼지 여부\r\n그런데, this.ShowInTaskbar = true로 하면 예외 메시지를 보내지 않고 충돌하므로,\r\nHide()를 사용합니다.";
                MessageBox.Show("런타임에 this.ShowInTaskbar가 false가 되면, 프로그램이 충돌하여 종료됩니다.\r\n" +
                    "MainForm.cs에서 ShowInTaskbar속성을 바꿔본 후 관찰해 보세요.");
                ////    this.ShowInTaskbar = this.ShowInTaskbar.Equals(true) ? false : true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("예외가 발생했습니다." + ex.ToString());
            }
            this.ShowInTaskBarPropLabel.Text = this.ShowInTaskbar.ToString();
        }

        private void PopupOpacityFormBtn_Click(object sender, EventArgs e)
        {
            this.instructionTextBox.Text = "새 창의 Opacity = 0.5, TopMost = true에 타이머를 추가하여, 불투명도가 0.1씩 증가하도록 설정합니다." +
                "\r\n폼의 종료버튼이 폼의 .CancelButton에, 폼의 센터 버튼이 .AcceptButton에 연결되어 있습니다." +
                "\r\nthis.CenterBtn.DialogResult = DialogResult.OK;로 설정하고" +
                "\r\nthis.FormCloseBtn.DialogResult = DialogResult.Cancel;로 설정하면, Click이벤트 없이도 처리됩니다.";

            // IDE0017 개체 초기화를 단순화할 수 있습니다.
            OpacityForm opacityForm = new OpacityForm() {
                StartPosition = FormStartPosition.CenterParent,
            };
            
//            opacityForm.StartPosition = FormStartPosition.CenterParent;
            opacityForm.ShowDialog();
        }

        private void CreateTransparentFormBtn_Click(object sender, EventArgs e)
        {
            this.instructionTextBox.Text = "새 창의 Paint이벤트에서 그리도록 설정하고, TransParencyKey값을 .BackColor속성 값 System.Drawing.SystemColors.Control과 같게 설정.\r\nFormBorderStyle을 None으로 설정. MouseMove등 따로 설정.";

            TransparentForm transparentForm = new TransparentForm();
            transparentForm.ShowDialog();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 버전정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("포트폴리오 버전 1.0");
        }

        private void ForeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog { FullOpen = true };
            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                this.ForeColor = colorDialog.Color;
            }
        }

        private void BackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog { FullOpen = true };
            if(DialogResult.OK ==  colorDialog.ShowDialog())
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void SetFlatAppearenceBtn_Click(object sender, EventArgs e)
        {
            FlatAppearanceForm flatAppearanceForm = new FlatAppearanceForm();
            flatAppearanceForm.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string controlName = FindControlAtCursor(this)?.Name + "의 contextMenu입니다.";
            MessageBox.Show( controlName);
        }

        private void ProcessLayoutEventBtn_Click(object sender, EventArgs e)
        {
            ProcessLayoutEventForm processLayoutEventForm = new ProcessLayoutEventForm();
            processLayoutEventForm.ShowDialog();
        }

        private void CreateMDIBtn_Click(object sender, EventArgs e)
        {
            // 부모폼을 컨테이너로 설정. // SplitContainer에 창들을 넣으면 정렬 안 됨.
            this.instructionTextBox.Text = "SplitContainer에 창들을 넣으면 정렬 안 됨.";
            MDIForm mdiForm = new MDIForm();
            mdiForm.ShowDialog();
        }


        // 모달리스는 사용자가 원하는 동안은 유지되어야 하므로, 지역변수로 있어선 안 되므로, 멤버 변수로 선언
        public OpacityForm_Modalless opacityForm_Modalless;
        //{
        //    get;
        //    set;
        //}

        public void PopupOpacityFormModallessBtn_Click(object sender, EventArgs e)
        {
            this.instructionTextBox.Text = "새 창의 Opacity = 0.5, TopMost = true에 타이머를 추가하여, 불투명도가 0.1씩 증가하도록 설정합니다." +
                "\r\n 모달리스 폼입니다." +
                "\r\n폼에 Accept버튼 이벤트를 등록하고, Close 메서드를 이용해서, Close버튼을 만듦." +
                "\r\n그냥 <Enter>키와 <ESC>키를 누르면 적용 됨.";

            // IDE0017 개체 초기화를 단순화할 수 있습니다.
            // 모달리스 폼 초기화
            opacityForm_Modalless = new OpacityForm_Modalless()
            {
                StartPosition = FormStartPosition.CenterParent,
//                Owner = this,   // 나중에 해제를 위해
            };
            // 현재(부모) 폼의 이벤트 함수를 -> (자식)모달리스 폼의 이벤트 함수에 전달.(추가)
            opacityForm_Modalless.Accept += new EventHandler(OpacityFormModalless_WhenSonAccept);  // 대화상자에서 Accept버튼이 눌려지면, 그 값에 접근하기 위해.
            opacityForm_Modalless.NowClose += new EventHandler(OpacityFormModalless_WhenSonClose);
            opacityForm_Modalless.Show();

        }

        // 모달리스 폼의 객체에 접근
        void OpacityFormModalless_WhenSonAccept(object sender, EventArgs e)
        {
            // 자식 폼을 부모 폼에서 복사
            OpacityForm_Modalless copiedForm = sender as OpacityForm_Modalless;
            // 자식 폼의 property에 접근
            MessageBox.Show(copiedForm.Text);
            copiedForm.Close();
            //copiedForm.Dispose();
        }

        // 모달리스 폼을 닫기 위해, 부모 폼에 포커스를 맞추고, 닫음.
        void OpacityFormModalless_WhenSonClose(object sender, EventArgs e)
        {
            // 대화 상자에서 얻어 온 결과 값을 저장하고, 자식 폼을 해제
            DialogResult dr = (sender as OpacityForm_Modalless).DialogResult;
            this.Focus();   // 부모 폼으로 포커스를 맞추지 않으면 에러 남.
            opacityForm_Modalless.Close();
            opacityForm_Modalless.Dispose() ;
            MessageBox.Show(dr.ToString());
        }

        private void ErrorProviderBtn_Click(object sender, EventArgs e)
        {
            ErrorProviderExampleForm errorProviderExampleForm = new ErrorProviderExampleForm()
            {
                Text = "Loan Application",
            };

            this.instructionTextBox.Text = "TextBox의 Validating()이벤트를 처리합니다.";
            errorProviderExampleForm.ShowDialog();
        }

        // 마우스 커서 위치에 있는 컨트롤 찾기.
        // 폼 안에 커서가 있을 때 실행되므로, 클라이 언트 영역 안에서만 비교하면 됨.
        public static Control FindControlAtPoint(Control container, Point mouseClientPosition)
        {
            Control child;
            foreach (Control c in container.Controls)
            {
                // 자식 컨트롤들이 있고, 자식 컨트롤들 중에 마우스 위치를 포함하는 자식컨트롤이 있는 경우,
                // 처음으로 발견하는 자식 컨트롤을 리턴. 그런데, 마지막까지 파고들어 감.
                //MessageBox.Show((c.Visible && c.Bounds.Contains(mouseClientPosition)).ToString());
                //// c.Bound가 Client영역인데?
                //MessageBox.Show("c.Visible = " + c.Visible.ToString());
                //MessageBox.Show("pos.X = " + MousePosition.X.ToString());
                //MessageBox.Show("pos.Y = " + MousePosition.Y.ToString());
                //MessageBox.Show("c.Bounds.X = " + c.Bounds.X.ToString());
                //MessageBox.Show("c.Bounds.Y = " + c.Bounds.Y.ToString());
                //MessageBox.Show("c.Bounds.Width = " + c.Bounds.Width.ToString());
                //MessageBox.Show("c.Bounds.Height = " + c.Bounds.Height.ToString());

                if (c.Visible && c.Bounds.Contains(mouseClientPosition))   // .Bounds는 컨트롤의 크기와 위치를 나타내는 Rectangle
                {
                    // 마우스 위치를 포함하는 자식 컨트롤이 없으면 child가 null, 있으면 child가 컨트롤을 가짐.
                    child = FindControlAtPoint(c, mouseClientPosition);
                    // 마우스 위치를 포함하는 자식 컨트롤이 없으면, 상위 컨트롤을 리턴.
                    if (child == null) return c;
                    // 마우스 위치를 포함하는 자식 컨트롤이 있으면, 자식 컨트롤을 리턴.
                    else return child;
                }
            }
            // 마우스 위치를 포함하는 자식 컨트롤이 없는 경우 null을 리턴.
            return null;
        }

        //}        // 마우스 커서 위치에 있는 컨트롤 찾기. // 사실상 pos는 안 쓰이는 거 아닌가?
        //public static Control FindControlAtPoint(Control container, Point pos)
        //{
        //    Control child;
        //    foreach(Control c in container.Controls)
        //    {
        //        // 자식 컨트롤들이 있고, 자식 컨트롤들 중에 마우스 위치를 포함하는 자식컨트롤이 있는 경우,
        //        // 처음으로 발견하는 자식 컨트롤을 리턴. 그런데, 마지막까지 파고들어 감.
        //        if (c.Visible && c.Bounds.Contains(MousePosition))   // .Bounds는 컨트롤의 크기와 위치를 나타내는 Rectangle
        //        {
        //            // 마우스 위치를 포함하는 자식 컨트롤이 없으면 child가 null, 있으면 child가 컨트롤을 가짐.
        //            child = FindControlAtPoint(c, new Point(pos.X - c.Left, pos.Y - c.Top));
        //            // 마우스 위치를 포함하는 자식 컨트롤이 없으면, 상위 컨트롤을 리턴.
        //            if (child == null) return c;
        //            // 마우스 위치를 포함하는 자식 컨트롤이 있으면, 자식 컨트롤을 리턴.
        //            else return child;
        //        }
        //    }
        //    // 마우스 위치를 포함하는 자식 컨트롤이 없는 경우 null을 리턴.
        //    return null;
        //}

        public static Control FindControlAtCursor(Form form)
        {
            Point pos = Cursor.Position;
            // 폼이 커서 위치를 포함하고 있으면,
            if (form.Bounds.Contains(pos)) // 그러니까 이 .Bounds는 커서의 절대 위치를 포함해야 하는데,
                // 위에서 child옆 FindControlAtPoint(c, 여기는 상대 위치가 들어가는데...)
                // 그러니까 이게, Cursor.Position이 화면의 좌표가 아니라,
                // Form에서의 좌표이고,
                // form.Bounds.Contains가 클라이언트 좌표이면 말이되는데,
                // 그런데, 그려면 의미가 없는데,... 사각형 범위가 벗어나는 곳만 체크하므로,
                // c.Left가 컨테이너의 가장자리와 컨트롤의 가장자리 사이의 거리라고 하므로,
                // 
            {
//                MessageBox.Show("form.Bounds.Contains(Cursor.Position)실행중입니다.");
                return FindControlAtPoint(form, form.PointToClient(Cursor.Position));
                //return FindControlAtPoint(form, form.PointToClient(Cursor.Position));
            }
            return null;
        }
    }
}
