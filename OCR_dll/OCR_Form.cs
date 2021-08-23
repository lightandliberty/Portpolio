using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using IronOcr;
using Aspose.OCR;
using OpenCvSharp;
using OpenCvSharp.Extensions;   // BitmapConverter() 사용

namespace OCR_dll
{
    public partial class OCR_Form: Form
    {
        VideoCapture vc;
        VideoWriter vw = new VideoWriter();
        Timer timer1 = new Timer();
        
        private void videoStartBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            try
            {
                vc?.Dispose();
            }
            catch { }

            // video를 초기화
            vc = new VideoCapture(0);   // 첫번째로 연결된 카메라(0번) 영상을 가져오겠다는 뜻
            // http:로 된 영상을 가져오려면 (mjpgstreamer 패키지로 카메라를 동작시켰을 때 가져오는 것 _ 웹서버로 영상 송출하는 장비 어디서든 응용이 가능)
            //vc = new VideoCapture(string.Format("http://192.168.0.23:8090/?action=stream"));
            timer1.Enabled = true;

            //// 아래와 같이도 가능. 33ms마다 q를 입력할 때까지 대기
            //Mat frame = new Mat();
            //while (Cv2.WaitKey(33) != 'q')
            //{
            //    vc.Read(frame);
            //    Cv2.ImShow("frame", frame);
            //}
            //frame.Dispose();
            //vc.Release();
            //Cv2.DestroyAllWindows();
        }

        private void focusConfirmBtn_Click(object sender, EventArgs e)
        {

        }

        //// 타이머가 프레임처럼 몇밀리세컨드마다 가져와서 영상처럼 보이게 한다.
        //// cv2.imRead()함수로 사진파일 하나 읽어와서 테스트해 볼 수도 있지만.
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    // Mat 행렬의 크기, 행렬 요소의 데이터 타입, 깊이(채널)
        //    Mat frame = new Mat();  // 프레임을 표시하기 위해 Mat클래스인 frame을 초기화
        //    vc.Read(frame);
        //    if (frame.Empty()) return;
        //    else
        //    {
        //        try
        //        {
        //            this.Invoke((Action)(() =>
        //            {
        //                vw.Write(frame);
        //                pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
        //            }), null);
        //        }
        //        catch { }
        //    }
        //}

