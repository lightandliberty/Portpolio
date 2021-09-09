using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicProperties_dll
{
    public partial class ErrorProviderExampleForm : Form
    {
        public ErrorProviderExampleForm()
        {
            InitializeComponent();
        }

        private void ApplicantNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ApplicantPhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoanAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if(applicantNameTextBox.Text.Length == 0)
            {
                error = "Please enter a name";
                e.Cancel = true;
            }
            // error가 null이면 오류 아이콘 표시 안 됨.
            errorProvider1.SetError((Control)sender, error);
        }
    }
}
