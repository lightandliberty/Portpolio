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
    public partial class DrawBrushes : Form
    {
        public Dictionary<Rectangle, SolidBrush> mSolidBrushRectangles;
        public Dictionary<Rectangle, TextureBrush> mTextureBrushRectangles;
        public Dictionary<Rectangle, System.Drawing.Drawing2D.HatchBrush> mHatchBrushRectangles;
        public Dictionary<Rectangle, System.Drawing.Drawing2D.LinearGradientBrush> mLinearGradientBrushRectangles;
        public Dictionary<Rectangle, System.Drawing.Drawing2D.PathGradientBrush> mPathGradientBrushRectangles;

        public delegate void HatchBrushSelectEventHandler(Object sender, BrushEventArgs hb);   // 이벤트 함수 형태 선언

        // 이벤트 함수 포인터 배열 생성. (여기에 부모 폼에서 함수를 추가함)
        public event HatchBrushSelectEventHandler Selected;

        public BasicDrawingForm.BoolListRectangle.PopupFlags selectBrushFlag;
        public int mParentX;
        public int mParentWidth;

        public DrawBrushes()
        {
            InitializeComponent();
        }

        public DrawBrushes(BasicDrawingForm.BoolListRectangle.PopupFlags popupFlag)
        {
            InitializeComponent();
            // 선택할 브러쉬 플래그
            selectBrushFlag = popupFlag;

        }


        public DrawBrushes(BasicDrawingForm.BoolListRectangle.PopupFlags popupFlag, int parentX, int parentWidth)
        {
            InitializeComponent();
            // 선택할 브러쉬 플래그
            selectBrushFlag = popupFlag;
            mParentX = parentX;
            mParentWidth = parentWidth;
        }

        private void HatchBrushes_Load(object sender, EventArgs e)
        {
            switch (selectBrushFlag)
            {
                case BasicDrawingForm.BoolListRectangle.PopupFlags.SolidBrush:
                    mSolidBrushRectangles = new Dictionary<Rectangle, SolidBrush>();
                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.TextureBrush:
                    mTextureBrushRectangles = new Dictionary<Rectangle, TextureBrush>();
                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.HatchBrush:
                    mHatchBrushRectangles = new Dictionary<Rectangle, System.Drawing.Drawing2D.HatchBrush>();
                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.LinearGradientBrush:
                    mLinearGradientBrushRectangles = new Dictionary<Rectangle, System.Drawing.Drawing2D.LinearGradientBrush>();
                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.PathGradientBrush:
                    mPathGradientBrushRectangles = new Dictionary<Rectangle, System.Drawing.Drawing2D.PathGradientBrush>();
                    break;
                default:
                    this.DialogResult = DialogResult.Cancel;
                    break;
            }

            this.Text = "마우스로 패턴을 선택할 수 있습니다.";

        }

        // Size를 0,0으로 하였음로, 디자인 화면에선 Ctrl + A 키로 선택할 수 있습니다.
        private void CancelMetalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public List<Rectangle> rects = new List<Rectangle>();
        private void DrawHatchBrushes_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // HatchStyle은 1 ~ 52까지 있음.
            int x = 0;
            int y = 0;
            Font font = new Font("malgun gothic", 8, FontStyle.Regular);
            int width = this.ClientSize.Width / 4;
            int height = this.ClientSize.Height / 26;
            Rectangle rect;
            Rectangle parentRect;
            switch(selectBrushFlag)
            {
                case BasicDrawingForm.BoolListRectangle.PopupFlags.SolidBrush:
                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.TextureBrush:
                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.HatchBrush:
                    rect = new Rectangle(x, y, width, height);
                    // HatchBrush용 Paint
                    using (Brush solidBrush1 = new System.Drawing.SolidBrush(Color.LightGray))
                    {
                        for (int i = 0; i < 13; i++)
                        {
                            // 4칸 반복해서 그림
                            for (int j = 0; j < 4; j++)
                            {
                                using (Brush brush = new System.Drawing.Drawing2D.HatchBrush((System.Drawing.Drawing2D.HatchStyle)j + (i * 4), Color.DarkBlue, Color.White))
                                {
                                    // 윗칸 칠하고, 글씨 씀
                                    g.FillRectangle(solidBrush1, rect);
                                    g.DrawString(((System.Drawing.Drawing2D.HatchStyle)j + (i * 4)).ToString(), font, System.Drawing.Brushes.Black, rect.X, rect.Y + 1);
                                    rect.Y += height;
                                    // 아래 칸 칠하고, 사각형을 배열에 저장.
                                    g.FillRectangle(brush, rect);
                                    // rects에 저장하고, 마지막 요소를 key로 해서 HatchBrush를 저장
                                    rects.Add(rect);
                                    // HatchBrush를 new로 생성해서 Dictionary에 저장. rect와 rects.Last()는 
                                    mHatchBrushRectangles.Add(rect, new System.Drawing.Drawing2D.HatchBrush((System.Drawing.Drawing2D.HatchStyle)j + (i * 4), Color.DarkBlue, Color.White));
                                };
                                rect.X += width;
                                rect.Y -= height;
                            }
                            rect.X = 0;
                            rect.Y += height * 2;
                        }
                    };
                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.LinearGradientBrush:
                    width = this.ClientSize.Width;
                    height = this.ClientSize.Height / 4;
                    
                    rect = new Rectangle(x, y, width, height);
                    parentRect = new Rectangle(mParentX, y, mParentWidth, height);
                    // LinearGradientBrush용 Paint
                    using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(rect, Color.White, Color.Black, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
                    {
                        g.FillRectangle(brush, rect);
                        g.DrawString("Normal", font, System.Drawing.Brushes.Black, rect.X, rect.Y);

                        // Factor혼합 비율과 Positions혼합 위치를 지정하는 Blend객체를 이용한 브러시
                        System.Drawing.Drawing2D.LinearGradientBrush myBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
                            rect,
                            Color.Blue,
                            Color.Red,
                            0.1f
                            )
                        {
                            Blend = new System.Drawing.Drawing2D.Blend()
                            {
                                Factors = new float[] { 0.4f }, // Factors 원소 여러개면 에러 남.
                                Positions = new float[] { 0.2f, 0.5f, 0.8f },
                            }
                        };

                        // myFactors가 여러개면 에러 남.
                        g.FillRectangle(myBrush, rect);
                        g.DrawString("Blend test", font, System.Drawing.Brushes.Black, rect.X, rect.Y);
                        // 사각형과 그에 해당하는 브러쉬를 저장한다.
                        rects.Add(rect);
                        // Factor혼합 비율과 Positions혼합 위치를 지정하는 Blend객체를 이용한 브러시


                        // ParentRectX와 Width를 적용하기 위해 새로 브러시를 생성
                        System.Drawing.Drawing2D.LinearGradientBrush myParentBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
                            new Rectangle(parentRect.X+1, parentRect.Y, parentRect.Width, parentRect.Height) ,
                            Color.Blue,
                            Color.Red,
                            0.1f
                            )
                        {
                            Blend = new System.Drawing.Drawing2D.Blend()
                            {
                                Factors = new float[] { 0.4f }, // Factors 원소 여러개면 에러 남.
                                Positions = new float[] { 0.2f, 0.5f, 0.8f },
                            }
                        };
                        mLinearGradientBrushRectangles[rect] = myParentBrush;
                        // using에서 사용한 브러시를 저장하고 싶으면 아래 주석을 해제하고 윗 줄을 주석처리하면 됨.
                        //mLinearGradientBrushRectangles[rect] = new System.Drawing.Drawing2D.LinearGradientBrush(parentRect, Color.White, Color.Black, System.Drawing.Drawing2D.LinearGradientMode.Horizontal) { };


                        // Triangle GradientBrush로 그리기
                        rect.Y += height;
                        parentRect.Y += height;

                        brush.SetBlendTriangularShape(0.5f);        // 중간에 초점을 둔다
                        g.FillRectangle(brush, rect);
                        g.DrawString("Triangle", font, System.Drawing.Brushes.Black, rect.X, rect.Y);
                        // 사각형 저장
                        rects.Add(rect);
                        // 저장할 브러시를 생성
                        System.Drawing.Drawing2D.LinearGradientBrush triangleLGBrush = new System.Drawing.Drawing2D.LinearGradientBrush(parentRect, Color.White, Color.Black, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
                        triangleLGBrush.SetBlendTriangularShape(0.5f);
                        // 브러시를 저장
                        mLinearGradientBrushRectangles[rect] = triangleLGBrush;

                        // brush를 Bell속성으로 설정 후 그리기
                        rect.Y += height;
                        parentRect.Y += height;

                        brush.SetSigmaBellShape(0.5f);
                        g.FillRectangle(brush, rect);
                        g.DrawString("Bell", font, System.Drawing.Brushes.Black, rect.X, rect.Y);
                        // 사각형 저장
                        rects.Add(rect);
                        // 저장할 브러시를 생성
                        System.Drawing.Drawing2D.LinearGradientBrush bellLGBrush = new System.Drawing.Drawing2D.LinearGradientBrush(parentRect, Color.White, Color.Black, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
                        bellLGBrush.SetSigmaBellShape(0.5f);
                        // 사각형의 영역에 해당하는 생성한 브러시 저장
                        mLinearGradientBrushRectangles[rect] = bellLGBrush;

                        // 커스텀 그레디언트. 흰 -> 빨 -> 검
                        rect.Y += height;
                        parentRect.Y += height;
                        // 커스텀 그레디언트 .InterpolationColors에 설정할 Blend 색 배열 설정.
                        System.Drawing.Drawing2D.ColorBlend colorBlend = new System.Drawing.Drawing2D.ColorBlend()
                        {
                            Colors = new Color[] { Color.White, Color.Red, Color.Black },
                            Positions = new float[] { 0.0f, 0.5f, 1.0f }
                        };
                        // 색 배열을 .InterpolationColors에 설정
                        brush.InterpolationColors = colorBlend;
                        // 설정한 브러시로 사각형 그리고, 글씨 그림
                        g.FillRectangle(brush, rect);
                        g.DrawString("Custom Colors", font, System.Drawing.Brushes.Black, rect.X, rect.Y);
                        // 사각형 저장
                        rects.Add(rect);
                        // 저장할 브러시 생성
                        System.Drawing.Drawing2D.LinearGradientBrush customColorLGBrush = new System.Drawing.Drawing2D.LinearGradientBrush(parentRect, Color.White, Color.Black, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
                        // 브러시의 .InterpolationColors에 지정할 ColorBlend생성
                        System.Drawing.Drawing2D.ColorBlend cBlend = new System.Drawing.Drawing2D.ColorBlend()
                        {
                            Colors = new Color[] { Color.White, Color.Red, Color.Black },
                            Positions = new float[] { 0.0f, 0.5f, 1.0f }
                        };
                        // 색 배열을 .InterpolationColors에 설정
                        customColorLGBrush.InterpolationColors = cBlend;
                        // 사각형의 영역에 해당하는 브러시 저장
                        //customColorLGBrush.WrapMode = System.Drawing.Drawing2D.WrapMode.TileFlipX;  // 전달하는 X값-1로 해도 되긴 한데,
                        mLinearGradientBrushRectangles[rect] = customColorLGBrush;

                    }

                    break;
                case BasicDrawingForm.BoolListRectangle.PopupFlags.PathGradientBrush:
                    break;
                default:
                    this.DialogResult = DialogResult.Cancel;
                    break;

            }



        }
        public BrushInfo mBrushInfo;

        private void DrawHatchBrushes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Rectangle r in rects)
                {
                    if (r.Contains(new Point(e.X, e.Y)))
                    {
                        //                        MessageBox.Show("선택하신 Brush는 " + mBrushRectangles[r].HatchStyle.ToString() + "입니다.");
                        if (Selected != null)
                        {
                            switch (selectBrushFlag)
                            {
                                case BasicDrawingForm.BoolListRectangle.PopupFlags.SolidBrush:
                                    break;
                                case BasicDrawingForm.BoolListRectangle.PopupFlags.TextureBrush:
                                    break;
                                case BasicDrawingForm.BoolListRectangle.PopupFlags.HatchBrush:
                                    // BrushInfo에 사각형의 영역에 해당하는 브러쉬를 저장한다.(초기 flag값에 따라 각각 사각형에 해당하는 브러쉬가 다름)
                                    // 어차피 한 브러쉬 스타일만 선택하므로, 사각형은 재사용할 수 있지만, 브러쉬는 고유의 객체를 만들어야 하므로, Switch문 사용하였음.
                                    Selected(this, new BrushEventArgs(new BrushInfo() { brush = mHatchBrushRectangles[r] })); // 주어진 인수로 함수 포인터 배열 실행.
                                    this.DialogResult = DialogResult.OK;
                                    break;
                                case BasicDrawingForm.BoolListRectangle.PopupFlags.LinearGradientBrush:
                                    // BrushInfo에 사각형의 영역에 해당하는 브러시를 저장한다.
                                    Selected(this, new BrushEventArgs(new BrushInfo() { brush = mLinearGradientBrushRectangles[r] }));
                                    this.DialogResult = DialogResult.OK;
                                    break;
                                case BasicDrawingForm.BoolListRectangle.PopupFlags.PathGradientBrush:
                                    break;
                                default:
                                    this.DialogResult = DialogResult.Cancel;
                                    break;
                            }
                        }
                        break;
                    }

                }
            }
        }

    }

    // 이벤트 전달 객체의 매개변수에 전달할 정보
    public class BrushInfo
    {
        public Brush brush;
    }

    // 이벤트 발생 시 전달할 이벤트 객체. (아까 정보 객체로부터 멤버를 채움)
    public class BrushEventArgs : EventArgs
    {
        public Brush mBrush { get; private set; }
        public BrushEventArgs(BrushInfo brushInfo)
        {
            mBrush = brushInfo.brush;
        }
    }


}
