using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeonButtonProject_Dll
{
    public partial class NeonButtonMain: Form
    {
        public NeonButtonMain()
        {
            InitializeComponent();
        }

        public int colorNum = 0;

        private void NeonButtonBtn_Click(object sender, EventArgs e)
        {
            switch (colorNum)
            {
                case (int)CustomControls_dll.NeonButton.KeyColor.Count:     // 색의 수에 도달하면, 인덱스를 넘어간 것이므로, 0으로 되돌림.
                    colorNum = 0;
                    break;
                default:
                    colorNum++;
                    break;
            }
            (sender as CustomControls_dll.NeonButton).ButtonColor = (CustomControls_dll.NeonButton.KeyColor)colorNum;
            //CustomControls_dll.NeonButton btn = sender as CustomControls_dll.NeonButton;
            //btn.ButtonColor = (CustomControls_dll.NeonButton.KeyColor)colorNum;
            //btn.ButtonColor = CustomControls_dll.NeonButton.KeyColor.Pink;
        }



        //ColorDialog colorDialog = new ColorDialog()
        //{
        //    AllowFullOpen = true,
        //};
        //if (DialogResult.OK == colorDialog.ShowDialog())
        //{
        //    int[] customColors = colorDialog.CustomColors;

        //    System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\CSharp\Portfolio2021\NeonButtonProject/neonBtnColors.txt", true); // true일 경우, 뒤에 추가로 기록.
        //    StringBuilder sb = new StringBuilder();
        //    Color customColor = new Color();
        //    for(int j = 0; j < customColors.Length; j++)
        //    {
        //        customColor = Color.FromArgb(customColors[j]);
        //        sb.Append("color = ");
        //        sb.Append(customColors[j].ToString());
        //        sb.Append(", R: ");
        //        sb.Append(customColor.R.ToString());
        //        sb.Append(", G: ");
        //        sb.Append(customColor.G.ToString());
        //        sb.Append(", B: ");
        //        sb.Append(customColor.B.ToString());
        //        sb.Append("\r\n");
        //    }
        //    sw.WriteLine(sb);
        //    sw.Close();
        //}


        //// ColorDialog창을 10번 열어서,(파일 덮어씌기 때문에)
        //for (int i = 0; i < 10; i++)
        //{
        //    if (DialogResult.OK == colorDialog.ShowDialog())
        //    {
        //        string savePath = @"c:/csharp/portfolio2021/neonBtnColor" + i.ToString() + ".txt";
        //        int[] customColor = colorDialog.CustomColors;
        //        StringBuilder sb = new StringBuilder();
        //        for(int j = 0; j < customColor.Length; j++)
        //        {
        //            sb.Append("color = ");
        //            sb.Append(customColor[j].ToString());
        //            sb.Append(", ");
        //        }
        //        System.IO.File.WriteAllText(savePath, sb.ToString(), Encoding.Default);
        //    }
        //}


    }


}
