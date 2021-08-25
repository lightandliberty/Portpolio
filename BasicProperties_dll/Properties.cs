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
    }
}
