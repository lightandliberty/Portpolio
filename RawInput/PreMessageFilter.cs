using System.Windows.Forms;


namespace RawInput_dll
{
    public class PreMessageFilter : IMessageFilter
    {
        // true : 메시지를 필터링하고 발송을 중지
        // false : 다음 필터 또는 컨트롤로 계속되도록 허용
        public bool PreFilterMessage(ref Message m)
        {
            return m.Msg == Win32.WM_KEYDOWN;   // WM_KEYDOWN 메시지가 발생한 경우면 필터링.
        }
    }
}
