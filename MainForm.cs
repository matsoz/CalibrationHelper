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
    public partial class MainForm : Form
    {
        //1. Basic Form instances
        Form Step1Form, Step2Form, Step3Form, Step4Form;
        public byte FormStatus = 0;
        
        //2. Calibration related types - Pre and Post optimization
        public double[] XCalArray, YCalArray;
        public double [,] ZCalTab, ZCalTabOptm;

        //3. Data Related Types
        public double[] XDataArray, YDataArray, ZDataArray;


        public MainForm()
        {
            InitializeComponent();
            
            Step1Form = new TableForm(this);
            Step2Form = new DataForm(this);
            Step3Form = new CalibrationDataForm(this);
            Step4Form = new ResultsForm(this);
        }

        private void Step1Button_Click(object sender, EventArgs e)
        {
            Step1Form.Show();
        }
        
        private void Step2Button_Click(object sender, EventArgs e)
        {
            if ((FormStatus & 0x01) == 0x01) Step2Form.Show();
        }

        private void Step3Button_Click(object sender, EventArgs e)
        {
            if ((FormStatus & 0x02) == 0x02) Step3Form.Show();
        }

        private void Step4Button_Click(object sender, EventArgs e)
        {
            if ((FormStatus & 0x04) == 0x04) Step4Form.Show();
        }
    }
}