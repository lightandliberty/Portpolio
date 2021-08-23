using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawInput_dll
{
    // ProcessRawInput(lParam)에서 입력된 정보KeyPressInfo를 매개변수로 받아 전달할 커스텀 이벤트 객체
    public class RawInputEventArg : EventArgs
    {
        public RawInputEventArg(KeyPressInfo keyPressInfo)
        {
            mKeyPressInfo = keyPressInfo;

        }

        public KeyPressInfo mKeyPressInfo { get; private set; }
    }

    // ProcessRawInput(lParam)에서 정보를 저장할 객체. 위의 RawInputEventArg()생성자의 매개변수
    public class KeyPressInfo
    {
        public string mDeviceName;      // (GetRawInputDeviceInfo(장치리스트를 PtrToStructure로부터 가져온 매개변수)로 얻은 장치 정보. // 예) \\?\HID#VID_045E&PID_00DD&MI_00#8&1eb402&0&0000#{884b96c3-56ef-11d1-bc8c-00a0c91405dd} 
        public string mDeviceType;      // 장치 종류. 예) 키보드 or 마우스 or HID (Human Interface Device)
        public IntPtr mDeviceHandle;    // 입력을 보내는 장치를 향하는 핸들
        public string mName;            // 예) PS/2 Keyboard Input device
        private string m_Source;         // Keyboard_XX
        public int mVKey;               // 가상 키. L/R 키들과 줌키가 수정됨. (예: LSHIFT/RSHIFT)
        public string mVKeyName;        // 가상 키 이름.  L/R 키들과 줌키가 수정됨.(예: LSHIFT/RSHIFT)
        public uint mMessage;           // WM_KEYDOWN 또는 WM_KEYUP
        public string mKeyPressState;   // MAKE 또는 BREAK

        public string Source
        {
            get { return m_Source; }
            set { m_Source = string.Format("Keyboard_{0}", value.PadLeft(2, '0')); } // PadLeft(Int32, Char) 2자리수로 앞에 0을 붙여서 정렬
            // Keyboard_00으로 나옴. 위의 Keyboard_XX대로 나옴.
        }

        public override string ToString()
        {
            // (GetRawInputDeviceInfo(장치리스트를 PtrToStructure로부터 가져온 매개변수)로 얻은
            // 장치 정보, 장치 종류, 장치 핸들, 장치 설명
            return string.Format("Device\n mDeviceName: {0}\n mDeviceType: {1}\n mDeviceHandle: {2}\n mName: {3}\n", mDeviceName, mDeviceType, mDeviceHandle.ToInt64().ToString("X"), mName);
        }
    }

    

}
