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
        Form Step1Form, Step2Form;

        public MainForm()
        {
            InitializeComponent();
            Step1Form = new TableForm();
            Step2Form = new DataForm();
        }

        private void Step1Button_Click(object sender, EventArgs e)
        {
            Step1Form.Show();
        }

        private void Step2Button_Click(object sender, EventArgs e)
        {
            Step2Form.Show();
        }
    }
}