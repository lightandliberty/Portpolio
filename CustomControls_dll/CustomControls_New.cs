using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControls_dll
{
    #region Metal 버튼 클래스 설정
    public class MetalButton : Button
    {
        private bool isLeftMouseButtonDown = false;

        public MetalButton()
        {
            MouseDown += new MouseEventHandler(Button_MouseDown);
            MouseUp += new MouseEventHandler(Button_MouseUp);
            MouseLeave += new EventHandler(Button_MouseLeave);
            Paint += new PaintEventHandler(Button_Paint);
        }

        public void SetButtonToMetalStyle(object sender, EventArgs e)
        {
            (sender as MetalButton).MouseDown += new MouseEventHandler(Button_MouseDown);
            (sender as MetalButton).MouseUp += new MouseEventHandler(Button_MouseUp);
            (sender as MetalButton).MouseLeave += new EventHandler(Button_MouseLeave);
            (sender as MetalButton).Paint += new PaintEventHandler(Button_Paint);
        }

        public void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseButtonDown = true;
                DrawThisButtonColorToClickedMetal(sender, (sender as MetalButton).CreateGraphics());
            }
        }

        public void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseButtonDown = false;
                DrawThisButtonColorToMetal(sender, (sender as MetalButton).CreateGraphics());
            }
        }

        public void Button_MouseLeave(object sender, EventArgs e)
        {
            isLeftMouseButtonDown = false;
            DrawThisButtonColorToMetal(sender, (sender as MetalButton).CreateGraphics());
        }

        public void Button_Paint(object sender, PaintEventArgs e)
        {
            if (isLeftMouseButtonDown == true)         // 마우스 버튼이 눌렸으면
            {
                DrawThisButtonColorToClickedMetal(sender, e.Graphics);
            }
            else
            {
                DrawThisButtonColorToMetal(sender, e.Graphics);
            }
        }

        ~MetalButton()
        {
            this.Dispose();
        }

        protected override void Dispose(bool disposing)
        {
            MouseDown -= new MouseEventHandler(Button_MouseDown);
            MouseUp -= new MouseEventHandler(Button_MouseUp);
            MouseLeave -= new EventHandler(Button_MouseLeave);
            Paint -= new PaintEventHandler(Button_Paint);
            base.Dispose(disposing);
        }

        #region 버튼색을 메탈색으로 설정
        public static void DrawThisButtonColorToMetal(object sender, Graphics gra)
        {
            // 전달된 버튼의 색을 변경
            Graphics g = gra;
            g.FillRectangle(
                new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as MetalButton).Height), Color.White, Color.LightGray),
                new RectangleF(new Point(0, 0), new Size((sender as MetalButton).Size.Width, (sender as MetalButton).Size.Height)));
            // 버튼에 표시할 Text 중앙 정렬
            StringFormat sf = new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center,
            };
            g.DrawString((sender as MetalButton).Text,
                new Font((sender as MetalButton).Font.Name, 10), System.Drawing.Brushes.Black,
                new Rectangle(new Point(0, 0), new Size((sender as MetalButton).Size.Width, (sender as MetalButton).Size.Height)),
                sf);
        }
        public static void DrawThisButtonColorToClickedMetal(object sender, Graphics gra)
        {
            // 전달된 버튼의 색을 변경
            Graphics g = gra;
            g.FillRectangle(
                new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as MetalButton).Height), Color.LightGray, Color.White),
                new RectangleF(new Point(0, 0), new Size((sender as MetalButton).Size.Width, (sender as MetalButton).Size.Height)));
            // 버튼에 표시할 Text 중앙 정렬
            StringFormat sf = new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };
            g.DrawString((sender as MetalButton).Text,
                new Font((sender as MetalButton).Font.Name, 10), System.Drawing.Brushes.Black,
                new Rectangle(new Point(0, 0), new Size((sender as MetalButton).Size.Width, (sender as MetalButton).Size.Height)),
                sf);
        }
    }
    #endregion
    #endregion

    #region Neon 버튼 클래스 설정

    #region neon 버튼 기본 설정.(생성자 등)
    public class NeonButton : Button
    {
        private bool isLeftMouseButtonDown = false;
        private bool isHover = false;

        public NeonButton()
        {
            MouseDown += new MouseEventHandler(NeonButton_MouseDown);
            MouseUp += new MouseEventHandler(NeonButton_MouseUp);
            MouseHover += new EventHandler(NeonButton_MouseHover);
            MouseLeave += new EventHandler(NeonButton_MouseLeave);
            Paint += new PaintEventHandler(NeonButton_Paint);
            
            // 네온 컬러쌍 초기화
            InitNeonPairs();
//            ButtonColor = KeyColor.Gray3;
        }

        #region 보통 버튼에 네온 스타일을 적용시키는 메서드. isLeftMouseButtonDown멤버가 클래스에 있어야 하고, 적당히 변형하여 적용해야 함.

        public void SetButtonToNeonStyle(object sender, EventArgs e)
        {
            // 
            // 
            (sender as NeonButton).MouseDown += new MouseEventHandler(NeonButton_MouseDown);
            (sender as NeonButton).MouseUp += new MouseEventHandler(NeonButton_MouseUp);
            (sender as NeonButton).MouseHover += new EventHandler(NeonButton_MouseHover);
            (sender as NeonButton).MouseLeave += new EventHandler(NeonButton_MouseLeave);
            (sender as NeonButton).Paint += new PaintEventHandler(NeonButton_Paint);
        }
        #endregion

        public void NeonButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseButtonDown = true;
                isHover = true;
                DrawThisButtonColorToClickedNeon(sender, (sender as NeonButton).CreateGraphics());
            }
        }

        // 마우스가 버튼 위에 있으면
        public void NeonButton_MouseHover(object sender, EventArgs e)
        {
            isHover = true;
            DrawThisButtonColorToHoverNeon(sender, (sender as NeonButton).CreateGraphics());
        }

        // 버튼 위에서 마우스를 떼면
        public void NeonButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseButtonDown = false;
                DrawThisButtonColorToHoverNeon(sender, (sender as NeonButton).CreateGraphics());
            }
        }

        // 버튼 밖으로 마우스가 나가면
        public void NeonButton_MouseLeave(object sender, EventArgs e)
        {
            isLeftMouseButtonDown = false;
            isHover = false;
            DrawThisButtonColorToNeon(sender, (sender as NeonButton).CreateGraphics());
        }

        // 버튼 그리기.
        public void NeonButton_Paint(object sender, PaintEventArgs e)
        {
            if (isLeftMouseButtonDown)         // 마우스 버튼이 눌렸으면
            {
                DrawThisButtonColorToClickedNeon(sender, e.Graphics);
            }
            else if(isHover)// 마우스가 위에 있는 거면,
            {
                DrawThisButtonColorToHoverNeon(sender, e.Graphics);
            }
            else
            {
                DrawThisButtonColorToNeon(sender, e.Graphics);
            }
        }

        ~NeonButton()
        {
            this.Dispose();
        }

        // 델리게이트에 등록된 원소들 해제. (해제 안하면 에러남)
        protected override void Dispose(bool disposing)
        {
            MouseDown -= new MouseEventHandler(NeonButton_MouseDown);
            MouseUp -= new MouseEventHandler(NeonButton_MouseUp);
            MouseHover -= new EventHandler(NeonButton_MouseHover);
            MouseLeave -= new EventHandler(NeonButton_MouseLeave);
            Paint -= new PaintEventHandler(NeonButton_Paint);
            base.Dispose(disposing);
        }
        #endregion

        #region 버튼색을 네온색으로 설정
        public KeyColor mKeyColor;  // 네온 불빛이 들어오기 전의 색상
        public Color mForeColor;        // 네온 불빛이 들어오거나 할 때의 글자색. 현재 안 쓰임.
        public Dictionary<KeyColor, Color> neonClickedPairs;   // 네온 버튼을 클릭했을 때 글자색
        public Dictionary<KeyColor, Color> neonHoverPairs;     // 네온 버튼 위에 올려 놓았을 때 글자색.
        public Dictionary<KeyColor, Color> neonNormalPairs;     // 네온 버튼의 클릭하기 전 글자색.
        
        public KeyColor ButtonColor                             // 버튼의 색상을 설정한다.
        {
            get => mKeyColor;
            set
            {
                if (neonClickedPairs.ContainsKey(value) && neonHoverPairs.ContainsKey(value) && neonNormalPairs.ContainsKey(value))
                {
                    mKeyColor = value;
                }
            }
        }



        #region enum KeyColor와 class NeonColors 정의
        public enum KeyColor : int
        {
            Pink = 0,
            Red,
            Cyan,
            Blue,
            Green,
            Green2,
            LightGreen,
            Yellow,
            Orange,
            Brown,
            Gray1,
            Gray2,
            Gray3,
            Count,
        }

        
        public class NeonColors
        {
            public KeyColor keyColor;
            public Color normalColor;
            public Color hoverColor;
            public Color neonColor;

            public NeonColors()
            {
                keyColor = KeyColor.Gray1;
                normalColor = Color.Gray;
                hoverColor = Color.Black;
                neonColor = Color.White;
            }

            public NeonColors(KeyColor keyC, Color normalC, Color hoverC, Color neonC)
            {
                keyColor = keyC;
                normalColor = normalC;
                hoverColor = hoverC;
                neonColor = neonC;
            }
        }
        #endregion

        // 어떤 컬러에 대한 클릭하기 전의 색, 마우스를 올렸을 때의 색, 클릭했을 때의 색 등을 배열에 저장.
        public void InitNeonPairs()
        {
            // 객체에 메모리 할당.
            neonClickedPairs = new Dictionary<KeyColor, Color>();
            neonHoverPairs = new Dictionary<KeyColor, Color>();
            neonNormalPairs = new Dictionary<KeyColor, Color>();
            
            // 일단 기본 네온 컬러들을 배열에 복사. (Hover(가장 어두운 색), 기본색(중간 밝은 색), 네온 색(클릭 했을 때의 가장 밝은 색))
            List<NeonColors> colorList = new List<NeonColors>()
            {
                new NeonColors(KeyColor.Pink, Color.FromArgb(238, 196, 241), Color.FromArgb(141, 074, 178), Color.FromArgb(253, 233, 255)),
                new NeonColors(KeyColor.Red, Color.FromArgb(225, 036, 100), Color.FromArgb(068, 003, 047), Color.FromArgb(247, 231, 242)),
                new NeonColors(KeyColor.Cyan, Color.FromArgb(100, 202, 249), Color.FromArgb(037, 155, 231), Color.FromArgb(122, 244, 253)),
                new NeonColors(KeyColor.Blue, Color.FromArgb(141, 164, 242), Color.FromArgb(046, 043, 244), Color.FromArgb(171, 197, 247)),
                new NeonColors(KeyColor.Green, Color.FromArgb(168, 203, 163), Color.FromArgb(009, 125, 026), Color.FromArgb(220, 246, 215)),
                new NeonColors(KeyColor.Green2, Color.FromArgb(014,114,018), Color.FromArgb(010,065,008), Color.FromArgb(232,250,243)),
                new NeonColors(KeyColor.LightGreen, Color.FromArgb(035, 229, 141), Color.FromArgb(000, 055, 027), Color.FromArgb(246, 255, 255)),
                new NeonColors(KeyColor.Yellow, Color.FromArgb(230, 206, 013), Color.FromArgb(183, 156, 000), Color.FromArgb(240, 232, 006)),
                new NeonColors(KeyColor.Orange, Color.FromArgb(214, 170, 140), Color.FromArgb(159, 111, 083), Color.FromArgb(247, 223, 187)),
                new NeonColors(KeyColor.Brown, Color.FromArgb(195, 172, 165), Color.FromArgb(100, 078, 075), Color.FromArgb(224, 205, 192)),
                new NeonColors(KeyColor.Gray1, Color.FromArgb(153, 171, 187), Color.FromArgb(079, 098, 105), Color.FromArgb(206, 230, 241)),
                new NeonColors(KeyColor.Gray2, Color.FromArgb(169, 155, 159), Color.FromArgb(085, 073, 077), Color.FromArgb(229, 215, 220)),
                new NeonColors(KeyColor.Gray3, Color.FromArgb(217, 210, 214), Color.FromArgb(137, 127, 123), Color.FromArgb(241, 236, 243)),
            };

            // 클릭 전, 마우스 위에 있을 때, 클릭했을 때의 색을 각각 지정
            for (int i = 0; i < colorList.Count; i++)
            {
                AddHoverAndNeonColorsFrom4Color(colorList[i].keyColor, colorList[i].normalColor, colorList[i].hoverColor, colorList[i].neonColor);
            }

            colorList.Clear();
            //MessageBox.Show(neonNormalPairs.Contains(mKeyColor).ToString());
            // KeyColor로 버튼 색을 변경.
            ButtonColor = KeyColor.Pink;
        }

        // 0 ~ 255 사이의 수 리턴
        public static int Clamp0255(int num)
        {
            return num > 255 ? 255 :
                num < 0 ? 0 :
                num;
        }

        // 기본 버튼 색상으로 마우스를 위에 올릴 때의 색상 및 반짝일 때의 색상을 얻는다.
        public void AddHoverAndNeonColorsFrom4Color(KeyColor keyColor, Color normalColor, Color hoverColor, Color clickedColor)
        {
            neonNormalPairs[keyColor] = normalColor;            // 클릭하기 전의 색
            neonHoverPairs[keyColor] = hoverColor;              // 마우스를 위에 올려 놓았을 때의 색
            neonClickedPairs[keyColor] = clickedColor;          // 클릭했을 때의 색
//            ButtonColor = keyColor;
        }

        // 브러쉬 색상을 버튼의 밝기에 따라 변경한다.
        public Brush SetBrushColorFromBackColor(Color backColor)
        {
            if ((backColor.R > 150 && backColor.G > 150) || (backColor.G > 150 && backColor.B > 150) || (backColor.B > 150 && backColor.R > 150))
                return Brushes.Black;
            else
                return Brushes.White;
        }

        // 클릭하기 전 버튼의 배경 색을 그라데이션으로 그리고, 글씨를 가운데로 정렬해서 밝기에 맞게 그림.
        public void DrawThisButtonColorToNeon(object sender, Graphics gra)
        {
            // 전달된 버튼의 색을 변경
            Graphics g = gra;
            g.FillRectangle(
                new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as NeonButton).Height), Color.White, this.neonNormalPairs[mKeyColor]),
                new RectangleF(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)));
            // 버튼에 표시할 Text 중앙 정렬
            StringFormat sf = new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center,
            };
            g.DrawString((sender as NeonButton).Text,
                new Font((sender as NeonButton).Font.Name, 10), SetBrushColorFromBackColor(this.neonNormalPairs[mKeyColor]),
                new Rectangle(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)),
                sf);

        }

        // 마우스를 올려 놓았을 때의 버튼의 배경 색을 그라데이션으로 그리고, 글씨를 가운데로 정렬해서 밝기에 맞게 그림.
        public void DrawThisButtonColorToHoverNeon(object sender, Graphics gra)
        {
            // 전달된 버튼의 색을 변경
            Graphics g = gra;
            g.FillRectangle(
                new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as NeonButton).Height), Color.White, this.neonHoverPairs[mKeyColor]),
                new RectangleF(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)));
            // 버튼에 표시할 Text 중앙 정렬
            StringFormat sf = new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center,
            };
            g.DrawString((sender as NeonButton).Text,
                new Font((sender as NeonButton).Font.Name, 10), SetBrushColorFromBackColor(this.neonHoverPairs[mKeyColor]),
                new Rectangle(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)),
                sf);
        }

        // 클릭할 때의 배경 색을 그라데이션으로 그리고, 글씨를 가운데로 정렬해서 밝기에 맞게 그림.
        public void DrawThisButtonColorToClickedNeon(object sender, Graphics gra)
        {
            // 전달된 버튼의 색을 변경
            Graphics g = gra;
            g.FillRectangle(
                new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as NeonButton).Height), Color.White, this.neonClickedPairs[mKeyColor]),
                new RectangleF(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)));
            // 버튼에 표시할 Text 중앙 정렬
            StringFormat sf = new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };
            g.DrawString((sender as NeonButton).Text,
                new Font((sender as NeonButton).Font.Name, 10), SetBrushColorFromBackColor(this.neonClickedPairs[mKeyColor]),
                new Rectangle(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)),
                sf);
        }
        #endregion
    }
}
#endregion


