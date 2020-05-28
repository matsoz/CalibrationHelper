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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalibrationDataForm));
            this.FormGenLabel = new System.Windows.Forms.Label();
            this.CurrMeanLabel = new System.Windows.Forms.Label();
            this.CurrStdDevLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FormGenLabel2 = new System.Windows.Forms.Label();
            this.FormTitleLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MeanTarBox = new System.Windows.Forms.TextBox();
            this.PrecisionTarBox = new System.Windows.Forms.TextBox();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.FineTuneIterBox = new System.Windows.Forms.TextBox();
            this.FineTuneSubIterBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FormGenLabel
            // 
            this.FormGenLabel.AutoSize = true;
            this.FormGenLabel.Location = new System.Drawing.Point(12, 33);
            this.FormGenLabel.Name = "FormGenLabel";
            this.FormGenLabel.Size = new System.Drawing.Size(160, 39);
            this.FormGenLabel.TabIndex = 0;
            this.FormGenLabel.Text = "Current Data Fit - Mean Value:\r\n\r\nCurrent Data Fit - Std. Deviation:\r\n";
            // 
            // CurrMeanLabel
            // 
            this.CurrMeanLabel.AutoSize = true;
            this.CurrMeanLabel.Location = new System.Drawing.Point(198, 34);
            this.CurrMeanLabel.Name = "CurrMeanLabel";
            this.CurrMeanLabel.Size = new System.Drawing.Size(34, 13);
            this.CurrMeanLabel.TabIndex = 1;
            this.CurrMeanLabel.Text = "00.00";
            // 
            // CurrStdDevLabel
            // 
            this.CurrStdDevLabel.AutoSize = true;
            this.CurrStdDevLabel.Location = new System.Drawing.Point(198, 60);
            this.CurrStdDevLabel.Name = "CurrStdDevLabel";
            this.CurrStdDevLabel.Size = new System.Drawing.Size(34, 13);
            this.CurrStdDevLabel.TabIndex = 2;
            this.CurrStdDevLabel.Text = "00.00";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(195, 259);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(77, 259);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FormGenLabel2
            // 
            this.FormGenLabel2.AutoSize = true;
            this.FormGenLabel2.Location = new System.Drawing.Point(12, 107);
            this.FormGenLabel2.Name = "FormGenLabel2";
            this.FormGenLabel2.Size = new System.Drawing.Size(212, 130);
            this.FormGenLabel2.TabIndex = 9;
            this.FormGenLabel2.Text = resources.GetString("FormGenLabel2.Text");
            // 
            // FormTitleLabel1
            // 
            this.FormTitleLabel1.AutoSize = true;
            this.FormTitleLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FormTitleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleLabel1.Location = new System.Drawing.Point(12, 9);
            this.FormTitleLabel1.Name = "FormTitleLabel1";
            this.FormTitleLabel1.Size = new System.Drawing.Size(293, 15);
            this.FormTitleLabel1.TabIndex = 10;
            this.FormTitleLabel1.Text = "------ Current Calibration - Pre-Treatment Data ------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "---- Optimized Calibration - Post-Treatment Data ----";
            // 
            // MeanTarBox
            // 
            this.MeanTarBox.Location = new System.Drawing.Point(240, 104);
            this.MeanTarBox.Name = "MeanTarBox";
            this.MeanTarBox.Size = new System.Drawing.Size(50, 20);
            this.MeanTarBox.TabIndex = 12;
            this.MeanTarBox.Text = "1";
            // 
            // PrecisionTarBox
            // 
            this.PrecisionTarBox.Location = new System.Drawing.Point(240, 130);
            this.PrecisionTarBox.Name = "PrecisionTarBox";
            this.PrecisionTarBox.Size = new System.Drawing.Size(50, 20);
            this.PrecisionTarBox.TabIndex = 13;
            this.PrecisionTarBox.Text = "3";
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(240, 156);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(50, 20);
            this.WeightBox.TabIndex = 14;
            this.WeightBox.Text = "3";
            // 
            // FineTuneIterBox
            // 
            this.FineTuneIterBox.Location = new System.Drawing.Point(240, 182);
            this.FineTuneIterBox.Name = "FineTuneIterBox";
            this.FineTuneIterBox.Size = new System.Drawing.Size(50, 20);
            this.FineTuneIterBox.TabIndex = 15;
            this.FineTuneIterBox.Text = "20";
            // 
            // FineTuneSubIterBox
            // 
            this.FineTuneSubIterBox.Location = new System.Drawing.Point(240, 208);
            this.FineTuneSubIterBox.Name = "FineTuneSubIterBox";
            this.FineTuneSubIterBox.Size = new System.Drawing.Size(50, 20);
            this.FineTuneSubIterBox.TabIndex = 16;
            this.FineTuneSubIterBox.Text = "20";
            // 
            // CalibrationDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 294);
            this.Controls.Add(this.FineTuneSubIterBox);
            this.Controls.Add(this.FineTuneIterBox);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.PrecisionTarBox);
            this.Controls.Add(this.MeanTarBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormTitleLabel1);
            this.Controls.Add(this.FormGenLabel2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
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
        private System.Windows.Forms.Label FormGenLabel2;
        private System.Windows.Forms.Label FormTitleLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MeanTarBox;
        private System.Windows.Forms.TextBox PrecisionTarBox;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TextBox FineTuneIterBox;
        private System.Windows.Forms.TextBox FineTuneSubIterBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}