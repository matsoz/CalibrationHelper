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
    public partial class ResultsForm : Form
    {
        //Parent MainForm declaration for data return
        public MainForm ParentApp;

        public ResultsForm(MainForm aParent)
        {
            InitializeComponent();
            
            this.ParentApp = aParent;
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            double[] ZRatioArrayOld =
                CalibrationMethods.CalibrationRatioArrayCalculation(ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                                                                    ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTab);
            double[] ZRatioArrayOptm =
                CalibrationMethods.CalibrationRatioArrayCalculation(ParentApp.XDataArray, ParentApp.YDataArray, ParentApp.ZDataArray,
                                                                    ParentApp.XCalArray, ParentApp.YCalArray, ParentApp.ZCalTabOptm);

            double ZMeanOld = StatBasic.Mean(ZRatioArrayOld);
            double ZStdDevOld = StatBasic.StdDev(ZRatioArrayOld);
            double ZMeanOptm = StatBasic.Mean(ZRatioArrayOptm);
            double ZStdDevOptm = StatBasic.StdDev(ZRatioArrayOptm);

            this.CurrMeanLabel.Text = ZMeanOld.ToString();
            this.CurrStdDevLabel.Text = ZStdDevOld.ToString();
            this.OptmMeanLabel.Text = ZMeanOptm.ToString();
            this.OptmStdDevLabel.Text = ZStdDevOptm.ToString();


        }
    }
}
