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
    public partial class CalibrationDataForm : Form
    {
        //Parent MainForm declaration for data return
        public MainForm ParentApp;
        public double[] ZRatioArray;
       // public event CalibrationDataForm_Shown;

        public CalibrationDataForm(MainForm aParent)
        {
            InitializeComponent();
            this.ParentApp = aParent;
        }
       

        private void CalibrationDataForm_Load(object sender, EventArgs e)
        {
            // ZRatioArray = CalibrationMethods.CalibrationRatioArrayCalculation(
            //     ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
            //     ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTab);

            //MessageBox.Show("TestShown");

            //this.CurrMeanLabel.Text =  StatBasic.Mean(ZRatioArray).ToString();
            //this.CurrStdDevLabel.Text =  StatBasic.StdDev(ZRatioArray).ToString() ;

            CurrMeanLabel.Text = "ABC";
            CurrStdDevLabel.Text = "ABC";
        }
    }
}
