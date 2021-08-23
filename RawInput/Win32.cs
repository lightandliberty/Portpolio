using System;
using System.IO;
using System.Globalization;
using System.ComponentModel;
using System.Runtime.InteropServices;

class clsGetInputID
{
    private const int RID_INPUT = 0x10000003;
    private const int RIDEV_INPUTSINK = 0x00000100;

    [DllImport("user32.dll", SetLastError = true)]
    extern static uint GetRawInputDeviceInfo(IntPtr hDevice, uint uiCommand, IntPtr pData, ref uint pcbSize);
    [DllImport("User32.dll")]
    extern static uint GetRawInputData(IntPtr hRawInput, uint uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);
    [DllImport("User32.dll")]
    extern static bool RegisterRawInputDevices(RAWINPUTDEVICE[] pRawInputDevice, uint uiNumDevices, uint cbSize);
    [DllImport("User32.dll")]
    extern static bool RegisterTouchWindow(IntPtr hwnd, ulong ulFlags);

    [Flags()]
    public enum RawMouseFlags : ushort
    {
        /// <summary>Relative to the last position.</summary>
        MoveRelative = 0,
        /// <summary>Absolute positioning.</summary>
        MoveAbsolute = 1,
        /// <summary>Coordinate data is mapped to a virtual desktop.</summary>
        VirtualDesktop = 2,
        /// <summary>Attributes for the mouse have changed.</summary>
        AttributesChanged = 4
    }
    [Flags()]
    public enum RawMouseButtons : ushort
    {
        /// <summary>No button.</summary>
        None = 0,
        /// <summary>Left (button 1) down.</summary>
        LeftDown = 0x0001,
        /// <summary>Left (button 1) up.</summary>
        LeftUp = 0x0002,
        /// <summary>Right (button 2) down.</summary>
        RightDown = 0x0004,
        /// <summary>Right (button 2) up.</summary>
        RightUp = 0x0008,
        /// <summary>Middle (button 3) down.</summary>
        MiddleDown = 0x0010,
        /// <summary>Middle (button 3) up.</summary>
        MiddleUp = 0x0020,
        /// <summary>Button 4 down.</summary>
        Button4Down = 0x0040,
        /// <summary>Button 4 up.</summary>
        Button4Up = 0x0080,
        /// <summary>Button 5 down.</summary>
        Button5Down = 0x0100,
        /// <summary>Button 5 up.</summary>
        Button5Up = 0x0200,
        /// <summary>Mouse wheel moved.</summary>
        MouseWheel = 0x0400
    }


