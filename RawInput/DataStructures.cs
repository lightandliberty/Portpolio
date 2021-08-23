using System;
using System.Runtime.InteropServices;

namespace RawInput_dll
{
    // ReSharper disable FieldCanBeMadeReadOnly.Global

    [StructLayout(LayoutKind.Explicit)]
    public struct DeviceInfo
    {
        [FieldOffset(0)]
        public int Size;
        [FieldOffset(4)]
        public int Type;

        [FieldOffset(8)]
        public DeviceInfoMouse MouseInfo;
        [FieldOffset(8)]
        public DeviceInfoKeyboard KeyboardInfo;
        [FieldOffset(8)]
        public DeviceInfoHid HIDInfo;

        public override string ToString()
        {
            return string.Format("DeviceInfo\n Size: {0}\n Type: {1}\n", Size, Type);
        }
    }

    public struct DeviceInfoMouse
    {
        // ReSharper disable MemberCanBePrivate.Global
        public uint Id;                         // Identifier of the mouse device
        public uint NumberOfButtons;            // Number of buttons for the mouse
        public uint SampleRate;                 // Number of data points per second.
        public bool HasHorizontalWheel;         // True is mouse has wheel for horizontal scrolling else false.
        // ReSharper restore MemberCanBePrivate.Global
        public override string ToString()
        {
            return string.Format("MouseInfo\n Id: {0}\n NumberOfButtons: {1}\n SampleRate: {2}\n HorizontalWheel: {3}\n", Id, NumberOfButtons, SampleRate, HasHorizontalWheel);
        }
    }

    public struct DeviceInfoKeyboard
    {
        public uint Type;                       // Type of the keyboard
        public uint SubType;                    // Subtype of the keyboard
        public uint KeyboardMode;               // The scan code mode
        public uint NumberOfFunctionKeys;       // Number of function keys on the keyboard
        public uint NumberOfIndicators;         // Number of LED indicators on the keyboard
        public uint NumberOfKeysTotal;          // Total number of keys on the keyboard

        public override string ToString()
        {
            return string.Format("DeviceInfoKeyboard\n Type: {0}\n SubType: {1}\n KeyboardMode: {2}\n NumberOfFunctionKeys: {3}\n NumberOfIndicators {4}\n NumberOfKeysTotal: {5}\n",
                                                             Type,
                                                             SubType,
                                                             KeyboardMode,
                                                             NumberOfFunctionKeys,
                                                             NumberOfIndicators,
                                                             NumberOfKeysTotal);
        }
    }

    public struct DeviceInfoHid
    {
        public uint VendorID;       // Vendor identifier for the HID
        public uint ProductID;      // Product identifier for the HID
        public uint VersionNumber;  // Version number for the device
        public ushort UsagePage;    // Top-level collection Usage page for the device
        public ushort Usage;        // Top-level collection Usage for the device

        public override string ToString()
        {
            return string.Format("HidInfo\n VendorID: {0}\n ProductID: {1}\n VersionNumber: {2}\n UsagePage: {3}\n Usage: {4}\n", VendorID, ProductID, VersionNumber, UsagePage, Usage);
        }
    }

    // 장치 알림을 위한 등록에서 쓰이는 
    struct BroadcastDeviceInterface
    {
        // ReSharper disable NotAccessedField.Global
        // ReSharper disable UnusedField.Compiler
        public Int32 DbccSize;
        public BroadcastDeviceType BroadcastDeviceType;
        public Int32 DbccReserved;
        public Guid DbccClassguid;
        public char DbccName;
        // ReSharper restore NotAccessedField.Global
        // ReSharper restore UnusedField.Compiler
    }


    // c++의 객체를 c#객체 rid에 그대로 저장하므로, IntPtr hDevice필요.
    [StructLayout(LayoutKind.Sequential)]
    internal struct Rawinputdevicelist
    {
        public IntPtr hDevice;
        public uint dwType;
    }

    // 마샬링으로 관리되지 않은 메모리로 옮길 때, 구조체 멤버 순서대로 옮겨지도록 (Sequential)
    // 관리되는 메모리까지 필드 위치가 보장되려면 Explicit사용. Offset이 중복되면 공용체
    [StructLayout(LayoutKind.Sequential)]
    public struct InputData
    {
        public Rawinputheader header;
        public RawData data;
    }

    // _rawBuffer.header부분
    [StructLayout(LayoutKind.Sequential)]
    public struct Rawinputheader
    {
        public uint dwType;
        public uint dwSize;
        public IntPtr hDevice;
        public IntPtr wParam;

        public override string ToString()
        {
            return string.Format("RawInputHeader\n dwType : {0}\n dwSize : {1}\n hDevice : {2}\n wParam : {3}", dwType, dwSize, hDevice, wParam);
        }
    }

