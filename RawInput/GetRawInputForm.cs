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
    public partial class GetRawInputForm : Form
    {
        // 본격적으로 RawInput을 캐치할 프로그램
        public RawInput _rawInput = null;
        public RawInputInfo mRawKeyboardInputInfo = null; // 키보드 정보 저장
        public RawInputInfo mRawMouseInputInfo = null;    // 마우스 정보 저장
        // RegisterRawInputDevices의 Flags에 전달될 CaptureOnlyInForeground는 RawInputDeviceFlags.NONE를 설정하고, false면 RawInputDeviceFlags.INPUTSINK(foreground가 아닐때 받는 입력도 수신함)를 설정함
        const bool CaptureOnlyInForeground = true;

        public GetRawInputForm()
        {
            InitializeComponent();
            _rawInput = new RawInput(Handle, CaptureOnlyInForeground);
            // RawInput클래스에 WndProc가 재정의 되어 있어, 입력이 생기면, ProcessRawInput에 message.LParam을 전달하면,
            // ProcessRawInput()메서드에서 delegate객체에 등록된 메서드를 실행시켜, 이 폼의 키보드/마우스 정보 저장 객체에 저장한다.
            // RawInput클래스의 RawKeyboard객체 _keyboardDriver객체 멤버는 그냥, 메서드를 가지고 있는 객체라고 생각하면 됨.
            _rawInput.KeyPressed += OnKeyPressed; // 이벤트 메서드를 연결

        }


        private void GetRawInputForm_Load(object sender, EventArgs e)
        {
        }

        // 델리게이트 객체에 연결할 메서드. (멤버 객체에 정보를 저장)
        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            // 마우스 | 키보드 정보 객체에 각각 저장
            if (e.mKeyPressInfo.mDeviceType == "MOUSE" && mRawMouseInputInfo == null)
            {
                mRawMouseInputInfo = new RawInputInfo();
                mRawMouseInputInfo.Init(e);
                mouseNameLbl.Text = mRawMouseInputInfo.mDeviceNameInSystem;
            }
            else if (e.mKeyPressInfo.mDeviceType == "KEYBOARD" && mRawKeyboardInputInfo == null)
            {
                mRawKeyboardInputInfo = new RawInputInfo();
                mRawKeyboardInputInfo.Init(e);
                keyboardNameLbl.Text = mRawKeyboardInputInfo.mDeviceNameInSystem;
            }
            //// 마우스 또는 키보드가 여러개여서, 여러 종류를 저장할 경우, 이 경우, 폼 클로징 부분과, 메인에서 받는 마우스, 키보드 정보 객체도 배열로 바꿔줘야 함.
            //else if(e.mKeyPressInfo.mDeviceType == "MOUSE" && mRawMouseInputInfo != null)
            //{

            //}
            //else if (e.mKeyPressInfo.mDeviceType == "KEYBOARD" && mRawKeyboardInputInfo != null)
            //{

            //}
            // 정보를 다 저장했으면,
            if(mRawMouseInputInfo != null && mRawMouseInputInfo.mDeviceNameInSystem != ""
                && mRawKeyboardInputInfo != null && mRawKeyboardInputInfo.mDeviceNameInSystem != "")
                this.Close();

        }

            private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 메인 폼에 매개변수를 넘긴다.
        public delegate void GetArgs(RawInputInfo e);

        public event GetArgs GetKeyboardArgs;
        public event GetArgs GetMouseArgs;
            
        private void GetRawInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GetKeyboardArgs != null && mRawKeyboardInputInfo != null)
                GetKeyboardArgs(mRawKeyboardInputInfo); // 키보드 저장 정보를 메인에 보냄.
            if (GetMouseArgs != null && mRawMouseInputInfo != null)
                GetMouseArgs(mRawMouseInputInfo);       // 마우스 저장 정보를 메인에 보냄.
        }

        private void GetRawInputForm_Shown(object sender, EventArgs e)
        {
            this.instLbl.Focus();
        }
    }

}
