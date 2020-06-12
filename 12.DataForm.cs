using System;
using System.Windows.Forms;

namespace CalibrationHelper
{
    public partial class DataForm : Form
    {
        //Parent MainForm declaration for data return
        public MainForm ParentApp;

        public double[] XVect, YVect, ZVect;

        public DataForm(MainForm aParent)
        {
            InitializeComponent();

            ParentApp = aParent;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ConvertText2DoubleArrays();

            ParentApp.XDataArray = XVect;
            ParentApp.YDataArray = YVect;
            ParentApp.ZDataArray = ZVect;

            ParentApp.FormStatus = (byte)(ParentApp.FormStatus | 0x02);

            Hide();
            ParentApp.Step3Button_AutoOpen();
        }

        private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ConvertText2DoubleArrays()
        {
            // Convert each field (table and arrays) into numeric data
            XVect = TransformationMethods.TextCol2VectorCol(XArrayBox.Text);
            YVect = TransformationMethods.TextCol2VectorCol(YArrayBox.Text);
            ZVect = TransformationMethods.TextCol2VectorCol(ZArrayBox.Text);
        }

    }
}
