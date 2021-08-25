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
    public partial class TransparentForm : Form
    {
        public TransparentForm()
        {
            InitializeComponent();
            //this.TransparencyKey = System.Drawing.SystemColors.Control;
        }

        // 폼을 다시 그려야 할 때 발생
        private void TransparentForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Brown);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            // Brush, Graphics 객체는 항상 Dispose()해주는 게 좋음.(MSDN에서 추천)
//            formGraphics.DrawEllipse(System.Drawing.Pens.Black, new Rectangle(0, 0, 150, 100));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
