using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread_dll
{
    public partial class MultiThreadForm: Form
    {
        public MultiThreadForm()
        {
            InitializeComponent();
        }

        private void CancelMetalBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DigitsOfPiMetalBtn(object sender, EventArgs e)
        {
            var digitsOfPiForm = new DigitsOfPiForm();
            digitsOfPiForm.ShowDialog();
        }

        private void DigitsOfPiMetalBtn_MouseEnter(object sender, EventArgs e)
        {
            this.instructionTextBox.Text = "입력한 자리수만큼 파이를 계산합니다.";

        }
    }
}
