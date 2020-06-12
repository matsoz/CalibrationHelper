using System;
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

            ParentApp = aParent;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ConvertText2DoubleArrays();

            ParentApp.XCalArray = XVect;
            ParentApp.YCalArray = YVect;
            ParentApp.ZCalTab = Table2DVect;

            ParentApp.FormStatus = (byte)(ParentApp.FormStatus | 0x01);

            Hide();
            ParentApp.Step2Button_AutoOpen();
        }

        private void TableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void ConvertText2DoubleArrays()
        {
            // Convert each field (table and arrays) into numeric data
            XVect = TransformationMethods.TextLin2VectorLin(XArrayBox.Text);
            YVect = TransformationMethods.TextCol2VectorCol(YArrayBox.Text);
            Table2DVect = TransformationMethods.TextTable2VectorTable(TableBox.Text);
        }
    }
}
