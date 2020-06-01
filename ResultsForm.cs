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

            double ZMeanOld = Math.Round(StatBasic.Mean(ZRatioArrayOld), Math.Max(3,ParentApp.DataPrecision+1));
            double ZStdDevOld = Math.Round(StatBasic.StdDev(ZRatioArrayOld), Math.Max(3, ParentApp.DataPrecision+1));
            double ZMeanOptm = Math.Round(StatBasic.Mean(ZRatioArrayOptm), Math.Max(3, ParentApp.DataPrecision+1));
            double ZStdDevOptm = Math.Round(StatBasic.StdDev(ZRatioArrayOptm), Math.Max(3, ParentApp.DataPrecision+1));
            
            this.CurrMeanLabel.Text = ZMeanOld.ToString();
            this.CurrStdDevLabel.Text = ZStdDevOld.ToString();
            this.OptmMeanLabel.Text = ZMeanOptm.ToString();
            this.OptmStdDevLabel.Text = ZStdDevOptm.ToString();

            this.TableBox.Text = TransformationMethods.VectorTable2TextTable(ParentApp.ZCalTabOptm);
            this.XArrayBox.Text = TransformationMethods.VectorLin2TextLin(ParentApp.XCalArray);
            this.YArrayBox.Text = TransformationMethods.VectorCol2TextCol(ParentApp.YCalArray);

        }
    }
}
