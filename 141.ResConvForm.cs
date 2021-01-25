using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace CalibrationHelper
{
    public partial class ResConvForm : Form
    {
        string FitTypeString;

        public ResConvForm(bool FitType)
        {
            InitializeComponent();
            FitTypeString = (FitType == false) ? "Absolute error optimization" : "Relative ratio optimization";
        }

        public void PlotConvergencyCurve(double[] CurveAvg, double[] CurveErr)
        {
            //1. PlotModel data definition
            var PlotModel = new PlotModel();

            Axis Err = new LinearAxis() { Position = AxisPosition.Left,
                Title = "Error", AxisTitleDistance = 15,
                TitleFontSize = 18 };
            Axis Step = new LinearAxis() { Position = AxisPosition.Top,
                Title = "Iteration Num.", AxisTitleDistance = 30,
                TitleFontSize = 18 };

            PlotModel.Axes.Add(Err);
            PlotModel.Axes.Add(Step);

            //2. CurveAvg and CurveErr data Plot as Candlesticks
            var PlotData_CurveErr = new CandleStickSeries { CandleWidth = 0.85, Color = OxyColors.Red };
            double[] CurveErrNorm = new double[CurveErr.Length];
            int CandleScale = 1;

            for (int m = 0; m < CurveErr.Length; m++)
            {
                CurveErrNorm[m] = CurveErr[m];
            }
            while (Math.Abs(CurveErrNorm[CurveErrNorm.GetUpperBound(0) - 1] / CurveAvg[CurveErrNorm.GetUpperBound(0) - 1]) > 4)
            {
                for (int m = 0; m < CurveErrNorm.Length; m++)
                {
                    CurveErrNorm[m] *= 0.2;
                }
                CandleScale *= 5;
            }

            for (int i = 0; i < CurveAvg.Length; i++)
            {
                HighLowItem Candle = new HighLowItem();
                double CandleAvg = CurveAvg[i];
                double CandleStdD = CurveErrNorm[i];

                Candle.High = CandleAvg + 3 * CandleStdD;
                Candle.Low = CandleAvg - 3 * CandleStdD;
                Candle.Open = CandleAvg + 1 * CandleStdD;
                Candle.Close = CandleAvg - 1 * CandleStdD;
                Candle.X = i;

                PlotData_CurveErr.Items.Add(Candle);
            }
            PlotModel.Series.Add(PlotData_CurveErr);

            //3. PlotModel plot on PlotBoard
            this.PlotBoard.Model = PlotModel;
            PlotModel.Title = "Convergency per Iteration - " + FitTypeString;
            PlotModel.Subtitle = "CandleSticks Scale: 1 : " + CandleScale.ToString();
        }
    }
}
