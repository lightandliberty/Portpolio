using System;
using System.Diagnostics;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.InteropServices;   // StructLayout, LayoutKind 사용을 위해

namespace RawInput_dll
{
    // 폼에서 RawInput객체를 만들고, 그 객체에 창의 핸들을 전달하여, 그 객체에서 RawKeyboard객체를 생성.
    // RawKeyboard(hwnd, true) 생성자에서
    // 처음에 WM_INPUT메시지가 발생하도록 설정하고,
    // 장치 리스트를 저장한 후,
    // WM_INPUT메시지에서 얻은 정보로 KeyPressed이벤트 설정.
    
    // 폼에서 만들었던 RawInput 객체에서 WM_INPUT: 메시지 재정의함.

    // (RawKeyboard객체를 내포한 RawInput클래스에서 KeyPressed등의 이벤트가 발생할 때, RawKeyboard.KeyPressed에 추가되도록 설정하고,
    // 폼의 KeyPressed이벤트를 RawKeyboard의 KeyPress이벤트에 추가하면, 그 RawKeyboard에서 RawInput이 발생할 때마다, KeyPress메서드가 갱신되고,(폼에서 추가한 이벤트는 안 사라지나?)
    // 폼에서 단추를 누르거나, 글자를 입력할 때, RawKeyboard의 KeyPress에 이벤트가 추가되므로, label에 갱신된 자료로 표시됨.
    // 
    
    public sealed class RawKeyboard     // 상속으로부터 봉인 (오버라이드 안 됨)
    {
        // KeyPressed이벤트를 등록할 모형(함수 포인터 생성)
        public delegate void DeviceEventHandler(object sender, RawInputEventArg e);
        // KeyPressed이벤트 멤버 생성(함수 포인터 배열 생성)
        public event DeviceEventHandler KeyPressed; 
        
        // 장치 리스트 생성(_rawBuffer.header.hdevice)가 key값, KeyPressInfo(이벤트 객체 매개변수)가 value
        public readonly Dictionary<IntPtr, KeyPressInfo> mDeviceList = new Dictionary<IntPtr, KeyPressInfo>();
        // WM_INPUT에서 얻은 정보를 저장할 객체(키보드에서 발생한 신호인지, 마우스에서 발생한 신호인지)
        public static InputData _rawBuffer;
        
        // 쓰레드 락 매개변수 객체
        readonly object _padLock = new object();    // 한 번에 하나의 쓰레드만 사용하도록. lock(매개변수)
        public int mNumberOfKeyboards { get; private set; }

        // RawInputDevice객체를 만들어, 장치의 종류, 입력 데이터를 받을 창 범위등을 정하고, WM_INPUT제공하는 장치를 등록
        public RawKeyboard(IntPtr hwnd, bool captureOnlyInForeground)   // 여기서 쓰이는 생성자
        {
            StartRawInputCapture(hwnd, captureOnlyInForeground);
            if(!Win32.RegisterTouchWindow(hwnd, 0)) // 성공시 0 아닌 값을 리턴하므로,
            {
                Debug.Print("ERROR: Could not register window for multi touch");
            }
        }

        // WM_INPUT메시지가 발생하도록 등록
        public void StartRawInputCapture(IntPtr hwnd, bool captureOnlyInForeground)
        {
            // WM_INPUT 메시지 발생하도록 등록할 객체
            RawInputDevice[] rid = new RawInputDevice[3]; // 마우스는 0x02, 키보드는 0x06

            // 키보드
            rid[0].UsagePage = HidUsagePage.GENERIC;    // 0x01
            rid[0].Usage = HidUsage.Keyboard;           // 0x06
            // 나중에 원시 입력 데이터 제공 받지 않도록 장치를 해제할 때는 RIDEV_REMOVE;를 등록
            rid[0].Flags = (captureOnlyInForeground ? RawInputDeviceFlags.NONE : RawInputDeviceFlags.INPUTSINK) | RawInputDeviceFlags.DEVNOTIFY;
            rid[0].Target = hwnd;

            // 마우스
            rid[1].UsagePage = HidUsagePage.GENERIC; // 0x01
            rid[1].Usage = HidUsage.Mouse;           // 0x02
            // 나중에 원시 입력 데이터 제공 받지 않도록 장치를 해제할 때는 RIDEV_REMOVE;를 등록
            rid[1].Flags = (captureOnlyInForeground ? RawInputDeviceFlags.NONE : RawInputDeviceFlags.INPUTSINK) | RawInputDeviceFlags.DEVNOTIFY;  // 장치를 추가하고, 제거하는 정보까지 제공 받음
            rid[1].Target = hwnd;

            // 터치 패드
            rid[2].UsagePage = HidUsagePage.GENERIC; // 0x01
            rid[2].Usage = HidUsage.Tablet;           // 0x80
            // 나중에 원시 입력 데이터 제공 받지 않도록 장치를 해제할 때는 RIDEV_REMOVE;를 등록
            rid[2].Flags = (captureOnlyInForeground ? RawInputDeviceFlags.NONE : RawInputDeviceFlags.INPUTSINK) | RawInputDeviceFlags.DEVNOTIFY;  // 장치를 추가하고, 제거하는 정보까지 제공 받음
            rid[2].Target = hwnd;

            

            // 원시 입력 데이터를 제공하는 장치를 등록 (User32.dll)
            if (false == Win32.RegisterRawInputDevices(rid, (uint)rid.Length, (uint)Marshal.SizeOf(rid[0])))
            {
                throw new ApplicationException("Failed to register raw input device(s).");
            }
        }
        