#region 버튼색을 네온색으로 설정에서 enum 적용 전.
//public Color mKeyColor;  // 네온 불빛이 들어오기 전의 색상
//public Color mForeColor;        // 네온 불빛이 들어오거나 할 때의 글자색. 현재 안 쓰임.
//public Dictionary<Color, Color> neonClickedPairs;   // 네온 버튼을 클릭했을 때 글자색
//public Dictionary<Color, Color> neonHoverPairs;     // 네온 버튼 위에 올려 놓았을 때 글자색.
//public Dictionary<Color, Color> neonNormalPairs;     // 네온 버튼의 클릭하기 전 글자색.

//enum KeyColor : int
//{
//    None = 0,
//    Pink,
//    Red,
//    Cyan,
//    Blue,
//    Green,
//    LightGreen,
//    Yellow,
//    Orange,
//    Brown,
//    Gray1,
//    Gray2,
//    Gray3,
//    White
//}


//// 어떤 컬러에 대한 클릭하기 전의 색, 마우스를 올렸을 때의 색, 클릭했을 때의 색 등을 배열에 저장.
//public void InitNeonPairs()
//{
//    // 객체에 메모리 할당.
//    neonClickedPairs = new Dictionary<Color, Color>();
//    neonHoverPairs = new Dictionary<Color, Color>();
//    neonNormalPairs = new Dictionary<Color, Color>();

