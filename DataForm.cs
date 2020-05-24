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
    public partial class DataForm : Form
    {
        public double[] XVect, YVect, ZVect;

        public DataForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ConvertText2DoubleArrays();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ConvertText2DoubleArrays()
        {
            // Convert each field (table and arrays) into numeric data
            XVect = TransformationMethods.TextCol2VectorCol(this.XArrayBox.Text);
            YVect = TransformationMethods.TextCol2VectorCol(this.YArrayBox.Text);
            ZVect = TransformationMethods.TextCol2VectorCol(this.ZArrayBox.Text);
        }

    }
}
