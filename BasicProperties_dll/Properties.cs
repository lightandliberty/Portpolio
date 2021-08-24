using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicProperties_dll
{
    public partial class Properties: Form
    {
        public Properties()
        {
            InitializeComponent();
        }

        private void TopMostBtn_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
