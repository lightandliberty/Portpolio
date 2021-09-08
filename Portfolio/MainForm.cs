using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Portfolio
{
    public partial class MainForm : Form
    {
        public string mKeyboardDeviceName = "";
        public string mMouseDeviceName = "";

        ShowRawInput showRawInput = null;

        public event ShowRawInput.SetKeyboardMouseLabel SetKeyboardMouseLBL
        {
            add { showRawInput.SetKeyboardMouseLBL += value; }
            remove { showRawInput.SetKeyboardMouseLBL -= value; }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void RawInputBtn_Click(object sender, EventArgs e)
        {
            showRawInput = new ShowRawInput();
            showRawInput.processingRawInputting._rawinput.KeyPressed += OnKeyPressed;
            showRawInput.SetKeyboardMouseLBL += GotOrNotMouseKeyboardName;
            showRawInput.ProcessDelegate();
            showRawInput.ShowDialog();
            MessageBox.Show(mKeyboardDeviceName,"키보드 장치 이름",MessageBoxButtons.OK,MessageBoxIcon.Information);
            MessageBox.Show(mMouseDeviceName,"마우스 장치 이름", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            showRawInput.Dispose();
        }

        // showRawInput에 추가할 delegate메서드
        public void GotOrNotMouseKeyboardName(object sender, ref ShowRawInput.SetKeyboardMouseEventArgs e)
        {
            if (!mKeyboardDeviceName.Equals(""))
                e.keyMouseFlags.gotKeyboardName = true;
            if (!mMouseDeviceName.Equals(""))
                e.keyMouseFlags.gotMouseName = true;
        }

        public void OnKeyPressed(object sender, RawInput_dll.RawInputEventArg e)
        {
            if(e.mKeyPressInfo.mDeviceType.Equals("KEYBOARD"))
                mKeyboardDeviceName = e.mKeyPressInfo.mDeviceName;
            if(e.mKeyPressInfo.mDeviceType.Equals("MOUSE"))
                mMouseDeviceName = e.mKeyPressInfo.mDeviceName;
        }


        private void BasicPropertiesBtn_Click(object sender, EventArgs e)
        {
            BasicProperties_dll.Properties basicProperties_dll = new BasicProperties_dll.Properties();
            basicProperties_dll.ShowDialog();

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 버전정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("포트폴리오 V1.0");
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