//    // 클릭 전, 마우스 위에 있을 때, 클릭했을 때의 색을 자동으로 지정.
//    mKeyColor = Color.Blue;
//    AddHoverAndNeonColorsFromBeforeColor(mKeyColor);

//    mKeyColor = Color.Yellow;
//    AddHoverAndNeonColorsFromBeforeColor(mKeyColor);

//    // 클릭 전, 마우스 위에 있을 때, 클릭했을 때의 색을 각각 지정
//    mKeyColor = Color.Violet;
//    neonNormalPairs.Add(mKeyColor, Color.Violet);
//    neonClickedPairs.Add(mKeyColor, Color.Pink);
//    neonHoverPairs.Add(mKeyColor, Color.HotPink);

//    // KeyColor로 버튼 색을 변경.
//    SetBeforeNeonColor(Color.Yellow);

//}

//// 0 ~ 255 사이의 수 리턴
//public static int Clamp0255(int num)
//{
//    return num > 255 ? 255 :
//        num < 0 ? 0 :
//        num;
//}

//// 기본 버튼 색상으로 마우스를 위에 올릴 때의 색상 및 반짝일 때의 색상을 얻는다.
//public void AddHoverAndNeonColorsFromBeforeColor(Color beforeColor)
//{
//    // 클릭하기 전의 색
//    neonNormalPairs[beforeColor] = Color.FromArgb(
//        Clamp0255(beforeColor.R),
//        Clamp0255(beforeColor.G),
//        Clamp0255(beforeColor.B));

