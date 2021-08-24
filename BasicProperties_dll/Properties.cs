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
            this.TopMost = true;
        }

        private void SetNotTopMostBtn_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
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
            this.Text = this.FormBorderStyle.ToString();
        }

        private void SetControlBoxBtn_Click(object sender, EventArgs e)
        {
            this.ControlBox = this.ControlBox.Equals(true) ? false : true;
            if (this.ControlBox.Equals(false))
                this.SetControlBoxBtn.BackColor = Color.Red;
            else
                this.SetControlBoxBtn.BackColor = mControlColor;

            this.Text = this.ControlBox.ToString();
        }
    }
}
