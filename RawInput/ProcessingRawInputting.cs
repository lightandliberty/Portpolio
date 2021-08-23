using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawInput_dll
{
    public partial class ProcessingRawInputting : Form
    {
        public readonly RawInput _rawinput;

        // RegisterRawInputDevices의 Flags에 전달될 CaptureOnlyInForeground는 RawInputDeviceFlags.NONE를 설정하고, false면 RawInputDeviceFlags.INPUTSINK(foreground가 아닐때 받는 입력도 수신함)를 설정함
        const bool CaptureOnlyInForeground = true;

        string mName = "";
        string mDeviceName = "";
        string mDeviceType = "";

        // 생성자
        public ProcessingRawInputting()
        {
            InitializeComponent();

            _rawinput = new RawInput(Handle, CaptureOnlyInForeground);
            _rawinput.KeyPressed += OnKeyPressed;
            // RegisterRawInputDevices의 Target멤버에 전달될 parentHandle로 Handle을 전달.(Handle은 IntPtr)
            // RegisterRawInputDevices의 Flags에 전달될 CaptureOnlyInForeground는 RawInputDeviceFlags.NONE를 설정하고, false면 RawInputDeviceFlags.INPUTSINK(foreground가 아닐때 받는 입력도 수신함)를 설정함
        }

        // 얻어올 정보. RawKeyboard에서 처리
        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            label2.Text = e.mKeyPressInfo.mName + ": " + e.mKeyPressInfo.mDeviceName;
            mName = e.mKeyPressInfo.mName;
            mDeviceName = e.mKeyPressInfo.mDeviceName;
            mDeviceType = e.mKeyPressInfo.mDeviceType;
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _rawinput.KeyPressed += OnKeyPressed;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        // 포커스가 있는 컨트롤에 이벤트를 전달하기 전에, 폼에서 이벤트를 받을지 여부를 결정하는 KeyPreview 를 true로 설정
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (DialogResult.Yes == MessageBox.Show("프로그램을 종료합니다.", "프로그램 종료", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                    this.Close();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        // 명령키는 일반 키가 적용되기 전에 처리됨. 메인 폼에서 KeyPreview = true로 설정하여 해결할 것이므로, 아래는 일단 생략
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if(keyData == Keys.Escape)
        //    {
        //        this.Close();
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
    }
}
