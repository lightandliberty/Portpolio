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
    public partial class Properties: Form
    {
        Color mControlColor;
        public Properties()
        {
            InitializeComponent();
            mControlColor = this.BackColor;
        }

        private void TopMostBtn_Click(object sender, EventArgs e)
        {
            this.TopMost = this.TopMost.Equals(true) ? false : true;
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

        }

        private void SetControlBoxBtn_Click(object sender, EventArgs e)
        {
            this.ControlBox = this.ControlBox.Equals(true) ? false : true;
            if (this.ControlBox.Equals(false))
                this.SetControlBoxBtn.BackColor = Color.Red;
            else
                this.SetControlBoxBtn.BackColor = mControlColor;

            this.Text = "this.ControlBox = " + this.ControlBox.ToString();
            instructionTextBox.Text = "폼의 좌측 상단에 아이콘을 위치시킬지, 우측상단에 종료 버튼을 위치시킬지,\r\n왼쪽상단 왼쪽버튼 클릭시 또는 오른쪽 상단 오른쪽 버튼 클릭시 메뉴 안 뜸";
        }

        private void SetMaxiMiniBtn_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = this.MaximizeBox.Equals(true) ? false : true;
            this.MinimizeBox = this.MinimizeBox.Equals(true) ? false : true;
            if (this.MaximizeBox.Equals(false))
                this.SetMaxiMiniBtn.BackColor = Color.Red;
            else
                this.SetMaxiMiniBtn.BackColor = mControlColor;
            this.Text = "this.MaximizeBox = " + this.MaximizeBox.ToString() + ", this.MinimizeBox = " + this.MinimizeBox.ToString();
            instructionTextBox.Text = "최소화, 최대화 버튼 표시";
        }

        private void SetHelpIconBtn_Click(object sender, EventArgs e)
        {
            this.HelpButton = this.HelpButton.Equals(true) ? false : true;
            if (this.HelpButton.Equals(false))
                this.SetHelpIconBtn.BackColor = Color.Red;
            else
                this.SetHelpIconBtn.BackColor = mControlColor;
            this.Text = "this.HelpButton = " + this.HelpButton.ToString();
            this.instructionTextBox.Text = "우측 상단에 ?표시의 버튼 표시.(단, ControlBox는 true, Maximize, Minimize는 false여야 함. \r\n?클릭시 HelpRequested이벤트 발생.\r\nfalse여도 <F1>키를 누르면 HelpRequested 이벤트 발생";
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
        }

        private void PopupOpacityFormBtn_Click(object sender, EventArgs e)
        {
            this.instructionTextBox.Text = "새 창의 Opacity = 0.5, TopMost = true에 타이머를 추가하여, 불투명도가 0.1씩 증가하도록 설정합니다.";
            OpacityForm opacityForm = new OpacityForm();
            opacityForm.StartPosition = FormStartPosition.CenterParent;
            opacityForm.ShowDialog();
        }
    }
}
