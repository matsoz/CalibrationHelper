using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Linq;
using System.Windows.Forms;


namespace CalibrationHelper
{
    public partial class HeatMapForm : Form
    {

        public HeatMapForm()
        {
            InitializeComponent();
        }

        public void PlotHeatMap(double[] XBkpt, double[] YBkpt, double[,] Map)
        {
            //1. PlotModel data definition and Input
            var PlotModel = new PlotModel { Title = "Map Zones and Gradients" };

            PlotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Top,
                Key = "X Axis",
                ItemsSource = XBkpt
            });// X Axis def and data input (horizontal)

            PlotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "Y Axis",
                ItemsSource = YBkpt.Reverse()
            });// Y axis def and data input (vertical)

            PlotModel.Axes.Add(new LinearColorAxis
            {
                Palette = OxyPalettes.Jet(500000)
            });// 2D Color map type

            var data = new double[YBkpt.Length, XBkpt.Length];
            for (int i = 0; i < YBkpt.Length; ++i)
            {
                for (int j = 0; j < XBkpt.Length; ++j)
                {
                    data[j, i] = Map[YBkpt.Length - i - 1, j];
                }
            } // 2D Map data input

            var heatMapSeries = new HeatMapSeries
            {
                X0 = 0,
                X1 = XBkpt.Length - 1,
                Y0 = 0,
                Y1 = YBkpt.Length - 1,
                XAxisKey = "X Axis",
                YAxisKey = "Y Axis",
                RenderMethod = HeatMapRenderMethod.Bitmap,
                LabelFontSize = 0.4, // neccessary to display the label
                FontSize = 1,
                Data = data
            }; //2D Map def

            //2. PlotModel plot on PlotBoard
            PlotModel.Series.Add(heatMapSeries);
            PlotBoard.Model = PlotModel;
        }
    }
}