    [StructLayout(LayoutKind.Sequential)]
    internal struct RAWINPUTDEVICE
    {
        [MarshalAs(UnmanagedType.U2)]
        public ushort usUsagePage;
        [MarshalAs(UnmanagedType.U2)]
        public ushort usUsage;
        [MarshalAs(UnmanagedType.U4)]
        public int dwFlags;
        public IntPtr hwndTarget;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct RAWHID
    {
        [MarshalAs(UnmanagedType.U4)]
        public int dwSizHid;
        [MarshalAs(UnmanagedType.U4)]
        public int dwCount;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct RawMouse
    {
        /// <summary>
        /// The mouse state.
        /// </summary>
        [FieldOffset(0)]
        public RawMouseFlags Flags;
        /// <summary>
        /// Flags for the event.
        /// </summary>
        [FieldOffset(4)]
        public RawMouseButtons ButtonFlags;
        /// <summary>
        /// If the mouse wheel is moved, this will contain the delta amount.
        /// </summary>
        [FieldOffset(6)]
        public ushort ButtonData;
        /// <summary>
        /// Raw button data.
        /// </summary>
        [FieldOffset(8)]
        public uint RawButtons;
        /// <summary>
        /// The motion in the X direction. This is signed relative motion or 
        /// absolute motion, depending on the value of usFlags. 
        /// </summary>
        [FieldOffset(12)]
        public int LastX;
        /// <summary>
        /// The motion in the Y direction. This is signed relative motion or absolute motion, 
        /// depending on the value of usFlags. 
        /// </summary>
        [FieldOffset(16)]
        public int LastY;
        /// <summary>
        /// The device-specific additional information for the event. 
        /// </summary>
        [FieldOffset(20)]
        public uint ExtraInformation;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct RAWKEYBOARD
    {
        [MarshalAs(UnmanagedType.U2)]
        public ushort MakeCode;
        [MarshalAs(UnmanagedType.U2)]
        public ushort Flags;
        [MarshalAs(UnmanagedType.U2)]
        public ushort Reserved;
        [MarshalAs(UnmanagedType.U2)]
        public ushort VKey;
        [MarshalAs(UnmanagedType.U4)]
        public uint Message;
        [MarshalAs(UnmanagedType.U4)]
        public uint ExtraInformation;
    }

    public enum RawInputType
    {
        /// <summary>
        /// Mouse input.
        /// </summary>
        Mouse = 0,
        /// <summary>
        /// Keyboard input.
        /// </summary>
        Keyboard = 1,
        /// <summary>
        /// Another device that is not the keyboard or the mouse.
        /// </summary>
        HID = 2
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct RawInput
    {
        /// <summary>Header for the data.</summary>
        [FieldOffset(0)]
        public RawInputHeader Header;
        /// <summary>Mouse raw input data.</summary>
        [FieldOffset(16)]
        public RawMouse Mouse;
        /// <summary>Keyboard raw input data.</summary>
        [FieldOffset(16)]
        public RAWKEYBOARD Keyboard;
        /// <summary>HID raw input data.</summary>
        [FieldOffset(16)]
        public RAWHID Hid;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct RawInputHeader
    {
        /// <summary>Type of device the input is coming from.</summary>
        public RawInputType Type;
        /// <summary>Size of the packet of data.</summary>
        public int Size;
        /// <summary>Handle to the device sending the data.</summary>
        public IntPtr Device;
        /// <summary>wParam from the window message.</summary>
        public IntPtr wParam;
    }


    public bool LockForBuzzersOnly = true;
    System.Collections.Generic.List<int> BuzzerDevices = new System.Collections.Generic.List<int>();


    public int GetDeviceID(System.Windows.Forms.Message message)
    {
        uint dwSize = 0;

        GetRawInputData(
            message.LParam,
            RID_INPUT,
            IntPtr.Zero,
            ref dwSize,
            (uint)Marshal.SizeOf(typeof(RawInputHeader))
        );

        IntPtr buffer = Marshal.AllocHGlobal((int)dwSize);

        GetRawInputData(
            message.LParam,
            RID_INPUT,
            buffer,
            ref dwSize,
            (uint)Marshal.SizeOf(typeof(RawInputHeader))
        );

        RawInput raw = (RawInput)Marshal.PtrToStructure(buffer, typeof(RawInput));
        Marshal.FreeHGlobal(buffer);

        if (raw.Mouse.ButtonFlags == RawMouseButtons.LeftDown || raw.Mouse.ButtonFlags == RawMouseButtons.RightDown)
        {
            return (int)raw.Header.Device;
        }
        else
        {
            return 0;
        }
    }


    public clsGetInputID(IntPtr hwnd)
    {
        RAWINPUTDEVICE[] rid = new RAWINPUTDEVICE[1];

        rid[0].usUsagePage = 0x01;
        rid[0].usUsage = 0x02;
        rid[0].dwFlags = RIDEV_INPUTSINK;
        rid[0].hwndTarget = hwnd;

        if (!RegisterRawInputDevices(rid, (uint)rid.Length, (uint)Marshal.SizeOf(rid[0])))
        {
            throw new ApplicationException("Failed to register raw input device(s).");
        }
    }
}

namespace RawInput_dll
{
    static public class Win32
    {
        public static int LoWord(int dwValue)
        {
            return (dwValue & 0xFFFF);
        }

        public static int HiWord(Int64 dwValue)
        {
            return (int)(dwValue >> 16) & ~FAPPCOMMANDMASK;
        }

        public static ushort LowWord(uint val)
        {
            return (ushort)val;
        }

        public static ushort HighWord(uint val)
        {
            return (ushort)(val >> 16);
        }

        public static uint BuildWParam(ushort low, ushort high)
        {
            return ((uint)high << 16) | low;
        }

        // ReSharper disable InconsistentNaming
        public const int KEYBOARD_OVERRUN_MAKE_CODE = 0xFF;
        public const int WM_APPCOMMAND = 0x0319;
        private const int FAPPCOMMANDMASK = 0xF000;
        internal const int FAPPCOMMANDMOUSE = 0x8000;
        internal const int FAPPCOMMANDOEM = 0x1000;

        public const int WM_KEYDOWN = 0x0100;
        public const int WM_KEYUP = 0x0101;
        internal const int WM_SYSKEYDOWN = 0x0104;
        internal const int WM_INPUT = 0x00FF;
        internal const int WM_USB_DEVICECHANGE = 0x0219;

        internal const int VK_SHIFT = 0x10;

        internal const int RI_KEY_MAKE = 0x00;      // Key Down
        internal const int RI_KEY_BREAK = 0x01;     // Key Up
        internal const int RI_KEY_E0 = 0x02;        // Left version of the key
        internal const int RI_KEY_E1 = 0x04;        // Right version of the key. Only seems to be set for the Pause/Break key.

        internal const int VK_CONTROL = 0x11;
        internal const int VK_MENU = 0x12;
        internal const int VK_ZOOM = 0xFB;
        internal const int VK_LSHIFT = 0xA0;
        internal const int VK_RSHIFT = 0xA1;
        internal const int VK_LCONTROL = 0xA2;
        internal const int VK_RCONTROL = 0xA3;
        internal const int VK_LMENU = 0xA4;
        internal const int VK_RMENU = 0xA5;

        internal const int SC_SHIFT_R = 0x36;
        internal const int SC_SHIFT_L = 0x2a;
        internal const int RIM_INPUT = 0x00;
        // ReSharper restore InconsistentNaming

        [DllImport("User32.dll", SetLastError = true)]
        internal static extern int GetRawInputData(IntPtr hRawInput, DataCommand command, [Out] out InputData buffer, [In, Out] ref int size, int cbSizeHeader);

        [DllImport("User32.dll", SetLastError = true)]
        internal static extern int GetRawInputData(IntPtr hRawInput, DataCommand command, [Out] IntPtr pData, [In, Out] ref int size, int sizeHeader);

        [DllImport("User32.dll", SetLastError = true)]
        internal static extern uint GetRawInputDeviceInfo(IntPtr hDevice, RawInputDeviceInfo command, IntPtr pData, ref uint size);

        [DllImport("user32.dll")]
        private static extern uint GetRawInputDeviceInfo(IntPtr hDevice, uint command, ref DeviceInfo data, ref uint dataSize);


        [DllImport("User32.dll", SetLastError = true)]
        internal static extern uint GetRawInputDeviceList(IntPtr pRawInputDeviceList, ref uint numberDevices, uint size);

        [DllImport("User32.dll", SetLastError = true)]
        internal static extern bool RegisterRawInputDevices(RawInputDevice[] pRawInputDevice, uint numberDevices, uint size);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr RegisterDeviceNotification(IntPtr hRecipient, IntPtr notificationFilter, DeviceNotification flags);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool UnregisterDeviceNotification(IntPtr handle);

        //[DllImport("User32.dll", SetLastError = true)]
        //internal static extern bool RegisterTouchWindow(IntPtr hwnd, uint ulFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterTouchWindow(IntPtr hwnd,
        [MarshalAs(UnmanagedType.U4)] RegisterTouchFlags flags);

        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern void CloseTouchInputHandle(IntPtr lParam);

        [Flags, Serializable]
        public enum RegisterTouchFlags
        {
            TWF_NONE = 0x00000000,

            TWF_FINETOUCH = 0x00000001,

            TWF_WANTPALM = 0x00000002
        }


        public static void DeviceAudit()
        {
            // 파일을 열음.
            var file = new FileStream("DeviceAudit.txt", FileMode.Create, FileAccess.Write);
            var sw = new StreamWriter(file);

            var keyboardNumber = 0;
            uint deviceCount = 0;
            var dwSize = (Marshal.SizeOf(typeof(Rawinputdevicelist)));

            if (GetRawInputDeviceList(IntPtr.Zero, ref deviceCount, (uint)dwSize) == 0)
            {
                var pRawInputDeviceList = Marshal.AllocHGlobal((int)(dwSize * deviceCount));
                GetRawInputDeviceList(pRawInputDeviceList, ref deviceCount, (uint)dwSize);

                for (var i = 0; i < deviceCount; i++)
                {
                    uint pcbSize = 0;

                    // On Window 8 64bit when compiling against .Net > 3.5 using .ToInt32 you will generate an arithmetic overflow. Leave as it is for 32bit/64bit applications
                    // rid를 만들어서 아래의 GetRawInputDeviceInfo()에서 활용
                    var rid = (Rawinputdevicelist)Marshal.PtrToStructure(new IntPtr((pRawInputDeviceList.ToInt64() + (dwSize * i))), typeof(Rawinputdevicelist));

                    GetRawInputDeviceInfo(rid.hDevice, RawInputDeviceInfo.RIDI_DEVICENAME, IntPtr.Zero, ref pcbSize);

                    if (pcbSize <= 0)
                    {
                        sw.WriteLine("pcbSize: " + pcbSize);
                        sw.WriteLine(Marshal.GetLastWin32Error());
                        return;
                    }

                    var size = (uint)Marshal.SizeOf(typeof(DeviceInfo));
                    var di = new DeviceInfo { Size = Marshal.SizeOf(typeof(DeviceInfo)) };
                    // pData대신 di를 만들어서,  // 아래와 다른 오버로딩된 매개변수
                    if (GetRawInputDeviceInfo(rid.hDevice, (uint)RawInputDeviceInfo.RIDI_DEVICEINFO, ref di, ref size) <= 0)
                    {
                        sw.WriteLine(Marshal.GetLastWin32Error());
                        return;
                    }

                    // 장치의 이름을 얻는 메서드
                    var pData = Marshal.AllocHGlobal((int)pcbSize);
                    GetRawInputDeviceInfo(rid.hDevice, RawInputDeviceInfo.RIDI_DEVICENAME, pData, ref pcbSize);
                    var deviceName = Marshal.PtrToStringAnsi(pData);

                    // 장치가 키보드일 경우 또는 HID일 경우에만 장치 정보를 객체에 저장
                    if (rid.dwType == DeviceType.RimTypekeyboard || rid.dwType == DeviceType.RimTypeHid)
                    {
                        var deviceDesc = GetDeviceDescription(deviceName);

                        // 이 부분은 원본과 다름 (객체명을 직관적으로 하기 위해 KeyPressInfo로 함)
                        var dInfo = new KeyPressInfo
                        {
                            mDeviceName = Marshal.PtrToStringAnsi(pData),
                            mDeviceHandle = rid.hDevice,
                            mDeviceType = GetDeviceType(rid.dwType),
                            mName = deviceDesc,
                            Source = keyboardNumber++.ToString(CultureInfo.InvariantCulture)
                        };

                        sw.WriteLine(dInfo.ToString());
                        sw.WriteLine(di.ToString());
                        sw.WriteLine(di.KeyboardInfo.ToString());
                        sw.WriteLine(di.HIDInfo.ToString());
                        //sw.WriteLine(di.MouseInfo.ToString());
                        sw.WriteLine("=========================================================================================================");
                    }

                    Marshal.FreeHGlobal(pData);
                }

                Marshal.FreeHGlobal(pRawInputDeviceList);

                sw.Flush();
                sw.Close();
                file.Close();

                return;
            }

            throw new Win32Exception(Marshal.GetLastWin32Error());
        }

        public static string GetDeviceType(uint device)
        {
            string deviceType;
            switch (device)
            {
                case DeviceType.RimTypemouse: deviceType = "MOUSE"; break;
                case DeviceType.RimTypekeyboard: deviceType = "KEYBOARD"; break;
                case DeviceType.RimTypeHid: deviceType = "HID"; break;
                case DeviceType.Unknown: deviceType = "UNKNOWN from GetDeviceType()"; break;
                default: deviceType = "UNKNOWN"; break;
            }

            return deviceType;
        }

        public static string GetDeviceDescription(string device)
        {
            string deviceDesc;
            try
            {
                //                System.Windows.Forms.MessageBox.Show("GetDeviceDescription에서 매개변수 device의 내용 = " + device.ToString());

                var deviceKey = RegistryAccess.GetDeviceKey(device);
                //                System.Windows.Forms.MessageBox.Show("deviceKey는" + deviceKey.ToString());
                deviceDesc = deviceKey.GetValue("DeviceDesc").ToString();
                //                System.Windows.Forms.MessageBox.Show("deviceDesc의 ;앞 부분과 포함해서 전부는 : " + deviceDesc.ToString());
                deviceDesc = deviceDesc.Substring(deviceDesc.IndexOf(';') + 1);
                //                System.Windows.Forms.MessageBox.Show("deviceDesc의 ;앞 부분과 포함해서 뒷부분은 : " + deviceDesc.ToString());
            }
            catch (Exception)
            {
                deviceDesc = "Device is malformed unable to look up in the registry";
            }

            //var deviceClass = RegistryAccess.GetClassType(deviceKey.GetValue("ClassGUID").ToString());
            //isKeyboard = deviceClass.ToUpper().Equals( "KEYBOARD" );

            // 그냥 장치의 평범한 이름들이 있음. PS/2 Keyboard input device같은
            //            System.Windows.Forms.MessageBox.Show("Win32.cs의 GetDeviceKey()를 이용한 GetDeviceDescription의 값 = " + deviceDesc.ToString());

            return deviceDesc;
        }

        //public static bool InputInForeground(IntPtr wparam)
        //{
        //    return wparam.ToInt32() == RIM_INPUT;
        //}
    }
}