        string mOcr = "";
        public OCR_Form()
        {
            InitializeComponent();
            pictureBox1.Load(@"C:\CSharp\test.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            timer1.Tick += timer1_Tick;
        }

        private void OCR_Tesseract_Btn_Click(object sender, EventArgs e)
        {
            Bitmap oc = (Bitmap)pictureBox1.Image;
            mOcr = OcrProcess(oc);  // 판독한 문자를 저장

            // BeginInvoke(컨트롤의 내부 핸들이 만들어진 스레드에서 대리자를 비동기식으로 실행. (Delegate, Object[]) 등)
            textBox1.BeginInvoke(new MethodInvoker(delegate { textBox1.Text = mOcr; }));
        }

        private string OcrProcess(Bitmap oc)
        {
            try
            {
                // 한국어를 판독하고 싶을 때,
                //using (TesseractEngine engine = new TesseractEngine(@"./tessdata", "kor", EngineMode.TesseractOnly))
                using (TesseractEngine engine = new TesseractEngine(@"C:\CSharp\Portfolio2021\OCR_dll\bin\Debug\tessdata", "eng", EngineMode.TesseractOnly))
                {
                    using (Page page = engine.Process(oc))
                    {
                        return page.GetText();
                    }
                }
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        // https://ironsoftware.com/csharp/ocr/
        private void OCR_IronBtn_Click(object sender, EventArgs e)
        {
            IronTesseract irontesseract = new IronTesseract();
            // 아래 한 줄로도 실행 가능.
//            textBox1.BeginInvoke(new MethodInvoker(delegate { textBox1.Text = irontesseract.Read(new OcrInput(@"C:\CSharp\test.png")).Text; }));

            // 이미지를 적재
            Bitmap oc = (Bitmap)pictureBox1.Image;

//            irontesseract.Language = OcrLanguage.English;
            irontesseract.Language = OcrLanguage.EnglishBest;
            //            irontesseract.Language = OcrLanguage.Korean;
//            irontesseract.Language = OcrLanguage.KoreanBest;
            //irontesseract.Language = OcrLanguage.KoreanFast;
//            irontesseract.AddSecondaryLanguage(OcrLanguage.EnglishBest);
//            irontesseract.AddSecondaryLanguage(OcrLanguage.Korean);

            using(OcrInput input = new OcrInput(@"C:\CSharp\test.png"))
            {
//                OcrResult result = irontesseract.Read(input);
                OcrResult result = irontesseract.Read(oc);

//                System.Diagnostics.Debug.WriteLine(result.Text);
                //textBox1.Text = result.Text;
                textBox1.BeginInvoke(new MethodInvoker(delegate { textBox1.Text = result.Text; }));
            }
            
            //textBox1.Text = irontesseract.Read(oc).Text;
        }

        // GPU를 지원
        // ASpose는 .Net Framework의 x64를 직접 지정해야 함. 그렇지 않으면 예외 발생. (AnyCPU를 지원하지 않음)
        private void OCR_ASpose_Btn_Click(object sender, EventArgs e)
        {
            AsposeOcr ocr = new AsposeOcr();
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            //string result = ocr.RecognizeImage(@"C:\CSharp\test.bmp");
            string result = ocr.RecognizeImage(ms);
            textBox1.BeginInvoke(new MethodInvoker(delegate { textBox1.Text = result; }));
        }

        // 그리기

        public int curMode = 2;     // 내가 사각형 그리기 상태인지 (그리기 상태면 마우스 포인터 ┼로 바뀜)
        OpenCvSharp.Point init;
        bool drawing = false;
        Mat temp = new Mat();

        // 드로우 모드를 변경할 수 있는 함수 정의
        enum DRAW_MODE : int
        {
            SHAPEMODE = 0,      // 크롭모드
            ERASERMODE = 1,     // 지우개 모드
            EDITMODE = 2        // 일반
        }
        
        private void SetDrawMode(int mode)
        {
            switch(mode)
            {
                case (int)DRAW_MODE.SHAPEMODE:
                    curMode = (int)DRAW_MODE.SHAPEMODE;
                    break;
                case (int)DRAW_MODE.ERASERMODE:
                    curMode = (int)DRAW_MODE.ERASERMODE;    // 좌표값을 확인해서 좌표값 범위가 사각형이랑 일치할 때 , 그 범위 안에 오게 선택하면 색 바뀌게 하고, 지우게 하는 것
                    break;
                case (int)DRAW_MODE.EDITMODE:
                    break;
                default:
                    break;
            }
        }

        // 일단 있길래 쳐 놓음
        //private Cursor LoadCursor(byte[] cursorFile)
        //{
        //    MemoryStream cursorMemoryStream = new MemoryStream(cursorFile);
        //    Cursor hand = new Cursor(cursorMemoryStream);
        //    return hand;
        //}

        // 위의 timer1_Tick()에 추가
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Mat 행렬의 크기, 행렬 요소의 데이터 타입, 깊이(채널)
            Mat frame = new Mat();  // 프레임을 표시하기 위해 Mat클래스인 frame을 초기화
            vc.Read(frame);
            if (frame.Empty()) return;
            else
            {
                try
                {
                    // windowsforms앱은 GUI디자이너랑 코드가 밀접한 관련이 있으므로, 꼭 invoke()처리를 해줘야 한다.(안그러면 중간에 멈춘다.)
                    this.Invoke((Action)(() =>
                    {
                        // 위의 timer1_Tick에 추가한 부분
                        if (curMode == (int)DRAW_MODE.SHAPEMODE)
                        {
                            temp = frame;
                            //if (dataGridView1.Rows.Count > 0)
                            if (dataGridView1.Rows.Count > 1 && init != null)
                            {
                                DrawCross(temp, init);
                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                {
                                    System.Diagnostics.Debug.WriteLine(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value).ToString() + " " + Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value).ToString() + " " + Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value).ToString() + " " + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value).ToString());
                                    //                                    System.Diagnostics.Debug.WriteLine(Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value).ToString() + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value).ToString());
                                    System.Diagnostics.Debug.WriteLine(dataGridView1.Rows.Count.ToString());
                                    // 저장은 [init.y, init.x, width, height]로 되어 이으므로,  (init.x, init.y)
                                    OpenCvSharp.Point f = new OpenCvSharp.Point(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
                                    // b는 (width, height)
                                    OpenCvSharp.Point b = new OpenCvSharp.Point(Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                                    Scalar sc = new Scalar(0, 255, 0);
                                    int thi = 1;
                                    // 사각형은 init.x, init.y, width, height 맞음
                                    OpenCvSharp.Rect rec = new OpenCvSharp.Rect(f.X, f.Y, b.X, b.Y);
                                    if (rec.Width == 0 || rec.Height == 0)
                                        return;
                                    // 이미지, 사각형, 컬러, 농도
                                    Cv2.Rectangle(temp, rec, sc, thi);
                                    Mat org = temp;
                                    org = org.SubMat(rec);      // 자르기
                                    OpenCvSharp.Point k = new OpenCvSharp.Point(b.X + f.X, b.Y + f.Y); // 잘랐을 때의 위치
                                }
                            }
                            else
                            {
                                DrawCross(temp, init);
                            }
                            pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(temp);
                        }
                        else
                        {
                            pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
                        }
                    }), null);
                    drawBtn.Enabled = true;
                }
                catch { System.Diagnostics.Debug.WriteLine("예외가 발생했습니다."); }
                finally { }
            }
        }


