using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RawInput_dll;
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

        //private const int CS_DropShadow = 0x00020000;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle |= CS_DropShadow;
        //        return cp;
        //    }
        //}



        // 이전 RawInput 구현 부분
        //private void RawInputBtn_Click(object sender, EventArgs e)
        //{
        //    showRawInput = new ShowRawInput();
        //    showRawInput.processingRawInputting._rawinput.KeyPressed += OnKeyPressed;
        //    showRawInput.SetKeyboardMouseLBL += GotOrNotMouseKeyboardName;
        //    showRawInput.ProcessDelegate();
        //    showRawInput.ShowDialog();
        //    MessageBox.Show(mKeyboardDeviceName,"키보드 장치 이름",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //    MessageBox.Show(mMouseDeviceName,"마우스 장치 이름", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    showRawInput.Dispose();
        //}

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
            BasicProperties_dll.BasicProperties_MainForm basicProperties_dll = new BasicProperties_dll.BasicProperties_MainForm();
            basicProperties_dll.ShowDialog();

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 버전정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("포트폴리오 2021 V1.0");
        }

        public void CloseFormBtn_Click(object sender, EventArgs e)
        {
            if (NeonMode)
            {
                neonCloseBtn_Click(this.neonCloseBtn, e);
                //NeonMode = false;
                //this.BackColor = SystemColors.Control;
                //this.Invalidate(true);
            }
            else
                this.Close();
        }

        private void NeonButtonProjectBtn_Click(object sender, EventArgs e)
        {
            NeonButtonProject_Dll.NeonButtonMain neonButtonProject_dll = new NeonButtonProject_Dll.NeonButtonMain();
            neonButtonProject_dll.ShowDialog();
        }

        private void DrawingMetalBtn_Click(object sender, EventArgs e)
        {
            DrawingProject_Dll.DrawingMain drawingMain = new DrawingProject_Dll.DrawingMain()
            {
                StartPosition = FormStartPosition.CenterParent,
            };
            drawingMain.ShowDialog();
        }

        public bool mNeonMode = false;
        
        // 속성은 메서드
        public bool NeonMode 
        {
            get => mNeonMode;
            set
            {
                mNeonMode = value;
                this.BasicPropertiesBtn.Visible = !mNeonMode;
                this.RawInputBtn.Visible = !mNeonMode;
                this.DrawingMetalBtn.Visible = !mNeonMode;
                this.neonButtonProjectBtn.Visible = !mNeonMode;
                this.MultiThreadBtn.Visible = !mNeonMode;

                this.CloseFormBtn.Size = mNeonMode ? new Size(0,0) : neonCloseBtn.Size; // Visible을 false로 하면 ESC가 작동 안하므로, 크기를 줄임.
                this.neonCloseBtn.Visible = mNeonMode;
            }
        }
        public Color bColor = DefaultBackColor;
        public int colorNum = 0;

        private void EnterNeonModeBtn_Click(object sender, EventArgs e)
        {
            // 처음 버튼을 눌렀으면,
            if (NeonMode == false)
            {
                NeonMode = true;
                neonChangeIntervalTimer.Enabled = true;
                using (Graphics g = this.CreateGraphics())
                {
                    this.BackColor = Color.Black;
                    StringFormat sf = new StringFormat()
                    {
                        LineAlignment = StringAlignment.Center,     // 세로 맞춤
                        Alignment = StringAlignment.Center,         // 가로 맞춤
                    };

                    this.Refresh();     // 이걸 안하면 배경이 나중에 검게 칠해지므로, 생각한대로 표시되지 않는다.

                    g.DrawString("새벽 공기 속에 흔들리는 네온",
                        new Font(this.Font.Name, 40, FontStyle.Bold), new SolidBrush((sender as CustomControls_dll.NeonButton).neonHoverPairs[(sender as CustomControls_dll.NeonButton).mKeyColor]),
                        new Rectangle(new Point(0, 0), new Size(this.ClientSize.Width, this.ClientSize.Height)),
                        sf);
                    g.DrawString("새벽 공기 속에 흔들리는 네온",
                        new Font(this.Font.Name, 40, FontStyle.Bold), new SolidBrush((sender as CustomControls_dll.NeonButton).neonNormalPairs[(sender as CustomControls_dll.NeonButton).mKeyColor]),
                        new Rectangle(new Point(3, 3), new Size(this.ClientSize.Width, this.ClientSize.Height)),
                        sf);
                    g.DrawString("새벽 공기 속에 흔들리는 네온",
                        new Font(this.Font.Name, 40, FontStyle.Bold), new SolidBrush((sender as CustomControls_dll.NeonButton).neonClickedPairs[(sender as CustomControls_dll.NeonButton).mKeyColor]),
                        new Rectangle(new Point(3, 3), new Size(this.ClientSize.Width, this.ClientSize.Height)),
                        sf);
                }
            }
            switch (colorNum)
            {
                case (int)CustomControls_dll.NeonButton.KeyColor.Count:     // 색의 수에 도달하면, 인덱스를 넘어간 것이므로, 0으로 되돌림.
                    colorNum = 0;
                    break;
                default:
                    colorNum++;
                    break;
            }
            (sender as CustomControls_dll.NeonButton).ButtonColor = (CustomControls_dll.NeonButton.KeyColor)colorNum;   // 버튼의 색을 바꾼다. ButtonColor는 속성으로 mKeyColor를 변경한다.
            this.neonCloseBtn.ButtonColor = (CustomControls_dll.NeonButton.KeyColor)colorNum;   // 버튼의 색을 바꾼다. ButtonColor는 속성으로 mKeyColor를 변경한다.
            this.neonCloseBtn.Refresh();
            this.enterNeonModeBtn.Refresh();
        }

        private void EnterNeonModeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (NeonMode)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    this.BackColor = Color.Black;
