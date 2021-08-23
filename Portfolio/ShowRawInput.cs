using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RawInput_dll;
using System.Diagnostics; // Debug를 위해


namespace Portfolio
{
    public partial class ShowRawInput : Form
    {
        string mName = "";
        string mDeviceName = "";
        string mDeviceType = "";
        public Dictionary<IntPtr, KeyPressInfo> mDeviceList = new Dictionary<IntPtr, KeyPressInfo>();
        string mDeviceRegistryKey = "";
        public bool mProcessing = false;
        //public bool mGotKeyboardName = false;
        //public bool mGotMouseName = false;
        public KeyMouseFlags mKeyMouseFlags = new KeyMouseFlags();

        // 메인에 있는 키보드, 마우스 문자열에 문자가 입력되어 있으면 마우스를 움직이거나 키보드를 누르라는 메시지가 나오지 않기 위해 delegate작성.
        public delegate void SetKeyboardMouseLabel(object sender, ref SetKeyboardMouseEventArgs e);
        public event SetKeyboardMouseLabel SetKeyboardMouseLBL;
        public class SetKeyboardMouseEventArgs : EventArgs
        {
            public SetKeyboardMouseEventArgs(KeyMouseFlags e)
            {
                keyMouseFlags = e;
            }
            public KeyMouseFlags keyMouseFlags { get; set; }
        }

        // 처음에 키보드이름을 얻었는지, 마우스 이름을 얻었는지 값은 false이지만, 한 번 움직이거나 키를 눌러 메인의 변수에 등록되어 있으면 delegate에서 처리하여 안내 문자가 나오지 않음.
        public class KeyMouseFlags
        {
            public bool gotKeyboardName = false;
            public bool gotMouseName = false;
            public KeyMouseFlags()
            {
                gotKeyboardName = false;
                gotMouseName = false;
            }
        }


        public ProcessingRawInputting processingRawInputting = null;
        public ShowRawInput()
        {
            InitializeComponent();
            button1.BackColor = Color.Red;
            processingRawInputting = new ProcessingRawInputting();
            processingRawInputting._rawinput.KeyPressed += OnKeyPressed;
            mDeviceList = processingRawInputting._rawinput._keyboardDriver.mDeviceList;
            mProcessing = true;
        }

        // showRawInput에 추가한 delegate메서드를 실행하는 부분
        public void ProcessDelegate()
        {
            // MainForm에서 함수가 추가되어 있으면, 매개변수를 넣어 실행
            SetKeyboardMouseEventArgs e = new SetKeyboardMouseEventArgs(mKeyMouseFlags);    // MainForm 변수에 마우스 이름, 키보드 이름이 입력되어 있으면 전달된 인수의 값을 바꿈.
            if (SetKeyboardMouseLBL != null)
                SetKeyboardMouseLBL(this, ref e);   // delegate메서드 실행. 참조로 전달해야 e값이 바뀜.
            if (mKeyMouseFlags.gotKeyboardName)
                infoKeyboardNullLabel.Visible = false;
            if (mKeyMouseFlags.gotMouseName)
                infoMouseNullLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!mProcessing)
            {
                button1.BackColor = Color.Red;
                processingRawInputting = new ProcessingRawInputting();
                processingRawInputting._rawinput.KeyPressed += OnKeyPressed;
                mDeviceList = processingRawInputting._rawinput._keyboardDriver.mDeviceList;
                mProcessing = true;
                //            processingRawInputting.ShowDialog();
            }
            else
            {
                button1.BackColor = Color.Silver;
                processingRawInputting.Dispose();
                mProcessing = false;
            }
        }

        // 얻어올 정보. RawKeyboard에서 처리
        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            label2.UseMnemonic = false; // &를 표시하기 위해. Label과 Button은 &를 접근 키 문자의 접두어로 쓰므로, false로 해 줘야 &가 표시된다.
                                        // &문자는 Alt키와 함께 눌러져서, 컨트롤에 바로 포커스를 줄 수 있다. &는 지역화 리소스로서 사용되고, 바로가기를 명시하기 위해 사용된다.
            label4.UseMnemonic = false;

