using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.Interpolation;

namespace CalibrationHelper
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]

        static public void Main()
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

            double ZValueA, ZValueB, ZValue;

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

    static public class CalibrationMethods
    {
        private const double Quantum = 0.001;

        static public double[] CalibrationRatioArrayCalculation(double[] DataX, double[] DataY, double[] DataZ,
                                                            double[] XBkpt, double[] YBkpt, double[,] ZTab)
        {
            if (DataX.Length == DataY.Length && DataY.Length == DataZ.Length) //Check Data size plausibility
            {
                double[] ZRatioArray = new double[DataX.Length];

                for (int i = 0; i < DataX.Length; i++)
                {
                    if(TabManagement.BilinearInterpolation(DataX[i], DataY[i], XBkpt, YBkpt, ZTab) != 0)
                    {
                        ZRatioArray[i] = DataZ[i] / TabManagement.BilinearInterpolation(DataX[i], DataY[i], XBkpt, YBkpt, ZTab);
                    }
                    else
                    {
                        ZRatioArray[i] = 0;
                    }


                }

                return ZRatioArray;
            }
            else
            {
                throw new System.ArgumentException("The X, Y and Z data arrays are not the same size", "original");
            }
        }

        static public double[,] CalibrationTabOptimization(double MeanTar, double StdDevTar,
                                                            int Phase1Iter, int Phase2Iter, int Phase3Iter,
                                                            double[] DataX, double[] DataY, double[] DataZ,
                                                            double[] XBkpt, double[] YBkpt, double[,] ZTab)
        {
            double CurMean, CurStdDev, OldMean, OldStdDev;
            double[] ZRatioArray;
            double QFactor = 1000;
            short QSig = 1;

            //1.1 First calculation of Mean and StdDev for optimization Phase 1 purpose
            ZRatioArray = CalibrationMethods.CalibrationRatioArrayCalculation(
             DataX, DataY, DataZ,
             XBkpt, YBkpt, ZTab);

            CurMean = StatBasic.Mean(ZRatioArray);
            CurStdDev = StatBasic.StdDev(ZRatioArray);

            //1.2 Loop function for Phase 1 optimization
            short Phase1St = 0;
            for (int P1 = 0; P1 < Phase1Iter; P1++)
            {
                //1.2.1 Increment or decrement all table values by an amount, gross approach
                for (int i = 0; i < 1 + ZTab.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < 1 + ZTab.GetUpperBound(1); j++)
                    {
                        ZTab[i, j] += QFactor * Quantum * QSig;
                    }
                }

                //1.2.2 Recalculate Mean value (CurMean) to compare with OldMean
                ZRatioArray = CalibrationMethods.CalibrationRatioArrayCalculation(
                 DataX, DataY, DataZ,
                 XBkpt, YBkpt, ZTab);

                OldMean = CurMean;
                CurMean = StatBasic.Mean(ZRatioArray);

                //1.2.3 Compare Step result and define next step
                //If First iteration approached to target value, PhaseSt1 = 1, keep direction and step size. Else, PhaseSt=0
                if ((Math.Abs(CurMean - MeanTar) < Math.Abs(OldMean - MeanTar)) && (Phase1St == 0 || Phase1St == 1))
                {
                    Phase1St = 1;
                }
                //If last iter. didn't approach and PhaseSt1 = 0, only invert direction.
                else if ((Math.Abs(CurMean - MeanTar) >= Math.Abs(OldMean - MeanTar)) && Phase1St == 0)
                {
                    QSig *= -1;
                }
                //If last iter. didn't approach and PhaseSt1 = 1, invert direction and diminish step
                else if ((Math.Abs(CurMean - MeanTar) >= Math.Abs(OldMean - MeanTar)) && Phase1St == 1)
                {
                    QSig *= -1;
                    QFactor /= 2;
                }

                //1.2.4 If Target achieved, finish loop earlier.
                if(Math.Abs(CurMean-MeanTar) < Quantum)
                {
                    break;
                }
            }

            QFactor = 100;
            //2.1 Loop function for Phase 2 optimization
            short Phase2St = 0;
            for (int P2 = 0; P2 < Phase2Iter; P2++)
            {
                //2.1.1 Increment or decrement individual table value by an amount, fine approach
                int ZRatio_Temp = 0;
                for (int i = 0; i < 1 + ZTab.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < 1 + ZTab.GetUpperBound(1); j++)
                    {
                        for(int P2B=0; P2B < Phase2Iter; P2B++) //Explore same Tab Point many times after changing
                        {
                            ZTab[i, j] += QFactor * Quantum * QSig;

                            //2.1.1.1 Recalculate Mean value (CurMean) to compare with OldMean

                            ZRatioArray = CalibrationMethods.CalibrationRatioArrayCalculation(
                                                                                 DataX, DataY, DataZ,
                                                                                 XBkpt, YBkpt, ZTab);

                            OldMean = CurMean;
                            CurMean = StatBasic.Mean(ZRatioArray);

                            //2.1.1.2 Compare Step result and define next step
                            //If First iteration approached to target value, PhaseSt1 = 1, keep direction and step size. Else, PhaseSt=0
                            if ((Math.Abs(CurMean - MeanTar) < Math.Abs(OldMean - MeanTar)) && (Phase2St == 0 || Phase2St == 1))
                            {
                                Phase2St = 1;
                            }
                            //If last iter. didn't approach and PhaseSt1 = 0, only invert direction.
                            else if ((Math.Abs(CurMean - MeanTar) >= Math.Abs(OldMean - MeanTar)) && Phase2St == 0)
                            {
                                QSig *= -1;
                            }
                            //If last iter. didn't approach and PhaseSt1 = 1, invert direction and diminish step
                            else if ((Math.Abs(CurMean - MeanTar) >= Math.Abs(OldMean - MeanTar)) && Phase2St == 1)
                            {
                                QSig *= -1;
                                QFactor /= 2;
                            }

                        }
                    }
                }

                //1.2.4 If Target achieved, finish loop earlier.
                if (Math.Abs(CurMean - MeanTar) < Quantum)
                {
                    break;
                }
            }

            return ZTab;
        }
    }

}