//                    g.FillRectangle(Brushes.Black, this.ClientRectangle);
                    //g.FillRectangle(
                    //    new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, this.ClientSize.Height), Color.White, (sender as CustomControls_dll.NeonButton).neonClickedPairs[(sender as CustomControls_dll.NeonButton).mKeyColor]),
                    //    new RectangleF(new Point(0, 0), new Size(this.ClientSize.Width, this.ClientSize.Height)));
                    StringFormat sf = new StringFormat()
                    {
                        LineAlignment = StringAlignment.Center,     // 세로 맞춤
                        Alignment = StringAlignment.Center,         // 가로 맞춤
                    };

                    // 글자색을 neon색으로 할 경우,
                    //g.DrawString("새벽 공기 속에 흔들리는 네온",
                    //    new Font(this.Font.Name, 40, FontStyle.Bold), new SolidBrush((sender as CustomControls_dll.NeonButton).neonNormalPairs[(sender as CustomControls_dll.NeonButton).mKeyColor]),
                    //    new Rectangle(new Point(0, 0), new Size(this.ClientSize.Width, this.ClientSize.Height)),
                    //    sf);
                    g.DrawString("새벽 공기 속에 흔들리는 네온",
                        new Font(this.Font.Name, 40, FontStyle.Bold), new SolidBrush((sender as CustomControls_dll.NeonButton).neonHoverPairs[(sender as CustomControls_dll.NeonButton).mKeyColor]),
                        new Rectangle(new Point(0, 0), new Size(this.ClientSize.Width, this.ClientSize.Height)),
                        sf);
                    g.DrawString("새벽 공기 속에 흔들리는 네온",
                        new Font(this.Font.Name, 40, FontStyle.Bold), new SolidBrush((sender as CustomControls_dll.NeonButton).neonNormalPairs[(sender as CustomControls_dll.NeonButton).mKeyColor]),
                        new Rectangle(new Point(3, 3), new Size(this.ClientSize.Width, this.ClientSize.Height)),
                        sf);
                    g.DrawString("새벽 공기 속에 흔들리는 네온",
                        new Font(this.Font.Name, 40, FontStyle.Bold), new SolidBrush((sender as CustomControls_dll.NeonButton).neonClickedPairs[(sender as CustomControls_dll.NeonButton).mKeyColor]),
                        new Rectangle(new Point(3, 3), new Size(this.ClientSize.Width, this.ClientSize.Height)),
                        sf);
                };
            }

        }

        private void neonCloseBtn_Click(object sender, EventArgs e)
        {
            NeonMode = !NeonMode;
            neonChangeIntervalTimer.Enabled = false;
            this.BackColor = SystemColors.Control;
            Invalidate(true);
        }

        private void NeonChangeIntervalTimer_Tick(object sender, EventArgs e)
        {
            EnterNeonModeBtn_MouseDown(this.enterNeonModeBtn, new MouseEventArgs(MouseButtons.Left,1,0,0,0) );
            EnterNeonModeBtn_Click(this.enterNeonModeBtn, e);
        }

        private void MultiThreadBtn_Click(object sender, EventArgs e)
        {
            MultiThread_dll.MultiThreadForm multiThreadForm = new MultiThread_dll.MultiThreadForm();
            multiThreadForm.ShowDialog();
        }


        public RawInputInfo mRawKeyboardInputInfo = null; // 키보드 정보 저장
        public RawInputInfo mRawMouseInputInfo = null;    // 마우스 정보 저장
        public GetRawInputForm getRawInputForm = null;
        private void getRawInputBtn_Click(object sender, EventArgs e)
        {
            // 현재 키보드나 마우스 하나만 저장. (배열로 다 저장하지 않음)
            if (mRawKeyboardInputInfo == null)
                mRawKeyboardInputInfo = new RawInputInfo();
            if(mRawMouseInputInfo == null)
                mRawMouseInputInfo = new RawInputInfo();

            if (getRawInputForm == null)
            {
                    getRawInputForm = new GetRawInputForm();
                    getRawInputForm.GetKeyboardArgs += GetKeyboardInfoArgs;
                    getRawInputForm.GetMouseArgs += GetMouseInfoArgs;
            }

            getRawInputForm.ShowDialog();

            MessageBox.Show(mRawKeyboardInputInfo.mDeviceNameInSystem, "키보드 장치 이름", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(mRawMouseInputInfo.mDeviceNameInSystem, "마우스 장치 이름", MessageBoxButtons.OK, MessageBoxIcon.Information);

            getRawInputForm.Dispose();
            getRawInputForm = null;
        }

        private void GetKeyboardInfoArgs(RawInputInfo e)
        {
            mRawKeyboardInputInfo = e;
        }

        private void GetMouseInfoArgs(RawInputInfo e)
        {
            mRawMouseInputInfo = e;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }


}
