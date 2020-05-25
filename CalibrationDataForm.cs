using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalibrationHelper
{
    public partial class CalibrationDataForm : Form
    {
        //Parent MainForm declaration for data return
        public MainForm ParentApp;

        public double[,] ZTabOptm;
        public double[] ZRatioArray;
        public double ZRatioMean, ZRatioStdDev;

        public CalibrationDataForm(MainForm aParent)
        {
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
            ZTabOptm = CalibrationMethods.CalibrationTabOptimization(double.Parse(this.MeanTarBox.Text), double.Parse(this.StdDevTarBox.Text),
                        int.Parse(this.Phase1IterBox.Text), int.Parse(this.Phase2IterBox.Text), int.Parse(this.Phase3IterBox.Text),
                        ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                        ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTab);

            this.Hide();
        }
      
    }
}
