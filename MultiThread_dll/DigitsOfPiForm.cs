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
            numDigitsUpDown.Select(0, 1);
        }

        // 자리수에 엔터를 치면
        private void NumDigitsUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 엔터키를 눌렀을 경우, 컨트롤에 반영 안 하고, 계산만 함.(사용자 입력 방지 효과)
                Calculate();
            }
        }

        // 계산 버튼 클릭 이벤트
        private void CalcMetalBtn_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        /// <summary>
        /// class System.Windows.Forms.Control에는
        /// public object Invoke(Delegate method);
        /// public virtual object Invoke(Delegate method, object[] args);
        /// public IAsyncResult BeginInvoke(Delegate method);
        /// public virtual IAsyncResult BeginInvoke(Delegate method, object[] args);
        /// 쓰진 않지만, public virtual object EndInvoke(IAsyncResult asyncResult); 메서드가 있다.
        /// 그러므로, 호출 스레드를 블록상태를 유지하려면 Invoke를 호출하고, 비블록 상태를 유지하려면 BeginInvoke메서드를 호출한다.
        /// </summary>

        // Delegate 형태 선언
        delegate void ShowProgressDelegate(string pi, int totalDigits, int digitsSoFar);



        // 계산하는 메서드 (메서드 호출을 단순화하기 위해, 이 한 단계를 거침)
        private void Calculate()
        {
            CalcPi((int)numDigitsUpDown.Value);
        }

        // 파이 계산
        private void CalcPi(int digits) // 계산 버튼을 클릭하면, 입력한 자리수를 매개변수로 이 메서드에 전달함
        {
            StringBuilder pi = new StringBuilder("3", digits + 2);  // 입력한 자리수 + 2크기로 초기 설정

            // 프로그레스바와 π숫자를 레이블에 설정 (문자열, 프로그래스바 MaxValue, 현재Value)
            ShowProgress(pi.ToString(), digits, 0);

            if(digits > 0) // 자리수가 0보다 크면,
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
                    ShowProgress(pi.ToString(), digits, i + digitCount);
                }
            }
        }

        // 프로그레스바와 π숫자를 레이블에 설정 (파이값str, 전체자리수, 현재 자리수
        private void ShowProgress(string pi, int totalDigits, int digitsSoFar)
        {
            piTextBox.Text = pi;
            piProgressBar.Maximum = totalDigits;
            piProgressBar.Value = digitsSoFar;
        }


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

    }
}