    // _rawBuffer.data 부분
    [StructLayout(LayoutKind.Explicit)]
    public struct RawData
    {
        // 공용체
        [FieldOffset(0)]
        internal Rawmouse mouse;
        [FieldOffset(0)]
        internal Rawkeyboard keyboard;
        [FieldOffset(0)]
        internal Rawhid hid;
    }

    // internal이므로 다른 어셈블리에서는 접근할 수 없음
    [StructLayout(LayoutKind.Sequential)]
    internal struct Rawhid
    {
        public uint dwSizHid;
        public uint dwCount;
        public byte bRawData;

        public override string ToString()
        {
            return string.Format("Rawhid\n dwSizeHid : {0}\n dwCount : {1}\n bRawData : {2}\n", dwSizHid, dwCount, bRawData);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct Rawmouse
    {
        [FieldOffset(0)]
        public ushort usFlags;          // 마지막 마우스위치를 기준으로 할 지, 절대 위치를 기준으로 할 지, 가상 데스크탑에 매핑할 지, 마우스 속성이 변경되었는지, 이 마우스 이벤트를 통합하지 않을지,
        [FieldOffset(4)]
        public uint ulButtons;          // 예약어
        [FieldOffset(4)]
        public ushort usButtonFlags;    // 왼쪽,오른쪽,가운데,X1,X2버튼이 아래,위로 변경되었는지, 휠(음수값:뒤로 회전),수평휠(음수값:왼쪽 회전)에서 원시입력이 나오는지,
        [FieldOffset(6)]
        public ushort usButtonData;     // usButtonFlags가 RI_MOUSE_WHEEL, RI_MOUSE_HWHEEL일 경우, 회전한 거리.
        [FieldOffset(8)]
        public uint ulRawButtons;       // 마우스 버튼의 Raw상태. Win32 subsystem은 이 멤버를 사용하지 않는다.
        [FieldOffset(12)]
        public int lLastX;              // X방향 움직임. usFlag에 따른 부호있는 기준의 움직임, 절대 위치 움직임.
        [FieldOffset(16)]
        public int lLastY;              // Y방향 움직임. usFlag에 따른 부호있는 기준의 움직임, 절대 위치 움직임.
        [FieldOffset(20)]
        public uint ulExtraInformation; // 이벤트에 대한 장치별 추가 정보

        public override string ToString()
        {
            return string.Format(
                "Rawmouse\n" +
                " usFlags: {0}\n" +
                " ulButtons : {1}\n" +
                " uButtonFlags: {2}\n" +
                " uButtonData: {3}\n" +
                " ulRawButtons: {4}\n" +
                " lLastX: {5}\n" +
                " lLastY: {6}\n" +
                " ulExtraInformation: {7}\n",
                usFlags, ulButtons, usButtonFlags, usButtonData, ulRawButtons, lLastX, lLastY, ulExtraInformation);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct Rawkeyboard
    {
        public ushort Makecode;             // 키 눌림으로부터 코드를 탐색한다.
        public ushort Flags;                // 하나 이상의 RI_KEY_MAKE, RI_KEY_BREAK, RI_KEY_E0, RI_KEY_E1
        private readonly ushort Reserved;   // 항상 0
        public ushort VKey;                 // 가상 키 코드
        public uint Message;                // 윈도우 메시지에 상응함. (예: WM_KEYDOWN, WM_SYASKEYDOWN 등)
        public uint ExtraInformation;       // 이벤트를 위한 구체적인 장치의 추가 정보 ( 키보드에 대해선 항상 0 인 듯)

        public override string ToString()
        {
            return string.Format("Rawkeyboard\n Makecode: {0}\n Makecode(hex) : {0:X}\n Flags: {1}\n Reserved: {2}\n VKeyName: {3}\n Message: {4}\n ExtraInformation {5}\n",
                Makecode, Flags, Reserved, VKey, Message, ExtraInformation);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct RawInputDevice
    {
        // internal이므로 다른 어셈블리에서는 접근할 수 없음
        internal HidUsagePage UsagePage;        // 최상위 컬렉션 사용 페이지
        internal HidUsage Usage;                // 최상위 컬렉션 사용 ID
        internal RawInputDeviceFlags Flags;     // RIDEV_REMOVE 설정하면 최상위 컬렉션이 제거, RIDEV_INPUTSINK 호출자가 창의 맨 앞에 있지 않아도 입력을 받을 수 있음.(hwndTarget을 지정해야 함) 등
        internal IntPtr Target;                 // 대상 창의 핸들. NULL일 경우, 키보드의 포커스가 있는 창.

        public override string ToString()
        {
            return string.Format("{0}/{1}, flags: {2}, target: {3}", UsagePage, Usage, Flags, Target);
        }
    }
}
