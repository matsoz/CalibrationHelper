namespace CalibrationHelper
{
    partial class HeatMapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlotBoard = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // PlotBoard
            // 
            this.PlotBoard.BackColor = System.Drawing.Color.White;
            this.PlotBoard.Location = new System.Drawing.Point(1, 1);
            this.PlotBoard.Name = "PlotBoard";
            this.PlotBoard.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlotBoard.Size = new System.Drawing.Size(630, 350);
            this.PlotBoard.TabIndex = 1;
            this.PlotBoard.Text = "Convergency Plot";
            this.PlotBoard.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PlotBoard.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PlotBoard.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // HeatMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 351);
            this.Controls.Add(this.PlotBoard);
            this.Location = new System.Drawing.Point(900, 400);
            this.Name = "HeatMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "4.2 Map Zones and Gradients";
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView PlotBoard;
    }
}