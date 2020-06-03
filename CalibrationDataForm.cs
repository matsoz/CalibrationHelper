using System;
using System.Windows.Forms;


namespace CalibrationHelper
{
    public partial class CalibrationDataForm : Form
    {
        //Parent MainForm declaration for data return
        public MainForm ParentApp;

        //General class variables
        public double[,] ZTabOptm;
        public double[] ZRatioArray;
        public double ZRatioMean, ZRatioStdDev;

        public CalibrationDataForm(MainForm aParent)
        {
            //Initialize the component and create reference to the instance handler
            InitializeComponent();
            this.ParentApp = aParent;
        }

        private void CalibrationDataForm_Load(object sender, EventArgs e)
        {
            ZRatioArray = CalibrationMethods.CalibrationRatioArrayCalculation(
                 ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                 ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTab);

            ZRatioMean = StatBasic.Mean(ZRatioArray);
            ZRatioStdDev = StatBasic.StdDev(ZRatioArray);

            this.CurrMeanLabel.Text = ZRatioMean.ToString();
            this.CurrStdDevLabel.Text = ZRatioStdDev.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ProgressBoxInvokation CalProgressBox = new ProgressBoxInvokation("Calibration ProgressBox Thread");

            //Call optimization function and optimize the map. The ProgressBox created above is manipulated inside this method.
            ZTabOptm = CalibrationMethods.CalibrationTabOptimizationWiPB(double.Parse(this.MeanTarBox.Text), int.Parse(this.PrecisionTarBox.Text),
                        int.Parse(this.WeightBox.Text), int.Parse(this.FineTuneIterBox.Text), int.Parse(this.FineTuneSubIterBox.Text),
                        ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                        ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTab,
                        ref CalProgressBox);

            ParentApp.DataPrecision = int.Parse(this.PrecisionTarBox.Text);
            ParentApp.ZCalTabOptm = ZTabOptm;
            ParentApp.FormStatus = (byte)(ParentApp.FormStatus | 0x04);

            this.Hide();
        }
    }
}



