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
    public partial class OpacityForm_Modalless : Form
    {
        public OpacityForm_Modalless()
        {
            InitializeComponent();
        }

        private void OpacityForm_Modalless_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            this.TopMost = true;
            this.Text = "Opacity = " + this.Opacity.ToString();
            // 모달리스에선 아래의 간단 AcceptButton, CancelButton처리가 되지 않음. _Click이벤트에서 처리해 줘야 함.
            //this.AcceptBtn.DialogResult = DialogResult.OK;
            //this.CloseBtn.DialogResult = DialogResult.Cancel;
            this.AcceptButton = this.AcceptBtn;
            this.CancelButton = this.CloseBtn;
        }
        
        // Accept 버튼이 눌러졌을 때 발생하는 이벤트
        public event EventHandler Accept;       // delegate로 정의된 EventHandler의 객체인 Accept 생성. 외부 이벤트 등록 예정.
        public event EventHandler NowClose;     // delegate로 정의된 EventHandler의 객체인 NowClose 생성. 외부 이벤트 등록 예정.

        private void AcceptBtn_Click(object sender, EventArgs e)        // Accept 버튼이 눌려지면 이벤트가 발생한다.
        {
            this.DialogResult = DialogResult.OK;

            if (Accept != null)                 // 이벤트(외부)가 등록되어 있으면, 등록된 이벤트를 실행한다.
                Accept(this, e);
        }

        // 닫기 버튼에서 외부 이벤트를 실행. (외부에서 포커스를 맞추고, 내부를 해제해야 함.)
        public void CloseBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            if (NowClose != null)
                NowClose(this, e);      // 외부에서 등록한 외부 메서드가 실행 됨.
        }

        // 창이 활성화 되면 타이머를 켬
        public void OpacityForm_Modalless_Activated(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        // 창이 비활성화 되면, 타이머 루프를 끄고, 투명도를 절반으로 낮춤.
        public void OpacityForm_Modalless_Deactivate(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Opacity = 0.5;
            this.Text = "Opacity = " + this.Opacity.ToString();
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
                this.Opacity += 0.1;
            this.Text = "Timer is Enabled" + "Opacity = " + this.Opacity.ToString();
        }

        public void TickResetBtn_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;

        }
    }
}

            //this.Controls.Add(acceptBtn);