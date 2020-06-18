using System;
using System.Windows.Forms;

namespace CalibrationHelper
{
    public partial class MainForm : Form
    {
        //0. Basic Form instances
        Form Step1Form, Step2Form, Step3Form, Step4Form;
        public byte FormStatus = 0;
        public int DataPrecision = 3;

        //1. Calibration related types - Pre and Post optimization
        public double[] XCalArray, YCalArray;
        public double[,] ZCalTab, ZCalTabOptm;

        //2. Data Related Types
        public double[] XDataArray, YDataArray, ZDataArray;

        //3. Optimization Related Types
        public double[] ErrStep, StdDStep;
        public int PrecisionTar;
        public bool FitType;

        public MainForm()
        {
            InitializeComponent();

            Step1Form = new TableForm(this);
            Step2Form = new DataForm(this);
            Step3Form = new OptimizationForm(this);
            Step4Form = new ResultsForm(this);
        }

        private void Step1Button_Click(object sender, EventArgs e)
        {
            Step1Form.Show();
        }

        private void Step2Button_Click(object sender, EventArgs e)
        {
            if ((FormStatus & 0x01) == 0x01)
            {
                Step2Form.Show();
            }
        }

        private void Step3Button_Click(object sender, EventArgs e)
        {
            if ((FormStatus & 0x02) == 0x02)
            {
                Step3Form.Show();
            }
        }

        private void Step4Button_Click(object sender, EventArgs e)
        {
            if ((FormStatus & 0x04) == 0x04)
            {
                Step4Form.Show();
            }
        }

        public void Step2Button_AutoOpen()
        {
            if ((FormStatus & 0x01) == 0x01)
            {
                Step2Form.Show();
            }
        }

        public void Step3Button_AutoOpen()
        {
            if ((FormStatus & 0x02) == 0x02)
            {
                Step3Form.Show();
            }
        }

        public void Step4Button_AutoOpen()
        {
            if ((FormStatus & 0x04) == 0x04)
            {
                Step4Form.Show();
            }
        }
    }
}