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
    public partial class TableForm : Form
    {
        //Parent MainForm declaration for data return
        public MainForm ParentApp;

        public double[] XVect, YVect;
        public double[,] Table2DVect;
        
        public TableForm(MainForm aParent)
        {
            InitializeComponent();

            this.ParentApp = aParent;
        }
              
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ConvertText2DoubleArrays();

            ParentApp.XCalArray = this.XVect;
            ParentApp.YCalArray = this.YVect;
            ParentApp.ZCalTab = this.Table2DVect;

            ParentApp.FormStatus = (byte)(ParentApp.FormStatus | 0x01);

            this.Hide();
        }

        private void ConvertText2DoubleArrays()
        {
            // Convert each field (table and arrays) into numeric data
            XVect = TransformationMethods.TextLin2VectorLin(this.XArrayBox.Text);
            YVect = TransformationMethods.TextCol2VectorCol(this.YArrayBox.Text);
            Table2DVect = TransformationMethods.TextTable2VectorTable(this.TableBox.Text);
        }
    }
}
