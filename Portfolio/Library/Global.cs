using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Portfolio
{
    public enum NeonColors : int
    {
        BrightChartreuse = 0,
        BrightGreen,
        BrightMagenta,
        BrightPink,
        BrightPurple,
        BrightRed,
        BrightSaffron,
        BrightScarlet,
        BrightTeal,
        ElectricCrimson,
        ElectricCyan,
        ElectricFlamingo,
        ElectricGreen,
        ElectricIndigo,
        ElectricLine,
        ElectricOrange,
        ElectricPink,
        ElectricPurple,
        ElectricRed,
        ElectricSheep,
        ElectricViolet,
        ElectricYellow,
        FluorescentGreen,
        FluorescentOrange,
        FluorescentPink,
        FluorescentRed,
        FluorescentRedOrange,
        FluorescentTurquoise,
        FluorescentYellow,
        LightNeonPink,
        NeonBlue,
        NeonCarrot,
        NeonFuchsia,
        NeonGreen,
        NeonPink,
        NeonPurple,
        NeonRed,
        NeonYellow,
        PinkishRedNeon,
        Pink,   // 39가지 네온 색에는 포함되지 않음
        Noname0,
        Noname1,
        Noname2,
        Noname3,
        Noname4,
        Noname5,
        Noname6,
        Noname7,
        Noname8,
        Noname9,
        Noname10,
        Noname11,
        Noname12,
        Noname13,
        Noname14,
        Noname15,
        Noname16,
        Noname17,
        Noname18,
        Noname19,
        Noname20,
        Noname21,
        Noname22,
        Noname23,
        Noname24,
        Noname25,
        Noname26,
        Noname27,
        Noname28,
        Noname29,
        Noname30,
        Noname31,
        Noname32,
        Noname33,
        Noname34,
        Noname35,
        NonameLight0,
        NonameLight1,
        NonameLight2,
        NonameLight3,
        NonameLight4,
        NonameLight5,
        NonameLight6,
        NonameLight7,
        NonameLight8,
        NonameLight9,
        NonameLight10,
        NonameLight11,
        NonameLight12,
        NonameLight13,
        NonameLight14,
        NonameLight15,
        NonameLight16,
        NonameLight17,
        NonameLight18,
        NonameLight19,
        NonameLight20,
        NonameLight21,
        NonameLight22,
        NonameLight23,
        NonameLight24,
        NonameLight25,
        NonameLight26,
        NonameLight27,
        NonameLight28,
        NonameLight29,
        NonameLight30,
        NonameLight31,
        NonameLight32,
        NonameLight33,
        NonameLight34,
        NonameLight35,
        Noname2XLight0,
        Noname2XLight1,
        Noname2XLight2,
        Noname2XLight3,
        Noname2XLight4,
        Noname2XLight5,
        Noname2XLight6,
        Noname2XLight7,
        Noname2XLight8,
        Noname2XLight9,
        Noname2XLight10,
        Noname2XLight11,
        Noname2XLight12,
        Noname2XLight13,
        Noname2XLight14,
        Noname2XLight15,
        Noname2XLight16,
        Noname2XLight17,
        Noname2XLight18,
        Noname2XLight19,
        Noname2XLight20,
        Noname2XLight21,
        Noname2XLight22,
        Noname2XLight23,
        Noname2XLight24,
        Noname2XLight25,
        Noname2XLight26,
        Noname2XLight27,
        Noname2XLight28,
        Noname2XLight29,
        Noname2XLight30,
        Noname2XLight31,
        Noname2XLight32,
        Noname2XLight33,
        Noname2XLight34,
        Noname2XLight35,
        Noname3XLight0,
        Noname3XLight1,
        Noname3XLight2,
        Noname3XLight3,
        Noname3XLight4,
        Noname3XLight5,
        Noname3XLight6,
        Noname3XLight7,
        Noname3XLight8,
        Noname3XLight9,
        Noname3XLight10,
        Noname3XLight11,
        Noname3XLight12,
        Noname3XLight13,
        Noname3XLight14,
        Noname3XLight15,
        Noname3XLight16,
        Noname3XLight17,
        Noname3XLight18,
        Noname3XLight19,
        Noname3XLight20,
        Noname3XLight21,
        Noname3XLight22,
        Noname3XLight23,
        Noname3XLight24,
        Noname3XLight25,
        Noname3XLight26,
        Noname3XLight27,
        Noname3XLight28,
        Noname3XLight29,
        Noname3XLight30,
        Noname3XLight31,
        Noname3XLight32,
        Noname3XLight33,
        Noname3XLight34,
        Noname3XLight35,
        Count,
        None,
    }
    public static class Global
    {
        #region 멤버
        public static Dictionary<NeonColors, Color> neonColorDic;
        #endregion 멤버

        #region  생성자
        static Global()
        {
            InitNeonColorDic(); // 색들을 저장

        }
        #endregion  생성자

        private static void InitNeonColorDic()
        {
            neonColorDic = new Dictionary<NeonColors, Color>();
            // ARGB 16진수 코드를 사용하는 경우 Color col = System.Windows.Media.ColorConverter.ConvertFromString("#FFDFD991") as Color;
            // 또는 col = (Color) ColorConverter.ConvertFromString("#FFDFD991"); 를 사용해야 함.


            neonColorDic[NeonColors.BrightChartreuse] = System.Drawing.ColorTranslator.FromHtml("#dfff11");
            neonColorDic[NeonColors.BrightGreen] = System.Drawing.ColorTranslator.FromHtml("#66ff00");
            neonColorDic[NeonColors.BrightMagenta] = System.Drawing.ColorTranslator.FromHtml("#ff08e8");
            neonColorDic[NeonColors.BrightPink] = System.Drawing.ColorTranslator.FromHtml("#fe01b1");
            neonColorDic[NeonColors.BrightPurple] = System.Drawing.ColorTranslator.FromHtml("#be03fd");
            neonColorDic[NeonColors.BrightRed] = System.Drawing.ColorTranslator.FromHtml("#ff000d");
            neonColorDic[NeonColors.BrightSaffron] = System.Drawing.ColorTranslator.FromHtml("#ffcf09");
            neonColorDic[NeonColors.BrightScarlet] = System.Drawing.ColorTranslator.FromHtml("#fc0e34");
            neonColorDic[NeonColors.BrightTeal] = System.Drawing.ColorTranslator.FromHtml("#01f9c6");
            neonColorDic[NeonColors.ElectricCrimson] = System.Drawing.ColorTranslator.FromHtml("#ff003f");
            neonColorDic[NeonColors.ElectricCyan] = System.Drawing.ColorTranslator.FromHtml("#0ff0fc");
            neonColorDic[NeonColors.ElectricFlamingo] = System.Drawing.ColorTranslator.FromHtml("#fc74fd");
            neonColorDic[NeonColors.ElectricGreen] = System.Drawing.ColorTranslator.FromHtml("#21fc0d");
            neonColorDic[NeonColors.ElectricIndigo] = System.Drawing.ColorTranslator.FromHtml("#6600ff");
            neonColorDic[NeonColors.ElectricLine] = System.Drawing.ColorTranslator.FromHtml("#ccff00");
            neonColorDic[NeonColors.ElectricOrange] = System.Drawing.ColorTranslator.FromHtml("#ff3503");
            neonColorDic[NeonColors.ElectricPink] = System.Drawing.ColorTranslator.FromHtml("#ff0490");
            neonColorDic[NeonColors.ElectricPurple] = System.Drawing.ColorTranslator.FromHtml("#bf00ff");
            neonColorDic[NeonColors.ElectricRed] = System.Drawing.ColorTranslator.FromHtml("#e60000");
            neonColorDic[NeonColors.ElectricSheep] = System.Drawing.ColorTranslator.FromHtml("#55ffff");
            neonColorDic[NeonColors.ElectricViolet] = System.Drawing.ColorTranslator.FromHtml("#8f00f1");
            neonColorDic[NeonColors.ElectricYellow] = System.Drawing.ColorTranslator.FromHtml("#fffc00");
            neonColorDic[NeonColors.FluorescentGreen] = System.Drawing.ColorTranslator.FromHtml("#08ff08");
            neonColorDic[NeonColors.FluorescentOrange] = System.Drawing.ColorTranslator.FromHtml("#ffcf00");
            neonColorDic[NeonColors.FluorescentPink] = System.Drawing.ColorTranslator.FromHtml("#fe1493");
            neonColorDic[NeonColors.FluorescentRed] = System.Drawing.ColorTranslator.FromHtml("#ff5555");
            neonColorDic[NeonColors.FluorescentRedOrange] = System.Drawing.ColorTranslator.FromHtml("#fc8427");
            neonColorDic[NeonColors.FluorescentTurquoise] = System.Drawing.ColorTranslator.FromHtml("#00fdff");
            neonColorDic[NeonColors.FluorescentYellow] = System.Drawing.ColorTranslator.FromHtml("#ccff02");
            neonColorDic[NeonColors.LightNeonPink] = System.Drawing.ColorTranslator.FromHtml("#ff11ff");
            neonColorDic[NeonColors.NeonBlue] = System.Drawing.ColorTranslator.FromHtml("#04d9ff");
            neonColorDic[NeonColors.NeonCarrot] = System.Drawing.ColorTranslator.FromHtml("#ff9933");
            neonColorDic[NeonColors.NeonFuchsia] = System.Drawing.ColorTranslator.FromHtml("#fe4164");
            neonColorDic[NeonColors.NeonGreen] = System.Drawing.ColorTranslator.FromHtml("#39ff14");
            neonColorDic[NeonColors.NeonPink] = System.Drawing.ColorTranslator.FromHtml("#fe019a");
            neonColorDic[NeonColors.NeonPurple] = System.Drawing.ColorTranslator.FromHtml("#bc13fe");
            neonColorDic[NeonColors.NeonRed] = System.Drawing.ColorTranslator.FromHtml("#ff073a");
            neonColorDic[NeonColors.NeonYellow] = System.Drawing.ColorTranslator.FromHtml("#cfff04");
            neonColorDic[NeonColors.PinkishRedNeon] = System.Drawing.ColorTranslator.FromHtml("#ff0055");
            neonColorDic[NeonColors.Pink] = Color.FromArgb(255, 20, 190);

            string[] neonColorNames = Enum.GetNames(typeof(NeonColors));

            int hue = 0;
            foreach (string neonColorName in neonColorNames)
            {
                NeonColors neonColorEnum = (NeonColors)Enum.Parse(typeof(NeonColors), neonColorName);
                if ((int)neonColorEnum >= (int)NeonColors.Noname0 && (int)neonColorEnum <= (int)NeonColors.Noname35)    // Noname0 ~ Noname35까지
                {
                    neonColorDic[neonColorEnum] = SimpleColorTransforms.HsLtoRgb(hue, 1, 0.51);
                    System.Diagnostics.Debug.WriteLine(hue.ToString());
                    hue += 10;
                    if (hue == 360) hue = 0; // hue가 0 ~ 350까지 저장
                }
                else if ((int)neonColorEnum >= (int)NeonColors.NonameLight0 && (int)neonColorEnum <= (int)NeonColors.NonameLight35)    // NonameLight0 ~ NonameLight35까지
                {
                    neonColorDic[neonColorEnum] = ControlPaint.Light(SimpleColorTransforms.HsLtoRgb(hue, 1, 0.51));
                    System.Diagnostics.Debug.WriteLine(hue.ToString());
                    hue += 10;
                    if (hue == 360) hue = 0; // hue가 0 ~ 350까지 저장
                }
                else if ((int)neonColorEnum >= (int)NeonColors.Noname2XLight0 && (int)neonColorEnum <= (int)NeonColors.Noname2XLight35)    // Noname2XLight0 ~ Noname2XLight35까지
                {
                    neonColorDic[neonColorEnum] = ControlPaint.LightLight(SimpleColorTransforms.HsLtoRgb(hue, 1, 0.51));
                    System.Diagnostics.Debug.WriteLine(hue.ToString());
                    hue += 10;
                    if (hue == 360) hue = 0; // hue가 0 ~ 350까지 저장
                }
                // 더 밝게 해서, 다시 저장했다.
                else if ((int)neonColorEnum >= (int)NeonColors.Noname3XLight0 && (int)neonColorEnum <= (int)NeonColors.Noname3XLight35)    // NonNoname3XLightame0 ~ Noname3XLight까지
                {
                    neonColorDic[neonColorEnum] = ControlPaint.Light(ControlPaint.LightLight(SimpleColorTransforms.HsLtoRgb(hue, 1, 0.51)));
                    System.Diagnostics.Debug.WriteLine(hue.ToString());
                    hue += 10;
                }
            }



        }


    }



}
