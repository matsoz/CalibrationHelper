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
    public partial class WaitBoxForm : Form
    {
        public int MaxSteps, ProgressOld=0, ProgressNew=0;

        private void WaitBoxForm_Load(object sender, EventArgs e)
        {
            Application.DoEvents();
        }

        public WaitBoxForm(int MaxSteps)
        {
            InitializeComponent();
            this.MaxSteps = MaxSteps; 
        }
        public WaitBoxForm()
        {
            InitializeComponent();
        }

        public void CalculateStep(int CurrentStep)
        {
            ProgressOld = ProgressNew;
            ProgressNew =   (int)(100*((double)CurrentStep / (double)MaxSteps));

            if (ProgressNew - ProgressOld >= 1) this.ProgressBar.PerformStep();
            
            if (ProgressNew >= 97) this.Close();
        }
    
    
    }
}