//    // 클릭했을 때의 색
//    neonClickedPairs[beforeColor] = Color.FromArgb(
//        Clamp0255(beforeColor.R + 50),
//        Clamp0255(beforeColor.G + 50),
//        Clamp0255(beforeColor.B + 50));

//    // 마우스를 위에 올려 놓았을 때의 색
//    neonHoverPairs[beforeColor] = Color.FromArgb(
//        Clamp0255(beforeColor.R - 50),
//        Clamp0255(beforeColor.G - 50),
//        Clamp0255(beforeColor.B - 50));
//}

//// 기본 버튼 색상으로 마우스를 위에 올릴 때의 색상 및 반짝일 때의 색상을 얻는다.
//public void AddHoverAndNeonColorsFrom4Color(Color keyColor, Color normalColor, Color hoverColor, Color clickedColor)
//{
//    // 클릭하기 전의 색
//    neonNormalPairs[keyColor] = normalColor;

//    // 마우스를 위에 올려 놓았을 때의 색
//    neonHoverPairs[keyColor] = hoverColor;

//    // 클릭했을 때의 색
//    neonClickedPairs[keyColor] = clickedColor;

//}

//// 버튼의 색 지정. 나중에 Enum으로 해야 할 듯.
//public Color ButtonColor
//{
//    get { return mKeyColor; }
//    set
//    {
//        if (neonClickedPairs.ContainsKey(value) && neonHoverPairs.ContainsKey(value) && neonNormalPairs.ContainsKey(value))
//            mKeyColor = value;
//    }
//}

