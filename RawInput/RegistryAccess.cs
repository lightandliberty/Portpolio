using Microsoft.Win32;

namespace RawInput_dll
{
    public static class RegistryAccess
    {
        // OpenSubKey로 레지스트리에 등록된 장치 정보를 얻음
        public static RegistryKey GetDeviceKey(string device)
        {
            var split = device.Substring(4).Split('#');
            // device의 내용 \\?\HID # ELAN0E03&Col04 # 5&25c95e27&0&0003 # {4d1e55b2-f16f-11cf-88cb-001111000030} 등
            var classCode = split[0];       // ACPI (Class code) // HID부터~
            var subClassCode = split[1];    // PNP0303 (SubClass code) // ELAN부터
            var protocolCode = split[2];    // 3&13c0b0c5&0 (Protocol code) // 5&25c95~ 부터 

            return Registry.LocalMachine.OpenSubKey(string.Format(@"System\CurrentControlSet\Enum\{0}\{1}\{2}", classCode, subClassCode, protocolCode));
        }

        public static string GetClassType(string classGuid)
        {
            var classGuidKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Class\" + classGuid);

            return classGuidKey != null ? (string)classGuidKey.GetValue("Class") : string.Empty;
        }

    }
}
