using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RawInput_dll
{
    public class RawInput : NativeWindow
    {
        
        public RawKeyboard _keyboardDriver;

        // 메시지를 넘길지 필터링할 지 결정하는 객체
        private PreMessageFilter _filter;
        // KeyPressed이벤트가 발생했을 때, _keyboardDriver객체의 .KeyPressed 함수 배열에 이벤트에 추가
        // EventArgs를 상속한 RawInputEventArgs를 이용해 delegate로 public delegate void DeviceEventHandler(object sender, RawInputEventArgs e)라고 정의하고, 그걸로 KeyPress이름의 객체를 생성하면 KeyPressed이벤트가 생성 되는 듯하다.
        // 여기서는 키가 눌리면, 객체 안의 KeyPressed부분이 실행되도록, 정의 부분을 추가해 주었지만.
        public event RawKeyboard.DeviceEventHandler KeyPressed
        {
            add { _keyboardDriver.KeyPressed += value; }
            remove { _keyboardDriver.KeyPressed -= value; }
        }

        // 모든 부분에서 키 입력을 받음.(포커스가 없을 때도)
        public void AddMessageFilter()
        {
            if (null != _filter) return;

            _filter = new PreMessageFilter();
            Application.AddMessageFilter(_filter);
        }

        // 앱에서 메시지 필터링을 삭제
        private void RemoveMessageFilter()
        {
            if (null != _filter) return;
            Application.RemoveMessageFilter(_filter);
        }

        public RawInput(IntPtr parentHandle, bool captureOnlyInForeground)
        {
            // Form컨트롤의 Handle속성에서 가져온 핸들을 AssignHandle을 사용하지 않으면 FormHandle이 작동하지 않으므로,
            // 운영체제 창 메시지를 가로채기위해, Native Window로 핸들 전달 및 생성
            AssignHandle(parentHandle);

            // RawInput생성자에서 RawKeyboard객체 생성자 호출
            _keyboardDriver = new RawKeyboard(parentHandle, captureOnlyInForeground);
            _keyboardDriver.EnumerateDevices();
        }

        // RawInput에서 메시지 override
        // 레지스터 등록은 RawKeyboard생성자에서 했으므로, WM_INPUT 원시입력 이벤트가 발생되겠지?
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message message)
        {
            switch(message.Msg)
            {
                case Win32.WM_INPUT:    // 0x00FF
                    {
                        _keyboardDriver.ProcessRawInput(message.LParam);
                    }
                    break;

                case 0x240:             // WM_TOUCH:
                    {
                        MessageBox.Show("touch");
                        _keyboardDriver.ProcessRawInput(message.LParam);
                    }
                    break;

                case Win32.WM_USB_DEVICECHANGE:
                    {
                        Debug.WriteLine("USB Device Arrival / Removal");
                        _keyboardDriver.EnumerateDevices();
                    }
                    break;
            }
            base.WndProc(ref message);
        }

        ~RawInput()
        {
//            Win32.UnregisterDeviceNotification(_devNotifyHandle);
//            RemoveMessageFilter();
        }




    }
}
