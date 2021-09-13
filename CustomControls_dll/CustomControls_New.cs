using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControls_dll
{
    #region Metal 버튼 클래스 설정
    public class MetalButton : Button
    {
        private bool isLeftMouseButtonDown = false;
        public MetalButton()
        {
            MouseDown += new MouseEventHandler(Button_MouseDown);
            MouseUp += new MouseEventHandler(Button_MouseUp);
            MouseLeave += new EventHandler(Button_MouseLeave);
            Paint += new PaintEventHandler(Button_Paint);
        }

        public void SetButtonToMetalStyle(object sender, EventArgs e)
        {
            (sender as MetalButton).MouseDown += new MouseEventHandler(Button_MouseDown);
            (sender as MetalButton).MouseUp += new MouseEventHandler(Button_MouseUp);
            (sender as MetalButton).MouseLeave += new EventHandler(Button_MouseLeave);
            (sender as MetalButton).Paint += new PaintEventHandler(Button_Paint);
        }

        public void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseButtonDown = true;
                DrawThisButtonColorToClickedMetal(sender, (sender as MetalButton).CreateGraphics());
            }
        }

        public void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseButtonDown = false;
                DrawThisButtonColorToMetal(sender, (sender as MetalButton).CreateGraphics());
            }
        }

        public void Button_MouseLeave(object sender, EventArgs e)
        {
            isLeftMouseButtonDown = false;
            DrawThisButtonColorToMetal(sender, (sender as MetalButton).CreateGraphics());
        }

        public void Button_Paint(object sender, PaintEventArgs e)
        {
            if (isLeftMouseButtonDown == true)         // 마우스 버튼이 눌렸으면
            {
                DrawThisButtonColorToClickedMetal(sender, e.Graphics);
            }
            else
            {
                DrawThisButtonColorToMetal(sender, e.Graphics);
            }
        }

        ~MetalButton()
        {
            this.Dispose();
        }

        protected override void Dispose(bool disposing)
        {
            MouseDown -= new MouseEventHandler(Button_MouseDown);
            MouseUp -= new MouseEventHandler(Button_MouseUp);
            MouseLeave -= new EventHandler(Button_MouseLeave);
            Paint -= new PaintEventHandler(Button_Paint);
            base.Dispose(disposing);
        }

        #region 버튼색을 메탈색으로 설정
        public static void DrawThisButtonColorToMetal(object sender, Graphics gra)
        {
            // 전달된 버튼의 색을 변경
            Graphics g = gra;
            g.FillRectangle(
                new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as MetalButton).Height), Color.White, Color.LightGray),
                new RectangleF(new Point(0, 0), new Size((sender as MetalButton).Size.Width, (sender as MetalButton).Size.Height)));
            // 버튼에 표시할 Text 중앙 정렬
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString((sender as MetalButton).Text,
                new Font((sender as MetalButton).Font.Name, 10), System.Drawing.Brushes.Black,
                new Rectangle(new Point(0, 0), new Size((sender as MetalButton).Size.Width, (sender as MetalButton).Size.Height)),
                sf);
        }
        public static void DrawThisButtonColorToClickedMetal(object sender, Graphics gra)
        {
            // 전달된 버튼의 색을 변경
            Graphics g = gra;
            g.FillRectangle(
                new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new Point(0, (sender as MetalButton).Height), Color.LightGray, Color.White),
                new RectangleF(new Point(0, 0), new Size((sender as MetalButton).Size.Width, (sender as MetalButton).Size.Height)));
            // 버튼에 표시할 Text 중앙 정렬
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString((sender as MetalButton).Text,
                new Font((sender as MetalButton).Font.Name, 10), System.Drawing.Brushes.Black,
                new Rectangle(new Point(0, 0), new Size((sender as MetalButton).Size.Width, (sender as MetalButton).Size.Height)),
                sf);
        }
    }
    #endregion

}
#endregion