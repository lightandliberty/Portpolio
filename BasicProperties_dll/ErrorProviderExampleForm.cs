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

        private void OkBtn_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //if(MyFormInvalid())
            //g.DrawString("This is a diagonal line drawn on the control",
            //    new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(30,30));
            //g.DrawLine(System.Drawing.Pens.Red, okBtn.Left, okBtn.Top, okBtn.Right, okBtn.Bottom);
            //else
            //g.FillRectangle(
            //    new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new PointF(0, okBtn.Height/2), Color.White, Color.White),
            //    new RectangleF(Point.Empty, new Size(okBtn.Size.Width, okBtn.Size.Height/2)));
            g.FillRectangle(
                new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, okBtn.Height), Color.White, Color.LightGray),
                new RectangleF(new Point(0, 0), new Size(okBtn.Size.Width, okBtn.Size.Height)));
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString((sender as Button).Text,
                new Font((sender as Button).Font.Name, 10), System.Drawing.Brushes.Black,
                new Rectangle(new Point(0, 0), new Size(okBtn.Size.Width, okBtn.Size.Height)),
                sf);
            
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            // 유효성 검사
            // DoValidations();
            // okBtn.Invalidate();
            this.Text = "Clicked";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
        }

        private void CancelBtn_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
//            if (MyFormInvalid())
                g.DrawString("This is a diagonal line drawn on the control",
                    new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(30, 30));
                g.DrawLine(System.Drawing.Pens.Red, cancelBtn.Left, cancelBtn.Top, cancelBtn.Right, cancelBtn.Bottom);
        }

    }
}