        // WM_INPUT메시지가 더이상 발생하지 않도록 등록
        public void EndRawInputCapture(IntPtr hwnd, bool captureOnlyInForeground)
        {
            // WM_INPUT 메시지가 발생하지 않도록 매개변수로 전달할 객체
            RawInputDevice[] rid = new RawInputDevice[2]; // 마우스는 0x02, 키보드는 0x06

            // 키보드
            rid[0].UsagePage = HidUsagePage.GENERIC; // 0x01
            rid[0].Usage = HidUsage.Keyboard;       //0x06
            // 나중에 원시 입력 데이터 제공 받지 않도록 장치를 해제할 때는 RIDEV_REMOVE;를 등록
            rid[0].Flags = RawInputDeviceFlags.REMOVE;
            rid[0].Target = hwnd;

            // 마우스
            rid[1].UsagePage = HidUsagePage.GENERIC; // 0x01
            rid[1].Usage = HidUsage.Mouse;           // 0x02
            // 나중에 원시 입력 데이터 제공 받지 않도록 장치를 해제할 때는 RIDEV_REMOVE;를 등록
            rid[1].Flags = RawInputDeviceFlags.REMOVE;
            rid[1].Target = hwnd;

            // 터치 패드
            rid[2].UsagePage = HidUsagePage.GENERIC; // 0x01
            rid[2].Usage = HidUsage.Tablet;           // 0x80
            // 나중에 원시 입력 데이터 제공 받지 않도록 장치를 해제할 때는 RIDEV_REMOVE;를 등록
            rid[2].Flags = RawInputDeviceFlags.REMOVE;
            rid[2].Target = hwnd;


            // 원시 입력 데이터를 제공하는 장치를 등록 (User32.dll)
            if (false == Win32.RegisterRawInputDevices(rid, (uint)rid.Length, (uint)Marshal.SizeOf(rid[0])))
            {
                throw new ApplicationException("Failed to remove raw input device(s) message.");
            }
        }
        
