using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.Interpolation;

namespace CalibrationHelper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    static public class TabManagement
    {
        static public double LinearInterpolation(double XSel, double[] XBkpt, double[] ZTab)
        {
            double XIndex = 0;
            byte X_BDOffset = 1;

            // Find X interpolation factor
            if (XSel < XBkpt[0])
            {
                XIndex = 0;
            }
            else if (XSel >= XBkpt[(XBkpt.Length) - 1])
            {
                XIndex = (XBkpt.Length) - 1;
                X_BDOffset = 0;
            }
            else
            {
                for (int i = 0; i < XBkpt.Length - 1; i++)
                {
                    if (XSel >= XBkpt[i] && XSel < XBkpt[i + 1])
                    {
                        XIndex = i + ((XSel - XBkpt[i]) / (XBkpt[i + 1] - XBkpt[i]));
                        break;
                    }
                }
            }

            // Interpolate within ZTab using XIndex factors
            double XIndexFrac = 0;
            int XIndexInt = 0;

            XIndexInt = (int)Math.Truncate(XIndex);
            XIndexFrac = XIndex - XIndexInt;

            double ZValueA, ZValueB, ZValueC, ZValueD, ZValue;

            ZValueA = ZTab[XIndexInt];
            ZValueB = ZTab[XIndexInt + X_BDOffset];

            ZValue = ((ZValueA * (1 - XIndexFrac)) + (ZValueB * XIndexFrac)); 

            return ZValue;
        }

        static public double BilinearInterpolation(double XSel, double YSel, double[] XBkpt, double[] YBkpt, double[,] ZTab)
        {
            double XIndex = 0, YIndex = 0;
            byte X_BDOffset = 1, Y_CDOffset = 1;

            // Find X interpolation factor
            if (XSel < XBkpt[0])
            {
                XIndex = 0;
            }
            else if (XSel >= XBkpt[(XBkpt.Length) - 1])
            {
                XIndex = (XBkpt.Length) - 1;
                X_BDOffset = 0;
            }
            else
            {
                for(int i = 0; i< XBkpt.Length - 1;i++)
                {
                    if (XSel >= XBkpt[i] && XSel < XBkpt[i+1])
                    {
                        XIndex = i + ((XSel - XBkpt[i]) / (XBkpt[i + 1] - XBkpt[i]));
                        break;
                    }
                }
            }

            // Find Y interpolation factor
            if (YSel < YBkpt[0])
            {
                YIndex = 0;
            }
            else if (YSel >= YBkpt[(YBkpt.Length) - 1 ])
            {
                YIndex = (YBkpt.Length) - 1;
                Y_CDOffset = 0;
            }
            else
            {
                for (int i = 0; i < YBkpt.Length - 1; i++)
                {
                    if (YSel >= YBkpt[i] && YSel < YBkpt[i + 1])
                    {
                        YIndex = i + ((YSel - YBkpt[i]) / (YBkpt[i + 1] - YBkpt[i]));
                        break;
                    }
                }
            }

            // Interpolate within ZTab using XIndex and YIndex factors
            double XIndexFrac = 0, YIndexFrac = 0;
            int XIndexInt = 0, YIndexInt = 0;

            XIndexInt = (int)Math.Truncate(XIndex);
            YIndexInt = (int)Math.Truncate(YIndex);
            XIndexFrac = XIndex - XIndexInt;
            YIndexFrac = YIndex - YIndexInt;

            double ZValueA, ZValueB, ZValueC, ZValueD, ZValue;

            ZValueA = ZTab[YIndexInt, XIndexInt];
            ZValueB = ZTab[YIndexInt, XIndexInt + X_BDOffset];
            ZValueC = ZTab[YIndexInt + Y_CDOffset, XIndexInt];
            ZValueD = ZTab[YIndexInt + Y_CDOffset, XIndexInt + X_BDOffset];

            ZValue = (1 - YIndexFrac) * ((ZValueA * (1 - XIndexFrac)) + (ZValueB * XIndexFrac)) +
                     (YIndexFrac) *     ((ZValueC * (1 - XIndexFrac)) + (ZValueD * XIndexFrac));

            return ZValue ;
        }
    }
    
    static public class StatBasic
    {
        static public double Mean (double[] Array)
        {
            return Statistics.Mean(Array);
        }

        static public double StdDev(double[] Array)
        {
            return Statistics.StandardDeviation(Array); ;
        }
    }

    static public class TransformationMethods
    {

       static public double[] TextLin2VectorLin(string TextVal)
        {
            //Pre treatment of "TextVal" string, removing doubled space characters
            while (TextVal.Contains("  "))
            {
                TextVal = TextVal.Replace("  ", " ");
            }

            //Transformation step -> String "TextVal" to Vector "VectVal"
            string[] TextValSplit = (TextVal.Trim(' ')).Split(' ');
            double[] VectVal = new double[TextValSplit.Length];
            int i;


            for (i = 0; i < TextValSplit.Length; i++)
            {
                VectVal[i] = double.Parse(TextValSplit[i]);
            }
            return VectVal;

        }

       static public double[] TextCol2VectorCol(string TextVal)
        {
            //Pre treatment of "TextVal" string, removing space characters and doubled linebreaks
            while (TextVal.Contains(" "))
            {
                TextVal = TextVal.Replace(" ", "");
            }
            while (TextVal.Contains("\r\n\r\n"))
            {
                TextVal = TextVal.Replace("\r\n\r\n", "\r\n");
            }
            while (TextVal.Contains(" \r\n"))
            {
                TextVal = TextVal.Replace(" \r\n", "\r\n");
            }
            while (TextVal.Contains("\r\n "))
            {
                TextVal = TextVal.Replace("\r\n ", "\r\n");
            }

            //Transformation step -> String "TextVal" to Vector "VectVal"
            string[] LinBrk = new string[] { "\r\n" }; //Define LineBreak std. string 
            string[] TextValSplit = ((TextVal.Trim('\r', '\n')).Split(LinBrk, StringSplitOptions.None));
            double[] VectVal = new double[((TextVal.Trim('\r', '\n')).Split(LinBrk, StringSplitOptions.None)).Length];
            int i;

            for (i = 0; i < TextValSplit.Length; i++)
            {
                VectVal[i] = double.Parse(TextValSplit[i]);
            }
            return VectVal;
        }

       static public double[,] TextTable2VectorTable(string TextVal)
        {

            //Pre treatment of "TextVal" string, removing doubled space characters and doubled linebreaks
            while (TextVal.Contains("  "))
            {
                TextVal = TextVal.Replace("  ", " ");
            }
            while (TextVal.Contains("\r\n\r\n"))
            {
                TextVal = TextVal.Replace("\r\n\r\n", "\r\n");
            }
            while (TextVal.Contains(" \r\n"))
            {
                TextVal = TextVal.Replace(" \r\n", "\r\n");
            }
            while (TextVal.Contains("\r\n "))
            {
                TextVal = TextVal.Replace("\r\n ", "\r\n");
            }

            //Transformation step -> String "TextVal" to Matrix "TableVal"
            string[] LinBrk = new string[] { "\r\n" }; //Define LineBreak std. string 
            string[] TextValSplitLin = ((TextVal.Trim('\r', '\n')).Split(LinBrk, StringSplitOptions.None));
            double[,] TableVal = new double[((TextVal.Trim('\r', '\n')).Split(LinBrk, StringSplitOptions.None)).Length,
                                    1 + ((TextVal.Split(' ')).Length / ((TextVal.Trim('\r', '\n')).Split(LinBrk, StringSplitOptions.None)).Length)];

            int LinNum = 1 + TableVal.GetUpperBound(0);
            int ColNum = 1 + TableVal.GetUpperBound(1);

            for (int i = 0; i < LinNum; i++)
            {
                string[] TextValSplitLinCol = (TextValSplitLin[i].Trim(' ')).Split(' ');
                for (int j = 0; j < ColNum; j++)
                {
                    TableVal[i, j] = double.Parse(TextValSplitLinCol[j]);
                }
            }

            return TableVal;
        }
    }
}
