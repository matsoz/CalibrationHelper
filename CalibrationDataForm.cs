using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;


namespace CalibrationHelper
{
    public partial class CalibrationDataForm : Form
    {
        //Parent MainForm declaration for data return
        public MainForm ParentApp;
        public WaitBoxForm ProgressBox;
        private bool ProgressBoxVisible = false, ProgressBoxDone = false;

        public double[,] ZTabOptm;
        public double[] ZRatioArray;
        public double ZRatioMean, ZRatioStdDev;

        public event EventHandler<CalibrationDataFormEventArgs> ProgressUpdate;
        public event EventHandler ProgressFinish;

        public CalibrationDataForm(MainForm aParent)
        {
            InitializeComponent();
            this.ParentApp = aParent;

            ProgressBox = new WaitBoxForm();
            this.Load += new EventHandler(ProgressBoxLoad);
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

        private void ProgressBoxLoad(object sender, EventArgs e)
        {
            this.Hide();
            //Create new thread for showing a Progress Box containing the loading status
            Thread PBthread = new Thread(new ThreadStart(this.ProgressBoxThread));
            PBthread.Start();

            this.ProgressUpdate += (o, ex) =>
            {
                this.ProgressBox.UpdateProgress(ex.CurrentStep);
            };
            this.ProgressFinish += (o, ex) =>
            {
                ProgressBoxDone = true;
                this.Show();
            };
        }

        private void ProgressBoxThread()
        {
            ProgressBox.Show();
            while (!ProgressBoxDone)
            {
                ProgressBox.Visible = ProgressBoxVisible && !ProgressBox.Visible ? true : ProgressBox.Visible;
                ProgressBox.Visible = !ProgressBoxVisible && ProgressBox.Visible ? false : ProgressBox.Visible;
                Application.DoEvents();
            }
            ProgressBox.Close();
            this.ProgressBox.Dispose();
        }

        public void ProgressBoxUpdate(int CurrentStep)
        {
            var handler = this.ProgressUpdate;
            if (handler != null)
            {
                handler(this, new CalibrationDataFormEventArgs(CurrentStep));
            }
        }

        public void ProgressBoxFinish()
        {
            var handler = this.ProgressFinish;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
            ProgressBoxDone = true;
        }
    
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ProgressBoxVisible = true;

            //Call optimization function and optimize the map
            ZTabOptm = CalibrationMethods.CalibrationTabOptimization(double.Parse(this.MeanTarBox.Text), int.Parse(this.PrecisionTarBox.Text),
                        int.Parse(this.WeightBox.Text), int.Parse(this.FineTuneIterBox.Text), int.Parse(this.FineTuneSubIterBox.Text),
                        ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                        ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTab,
                        this);

            ParentApp.DataPrecision = int.Parse(this.PrecisionTarBox.Text);
            ParentApp.ZCalTabOptm = ZTabOptm;
            ParentApp.FormStatus = (byte)(ParentApp.FormStatus | 0x04);

            this.Hide();
        }
      
    }

    public class CalibrationDataFormEventArgs : EventArgs
    {
        public CalibrationDataFormEventArgs(int CurrentStep)
        {
            this.CurrentStep = CurrentStep;
        }
        
        public int CurrentStep
        {
            get;
            private set;
        }
    }
}