        // 마우스 시작점부터 드래그해서 최종 가져간 점까지 좌표값을 받아서 그려줌.
        private void DrawRect(Mat t, OpenCvSharp.Point m)
        {
            Cv2.Rectangle(t, new OpenCvSharp.Rect(init.X, init.Y, m.X - init.X, m.Y - init.Y),
                new Scalar(0, 255, 255), 1);
            
            // 디자이너에 쓰레드 처리
            if(pictureBox1.InvokeRequired)
            {
                pictureBox1.Invoke(new MethodInvoker(
                    delegate () 
                    { pictureBox1.Image = BitmapConverter.ToBitmap(t);
                    }));
            }
            else
            {
                pictureBox1.Image = BitmapConverter.ToBitmap(t);
            }
        }

        private void DrawCross(Mat t, OpenCvSharp.Point m)
        {
            // 십자 마우스 포인터 색을 변경하려면 Scalar()함수의 색상표를 바꾸면 된다.
            Cv2.Line(t, new OpenCvSharp.Point(m.X - 40, m.Y), // 십자가 표시를 늘이거나 줄이려면 40을 조절하면 된다.
                new OpenCvSharp.Point(m.X + 40, m.Y), new Scalar(0, 255, 255), 1); // 0,255,255는 노랑
            Cv2.Line(t, new OpenCvSharp.Point(m.X, m.Y - 40),
                new OpenCvSharp.Point(m.X, m.Y + 40), new Scalar(0, 255, 255), 1);
            Cv2.PutText(t, Convert.ToString((int)(m.X)) + "," +
                Convert.ToString((int)(m.Y)), new OpenCvSharp.Point(m.X, m.Y),
                HersheyFonts.HersheyComplex, 0.5, new Scalar(0, 255, 255), 1);

            if(pictureBox1.InvokeRequired)      // 디자이너에 쓰레드 처리를 함.(안그러면 다운 됨)
            {
                pictureBox1.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        pictureBox1.Image = BitmapConverter.ToBitmap(t);
                    }));
            }
            else
            {
                pictureBox1.Image = BitmapConverter.ToBitmap(t);
            }
        }

        // 그리기 버튼을 클릭하면
        private void DrawBtn_Click(object sender, EventArgs e)
        {
            SetDrawMode((int)DRAW_MODE.SHAPEMODE);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(curMode == (int)DRAW_MODE.SHAPEMODE)
            {
                init = new OpenCvSharp.Point((double)e.X, (double)e.Y);
                drawing = true;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            SetDrawMode(curMode);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            SetDrawMode((int)DRAW_MODE.EDITMODE);
        }

        // 사각형으로 그리는 동안은 노란색으로 표시
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(curMode == (int)DRAW_MODE.SHAPEMODE)
            {
                if(drawing == true)
                {
                    OpenCvSharp.Point a = new OpenCvSharp.Point((double)e.X, (double)e.Y);
                    Mat tp = new Mat();
                    if(pictureBox1.InvokeRequired)
                    {
                        pictureBox1.Invoke(new MethodInvoker(
                            delegate ()
                            {
                                pictureBox1.Image = BitmapConverter.ToBitmap(temp);
                            }));
                    }
                    else
                    {
                        pictureBox1.Image = BitmapConverter.ToBitmap(temp);
                    }
                    DrawRect(temp, a);
                }
                else
                {
                    OpenCvSharp.Point a = new OpenCvSharp.Point(e.X, e.Y);
                    Mat tp = new Mat();
                    if (pictureBox1.InvokeRequired)
                    {
                        pictureBox1.Invoke(new MethodInvoker(
                            delegate ()
                            {
                                pictureBox1.Image = BitmapConverter.ToBitmap(temp);
                            }));
                    }
                    else
                    {
                        pictureBox1.Image = BitmapConverter.ToBitmap(temp);
                    }
                    DrawCross(temp, a);
                    init = a;
                }
            }
        }

        // 마우스버튼이 떨어지는 순간 초록색으로 확정적으로 그린다.
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // 마우스 뗀 지점
            OpenCvSharp.Point a = new OpenCvSharp.Point((double)e.X, (double)e.Y);
            Mat t = new Mat();
            Scalar sc = new Scalar(0, 255, 0);
            // 행추가 위, 왼쪽, 너비, 높이
            dataGridView1.Rows.Add(Convert.ToString(init.Y), Convert.ToString(init.X), Convert.ToString(a.X - init.X), Convert.ToString(a.Y - init.Y), "", "");
            dataGridView1.ClearSelection();
            drawing = false;
        }

        private void OCR_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Tick -= timer1_Tick; // 이거 안 하면 계속 timer1_Tick이 실행되면서, 예외 발생함.
        }
    }

}
