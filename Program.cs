using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.Interpolation;
using System.Drawing;
using System.Collections;
using System.ComponentModel;



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
        
        static public double PointsDist2D(double Xa, double Ya, double Xb, double Yb)
        {
            return Math.Sqrt( Math.Pow(Xa - Xb, 2) + Math.Pow(Ya - Yb, 2) );
        }

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
            if (Array.Length > 0)
            {
                return Statistics.Mean(Array);
            }
            else
            {
                return 0;
            }
            
        }

        static public double MeanWeighted(double[] Array, double[] Weight, int WeightPow)
        {
            if (Array.Length > 0)
            {
                double AccumDen=0, AccumNum=0;
                
                for (int i=0; i<Array.Length; i++)
                {
                    AccumNum += Array[i] * Math.Pow(Weight[i],WeightPow);
                    AccumDen += Math.Pow(Weight[i],WeightPow);
                }

                return AccumNum / AccumDen;
            }
            else
            {
                return 0;
            }

        } //Type 1 for linear, 2 for  Quadratic

        static public double StdDev(double[] Array)
        {
            if (Array.Length > 0)
            {
                return Statistics.StandardDeviation(Array);
            }
            else
            {
                return 0;
            }
            
        }
    }

    static public class TransformationMethods
    {
       static public double[] TextLin2VectorLin(string TextVal)
        {
            //Pre treatment of "TextVal" string, removing doubled space characters
            while (TextVal.Contains("\t"))
            {
                TextVal = TextVal.Replace("\t", " ");
            }
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
            while (TextVal.Contains("\t"))
            {
                TextVal = TextVal.Replace("\t", " ");
            }
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
            while (TextVal.Contains("\t"))
            {
                TextVal = TextVal.Replace("\t", " ");
            }
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

       static public string VectorTable2TextTable(double[,] VectorTable)
        {
            string TextTable = "" ; //= new string[2 * (VectorTable.GetUpperBound(0)+1) * (VectorTable.GetUpperBound(1)+1)];

            for (int i = 0; i < 1 + VectorTable.GetUpperBound(0); i++) //i sweeps Y
            {
                for (int j = 0; j < 1 + VectorTable.GetUpperBound(1); j++)//j sweeps X
                {
                    TextTable = String.Concat(TextTable, VectorTable[i, j], "\t");
                }
                TextTable = String.Concat(TextTable, "\r\n");
            }
            return TextTable;
        }
        static public string VectorCol2TextCol(double[] Vector)
        {
            string TextVector = ""; 

            for (int i = 0; i < 1 + Vector.GetUpperBound(0); i++) 
            {
                TextVector = String.Concat(TextVector, Vector[i], "\r\n");
            }
            return TextVector;
        }

        static public string VectorLin2TextLin(double[] Vector)
        {
            string TextVector = "";

            for (int i = 0; i < 1 + Vector.GetUpperBound(0); i++) 
            {
                TextVector = String.Concat(TextVector, Vector[i], "\t");
            }
            return TextVector;
        }
    }

    static public class CalibrationMethods
    {
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
        } //Calculates ratio between Calibration and Data

        static public double[,] CalibrationTabOptimization( double MeanTar, int PrecisionTar,
                                                            int WeightBox, int FineTuneIterBox, int FineTuneSubIterBox,
                                                            double[] DataX, double[] DataY, double[] DataZ,
                                                            double[] XBkpt, double[] YBkpt, double[,] ZTab,
                                                            CalibrationDataForm aParent = null)
        {
            double X_A, X_B, Y_A, Y_B, ZMeanInterval;
            double[,] ZWorkTab = new double[1 + ZTab.GetUpperBound(0), 1 + ZTab.GetUpperBound(1)];
            byte [,] ZTabStatus = new byte[1 + ZTab.GetUpperBound(0), 1 + ZTab.GetUpperBound(1)];

            //1. Sweep each table point and get average value from delivered data
            for (int i = 0; i < 1 + ZWorkTab.GetUpperBound(0); i++) //i sweeps Y
            {
                for (int j = 0; j < 1 + ZWorkTab.GetUpperBound(1); j++)//j sweeps X
                {
                    //1.1 Select interval around table current point - X Values
                    if (j == 0)
                    {
                        X_A = XBkpt[j] - ((XBkpt[j + 1] - XBkpt[j]) / 2);
                        X_B = (XBkpt[j + 1] + XBkpt[j]) / 2;
                    }
                    else if (j == ZWorkTab.GetUpperBound(1))
                    {
                        X_A = (XBkpt[j] + XBkpt[j - 1]) / 2;
                        X_B = XBkpt[j] + ((XBkpt[j] - XBkpt[j - 1]) / 2);
                    }
                    else
                    {
                        X_A = (XBkpt[j] + XBkpt[j - 1]) / 2;
                        X_B = (XBkpt[j + 1] + XBkpt[j]) / 2;
                    }

                    //1.2 Select interval around table current point - Y Values
                    if (i == 0)
                    {
                        Y_A = YBkpt[i] - ((YBkpt[i + 1] - YBkpt[i]) / 2);
                        Y_B = (YBkpt[i + 1] + YBkpt[i]) / 2;
                    }
                    else if (i == ZWorkTab.GetUpperBound(0))
                    {
                        Y_A = (YBkpt[i] + YBkpt[i - 1]) / 2;
                        Y_B = YBkpt[i] + ((YBkpt[i] - YBkpt[i - 1]) / 2);
                    }
                    else
                    {
                        Y_A = (YBkpt[i] + YBkpt[i - 1]) / 2;
                        Y_B = (YBkpt[i + 1] + YBkpt[i]) / 2;
                    }

                    //1.3 Collect data corresponding to the targeted interval
                    int m_A = 0, m_B = 0, m_C = 0, m_D = 0;
                    //1.3.1 Num. of positions needed for each array
                    for (int k = 0; k < DataX.Length; k++)
                    {
                        m_A += (DataX[k] >= X_A && DataX[k] < XBkpt[j] && DataY[k] >= Y_A && DataY[k] < YBkpt[i]) ? 1 : 0;
                        m_B += (DataX[k] >= XBkpt[j] && DataX[k] < X_B && DataY[k] >= Y_A && DataY[k] < YBkpt[i]) ? 1 : 0;
                        m_C += (DataX[k] >= X_A && DataX[k] < XBkpt[j] && DataY[k] >= YBkpt[i] && DataY[k] < Y_B) ? 1 : 0;
                        m_D += (DataX[k] >= XBkpt[j] && DataX[k] < X_B && DataY[k] >= YBkpt[i] && DataY[k] < Y_B) ? 1 : 0;
                    }

                    double[] DataZSel_A = new double[m_A];
                    double[] DataZWei_A = new double[m_A];

                    double[] DataZSel_B = new double[m_B];
                    double[] DataZWei_B = new double[m_B];

                    double[] DataZSel_C = new double[m_C];
                    double[] DataZWei_C = new double[m_C];

                    double[] DataZSel_D = new double[m_D];
                    double[] DataZWei_D = new double[m_D];

                    m_A = 0;
                    m_B = 0;
                    m_C = 0;
                    m_D = 0;

                    //1.3.2 - Z values and weight calculation for each interval
                    for (int k = 0; k < DataX.Length; k++)
                    {
                        if (DataX[k] >= X_A && DataX[k] < XBkpt[j] && DataY[k] >= Y_A && DataY[k] < YBkpt[i])
                        {
                            DataZSel_A[m_A] = DataZ[k];
                            DataZWei_A[m_A] = TabManagement.PointsDist2D((DataX[k] - X_A) / (XBkpt[j] - X_A),
                                                                                (DataY[k] - Y_A) / (YBkpt[i] - Y_A),
                                                                                0, 0);
                            m_A++;
                        }
                        else if (DataX[k] >= XBkpt[j] && DataX[k] < X_B && DataY[k] >= Y_A && DataY[k] < YBkpt[i])
                        {
                            DataZSel_B[m_B] = DataZ[k];
                            DataZWei_B[m_B] = TabManagement.PointsDist2D((DataX[k] - X_B) / (XBkpt[j] - X_B),
                                                                                (DataY[k] - Y_A) / (YBkpt[i] - Y_A),
                                                                                0, 0);
                            m_B++;
                        }
                        else if (DataX[k] >= X_A && DataX[k] < XBkpt[j] && DataY[k] >= YBkpt[i] && DataY[k] < Y_B)
                        {
                            DataZSel_C[m_C] = DataZ[k];
                            DataZWei_C[m_C] = TabManagement.PointsDist2D((DataX[k] - X_A) / (XBkpt[j] - X_A),
                                                                                (DataY[k] - Y_B) / (YBkpt[i] - Y_B),
                                                                                0, 0);
                            m_C++;
                        }
                        else if (DataX[k] >= XBkpt[j] && DataX[k] < X_B && DataY[k] >= YBkpt[i] && DataY[k] < Y_B)
                        {
                            DataZSel_D[m_D] = DataZ[k];
                            DataZWei_D[m_D] = TabManagement.PointsDist2D((DataX[k] - X_B) / (XBkpt[j] - X_B),
                                                                                (DataY[k] - Y_B) / (YBkpt[i] - Y_B),
                                                                                0, 0);
                            m_D++;
                        }
                    }

                    //1.4 Calculate ZMean, within selected interval
                    byte b_A = 1, b_B = 1, b_C = 1, b_D = 1;
                    
                    b_A = DataZSel_A.Length == 0 ? (byte)0 : (byte)1;
                    b_B = DataZSel_B.Length == 0 ? (byte)0 : (byte)1;
                    b_C = DataZSel_C.Length == 0 ? (byte)0 : (byte)1;
                    b_D = DataZSel_D.Length == 0 ? (byte)0 : (byte)1;

                    ZMeanInterval = (b_A * StatBasic.MeanWeighted(DataZSel_A, DataZWei_A, WeightBox) +
                        b_B * StatBasic.MeanWeighted(DataZSel_B, DataZWei_B, WeightBox) +
                        b_C * StatBasic.MeanWeighted(DataZSel_C, DataZWei_C, WeightBox) +
                        b_D * StatBasic.MeanWeighted(DataZSel_D, DataZWei_D, WeightBox)) / (b_A + b_B + b_C + b_D);

                    //1.5 Input mean optimized value (based on data) in ZWorkTab
                    ZWorkTab[i, j] = ZMeanInterval;

                    //1.6 Track/Flag the table values which didn't have associated data to be calculated
                    ZTabStatus[i, j] = (b_A + b_B + b_C + b_D == 0) ? (byte)0 : (byte)1;
                    ZWorkTab[i, j] = (b_A + b_B + b_C + b_D == 0) ? Math.Pow(10, -1 * (PrecisionTar + 1)) : ZWorkTab[i,j];

                }
            }


            //2. Sweep empty table points (due to lack of data) and estimate value by neighbors
            for (int i = 0; i < 1 + ZWorkTab.GetUpperBound(0); i++) //i sweeps Y
            {
                for (int j = 0; j < 1 + ZWorkTab.GetUpperBound(1); j++)//j sweeps X
                {
                    ZWorkTab[i, j] += (ZWorkTab[i, j] == 0) ? Math.Pow(10, -1 * (PrecisionTar + 1)) : 0 ;
                    
                    if(ZTabStatus[i,j] == 0)// Empty position gotten
                    {
                        double Z_Ya = 0, Z_Yb = 0, Z_Xa = 0, Z_Xb = 0;
                        byte b_Ya = 0, b_Yb = 0, b_Xa = 0, b_Xb = 0;
                        
                        Z_Ya = (i == 0) ? 0 : ZWorkTab[i - 1, j];
                        Z_Yb = (i == ZWorkTab.GetUpperBound(0)) ? 0 : ZWorkTab[i + 1, j];
                        Z_Xa = (j == 0) ? 0 : ZWorkTab[i, j - 1];
                        Z_Xb = (j == ZWorkTab.GetUpperBound(1)) ? 0 : ZWorkTab[i, j + 1];

                        b_Ya = (byte)((i == 0) ? 0 : ZTabStatus[i - 1, j]);
                        b_Yb = (byte)((i == ZWorkTab.GetUpperBound(0)) ? 0 : ZTabStatus[i + 1, j]);
                        b_Xa = (byte)((j == 0) ? 0 : ZTabStatus[i, j - 1]);
                        b_Xb = (byte)((j == ZWorkTab.GetUpperBound(1)) ? 0 : ZTabStatus[i, j + 1]);


                        ZWorkTab[i, j] = (b_Ya * Z_Ya + b_Yb * Z_Yb + b_Xa * Z_Xa + b_Xb * Z_Xb) /
                                         (b_Ya + b_Yb + b_Xa + b_Xb);
                        
                        ZWorkTab[i, j] += Math.Pow(10, -1 * (PrecisionTar+1));
                    }
                }
            }

            //3. Sweep each table point and adjust to dimish Z Ratio average deviation
            double MFactor = 1.01, ZStdDevOld;
            double[] ZRatioArray = CalibrationMethods.CalibrationRatioArrayCalculation(DataX, DataY, DataZ, XBkpt, YBkpt, ZWorkTab);
            double ZStdDev = StatBasic.StdDev(ZRatioArray);

            if (aParent != null) aParent.ProgressBoxUpdate(0);
            for (int P2A = 0; P2A < FineTuneIterBox; P2A++)
            {
                for (int i = 0; i < 1 + ZWorkTab.GetUpperBound(0); i++) //i sweeps Y
                {
                    for (int j = 0; j < 1 + ZWorkTab.GetUpperBound(1); j++)//j sweeps X
                    {
                        int LoopSkip = 0;
                        for (int P2B = 0; P2B < FineTuneSubIterBox; P2B++)
                        {
                            // Increment or Decrement a Table value by a specific percent
                            ZWorkTab[i, j] *=  MFactor;

                            // Evaluate the results of the value increment/decrement
                            ZRatioArray = CalibrationMethods.CalibrationRatioArrayCalculation(DataX, DataY, DataZ, XBkpt, YBkpt, ZWorkTab);
                            ZStdDevOld = ZStdDev;
                            ZStdDev = StatBasic.StdDev(ZRatioArray);

                            // If the result didn't optimize the StdDev, undo operation and change direction
                            MFactor = (ZStdDev >= ZStdDevOld) ? 1/MFactor : MFactor;
                            ZWorkTab[i, j] *= (ZStdDev > ZStdDevOld) ? MFactor : 1;

                            // When a second direction change is required (optm reached), break loop and goto next Table position
                            LoopSkip = (P2B == 1 && LoopSkip == 0) ? 1 : LoopSkip;
                            LoopSkip += (ZStdDev >= ZStdDevOld) ? 1 : 0 ;
                                         
                            if (LoopSkip == 2) break;
                        }
                        if (aParent != null) aParent.ProgressBoxUpdate(100 * P2A / FineTuneIterBox);
                    }
                }

                if (MFactor < 1) MFactor = 1/MFactor;

                MFactor = ((MFactor - 1) / 2) + 1;
            }

            if (aParent != null) aParent.ProgressBoxFinish();

            //3. Adjust Calibration Table values - MeanTar, Decimal Places, Round Values
            ZRatioArray = CalibrationMethods.CalibrationRatioArrayCalculation(DataX, DataY, DataZ, XBkpt, YBkpt, ZWorkTab);
            double ZMean = StatBasic.Mean(ZRatioArray);

            for (int i = 0; i < 1 + ZWorkTab.GetUpperBound(0); i++) //i sweeps Y
            {
                for (int j = 0; j < 1 + ZWorkTab.GetUpperBound(1); j++)//j sweeps X
                {
                    ZWorkTab[i, j] *= ZMean * MeanTar;
                    ZWorkTab[i, j] = Math.Round(ZWorkTab[i, j], PrecisionTar);
                }
            }
           
            return ZWorkTab;
        }
    }
}