//// 네온 불빛이 들어오기 전 색상을 설정한다.
//public void SetBeforeNeonColor(System.Drawing.Color neonColor)
//{
//    // 불빛이 들어오기 전 색상이, 클릭하기 전, 마우스 올려 놓았을 때, 클릭했을 때의 배열 Dictionary<Color,Color>에 있으면 변경.
//    if (neonClickedPairs.ContainsKey(neonColor) && neonHoverPairs.ContainsKey(neonColor) && neonNormalPairs.ContainsKey(neonColor))
//        mKeyColor = neonColor;
//}

//// 글자 색상을 버튼의 밝기에 따라 변경한다.
//public Color SetForeColorFromBackColor(Color backColor)
//{
//    if ((backColor.R > 150 && backColor.G > 150) || (backColor.G > 150 && backColor.B > 150) || (backColor.B > 150 && backColor.R > 150))
//        return Color.Black;
//    else
//        return Color.White;
//}

//// 브러쉬 색상을 버튼의 밝기에 따라 변경한다.
//public Brush SetBrushColorFromBackColor(Color backColor)
//{
//    if ((backColor.R > 150 && backColor.G > 150) || (backColor.G > 150 && backColor.B > 150) || (backColor.B > 150 && backColor.R > 150))
//        return Brushes.Black;
//    else
//        return Brushes.White;
//}

