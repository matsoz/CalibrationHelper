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
        Form Step1Form, Step2Form, Step3Form;
        
        //1. Calibration related types
        public double[] XCalArray, YCalArray;
        public double [,] ZCalTab;

        //2. Data Related Types
        public double[] XDataArray, YDataArray, ZDataArray;

        public MainForm()
        {
            InitializeComponent();
            
            Step1Form = new TableForm(this);
            Step2Form = new DataForm(this);
            Step3Form = new CalibrationDataForm(this);
        }

        private void Step1Button_Click(object sender, EventArgs e)
        {
            Step1Form.Show();
        }
        
        private void Step2Button_Click(object sender, EventArgs e)
        {
            Step2Form.Show();
        }

        private void Step3Button_Click(object sender, EventArgs e)
        {
            Step3Form.Show();
        }

    }
}