            label2.Text = e.mKeyPressInfo.mDeviceName;       // 장치의 내부 이름
            label4.Text = e.mKeyPressInfo.mDeviceName.Replace("&", ""); // &을 뗀 이름. 나중에 장치의 내부 이름을 비교할 땐, &를 제거하고 비교해야 한다.
            label6.Text = e.mKeyPressInfo.mDeviceType;       // 장치 종류        
            label8.Text = e.mKeyPressInfo.mName;              // 장치 설명

            // 장치의 내부 이름, 장치의 클래스 코드, 장치의 서브 클래스 코드, 장치의 프로토콜 코드, 장치의 레지스트리 키, 장치 설명, 장치의 로컬 머신 키
            string[] deviceNameSplit = e.mKeyPressInfo.mDeviceName.Substring(4).Split('#');

            // Registry.LocalMachine.OpenSubKey의 매개변수 openRegSb생성
            StringBuilder openRegSb = new StringBuilder();
            openRegSb.Append(@"System\CurrentControlSet\Enum");
            for(int i = 0; i < deviceNameSplit.Length-1; i++)   // {} mDeviceName의 중괄호 부분이 들어가면 안되므로, Length-1을 해줌. Length를 하면, 중괄호 부분인 [3]까지 들어감.
            {
                openRegSb.Append("\\"); openRegSb.Append(deviceNameSplit[i]);
            }

            // Registry.LocalMachine.OpenSubKey의 매개변수를 나누어서 담았을 경우,
            //string classCode = deviceNameSplit[0]; string subClassCode = (deviceNameSplit[1] != null) ? deviceNameSplit[1] : ""; string protocolCode = (deviceNameSplit[2] != null) ? deviceNameSplit[2] : "";
            
            //label14.Text = string.Format(@"System\CurrentControlSet\Enum\{0}\{1}\{2}", classCode, subClassCode, protocolCode); // 담긴 값 확인
            label16.Text = openRegSb.ToString();
            //Debug.WriteLine("deviceNameSplit.Length = " + deviceNameSplit.Length.ToString());
            
            Microsoft.Win32.RegistryKey deviceRegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(openRegSb.ToString());   // 레지스트리
            // 나누어서 담긴 매개변수로 레지스트리 키 값을 얻을 때
            //Microsoft.Win32.RegistryKey deviceRegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(string.Format(@"System\CurrentControlSet\Enum\{0}\{1}\{2}", classCode, subClassCode, protocolCode)) ;   

            label10.Text = deviceRegistryKey?.ToString();  // 장치 레지스트리. 장치 이름은 deviceRegistryKey.GetValue("DeviceDesc").ToString()로 읽고, deviceKey.GetValue("DeviceDesc").ToSTring().Substring(deviceKey.GetValue("DeviceDesc").ToSTring().IndexOf(';')+1);로 장치 이름 접근

            // 장치 클래스. 클래스 GUID, 클래스GUID키
            if (deviceRegistryKey != null && deviceRegistryKey.GetValue("ClassGUID") != null)
            {
                string classGuid = deviceRegistryKey.GetValue("ClassGUID").ToString();
                Microsoft.Win32.RegistryKey classGuidKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Class\" + classGuid);
                string deviceClass = (classGuidKey != null ? (string)classGuidKey.GetValue("Class") : string.Empty).ToString(); // 장치 클래스
                label12.Text = deviceClass; // 장치 클래스

                label14.Text = deviceClass.ToUpper().Equals("KEYBOARD").ToString(); // 장치가 키보드인지 장치 클래스로부터
                label18.Text = classGuid;
            }
            else // 기존에 입력된 classGuid값, deviceClass값 초기화.
            {
                label12.Text = "";
                label14.Text = "";
                label18.Text = "";
            }

            // 장치의 레지스트리 키
            mName = e.mKeyPressInfo.mName;
            mDeviceName = e.mKeyPressInfo.mDeviceName;
            mDeviceType = e.mKeyPressInfo.mDeviceType;

            if (mDeviceType == "MOUSE")
            {
                mKeyMouseFlags.gotMouseName = true;
                infoMouseNullLabel.Visible = false;
            }
            if (mDeviceType == "KEYBOARD")
            {
                mKeyMouseFlags.gotKeyboardName = true;
                infoKeyboardNullLabel.Visible = false;
            }
        }

    }
}
