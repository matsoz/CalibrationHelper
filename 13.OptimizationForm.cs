using System;
using System.Windows.Forms;



namespace CalibrationHelper
{
    public partial class OptimizationForm : Form
    {
        //Parent MainForm declaration for data return
        public MainForm ParentApp;

        //General class variables
        public double[,] ZTabOptm;
        public double[] ZRatioArray;
        public double[] ZSqrdErrArray, ZCalTabArray;
        public double ZRatioMean, ZRatioStdDev, ZAbsErrMean, ZAbsErrStdD;
        public bool FitType = false; // false for Absolute, true for Relative
        public double[] ErrStep, StdDStep;

        public OptimizationForm(MainForm aParent)
        {
            //Initialize the component and create reference to the instance handler
            InitializeComponent();
            ParentApp = aParent;
        }

        private void CalibrationDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void AbsFitBtn_CheckedChanged(object sender, EventArgs e)
        {
            FitType = (AbsFitBtn.Checked == true) ? false : true;
            MeanTarBox.Text = (AbsFitBtn.Checked == true) ? "0" : "1";
        }

        private void CalibrationDataForm_Load(object sender, EventArgs e)
        {
            ZRatioArray = CalibrationMethods.CalibrationRatioArrayCalculation(
                 ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                 ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTab);

            ZCalTabArray = CalibrationMethods.CalibrationAbsoluteArrayCalculation(
                 ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                 ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTab);

            ZRatioMean = VectorStatBasicMethods.Mean(ZRatioArray);
            ZRatioStdDev = VectorStatBasicMethods.StdDev(ZRatioArray);
            ZAbsErrMean = VectorStatBasicMethods.ErrorsAvg(ZCalTabArray, ParentApp.ZDataArray);
            ZAbsErrStdD = VectorStatBasicMethods.ErrorsStdDev(ZCalTabArray, ParentApp.ZDataArray);

            CurrMeanLabel.Text = ZRatioMean.ToString();
            CurrStdDevLabel.Text = ZRatioStdDev.ToString();
            CurrAbsErrLabel.Text = ZAbsErrMean.ToString();
            CurrAbsErrStdDLabel.Text = ZAbsErrStdD.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ProgressBoxInvokation CalProgressBox = new ProgressBoxInvokation("Calibration ProgressBox Thread");

            ErrStep = new double[2 + int.Parse(FineTuneIterBox.Text)];
            StdDStep = new double[2 + int.Parse(FineTuneIterBox.Text)];

            //Call optimization function and optimize the map. The ProgressBox created above is manipulated inside this method.
            ZTabOptm = CalibrationMethods.CalibrationTabOptimizationWiPB(double.Parse(MeanTarBox.Text), int.Parse(PrecisionTarBox.Text),
                        int.Parse(WeightBox.Text), int.Parse(FineTuneIterBox.Text), int.Parse(FineTuneSubIterBox.Text), FitType,
                        ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                        ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTab,
                        ref CalProgressBox, ref ErrStep, ref StdDStep);

            //Output calculated values to Parent caller
            ParentApp.DataPrecision = int.Parse(PrecisionTarBox.Text);
            ParentApp.ZCalTabOptm = ZTabOptm;
            ParentApp.ErrStep = ErrStep;
            ParentApp.StdDStep = StdDStep;
            ParentApp.PrecisionTar = int.Parse(PrecisionTarBox.Text);
            ParentApp.FitType = FitType;
            ParentApp.FormStatus = (byte)(ParentApp.FormStatus | 0x04);

            //Hide current window and open next step window
            Hide();
            ParentApp.Step4Button_AutoOpen();
        }
    }
}



