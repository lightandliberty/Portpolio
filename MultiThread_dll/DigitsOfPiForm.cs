using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread_dll
{
    public partial class DigitsOfPiForm : Form
    {
        public DigitsOfPiForm()
        {
            InitializeComponent();
        }


        private void DigitsOfPiForm_Load(object sender, EventArgs e)
        {
        }

        // 자리수에 엔터를 치면
        private void NumDigitsUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 엔터키를 눌렀을 경우, 컨트롤에 반영 안 하고, 계산만 함.(사용자 입력 방지 효과)
                if (state == CalcState.Canceled)
                    return;
                CalculateIfPending();
            }
        }


        /// <summary>
        /// 취소할 때, 작업자 스레드가 정지해야 한다는 사실을 UI스레드가 알게 되는 시간,
        /// 작업자 스레드 자신이 스스로 정지해야 된다는 사실을 알게 되는 시간
        /// 진행 상황 전송을 멈추어야 할 기회를 갖는 시간
        /// 이 시간동안 UI를 비활성화하기 위해, 열거형을 이용한다.
        /// </summary>

        enum CalcState
        {
            Pending,    // 계산을 처리하지도 취소하지도 않은 상태
            Calculating,    // 계산중인 상태
            Canceled,       // UI스레드에서는 계산이 취소되었으나, 작업자 스레드에서는 취소되지 않은 상태
        }

        private CalcState state = CalcState.Pending;

        // 계산 버튼 클릭 이벤트
        private void CalcMetalBtn_Click(object sender, EventArgs e)
        {
            CalculateIfPending();
        }

        /// <summary>
        /// 컨트롤에 포함된 동기/비동기 실행 메서드
        /// class System.Windows.Forms.Control에는
        /// public object Invoke(Delegate method);
        /// public virtual object Invoke(Delegate method, object[] args);
        /// public IAsyncResult BeginInvoke(Delegate method);
        /// public virtual IAsyncResult BeginInvoke(Delegate method, object[] args);
        /// 쓰진 않지만, public virtual object EndInvoke(IAsyncResult asyncResult); 메서드가 있다.
        /// 그러므로, 호출 스레드를 블록상태를 유지하려면 Invoke를 호출하고, 비블록 상태를 유지하려면 BeginInvoke메서드를 호출한다.
        /// </summary>

        // 스레드를 생성할 커스텀 대리자 정의 (MulticastDelegate클래스로부터 상속된 .Invoke .BeginInvoke .EndInvoke를 가지고 있음)
        delegate void CalcPiDelegate(int digits); // 스레드에서 실행할 메서드의 매개변수 형태로 정의

        // Just to call EndInvoke as the docs say we have to:
        // http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpguide/html/cpovrasynchronousprogrammingoverview.asp
        void CallEndInvoke(IAsyncResult result)
        {
            try
            {
                // delegate개체에 .BeginInvoke의 반환값 IAsyncResult result의 .AsyncState속성값을 저장.
                // 사실 result.AsyncState는 .BeginInvoke의 세 번째 배개변수다.
                CalcPiDelegate del = (CalcPiDelegate)result.AsyncState;
                // delegate개체의 .EndInvoke()에 .BeginInvoke의 반환값 result를 매개변수로 저장해서 실행
                del.EndInvoke(result);
            }
            catch (Exception ex)
            {
                // Don't let failed worker thread scare user...
                System.Diagnostics.Debug.WriteLine(string.Format("Failed worker thread: {0}", ex.Message));
            }
        }


        // 계산하는 메서드 (메서드 호출을 단순화하기 위해, 이 한 단계를 거침)
        // 계산 버튼을 누르거나, numDigitsUpDown에 엔터를 치면 실행됨.
        private void CalculateIfPending()   // UI스레드에서만 state 변수에 접근하므로, lock은 필요하지 않다.
        {
            switch (state)
            {
                case CalcState.Pending:     // 아무 상태도 아닐 때, 버튼을 눌렀으면, 계산 시작
                    // 취소를 허용한다.
                    state = CalcState.Calculating;  // 계산중 상태로 변경
                    calcMetalBtn.Text = "Cancel";

                    CalcPiDelegate calcPiDelegate = new CalcPiDelegate(CalcPi); // 커스텀 대리자 생성
                    //                                         int digits,       AsyncCallBack callback,     object asyncState
                    // 책의 첫번째 예제에선 CalcPi 메서드가 UI를 직접 갱신하기 때문에, 마지막 두 개의 인수를 null로 지정하는 것외에 별다른 처리가 필요 없다고 하였다. 마지막 예제에서는 수정해서 인수 지정.
                    calcPiDelegate.BeginInvoke((int)numDigitsUpDown.Value, new AsyncCallback(CallEndInvoke), calcPiDelegate); // 스레드 실행( calcPiDelegate에 등록된 메서드 다 실행 )
                                                                                        // CalcPi((int)numDigitsUpDown.Value); // 스레드 없이 실행할 때,
                                                                                        // Calc버튼을 Cancel버튼으로도 사용할 수 있게 만든다.
                    break;
                case CalcState.Calculating: // 계산중일 때, Cancel버튼을 눌렀으면, 계산 취소
                    state = CalcState.Canceled;
                    calcMetalBtn.Enabled = false; // 취소되는 도중엔 버튼의 동작을 막음
                    break;
                case CalcState.Canceled:    // 취소하고 있는 도중엔 버튼의 동작을 막았는데, 그럼에도 혹시 눌렸다면, 에러 표시
                    System.Diagnostics.Debug.Assert(false); // 호출 스택을 보여줌
                    break;
            }

        }

        // 파이 계산 (사실상 메인 메서드) _ 작업 스레드에서 실행
        private void CalcPi(int digits) // 계산 버튼을 클릭하면, 입력한 자리수를 매개변수로 이 메서드에 전달함
        {
            StringBuilder pi = new StringBuilder("3", digits + 2);  // 입력한 자리수 + 2크기로 초기 설정
            object sender = System.Threading.Thread.CurrentThread;
            SetControlsArgs e = new SetControlsArgs(pi.ToString(), digits, 0);
            SetControls(sender, e); // 작업 스레드에서 실행되며, UI스레드의 컨트롤을 바꿈.

            if (digits > 0) // 자리수가 0보다 크면,
            {
                pi.Append("."); // StringBuilder의 기본값 3뒤에 점 "." 을 찍음.

                // 0부터 자리수까지 i의 값을 9씩 증가시킴
                for(int i = 0; i < digits; i+= 9)
                {
                    int nineDigits = NineDigitsOfPi.StartingAt(i + 1); // i+1번째 자리부터 π를 9자리씩 계산해서 nineDigits에 저장
                    int digitCount = Math.Min(digits - i, 9); // 남은 계산해야할 자리수가 9보다 작으면 digits-i를 반환 아니면, 9를 반환. i + 1부터 시작이므로, 계산은 맞는 듯하다.
                    string ds = string.Format("{0:D9}", nineDigits);   // i+1번째 자리부터 계산한 9자리의 π값을 정수자리수 D9형식으로 ds에 저장.
                    // 0:D9 면 앞에 부족한 자리수를 0으로 채워서 000001329 이런 식으로 채우지만,
                    // nineDigits에서 π를 9자리 다 구해서 정수9자리 형식으로 string ds에 저장후, digitCount의 수만큼 자르므로,
                    // 0이 포함되지 않아 π의 자리수 표현이 잘 이루어진다.
                    pi.Append(ds.Substring(0, digitCount));  // 표현해야 하는 남은 자리수만큼 잘라서, StringBuilder pi에 추가 (이렇게 9자리씩 남은 자리수까지 추가

                    // 프로그레스바와 π숫자를 레이블에 설정 (문자열, 프로그래스바 MaxValue, 현재Value)
                    e.Pi = pi.ToString();
                    e.DigitsSoFar = i + digitCount; // 계산한 자리수 + 현재 덧붙인 자리수 e.TotalDigits는 같으므로 갱신 안 함.
                    SetControls(sender, e); // this.BeginInvoke(showProgressDelegate,new object[] { pi.ToString(), digits, i + digitCount });
                    if (e.Cancel) break;    // SetControls()에서 e.Cancel에 취소 여부를 대입하므로,
                }
            }
        }

        #region UI 컨트롤을 바꾸기 위한 함수 포인터 배열 타입 정의. 컨트롤에서 this.InvokeRequired == true일 경우, 사용.
        // 예제에선 사용 안 함.
        delegate void SetControlsDelegate2(); 
        private void SetControls2() // UI 컨트롤을 바꾸기 위해,
        {
            if (this.InvokeRequired == false)
            {
                this.calcMetalBtn.Text = "Calc";
                calcMetalBtn.Enabled = true;
            }
            else
            {
                SetControlsDelegate2 setControlsDelegate2 = new SetControlsDelegate2(SetControls2);
                this.BeginInvoke(setControlsDelegate2, null);
            }
        }
        #endregion UI 컨트롤을 바꾸기 위한 함수 포인터 배열 타입 정의. 컨트롤에서 this.InvokeRequired == true일 경우, 사용. 끝.


        // Worker 스레드에서 이 개체를 만들지만, UI스레드에서만 경쟁 상태를 가질 수 있는 변수에 접근해 Cancel멤버에 값을 대입하므로, 경쟁 상태는 일어나지 않는다.
        public class SetControlsArgs : EventArgs
        {
            public string Pi;
            public int TotalDigits;
            public int DigitsSoFar;
            public bool Cancel;

            public SetControlsArgs(string pi, int totalDigits, int digitsSoFar)
            {
                this.Pi = pi;
                this.TotalDigits = totalDigits;
                this.DigitsSoFar = digitsSoFar;
            }

        }

        // 함수 포인터 배열 타입 정의 (이 객체에 메서드를 등록 후 실행시킴)
        delegate void SetControlsDelegateHandler(object sender, SetControlsArgs e);

        // 프로그레스바와 π숫자를 레이블에 설정 (파이값str, 전체자리수, 현재 자리수
        // 컨트롤의 설정 변경 메서드. 책에선 SetProgress()
        private void SetControls(object sender, SetControlsArgs e)
        {
            if (this.InvokeRequired == false) // UI스레드일 경우,
            {
                piTextBox.Text = e.Pi;
                piProgressBar.Maximum = e.TotalDigits;
                piProgressBar.Value = e.DigitsSoFar;
                e.Cancel = (state == CalcState.Canceled);   // UI스레드에서만 state멤버에 접근하여 읽기/쓰기 작업을 하므로, 경쟁 상태는 발생하지 않는다.
                
                if(e.Cancel || (e.DigitsSoFar == e.TotalDigits) ) {
                    state = CalcState.Pending;  // 취소되었으므로, 원래대로
                    calcMetalBtn.Text = "Calc";
                    calcMetalBtn.Enabled = true;
                }
            }
            else // this.InvokeRequired == true 일 때, 
            {
                SetControlsDelegateHandler setControlsDelegate = new SetControlsDelegateHandler(SetControls); // 대리자 개체 생성
                                                                                                              // 프로그레스바와 π숫자를 레이블에 설정 (문자열, 프로그래스바 MaxValue, 현재Value)
                                                                                                              // 폼의 컨트롤 클래스의 Invoke를 실행. (컨트롤을 다 변경하고, e.Cancel멤버에 데이터를 채울 때까지 기다림.)
                var res = this.Invoke(setControlsDelegate, new object[] { sender, e });
                // Show progress asynchronously
                //        IAsyncResult res = 
                //          BeginInvoke(showProgress, new object[] { pi, totalDigits, digitsSoFar, inoutCancel});
                //
                //        // Wait for results
                //        while( !res.IsCompleted  ) System.Threading.Thread.Sleep(100);
                //
                //        // Harvest results
                //        cancel = (bool)inoutCancel;
                //        object methodResults = EndInvoke(res);
                // Do something with results...

            }
        }


        #region 비동기로 실행할 경우, 아래를 실행

        //object statelock = new object();
        //private void CalculateIfPending()
        //{
        //    switch (state)
        //    {
        //        case CalcState.Pending:     // 아무 상태도 아닐 때, 버튼을 눌렀으면, 계산 시작
        //            // 취소를 허용한다.
        //            lock (statelock)
        //            {
        //                state = CalcState.Calculating;  // 계산중 상태로 변경
        //            }
        //            calcMetalBtn.Text = "Cancel";

        //            CalcPiDelegate calcPiDelegate = new CalcPiDelegate(CalcPi); // 커스텀 대리자 생성
        //            calcPiDelegate.BeginInvoke((int)numDigitsUpDown.Value, null, null); // 스레드 실행( calcPiDelegate에 등록된 메서드 다 실행 )
        //                                                                                // CalcPi((int)numDigitsUpDown.Value); // 스레드 없이 실행할 때,
        //                                                                                // Calc버튼을 Cancel버튼으로도 사용할 수 있게 만든다.
        //            break;
        //        case CalcState.Calculating: // 계산중일 때, Cancel버튼을 눌렀으면, 계산 취소
        //            lock(statelock)
        //            {
        //                state = CalcState.Canceled;
        //            }
        //            calcMetalBtn.Enabled = false; // 취소되는 도중엔 버튼의 동작을 막음
        //            break;
        //        case CalcState.Canceled:    // 취소하고 있는 도중엔 버튼의 동작을 막았는데, 그럼에도 혹시 눌렸다면, 에러 표시
        //            System.Diagnostics.Debug.Assert(false); // 호출 스택을 보여줌
        //            break;
        //    }

        //}

        //// 파이 계산 (사실상 메인 메서드) _ 작업 스레드에서 실행
        //private void CalcPi(int digits) // 계산 버튼을 클릭하면, 입력한 자리수를 매개변수로 이 메서드에 전달함
        //{
        //    StringBuilder pi = new StringBuilder("3", digits + 2);  // 입력한 자리수 + 2크기로 초기 설정


        //    SetControls(pi.ToString(), digits, 0); // 작업 스레드에서 실행되며, UI스레드의 컨트롤을 바꿈.


        //    bool isCancel = false;
        //    if (digits > 0) // 자리수가 0보다 크면,
        //    {
        //        pi.Append("."); // StringBuilder의 기본값 3뒤에 점 "." 을 찍음.

        //        // 0부터 자리수까지 i의 값을 9씩 증가시킴
        //        for(int i = 0; i < digits; i+= 9)
        //        {
        //            int nineDigits = NineDigitsOfPi.StartingAt(i + 1); // i+1번째 자리부터 π를 9자리씩 계산해서 nineDigits에 저장
        //            int digitCount = Math.Min(digits - i, 9); // 남은 계산해야할 자리수가 9보다 작으면 digits-i를 반환 아니면, 9를 반환. i + 1부터 시작이므로, 계산은 맞는 듯하다.
        //            string ds = string.Format("{0:D9}", nineDigits);   // i+1번째 자리부터 계산한 9자리의 π값을 정수자리수 D9형식으로 ds에 저장.
        //            // 0:D9 면 앞에 부족한 자리수를 0으로 채워서 000001329 이런 식으로 채우지만,
        //            // nineDigits에서 π를 9자리 다 구해서 정수9자리 형식으로 string ds에 저장후, digitCount의 수만큼 자르므로,
        //            // 0이 포함되지 않아 π의 자리수 표현이 잘 이루어진다.
        //            pi.Append(ds.Substring(0, digitCount));  // 표현해야 하는 남은 자리수만큼 잘라서, StringBuilder pi에 추가 (이렇게 9자리씩 남은 자리수까지 추가

        //            // 프로그레스바와 π숫자를 레이블에 설정 (문자열, 프로그래스바 MaxValue, 현재Value)
        //            SetControls(pi.ToString(), digits, i + digitCount); // this.BeginInvoke(showProgressDelegate,new object[] { pi.ToString(), digits, i + digitCount });
        //            //ShowProgress(pi.ToString(), digits, i + digitCount);
        //            lock (statelock)
        //            {
        //                if (state == CalcState.Canceled)
        //                {
        //                    state = CalcState.Pending;
        //                    SetControls2();
        //                    isCancel = true; // 혹시 예제에서 쓰일까봐 만들었는데, 쓰이진 않음.
        //                }
        //            }
        //            if (isCancel == true)
        //                break;
        //        }
        //        // 계산이 다 끝났으면,
        //        lock(statelock)
        //        {
        //            state = CalcState.Pending;
        //            SetControls2();
        //        }

        //    }
        //}

        //delegate void SetControlsDelegate2();
        //private void SetControls2() // UI 컨트롤을 바꾸기 위해,
        //{
        //    if (this.InvokeRequired == false)
        //    {
        //        this.calcMetalBtn.Text = "Calc";
        //        calcMetalBtn.Enabled = true;

        //    }
        //    else
        //    {
        //        SetControlsDelegate2 setControlsDelegate2 = new SetControlsDelegate2(SetControls2);
        //        this.BeginInvoke(setControlsDelegate2, null);
        //    }
        //}

        //// 스레드에서 실행될 대리자 형태 선언
        //delegate void SetControlsDelegate(string pi, int totalDigits, int digitsSoFar);

        //// 프로그레스바와 π숫자를 레이블에 설정 (파이값str, 전체자리수, 현재 자리수
        //// 컨트롤의 설정 변경 메서드
        //private void SetControls(string pi, int totalDigits, int digitsSoFar)
        //{
        //    if (this.InvokeRequired == false) // UI스레드일 경우,
        //    {
        //        piTextBox.Text = pi;
        //        piProgressBar.Maximum = totalDigits;
        //        piProgressBar.Value = digitsSoFar;
        //    }
        //    else // this.InvokeRequired == true 일 때, 
        //    {
        //        SetControlsDelegate setControlsDelegate = new SetControlsDelegate(SetControls); // 대리자 개체 생성
        //                                                                                            // 프로그레스바와 π숫자를 레이블에 설정 (문자열, 프로그래스바 MaxValue, 현재Value)
        //        // 폼 클래스의 .BeginInvoke()메서드의 반환 값은 IAsyncResult이므로, 클래스의 인터페이스를 참조하게 되어, res의 결과가 스레드의 결과에 따라 값이 변한다. 구조체의 인터페이스 참조의 경우, 값으로 전달되어 반영되지 않으므로, 위험.
        //        IAsyncResult res = this.BeginInvoke(setControlsDelegate, new object[] { pi.ToString(), totalDigits, digitsSoFar });
        //        // 컨트롤 텍스트 상자에 원래 있던 문자 3을 전달하고, 진행 표시줄의 값을 전달하는 것 뿐이므로,
        //        // 딱히 반환 값으로 뭘 할 건 없는 듯하다.
        //        //ShowProgress(pi.ToString(), digits, i + digitCount); // 스레드 없이 실행할 때 사용했던 메서드
        //        if (res.IsCompleted == false)
        //            System.Threading.Thread.Sleep(100); // 빈 Idle이 발생하므로, 이 경우, this.Invoke가 더 적절한 듯하다.
        //        object methodResults = this.EndInvoke(res);

        //    }
        //}

        #endregion 비동기로 실행할 경우, 아래를 실행



        public class NineDigitsOfPi
        {
            public static int mul_mod(long a, long b, int m)
            {
                return (int)((a * b) % m);
            }

            // return the inverse of x mod y
            public static int inv_mod(int x, int y)
            {
                int q = 0;
                int u = x;
                int v = y;
                int a = 0;
                int c = 1;
                int t = 0;

                do
                {
                    q = v / u;

                    t = c;
                    c = a - q * c;
                    a = t;

                    t = u;
                    u = v - q * u;
                    v = t;
                }
                while (u != 0);

                a = a % y;
                if (a < 0) a = y + a;

                return a;
            }

            // return (a^b) mod m 
            public static int pow_mod(int a, int b, int m)
            {
                int r = 1;
                int aa = a;

                while (true)
                {
                    if ((b & 0x01) != 0) r = mul_mod(r, aa, m);
                    b = b >> 1;
                    if (b == 0) break;
                    aa = mul_mod(aa, aa, m);
                }

                return r;
            }

            // return true if n is prime
            public static bool is_prime(int n)
            {
                if ((n % 2) == 0) return false;

                int r = (int)(Math.Sqrt(n));
                for (int i = 3; i <= r; i += 2)
                {
                    if ((n % i) == 0) return false;
                }

                return true;
            }

            // return the prime number immediately after n
            public static int next_prime(int n)
            {
                do
                {
                    n++;
                }
                while (!is_prime(n));

                return n;
            }

            // n번째 자리부터 파이를 9자리까지 계산. n은 인덱스 번호가 아니라 자리수.
            public static int StartingAt(int n)
            {
                int av = 0;
                int vmax = 0;
                int N = (int)((n + 20) * Math.Log(10) / Math.Log(2));
                int num = 0;
                int den = 0;
                int kq = 0;
                int kq2 = 0;
                int t = 0;
                int v = 0;
                int s = 0;
                double sum = 0.0;

                for (int a = 3; a <= (2 * N); a = next_prime(a))
                {
                    vmax = (int)(Math.Log(2 * N) / Math.Log(a));
                    av = 1;

                    for (int i = 0; i < vmax; ++i) av = av * a;

                    s = 0;
                    num = 1;
                    den = 1;
                    v = 0;
                    kq = 1;
                    kq2 = 1;

                    for (int k = 1; k <= N; ++k)
                    {
                        t = k;
                        if (kq >= a)
                        {
                            do
                            {
                                t = t / a;
                                --v;
                            }
                            while ((t % a) == 0);

                            kq = 0;
                        }

                        ++kq;
                        num = mul_mod(num, t, av);

                        t = (2 * k - 1);
                        if (kq2 >= a)
                        {
                            if (kq2 == a)
                            {
                                do
                                {
                                    t = t / a;
                                    ++v;
                                }
                                while ((t % a) == 0);
                            }

                            kq2 -= a;
                        }

                        den = mul_mod(den, t, av);
                        kq2 += 2;

                        if (v > 0)
                        {
                            t = inv_mod(den, av);
                            t = mul_mod(t, num, av);
                            t = mul_mod(t, k, av);
                            for (int i = v; i < vmax; ++i) t = mul_mod(t, a, av);
                            s += t;
                            if (s >= av) s -= av;
                        }
                    }

                    t = pow_mod(10, n - 1, av);
                    s = mul_mod(s, t, av);
                    sum = (sum + (double)s / (double)av) % 1.0;
                }

                return (int)(sum * 1e9);
            }
        }

        private void CancelMetalBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DigitsOfPiForm_Shown(object sender, EventArgs e)
        {
            numDigitsUpDown.Focus();
            numDigitsUpDown.Select(0, 1);

        }
    }
}