        // 장치들을 _deviceList에 저장
        public void EnumerateDevices()
        {
            // 쓰레드 락
            lock(_padLock)
            {
                mDeviceList.Clear();

                int keyboardNumber = 0;

                // KeyPressInfo객체 초기화
                KeyPressInfo globalDevice = new KeyPressInfo
                {
                    mDeviceName = "Unknown Device Driver",
                    mDeviceHandle = IntPtr.Zero,
                    mDeviceType = Win32.GetDeviceType(DeviceType.Unknown),
                    mName = "KeyPressInfo초기 설정 값. ZOOM, MUTE, VOLUMEUP, VOLUMEDOWN 키들이 0의 핸들값으로 RawInput으로 보내진다",
                    Source = keyboardNumber++.ToString(CultureInfo.InvariantCulture)

                };

                // 0. CultureInfo.InvariantCulture 값이 궁금해서 궁금해서 시험삼아
                //System.Windows.Forms.MessageBox.Show(globalDevice.Source.ToString());
                // Keyboard_00으로 나옴.

                // 장치 리스트 배열에 초기화 시 입력한 장치 하나 추가
                mDeviceList.Add(globalDevice.mDeviceHandle, globalDevice);

                int numberOfDevices = 0;
                uint deviceCount = 0;
                int dwSize = (Marshal.SizeOf(typeof(Rawinputdevicelist)));  // 장치 리스트 객체의 크기

                // 원시 입력 장치의 수를 deviceCount에 저장하고, 성공시 pRawInputDeviceList에 포함된 장치의 수를 반환. (null이므로 0을 반환하는 듯)
                if(Win32.GetRawInputDeviceList(IntPtr.Zero, ref deviceCount, (uint)dwSize) == 0)
                {
                    // pRawInputDeviceList 핸들이 가리키는 곳에 Rawinputdevicelist크기 * 장치의 수만큼 할당
                    IntPtr pRawInputDeviceList = Marshal.AllocHGlobal((int)(dwSize * deviceCount));
                    // 할당받은 pRawInputDeviceList에 장치 리스트 정보를 저장
                    Win32.GetRawInputDeviceList(pRawInputDeviceList, ref deviceCount, (uint)dwSize);

                    for (int i = 0; i < deviceCount; i++)
                    {
                        uint pcbSize = 0;       // pData버퍼에 필요한 최소 크기

                        // 얻어온 장치리스트를 c#객체에 담음
                        Rawinputdevicelist rid = (Rawinputdevicelist)Marshal.PtrToStructure(new IntPtr((pRawInputDeviceList.ToInt64() + (dwSize * i))), typeof(Rawinputdevicelist));

                        // pcbSize를 pData버퍼에 필요한 최소크기로 설정.
                        // hDevice는 65504등의 handle
                        Win32.GetRawInputDeviceInfo(rid.hDevice, RawInputDeviceInfo.RIDI_DEVICENAME, IntPtr.Zero, ref pcbSize);

                        if (pcbSize <= 0) continue;

                        // 입력받은 pcbSize의 크기만큼 pData에 메모리를 할당. User32.dll함수를 사용하므로, IntPtr을 사용
                        IntPtr pData = Marshal.AllocHGlobal((int)pcbSize);
                        // pData에 장치 정보를 입력 받음. (예: pData는 7105320 등)
                        Win32.GetRawInputDeviceInfo(rid.hDevice, RawInputDeviceInfo.RIDI_DEVICENAME, pData, ref pcbSize);  // pData는 DeviceInfo
                        // deviceName은 장치 일렬번호같은 이름
                        string deviceName = Marshal.PtrToStringAnsi(pData);
                        // deviceDesc는 흔히 보는 장치 이름
                        string deviceDesc = Win32.GetDeviceDescription(deviceName);
                        // 이벤트 객체의 생성자에 매개변수로 정보를 전달할 객체
                        KeyPressInfo dInfo = new KeyPressInfo
                        {
                            mDeviceName = Marshal.PtrToStringAnsi(pData),   // deviceName과 같지만, 그냥 한 번 더 계산
                            mDeviceHandle = rid.hDevice,                    // 장치의 핸들 ( mDeviceList의 Key값이 됨 )
                            mDeviceType = Win32.GetDeviceType(rid.dwType),  // "MOUSE", "KEYBOARD", "HID", "UNKNOWN" 중 하나. rid.dwType값은 DeviceType.RimTypemouse, DeviceType.RimTypekeyboard, DeviceType.RimtypeHid, 혹은 그외,
                            mName = Win32.GetDeviceDescription(Marshal.PtrToStringAnsi(pData)), // deviceDesc와 같음
                            Source = keyboardNumber++.ToString(CultureInfo.InvariantCulture)    // Keyboard_XX로 설정됨.
                        };

                        if (false == mDeviceList.ContainsKey(rid.hDevice))   // 당연히 없겠지만, 핸들이 배열에 없으면 장치 정보를 추가
                        {
                            numberOfDevices++;
                            mDeviceList.Add(rid.hDevice, dInfo);
                        }

                        // 장치 데이터를 해제
                        Marshal.FreeHGlobal(pData);
                    }

                    Marshal.FreeHGlobal(pRawInputDeviceList);

                    mNumberOfKeyboards = numberOfDevices;
                    Debug.WriteLine("EnumerateDevices() found {0} Keyboard(s)", mNumberOfKeyboards);

                    return;
                }
            }

            // 원시입력 장치의 수를 deviceCount에 저장하는 데 실패했다면, 마지막 에러 메시지를 예외로 던짐.
            throw new Win32Exception(Marshal.GetLastWin32Error());
        }

