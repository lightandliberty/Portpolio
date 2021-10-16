﻿using System;
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

        private void CancelMetalBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DigitsOfPiForm_Load(object sender, EventArgs e)
        {
            numDigitsUpDown.Select(0, 1);
        }

        private void NumDigitsUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CalcMetalBtn_Click(sender, EventArgs.Empty);
            }
        }

        // 프로그레스바 설정
        void ShowProgress(string pi, int totalDigits, int digitsSoFar)
        {
            piTextBox.Text = pi;
            piProgressBar.Maximum = totalDigits;
            piProgressBar.Value = digitsSoFar;
        }

        // 파이 계산
        void CalcPi(int digits)
        {
            StringBuilder pi = new StringBuilder("3", digits + 2);  // 입력한 자리수 + 2크기로 초기 설정

            // 진행 상태를 보여준다.
            ShowProgress(pi.ToString(), digits, 0);

            if(digits > 0)
            {
                pi.Append(".");

                for(int i = 0; i < digits; i+= 9)
                {
                    int nineDigits = NineDigitsOfPi.StartingAt(i + 1);
                    int digitCount = Math.Min(digits - i, 9);
                    string ds = string.Format("{0:D9}", nineDigits);
                    pi.Append(ds.Substring(0, digitCount));

                    // 진행 상태를 보여준다.
                    ShowProgress(pi.ToString(), digits, i + digitCount);
                }
            }
        }


        private void CalcMetalBtn_Click(object sender, EventArgs e)
        {
            CalcPi((int)numDigitsUpDown.Value);
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

    }
}
