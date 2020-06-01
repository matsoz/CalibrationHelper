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
        private delegate void ProgressDelegate(int CurrentStep);
        private ProgressDelegate del;

        public WaitBoxForm()
        {
            InitializeComponent();
            this.ProgressBar.Maximum = 100;
            del = this.UpdateProgressInternal;
        }

       
        private void UpdateProgressInternal(int CurrentStep)
        {
            if (this.Handle == null)
            {
                return;
            }
            this.ProgressBar.Value = CurrentStep;
        }

        public void UpdateProgress(int CurrentStep)
        {
            this.Invoke(del, CurrentStep);
        }

    }
}
