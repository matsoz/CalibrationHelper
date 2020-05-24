namespace CalibrationHelper
{
    partial class CalibrationDataForm
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
            this.FormGenLabel = new System.Windows.Forms.Label();
            this.CurrMeanLabel = new System.Windows.Forms.Label();
            this.CurrStdDevLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormGenLabel
            // 
            this.FormGenLabel.AutoSize = true;
            this.FormGenLabel.Location = new System.Drawing.Point(12, 22);
            this.FormGenLabel.Name = "FormGenLabel";
            this.FormGenLabel.Size = new System.Drawing.Size(160, 39);
            this.FormGenLabel.TabIndex = 0;
            this.FormGenLabel.Text = "Current Data Fit - Mean Value:\r\n\r\nCurrent Data Fit - Std. Deviation:\r\n";
            // 
            // CurrMeanLabel
            // 
            this.CurrMeanLabel.AutoSize = true;
            this.CurrMeanLabel.Location = new System.Drawing.Point(198, 22);
            this.CurrMeanLabel.Name = "CurrMeanLabel";
            this.CurrMeanLabel.Size = new System.Drawing.Size(34, 13);
            this.CurrMeanLabel.TabIndex = 1;
            this.CurrMeanLabel.Text = "00.00";
            // 
            // CurrStdDevLabel
            // 
            this.CurrStdDevLabel.AutoSize = true;
            this.CurrStdDevLabel.Location = new System.Drawing.Point(198, 48);
            this.CurrStdDevLabel.Name = "CurrStdDevLabel";
            this.CurrStdDevLabel.Size = new System.Drawing.Size(34, 13);
            this.CurrStdDevLabel.TabIndex = 2;
            this.CurrStdDevLabel.Text = "00.00";
            // 
            // CalibrationDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 294);
            this.Controls.Add(this.CurrStdDevLabel);
            this.Controls.Add(this.CurrMeanLabel);
            this.Controls.Add(this.FormGenLabel);
            this.Name = "CalibrationDataForm";
            this.Text = "3. Calibration Statistics and Adjust Form";
            this.Load += new System.EventHandler(this.CalibrationDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormGenLabel;
        private System.Windows.Forms.Label CurrMeanLabel;
        private System.Windows.Forms.Label CurrStdDevLabel;
    }
}