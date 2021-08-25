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
    public partial class OpacityForm : Form
    {
        public OpacityForm()
        {
            InitializeComponent();
            this.Opacity = 0.5;
            this.TopMost = true;
            this.Text = "Opacity = " + this.Opacity.ToString();
        }

        private void OpacityForm_Activated(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void OpacityForm_Deactivate(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Opacity = 0.5;
            this.Text = "Opacity = " + this.Opacity.ToString();
        }

        private void CenterBtn_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0) this.Opacity += 0.1;
//            if (this.Opacity >= 1.0) this.Opacity = 0.5;
            this.Text = "Timer is Enabled" + "Opacity = " + this.Opacity.ToString();
        }
    }


}
