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

    public class RawInputInfo
    {
        public string mDeviceNameInSystem = string.Empty;
        public string mDeviceNameWithoutAmpersand = string.Empty;
        public string mDeviceType = string.Empty;
        public string mDeviceDesc = string.Empty;
        public string mArgForOpenSubKey = string.Empty; // OpenSubKey() 매개변수
        public string mRegistryKey = string.Empty;
        public string mDeviceClass = string.Empty;
        public string mClassGuid = string.Empty;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("mDeviceNameInSystem         : "); sb.Append(mDeviceNameInSystem);
            sb.Append("mDeviceNameWithoutAmpersand : "); sb.Append(mDeviceNameWithoutAmpersand);
            sb.Append("mDeviceType                 : "); sb.Append(mDeviceType);
            sb.Append("mDeviceDesc                 : "); sb.Append(mDeviceDesc);
            sb.Append("mArgForOpenSubKey           : "); sb.Append(mArgForOpenSubKey);
            sb.Append("mRegistryKey                : "); sb.Append(mRegistryKey);
            sb.Append("mDeviceClass                : "); sb.Append(mDeviceClass);
            sb.Append("mClassGuid                  : "); sb.Append(mClassGuid);
            return sb.ToString();
        }
        public void Init(RawInputEventArg e)
        {
            // label2.UseMnemonic = false; // &를 표시하기 위해. Label과 Button은 &를 접근 키 문자의 접두어로 쓰므로, false로 해 줘야 &가 표시된다.
            // &문자는 Alt키와 함께 눌러져서, 컨트롤에 바로 포커스를 줄 수 있다. &는 지역화 리소스로서 사용되고, 바로가기를 명시하기 위해 사용된다.

            mDeviceNameInSystem = e.mKeyPressInfo.mDeviceName;       // 장치의 내부 이름
            mDeviceNameWithoutAmpersand = e.mKeyPressInfo.mDeviceName.Replace("&", ""); // &을 뗀 이름. 나중에 장치의 내부 이름을 비교할 땐, &를 제거하고 비교해야 한다.
            mDeviceType = e.mKeyPressInfo.mDeviceType;       // 장치 종류        
            mDeviceDesc = e.mKeyPressInfo.mName;              // 장치 설명

            // 장치의 내부 이름, 장치의 클래스 코드, 장치의 서브 클래스 코드, 장치의 프로토콜 코드, 장치의 레지스트리 키, 장치 설명, 장치의 로컬 머신 키
            string[] deviceNameSplit = e.mKeyPressInfo.mDeviceName.Substring(4).Split('#');

            // Registry.LocalMachine.OpenSubKey의 매개변수 openRegSb생성
            StringBuilder openRegSb = new StringBuilder();
            openRegSb.Append(@"System\CurrentControlSet\Enum");
            for (int i = 0; i < deviceNameSplit.Length - 1; i++)   // {} mDeviceName의 중괄호 부분이 들어가면 안되므로, Length-1을 해줌. Length를 하면, 중괄호 부분인 [3]까지 들어감.
            {
                openRegSb.Append("\\"); openRegSb.Append(deviceNameSplit[i]);
            }

            // Registry.LocalMachine.OpenSubKey의 매개변수를 나누어서 담았을 경우,
            //string classCode = deviceNameSplit[0]; string subClassCode = (deviceNameSplit[1] != null) ? deviceNameSplit[1] : ""; string protocolCode = (deviceNameSplit[2] != null) ? deviceNameSplit[2] : "";

            //label14.Text = string.Format(@"System\CurrentControlSet\Enum\{0}\{1}\{2}", classCode, subClassCode, protocolCode); // 담긴 값 확인
            mArgForOpenSubKey = openRegSb.ToString();
            //Debug.WriteLine("deviceNameSplit.Length = " + deviceNameSplit.Length.ToString());

            Microsoft.Win32.RegistryKey deviceRegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(openRegSb.ToString());   // 레지스트리
            // 나누어서 담긴 매개변수로 레지스트리 키 값을 얻을 때
            //Microsoft.Win32.RegistryKey deviceRegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(string.Format(@"System\CurrentControlSet\Enum\{0}\{1}\{2}", classCode, subClassCode, protocolCode)) ;   

            mRegistryKey = deviceRegistryKey?.ToString();  // 장치 레지스트리. 장치 이름은 deviceRegistryKey.GetValue("DeviceDesc").ToString()로 읽고, deviceKey.GetValue("DeviceDesc").ToSTring().Substring(deviceKey.GetValue("DeviceDesc").ToSTring().IndexOf(';')+1);로 장치 이름 접근

            // 장치 클래스. 클래스 GUID, 클래스GUID키
            if (deviceRegistryKey != null && deviceRegistryKey.GetValue("ClassGUID") != null)
            {
                string classGuid = deviceRegistryKey.GetValue("ClassGUID").ToString();
                Microsoft.Win32.RegistryKey classGuidKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Class\" + classGuid);
                string deviceClass = (classGuidKey != null ? (string)classGuidKey.GetValue("Class") : string.Empty).ToString(); // 장치 클래스
                mDeviceClass = deviceClass; // 장치 클래스
                mClassGuid = classGuid;
            }
            else // 기존에 입력된 classGuid값, deviceClass값 초기화.
            {
                mDeviceClass = "";
                mClassGuid = "";
            }

        }
    }


}
