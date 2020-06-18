using System;
using System.Windows.Forms;

namespace CalibrationHelper
{
    public partial class ResultsForm : Form
    {
        //Parent MainForm declaration for data return
        public MainForm ParentApp;

        public ResultsForm(MainForm aParent)
        {
            InitializeComponent();
            ParentApp = aParent;
        }

        private void ResultsForm_Shown(object sender, EventArgs e)
        {

            //1.1 Calculate base arrays (Ratio and Abs) for final statistics calculation
            double[] ZRatioArrayOld =
                CalibrationMethods.CalibrationRatioArrayCalculation(ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                                                                    ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTab);
            double[] ZRatioArrayOptm =
                CalibrationMethods.CalibrationRatioArrayCalculation(ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                                                                    ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTabOptm);
            double[] ZCalTabArrayOld =
                CalibrationMethods.CalibrationAbsoluteArrayCalculation(ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                                                        ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTab);
            double[] ZCalTabArrayOptm =
                CalibrationMethods.CalibrationAbsoluteArrayCalculation(ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                                                                    ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTabOptm);

            //1.2 Calculate Mean and StdDev values (Ratio and Abs) from base arrays
            double ZMeanOld = Math.Round(VectorStatBasicMethods.Mean(ZRatioArrayOld), Math.Max(3, ParentApp.DataPrecision + 1));
            double ZStdDevOld = Math.Round(VectorStatBasicMethods.StdDev(ZRatioArrayOld), Math.Max(3, ParentApp.DataPrecision + 1));
            double ZAbsErrMeanOld = Math.Round(VectorStatBasicMethods.ErrorsAvg(ParentApp.ZDataArray, ZCalTabArrayOld),
                                             Math.Max(3, ParentApp.DataPrecision + 1));
            double ZAbsErrStdDOld = Math.Round(VectorStatBasicMethods.ErrorsStdDev(ParentApp.ZDataArray, ZCalTabArrayOld),
                                 Math.Max(3, ParentApp.DataPrecision + 1));

            double ZMeanOptm = Math.Round(VectorStatBasicMethods.Mean(ZRatioArrayOptm), Math.Max(3, ParentApp.DataPrecision + 1));
            double ZStdDevOptm = Math.Round(VectorStatBasicMethods.StdDev(ZRatioArrayOptm), Math.Max(3, ParentApp.DataPrecision + 1));
            double ZAbsErrMeanOptm = Math.Round(VectorStatBasicMethods.ErrorsAvg(ParentApp.ZDataArray, ZCalTabArrayOptm),
                                            Math.Max(3, ParentApp.DataPrecision + 1));
            double ZAbsErrStdDOptm = Math.Round(VectorStatBasicMethods.ErrorsStdDev(ParentApp.ZDataArray, ZCalTabArrayOptm),
                                Math.Max(3, ParentApp.DataPrecision + 1));

            //1.3 Write calculated values on the corresponding labels
            CurrMeanLabel.Text = ZMeanOld.ToString();
            CurrStdDevLabel.Text = ZStdDevOld.ToString();
            CurrAbsErrMeanLabel.Text = ZAbsErrMeanOld.ToString();
            CurrAbsErrStdDLabel.Text = ZAbsErrStdDOld.ToString();

            OptmMeanLabel.Text = ZMeanOptm.ToString();
            OptmStdDevLabel.Text = ZStdDevOptm.ToString();
            OptmAbsErrMeanLabel.Text = ZAbsErrMeanOptm.ToString();
            OptmAbsErrStdDLabel.Text = ZAbsErrStdDOptm.ToString();

            TableBox.Text = TransformationMethods.VectorTable2TextTable(ParentApp.ZCalTabOptm);
            XArrayBox.Text = TransformationMethods.VectorLin2TextLin(ParentApp.XCalArray);
            YArrayBox.Text = TransformationMethods.VectorCol2TextCol(ParentApp.YCalArray);

            //2. Open the Results Convergency pattern new window
            ResConvForm Convergency = new ResConvForm(ParentApp.FitType);
            Convergency.Show();
            Convergency.PlotConvergencyCurve(ParentApp.ErrStep,
                ParentApp.StdDStep);

            HeatMapForm HeatMap = new HeatMapForm();
            HeatMap.Show();
            HeatMap.PlotHeatMap(ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTabOptm);
        }

        private void ResultsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

    }
}