//// 클릭하기 전 버튼의 배경 색을 그라데이션으로 그리고, 글씨를 가운데로 정렬해서 밝기에 맞게 그림.
//public void DrawThisButtonColorToNeon(object sender, Graphics gra)
//{
//    // 전달된 버튼의 색을 변경
//    Graphics g = gra;
//    g.FillRectangle(
//        new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as NeonButton).Height), Color.White, this.neonNormalPairs[mKeyColor]),
//        new RectangleF(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)));
//    // 버튼에 표시할 Text 중앙 정렬
//    StringFormat sf = new StringFormat()
//    {
//        LineAlignment = StringAlignment.Center,
//        Alignment = StringAlignment.Center,
//    };
//    g.DrawString((sender as NeonButton).Text,
//        new Font((sender as NeonButton).Font.Name, 10), SetBrushColorFromBackColor(this.neonNormalPairs[mKeyColor]),
//        new Rectangle(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)),
//        sf);
//}

//// 마우스를 올려 놓았을 때의 버튼의 배경 색을 그라데이션으로 그리고, 글씨를 가운데로 정렬해서 밝기에 맞게 그림.
//public void DrawThisButtonColorToHoverNeon(object sender, Graphics gra)
//{
//    // 전달된 버튼의 색을 변경
//    Graphics g = gra;
//    g.FillRectangle(
//        new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as NeonButton).Height), Color.White, this.neonHoverPairs[mKeyColor]),
//        new RectangleF(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)));
//    // 버튼에 표시할 Text 중앙 정렬
//    StringFormat sf = new StringFormat()
//    {
//        LineAlignment = StringAlignment.Center,
//        Alignment = StringAlignment.Center,
//    };
//    g.DrawString((sender as NeonButton).Text,
//        new Font((sender as NeonButton).Font.Name, 10), SetBrushColorFromBackColor(this.neonHoverPairs[mKeyColor]),
//        new Rectangle(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)),
//        sf);
//}

//// 클릭할 때의 배경 색을 그라데이션으로 그리고, 글씨를 가운데로 정렬해서 밝기에 맞게 그림.
//public void DrawThisButtonColorToClickedNeon(object sender, Graphics gra)
//{
//    // 전달된 버튼의 색을 변경
//    Graphics g = gra;
//    g.FillRectangle(
//        new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as NeonButton).Height), Color.White, this.neonClickedPairs[mKeyColor]),
//        new RectangleF(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)));
//    // 버튼에 표시할 Text 중앙 정렬
//    StringFormat sf = new StringFormat()
//    {
//        LineAlignment = StringAlignment.Center,
//        Alignment = StringAlignment.Center
//    };
//    g.DrawString((sender as NeonButton).Text,
//        new Font((sender as NeonButton).Font.Name, 10), SetBrushColorFromBackColor(this.neonClickedPairs[mKeyColor]),
//        new Rectangle(new Point(0, 0), new Size((sender as NeonButton).Size.Width, (sender as NeonButton).Size.Height)),
//        sf);
//}
#endregion