        // 아까 원시 입력이 발생하도록 RegisterRawInputDevices()에 등록했고,
        // override로 WndProc()에서 WM_INPUT이 발생하면, ProcessRawInput(lParam)이 실행되도록 하였으므로,
        // 원시 입력 정보를 채워서, RawInputEventArg생성자의 매개변수로 전달함.

        public void ProcessRawInput(IntPtr hdevice)
        {
            // 장치 리스트 수가 없으면 종료
            if (mDeviceList.Count == 0) return;

            int dwSize = 0; // 원시 입력 RawInput객체

            // lParam값으로부터 _buffer.header.hDevice값을 구함.
            // (lParam, uiCommand, pData, pcbSize, cbSizeHeader)
            // 저장하는 곳이 null이면 필요한 크기가 dwSize에 저장된다.(에러일 경우 -1리턴)
            Win32.GetRawInputData(hdevice, DataCommand.RID_INPUT, IntPtr.Zero, ref dwSize, Marshal.SizeOf(typeof(Rawinputheader)));
            //Win32.GetRawInputData(hdevice, DataCommand.RID_HEADER, IntPtr.Zero, ref dwSize, Marshal.SizeOf(typeof(Rawinputheader)));
            
            // _rawBuffer.header.hDevice에 장치의 hDevice 65502등의 장치 리스트 키 저장
            // RID_HEADER면 RAWINPUT구조체의 헤더 정보를 얻고, RID_INPUT이면 RID_INPUT구조체의 raw data를 얻는다.
            // 에러일 경우 -1 리턴, _rawBuffer가 null이면 0리턴, 아니면, _rawBuffer에 복사한 바이트 크기 리턴
            //if (dwSize != Win32.GetRawInputData(hdevice, DataCommand.RID_HEADER, out _rawBuffer, ref dwSize, Marshal.SizeOf(typeof(Rawinputheader))))
            if (dwSize != Win32.GetRawInputData(hdevice, DataCommand.RID_INPUT, out _rawBuffer, ref dwSize, Marshal.SizeOf(typeof(Rawinputheader))))
            {
                // 필요했던 크기만큼 복사하지 못했으면,
                Debug.WriteLine("Error getting the rawinput buffer");
                return;
            }

            // 터치패드의 경우는 GetRawInputData()로 정보를 읽어오지 못하는 거 같다.

            // 입력되지 않았을 땐, 0
            //Debug.WriteLine(_rawBuffer.data.keyboard.ToString());
            //Debug.WriteLine(_rawBuffer.data.mouse.ToString());
            //Debug.WriteLine(_rawBuffer.data.hid.ToString());
//            Debug.WriteLine(_rawBuffer.header.ToString());

            // 원시입력 장치의 종류가 키보드면(1이면)
            if (_rawBuffer.header.dwType == DeviceType.RimTypekeyboard)
            {
                // 가상키, 눌린 키 코드, 
                int virtualKey = _rawBuffer.data.keyboard.VKey;     // 가상 키 코드
                int makeCode = _rawBuffer.data.keyboard.Makecode;   // 키 눌림으로부터 코드를 탐색한다.
                int flags = _rawBuffer.data.keyboard.Flags;         // 하나 이상의 RI_KEY_MAKE, RI_KEY_BREAK, RI_KEY_E0, RI_KEY_E1

                // 매핑되지 않은 키 코드(0xFF)면 종료
                if (virtualKey == Win32.KEYBOARD_OVERRUN_MAKE_CODE) return;

                // 왼쪽에 있는 키가 눌렸는지,(예: LShift, LCtrl, LAlt)
                // 나중에 VirtualKeyCorrection()의 매개변수로 쓰임
                bool isE0BitSet = ((flags & Win32.RI_KEY_E0) != 0);

                KeyPressInfo keyPressInfo;

                // .header.hDevice는 위의 GetRawInputData에서 자동으로 채워짐.
                // 눌려진 장치의 정보가 EnumerateDevices()에서 저장한 배열에 있으면, 배열로부터 정보를 채움
                if (mDeviceList.ContainsKey(_rawBuffer.header.hDevice))
                {
                    // 스레드 고정
                    lock (_padLock)
                    {
                        keyPressInfo = mDeviceList[_rawBuffer.header.hDevice];
                    }
//                    Debug.WriteLine("Handle: {0} was in the Keyboard device list.", _rawBuffer.header.hDevice);
                }
                // EnumerateDevices()에서 저장한 배열에 없으면
                else
                {
                    Debug.WriteLine("Handle: {0} was not in the device list.", _rawBuffer.header.hDevice);
                    return;
                }

                // KEY_UP인지,
                bool isBreakBitSet = ((flags & Win32.RI_KEY_BREAK) != 0);

                // 키가 눌렸으면 "MAKE"저장, 키를 뗀 상태면 "BREAK"저장
                keyPressInfo.mKeyPressState = isBreakBitSet ? "BREAK" : "MAKE";
                keyPressInfo.mMessage = _rawBuffer.data.keyboard.Message; // 윈도우 메시지에 상응함. (예: WM_KEYDOWN, WM_SYASKEYDOWN 등)
                keyPressInfo.mVKeyName = KeyMapper.GetKeyName(VirtualKeyCorrection(virtualKey, isE0BitSet, makeCode)).ToUpper();
                keyPressInfo.mVKey = virtualKey;

                // 이벤트 함수(배열)를 keyPressInfo로 새롭게 할당함.
                if (KeyPressed != null)
                {
                    // KeyPressed 메서드를 실행. 그러면, 등록된 메서드가 RawKeyboard객체, KeyPressInfo를 매개변수로 실행된다.
                    KeyPressed(this, new RawInputEventArg(keyPressInfo));
                }
            }
            // 원시입력 장치의 종류가 키보드면(1이면)
            else if (_rawBuffer.header.dwType == DeviceType.RimTypemouse)
            {
                // 눌린 버튼 정보 등 
                int usFlags = _rawBuffer.data.mouse.usFlags;
                uint ulButtons = _rawBuffer.data.mouse.ulButtons;
                int usButtonFlags = _rawBuffer.data.mouse.usButtonFlags;
                int usButtonData = _rawBuffer.data.mouse.usButtonData;
                uint ulRawButtons = _rawBuffer.data.mouse.ulRawButtons;
                int lLastX = _rawBuffer.data.mouse.lLastX;
                int lLastY = _rawBuffer.data.mouse.lLastY;
                uint ulExtraInformation = _rawBuffer.data.mouse.ulExtraInformation;



                KeyPressInfo keyPressInfo;

                // .header.hDevice는 위의 GetRawInputData에서 자동으로 채워짐.
                // 눌려진 장치의 정보가 EnumerateDevices()에서 저장한 배열에 있으면 배열로부터 정보를 채움.
                // (USB를 꽂거나 하는 경우 외엔 있을 듯)
                if (mDeviceList.ContainsKey(_rawBuffer.header.hDevice))
                {
//                    Debug.WriteLine("Handle: {0} was in the Mouse device list.", _rawBuffer.header.hDevice);
                    // 스레드 고정
                    lock (_padLock)
                    {
                        keyPressInfo = mDeviceList[_rawBuffer.header.hDevice];
                    }
                }
                // EnumerateDevices()에서 저장한 배열에 없으면
                else
                {
//                    Debug.WriteLine("Handle: {0} was not in the device list.", _rawBuffer.header.hDevice);
                    return;
                }

                // 마우스 입력과 관계 없는 항목은 빈칸
                keyPressInfo.mKeyPressState = "";
                keyPressInfo.mMessage = _rawBuffer.data.mouse.ulButtons; //맞게 대입했는지 모름 // 윈도우 메시지에 상응함. (예: WM_KEYDOWN, WM_SYASKEYDOWN 등)
                keyPressInfo.mVKeyName = "";
                keyPressInfo.mVKey = 0xFF;


                // 이벤트 함수(배열)를 keyPressInfo로 새롭게 할당함.
                if (KeyPressed != null)
                {
                    KeyPressed(this, new RawInputEventArg(keyPressInfo));   // 실행
                }
            }
            else // 키보드도 아니고, 마우스도 아닐 때,
            {
                KeyPressInfo keyPressInfo;

                if (mDeviceList.ContainsKey(_rawBuffer.header.hDevice))
                {
                    System.Windows.Forms.MessageBox.Show(_rawBuffer.header.hDevice.ToString());
                    // 스레드 고정
                    lock (_padLock)
                    {
                        keyPressInfo = mDeviceList[_rawBuffer.header.hDevice];
                    }
                }
                // EnumerateDevices()에서 저장한 배열에 없으면
                else
                {
                    Debug.WriteLine("Handle: {0} was not in the device list.", _rawBuffer.header.hDevice);
                    return;
                }

                // 가상키, 눌린 키 코드, 
                int virtualKey = _rawBuffer.data.keyboard.VKey;     // 가상 키 코드
                int makeCode = _rawBuffer.data.keyboard.Makecode;   // 키 눌림으로부터 코드를 탐색한다.
                int flags = _rawBuffer.data.keyboard.Flags;         // 하나 이상의 RI_KEY_MAKE, RI_KEY_BREAK, RI_KEY_E0, RI_KEY_E1

                // 매핑되지 않은 키 코드(0xFF)면 종료
                if (virtualKey == Win32.KEYBOARD_OVERRUN_MAKE_CODE) return;

                // 왼쪽에 있는 키가 눌렸는지,(예: LShift, LCtrl, LAlt)
                // 나중에 VirtualKeyCorrection()의 매개변수로 쓰임
                bool isE0BitSet = ((flags & Win32.RI_KEY_E0) != 0);


                // KEY_UP인지,
                bool isBreakBitSet = ((flags & Win32.RI_KEY_BREAK) != 0);

                // 키가 눌렸으면 "MAKE"저장, 키를 뗀 상태면 "BREAK"저장
                keyPressInfo.mKeyPressState = isBreakBitSet ? "BREAK" : "MAKE";
                keyPressInfo.mMessage = _rawBuffer.data.keyboard.Message; // 윈도우 메시지에 상응함. (예: WM_KEYDOWN, WM_SYASKEYDOWN 등)
                keyPressInfo.mVKeyName = KeyMapper.GetKeyName(VirtualKeyCorrection(virtualKey, isE0BitSet, makeCode)).ToUpper();
                keyPressInfo.mVKey = virtualKey;

                // 마우스 입력과 관계 없는 항목은 빈칸
                keyPressInfo.mKeyPressState = keyPressInfo.mKeyPressState == null ? "" : keyPressInfo.mKeyPressState;
                keyPressInfo.mMessage = (keyPressInfo.mMessage == 0) ? _rawBuffer.data.mouse.ulButtons : keyPressInfo.mMessage;  //맞게 대입했는지 모름 // 윈도우 메시지에 상응함. (예: WM_KEYDOWN, WM_SYASKEYDOWN 등)
                keyPressInfo.mVKeyName = keyPressInfo.mVKeyName == null ? "" : keyPressInfo.mVKeyName;
                keyPressInfo.mVKey = 0xFF;


                // 이벤트 함수(배열)를 keyPressInfo로 새롭게 할당함.
                if (KeyPressed != null)
                {
                    KeyPressed(this, new RawInputEventArg(keyPressInfo));   // 실행
                }

            }


        }
        


        

