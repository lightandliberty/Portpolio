using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingProject_Dll
{
    public partial class BasicDrawingForm : Form
    {

        public BasicDrawingForm()
        {
            InitializeComponent();
        }

        private void BasicDrawingForm_Load(object sender, EventArgs e)
        {
        }

        private void CancelMetalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkMetalBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 종료ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawEllipseBtn_MouseEnter(object sender, EventArgs e)
        {
            instructionTextBox.Text = "Graphics객체를 CreateGraphics()로 얻어, .FillEllipse()로 타원을 그린다." +
                "\r\n또는 기존에 그려진 타원을 시스템 색으로 지운다" +
                "\r\nSystemBrushes.Control로 지우고, finally에선 IDisposable인터페이스를 구현하는 Graphics객체의 자원을 해제한다." +
                "try, finally 블록은 using 블록으로도 대체 가능";
        }

        public bool drawEllipse = false;
        Color mEllipseColor1;
        Color mEllipseColor2;
        private void DrawEllipseBtn_Click(object sender, EventArgs e)
        {
            // 브러쉬를 그리는 모드가 켜있으면, 끝다.
            if (drawBrushes)
            {
                drawBrushes = !drawBrushes;
            }
            // 타원을 그릴지 지울지 여부를 토글(toggle: 껐다 켰다) 한다.
            //            Invalidate(true);
            drawEllipse = !drawEllipse;
            mEllipseColor1 = ColorTranslator.FromHtml("#FF0000");
            string htmlColorName = ColorTranslator.ToHtml(mEllipseColor1);

            if (drawEllipse)
                instructionTextBox.Text = "현재 설정되어 타원을 칠할 색의 HTML 문자 값은 " + htmlColorName;
            else
                instructionTextBox.Text = "현재 설정되어 타원을 지울 색의 HTML 문자 값은 " + ColorTranslator.ToHtml(SystemColors.Control);
            instructionTextBox.Text += "\r\n현재 설정되어 타원을 지울 색의 HTML 문자 값은 " + ColorTranslator.ToHtml(Color.FromKnownColor(KnownColor.Control));
            mEllipseColor2 = Color.FromKnownColor(KnownColor.Control);
            instructionTextBox.Text += "\r\n현재 설정되어 타원을 지울 색을 저장한 후의 HTML 문자 값은 " + ColorTranslator.ToHtml(mEllipseColor2);
            instructionTextBox.Text += "\r\n한번 더 클릭하면 지워지고, 다시 클릭하면 나타난다. ";
            this.Invalidate(true);      // true : 자식 컨트롤을 무효화 함.
            this.Update();
            //this.Refresh();     // Invalidate(true) + Update()
            // Paint이벤트에서 처리하므로, 주석 처리 함.
            //Graphics g = this.CreateGraphics();
            //try
            //{
            //    if(drawEllipse)
            //    {
            //        g.FillEllipse(Brushes.DarkBlue,
            //            new Rectangle(
            //            this.ClientRectangle.X + this.ClientRectangle.Width / 4,
            //            this.ClientRectangle.Y + this.ClientRectangle.Height / 4,
            //            this.ClientRectangle.Width / 2,
            //            this.ClientRectangle.Height / 2
            //            ));
            //    }
            //    else
            //    {
            //        // 기존에 그려진 타원을 지운다
            //        g.FillEllipse(SystemBrushes.Control,
            //            new Rectangle(
            //            this.ClientRectangle.X + this.ClientRectangle.Width/4,
            //            this.ClientRectangle.Y + this.ClientRectangle.Height/4,
            //            this.ClientRectangle.Width /2 ,
            //            this.ClientRectangle.Height / 2
            //            ));
            //    }
            //}
            //finally
            //{
            //    g.Dispose();
            //}

            //// using 블록으로도 대체 가능
            //using (Graphics g2 = this.CreateGraphics())
            //{
            //    if(drawEllipse)
            //        g2.FillEllipse(Brushes.Pink,
            //            new Rectangle(
            //            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
            //            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
            //            this.ClientRectangle.Width / 4,
            //            this.ClientRectangle.Height / 4
            //            ));
            //    else
            //        g2.FillEllipse(SystemBrushes.Control,
            //            new Rectangle(
            //            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
            //            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
            //            this.ClientRectangle.Width / 4,
            //            this.ClientRectangle.Height / 4
            //            ));
            //}
        }

        private void DrawEllipseBtn_Paint(object sender, PaintEventArgs e)
        {
        }

        // 영역 안의 브러쉬를 저장 및 매개변수에 반환
        public class BoolListRectangle
        {
            // 브러쉬별 영역을 저장할 사각형 리스트
            public List<Rectangle> mDrawBrushesRectangles;
            // 브러쉬별 영역을 저장한 사각형 리스트에 맞는 팝업 플래그들
            public Dictionary<Rectangle, PopupFlags> mPopupFlagsInDic;
            public bool isWrite;
            public PopupFlags mPopupFlag;
            
            public enum PopupFlags : int
            {
                None,
                SolidBrush,
                TextureBrush,
                HatchBrush,
                LinearGradientBrush,
                PathGradientBrush,
                Count
            }
            
            public PopupFlags PopupFlag         // 팝업창 종류를 저장할 속성.(mPopupFlag에 저장)
            {
                get => mPopupFlag;
                set { mPopupFlag = value; }
            }

            public SolidBrush mSolidBrush;
            public TextureBrush mTextureBrush;
            public System.Drawing.Drawing2D.HatchBrush mHatchBrush;
            public System.Drawing.Drawing2D.LinearGradientBrush mLinearGradientBrush;
            public System.Drawing.Drawing2D.PathGradientBrush mPathGradientBrush;

            public SolidBrush PSolidBrush { get { return mSolidBrush; } set { mSolidBrush = value; } }
            public TextureBrush PTextureBrush { get { return mTextureBrush; } set { mTextureBrush = value; } }
            public System.Drawing.Drawing2D.HatchBrush PHatchBrush { get { return mHatchBrush; } set { mHatchBrush = value; } }
            public System.Drawing.Drawing2D.LinearGradientBrush PLinearGradientBrush { get { return mLinearGradientBrush; } set { mLinearGradientBrush = value; } }
            public System.Drawing.Drawing2D.PathGradientBrush PPathGradientBrush { get { return mPathGradientBrush; } set { mPathGradientBrush = value; } }

            public int mLinearGradientBrushX;
            public int mLinearGradientBrushY;
            public int mLinearGradientBrushWidth;
            public int mLinearGradientBrushHeight;

            public BoolListRectangle()
            {
                mDrawBrushesRectangles = new List<Rectangle>();
                mPopupFlagsInDic = new Dictionary<Rectangle, PopupFlags>();
                isWrite = true;
                PopupFlag = PopupFlags.None;
            }

            public void Add(Rectangle rect)
            {
                if (isWrite == true)
                    mDrawBrushesRectangles.Add(rect);
            }

            public void SetBrushStyleFromMouseXY(MouseEventArgs e)
            {
                foreach(Rectangle rect in mDrawBrushesRectangles)
                {
                    // 클릭한 부분을 포함하면
                    if(rect.Contains(new Point(e.X, e.Y)))
                    {
                        PopupFlag = mPopupFlagsInDic[rect];
                        return;
                    }
                }
                PopupFlag = PopupFlags.None;
            }

        }

        public BoolListRectangle boolListRectangle;
        private void BasicDrawingForm_Paint(object sender, PaintEventArgs e)
        {
            //if (!drawEllipse) return;
            #region Paint이벤트에서 타원을 그린다.
            if (drawEllipse)
            {
                Brush b1 = new SolidBrush(mEllipseColor1);
                Graphics g3 = e.Graphics;
                g3.FillEllipse(b1, new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
                            this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Height / 4
                            ));
                g3.FillEllipse(Brushes.Pink, new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
                            this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Height / 4
                            ));


                Graphics g = this.CreateGraphics();
                try
                {
                    if (drawEllipse)
                    {
                        g.FillEllipse(b1,
                            new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4,
                            this.ClientRectangle.Width / 2,
                            this.ClientRectangle.Height / 2
                            ));
                    }
                    else
                    {
                        // 기존에 그려진 타원을 지운다
                        g.FillEllipse(SystemBrushes.Control,
                            new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4,
                            this.ClientRectangle.Width / 2,
                            this.ClientRectangle.Height / 2
                            ));
                    }
                }
                finally
                {
                    g.Dispose();
                }

                // using 블록으로도 대체 가능
                using (Graphics g2 = this.CreateGraphics())
                {
                    if (drawEllipse)
                        g2.FillEllipse(Brushes.Pink,
                            new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
                            this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Height / 4
                            ));
                    else
                        g2.FillEllipse(SystemBrushes.Control,
                            new Rectangle(
                            this.ClientRectangle.X + this.ClientRectangle.Width / 4 + this.ClientRectangle.Width / 8,
                            this.ClientRectangle.Y + this.ClientRectangle.Height / 4 + this.ClientRectangle.Height / 8,
                            this.ClientRectangle.Width / 4,
                            this.ClientRectangle.Height / 4
                            ));
                }
            }
            #endregion
            else if (drawBrushes)
            {
                if (boolListRectangle == null)
                {
                    // 사각형 배열에 한 번만 추가하도록 isWrite플래그를 사용
                    // 처음엔 HatchBrush창을 띄우고, 그 다음에는 클릭한 사각형에 해당하는 브러쉬 선택 창으로 변경
                    boolListRectangle = new BoolListRectangle()
                    {
                        isWrite = true,
                        PopupFlag = BoolListRectangle.PopupFlags.HatchBrush,
                    };
                }

                Graphics g = e.Graphics;
                int x = this.ClientRectangle.Width / 4;
                int y = this.ClientRectangle.Height / 4;
                int width = this.ClientRectangle.Width / 2;
                int height = this.ClientRectangle.Height / 5 / 2;
                Brush whiteBrush = System.Drawing.Brushes.White;
                Brush blackBrush = System.Drawing.Brushes.Black;
                y += height;
                // SolidBrush
                //using (Brush brush = new SolidBrush(Color.DarkBlue))
                if (boolListRectangle.PSolidBrush == null)
                    boolListRectangle.PSolidBrush = new SolidBrush(Color.DarkBlue);
                {
                    // 브러쉬, x, y, 너비, 높이
                    g.FillRectangle(boolListRectangle.PSolidBrush, x, y, width, height);
                    // SolidBrush 클릭 영역을 저장
                    if (boolListRectangle.isWrite)
                        boolListRectangle.Add(new Rectangle(x, y, width, height));
                    // 영역에 맞는 PopupFlags를 저장. (마지막에 추가되었으므로, 그에 맞게 브러쉬 스타일을 저장)
                    boolListRectangle.mPopupFlagsInDic[boolListRectangle.mDrawBrushesRectangles.Last()] = BoolListRectangle.PopupFlags.SolidBrush;
                    // 문자열, 폰트, 브러쉬, 시작위치x, 시작위치y
                    g.DrawString(boolListRectangle.PSolidBrush.ToString(), this.Font, whiteBrush, x, y + 3);  // 위에서 3만큼 띄움. y값에 저장 안 함.
                    y += height;
                }

                // TextureBrush
                //using (Brush brush = new TextureBrush(Resource1.flipTest))
                if (boolListRectangle.PTextureBrush == null)
                    boolListRectangle.PTextureBrush = new TextureBrush(Resource1.flipTest);
                {
                    g.FillRectangle(boolListRectangle.PTextureBrush, x, y, width, height);
                    // TextureBrush 클릭 영역을 저장
                    if (boolListRectangle.isWrite)
                        boolListRectangle.Add(new Rectangle(x, y, width, height));
                    // 영역에 맞는 PopupFlags를 저장. (마지막에 추가되었으므로, 그에 맞게 브러쉬 스타일을 저장)
                    boolListRectangle.mPopupFlagsInDic[boolListRectangle.mDrawBrushesRectangles.Last()] = BoolListRectangle.PopupFlags.TextureBrush;

                    g.DrawString(boolListRectangle.PTextureBrush.ToString(), this.Font, blackBrush, x, y + 3);  // 위에서 3만큼 띄움. y값에 저장 안 함.
                    y += height;
                }

                // HatchBrush
                if (boolListRectangle.PHatchBrush == null)
                    boolListRectangle.PHatchBrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Divot, Color.DarkBlue, Color.White);
                {
                    g.FillRectangle(boolListRectangle.PHatchBrush, x, y, width, height);
                    // HatchBrush 클릭 영역을 저장
                    if (boolListRectangle.isWrite)
                        boolListRectangle.Add(new Rectangle(x, y, width, height));
                    // 영역에 맞는 PopupFlags를 저장. (마지막에 추가되었으므로, 그에 맞게 브러쉬 스타일을 저장)
                    boolListRectangle.mPopupFlagsInDic[boolListRectangle.mDrawBrushesRectangles.Last()] = BoolListRectangle.PopupFlags.HatchBrush;

                    g.DrawString(boolListRectangle.PHatchBrush.ToString(), this.Font, blackBrush, x, y + 3);
                    y += height;
                }

                //// HatchBrush
                //using (Brush brush = new System.Drawing.Drawing2D.HatchBrush
                //    (System.Drawing.Drawing2D.HatchStyle.Divot, Color.DarkBlue, Color.White))
                //{
                //    g.FillRectangle(brush, x, y, width, height);
                //    g.DrawString(brush.ToString(), this.Font, blackBrush, x, y + 3);
                //    y += height;
                //}

                //LinearGradientBrush (선형으로 쭉 그려지는 브러쉬)
                //using (Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                //    new Rectangle(x, y, width, height),
                //    Color.DarkBlue,
                //    Color.White,
                //    45.0f
                //    ))
                if(boolListRectangle.PLinearGradientBrush == null)
                    boolListRectangle.PLinearGradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Rectangle(x, y, width, height),
                    Color.DarkBlue,
                    Color.White,
                    45.0f
                    );
                {
                    // 팝업 창에서의 x좌표와 width가 일치하지 않으므로, 인수로 넘겨줄 값을 저장한다.
                    boolListRectangle.mLinearGradientBrushX = x;
                    boolListRectangle.mLinearGradientBrushWidth = width;
                    g.FillRectangle(boolListRectangle.PLinearGradientBrush, x, y, width, height);
                    // LinearGradientBrush 클릭 영역을 저장
                    if (boolListRectangle.isWrite)
                        boolListRectangle.Add(new Rectangle(x, y, width, height));
                    // 영역에 맞는 PopupFlags를 저장. (마지막에 추가되었으므로, 그에 맞게 브러쉬 스타일을 저장)
                    boolListRectangle.mPopupFlagsInDic[boolListRectangle.mDrawBrushesRectangles.Last()] = BoolListRectangle.PopupFlags.LinearGradientBrush;

                    g.DrawString(boolListRectangle.PLinearGradientBrush.ToString(), this.Font, blackBrush, x, y + 3);
                    y += height;
                }

                // PathGradientBrush
                Point[] points = new Point[]
                {
                    new Point(x,y),                       // 왼쪽 위
                    new Point(x + width, y),              // 오른쪽 위
                    new Point(x + width, y + height),     // 오른쪽 아래
                    new Point(x, y + height)              // 왼쪽 아래
                };

                //using (Brush brush = new System.Drawing.Drawing2D.PathGradientBrush(points))
                if (boolListRectangle.PPathGradientBrush == null)
                    boolListRectangle.PPathGradientBrush = new System.Drawing.Drawing2D.PathGradientBrush(points);
                {
                    g.FillRectangle(boolListRectangle.PPathGradientBrush, x, y, width, height);
                    // PathGradientBrush 클릭 영역을 저장
                    if (boolListRectangle.isWrite)
                        boolListRectangle.Add(new Rectangle(x, y, width, height));
                    // 영역에 맞는 PopupFlags를 저장. (마지막에 추가되었으므로, 그에 맞게 브러쉬 스타일을 저장)
                    boolListRectangle.mPopupFlagsInDic[boolListRectangle.mDrawBrushesRectangles.Last()] = BoolListRectangle.PopupFlags.PathGradientBrush;

                    g.DrawString(boolListRectangle.PPathGradientBrush.ToString(), this.Font, blackBrush, x, y);
                    //y += height;
                }
                boolListRectangle.isWrite = false;
            }
        }

        public bool drawBrushes = false;
        private void DrawBrushesBtn_Click(object sender, EventArgs e)
        {
            // 타원을 그렸으면, 끈다.
            if (drawEllipse)
            {
                drawEllipse = !drawEllipse;
            }
            drawBrushes = true;
            //            drawBrushes = !drawBrushes;
            Invalidate(true);
            Update();       // Paint에서 boolListRectangle.PopupFlag객체를 설정하므로, Update()안 하면 예외 발생함.

            // 만약 처음에 띄우지 않으려면, 아래 부분 삭제하고, MouseUp이벤트에서만 폼 띄우면 된다.
            if (drawBrushes)
            {
                        DrawBrushes drawHatBrushes = new DrawBrushes(BasicDrawingForm.BoolListRectangle.PopupFlags.HatchBrush);
                        drawHatBrushes.Selected += Selected;
                        if (drawHatBrushes.ShowDialog() == DialogResult.OK)
                        {
                            this.Refresh();
                        }
            }
        }

        private void DrawBrushesBtn_MouseMove(object sender, MouseEventArgs e)
        {
            instructionTextBox.Text = "5가지 브러쉬로 각각 사각형을 그린다." +
                "\r\n새 창을 띄워 HatchBrushes 스타일을 보여 준다." +
                "\r\nHatchBrush를 클릭해서 선택하면, 그 브러쉬로 바꿔서 그린다.";
        }

        private void Selected(object sender, BrushEventArgs e)
        {
            switch (boolListRectangle.mPopupFlag)
            {
                case BoolListRectangle.PopupFlags.SolidBrush:
                    boolListRectangle.PSolidBrush = e.mBrush as SolidBrush;
                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.TextureBrush:
                    boolListRectangle.PTextureBrush = e.mBrush as TextureBrush;
                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.HatchBrush:
                    boolListRectangle.PHatchBrush = e.mBrush as System.Drawing.Drawing2D.HatchBrush;
                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.LinearGradientBrush:
                    boolListRectangle.PLinearGradientBrush = e.mBrush as System.Drawing.Drawing2D.LinearGradientBrush;
                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.PathGradientBrush:
                    boolListRectangle.PPathGradientBrush = e.mBrush as System.Drawing.Drawing2D.PathGradientBrush;
                    break;
                default:
                    break;
            }
        }

        private void BasicDrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void BasicDrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawBrushes)
            {
                if (e.Button == MouseButtons.Left)
                {
                    // 마우스 클릭한 부분에 대해 어떤 팝업창이 열릴지 설정. (마우스를 떼면 그 팝업창이 열림)
                    boolListRectangle.SetBrushStyleFromMouseXY(e);
                }
            }

            if (drawBrushes)
            {
                DrawBrushes drawHatBrushes;
                switch (boolListRectangle.PopupFlag)
                {
                    case BoolListRectangle.PopupFlags.SolidBrush:
                        break;

                    case BoolListRectangle.PopupFlags.TextureBrush:
                        break;

                    case BoolListRectangle.PopupFlags.HatchBrush:
                        drawHatBrushes = new DrawBrushes(BasicDrawingForm.BoolListRectangle.PopupFlags.HatchBrush);
                        drawHatBrushes.Selected += Selected;
                        if (drawHatBrushes.ShowDialog() == DialogResult.OK)
                        {
                            this.Refresh();
                        }
                        break;

                    case BoolListRectangle.PopupFlags.LinearGradientBrush:
                        // -1안 하면 왼쪽에 검정색 선 생김.
                        drawHatBrushes = new DrawBrushes(BasicDrawingForm.BoolListRectangle.PopupFlags.LinearGradientBrush, boolListRectangle.mLinearGradientBrushX-1, boolListRectangle.mLinearGradientBrushWidth);
                        drawHatBrushes.Selected += Selected;
                        if(drawHatBrushes.ShowDialog() == DialogResult.OK)
                        {
                            this.Refresh();
                        }
                        break;
                    case BoolListRectangle.PopupFlags.PathGradientBrush:
                        break;

                    // PopupFlag.None이어도 그냥 HatchBrush를 연다.
                    default:
                        //DrawHatchBrushes drawHatBrushes2 = new DrawHatchBrushes();
                        //drawHatBrushes2.Selected += Selected;
                        //if (drawHatBrushes2.ShowDialog() == DialogResult.OK)
                        //{
                        //    this.Refresh();
                        //}
                        break;
                }
            }

        }



    }
}
