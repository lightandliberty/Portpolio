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
    public partial class OpacityForm : Form
    {
        public OpacityForm()
        {
            InitializeComponent();
            this.Opacity = 0.5;
            this.TopMost = true;
            this.Text = "Opacity = " + this.Opacity.ToString();
        }

        private void OpacityForm_Load(object sender, EventArgs e)
        {
            // 이렇게 설정하면, Click이벤트 없이도, Enter와 ESC로 Click이벤트 처리 가능
            this.ConfirmBtn.DialogResult = DialogResult.OK;
            this.CloseBtn.DialogResult = DialogResult.Cancel;
            this.AcceptButton = this.ConfirmBtn;
            this.CancelButton = this.CloseBtn;
        }

        public void OpacityForm_Activated(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        public void OpacityForm_Deactivate(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Opacity = 0.5;
            this.Text = "Opacity = " + this.Opacity.ToString();
        }

        public void CenterBtn_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0) this.Opacity += 0.1;
//            if (this.Opacity >= 1.0) this.Opacity = 0.5;
            this.Text = "Timer is Enabled" + "Opacity = " + this.Opacity.ToString();
        }

        virtual public void FormCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }


}