        // ZOOM인지, 왼쪽 키인지, 오른쪽 키인지 정확하게 판단해서 virtualKey 리턴
        private static int VirtualKeyCorrection(int virtualKey, bool isE0BitSet, int makeCode)
        {
            int correctedVKey = virtualKey;

            // 키 정보를 읽어왔을 때, hDevice의 값이 0이면,
            if (_rawBuffer.header.hDevice == IntPtr.Zero)
            {
                // hDevice가 0이고, vkey가 VK_CONTROL일 때, ZOOM키를 가리킨다.
                if (_rawBuffer.data.keyboard.VKey == Win32.VK_CONTROL)
                {
                    correctedVKey = Win32.VK_ZOOM;
                }
            }
            else // 키 정보를 읽어왔을 때, hDevice의 값이 0이 아니면,
            {
                switch (virtualKey)
                {
                    // 오른쪽 CTRL과 ALT는 각각 e0비트가 설정되어 있으므로
                    case Win32.VK_CONTROL: // 0x11이면
                        correctedVKey = isE0BitSet ? Win32.VK_RCONTROL : Win32.VK_LCONTROL;
                        break;
                    case Win32.VK_MENU:
                        correctedVKey = isE0BitSet ? Win32.VK_RMENU : Win32.VK_LMENU;
                        break;
                    case Win32.VK_SHIFT:
                        correctedVKey = makeCode == Win32.SC_SHIFT_R ? Win32.VK_RSHIFT : Win32.VK_LSHIFT;
                        break;
                    default:
                        correctedVKey = virtualKey;
                        break;
                }
            }

            return correctedVKey;
        }
    }
}
