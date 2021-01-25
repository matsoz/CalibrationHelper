namespace CalibrationHelper
{
    partial class OptimizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptimizationForm));
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
            this.CurrAbsErrLabel = new System.Windows.Forms.Label();
            this.CurrAbsErrStdDLabel = new System.Windows.Forms.Label();
            this.AbsFitBtn = new System.Windows.Forms.RadioButton();
            this.RelFitBtn = new System.Windows.Forms.RadioButton();
            this.FitTypeBox = new System.Windows.Forms.GroupBox();
            this.FitTypeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormGenLabel
            // 
            this.FormGenLabel.AutoSize = true;
            this.FormGenLabel.Location = new System.Drawing.Point(12, 33);
            this.FormGenLabel.Name = "FormGenLabel";
            this.FormGenLabel.Size = new System.Drawing.Size(210, 104);
            this.FormGenLabel.TabIndex = 0;
            this.FormGenLabel.Text = "Current Data Fit - Relative Error Mean:\r\n\r\nCurrent Data Fit - Relative Error Std." +
    " Dev.:\r\n\r\nCurrent Data Fit - Absolute Error Mean:\r\n\r\nCurrent Data Fit - Absolute" +
    "  Error Std. Dev.:\r\n\r\n";
            // 
            // CurrMeanLabel
            // 
            this.CurrMeanLabel.AutoSize = true;
            this.CurrMeanLabel.Location = new System.Drawing.Point(250, 34);
            this.CurrMeanLabel.Name = "CurrMeanLabel";
            this.CurrMeanLabel.Size = new System.Drawing.Size(34, 13);
            this.CurrMeanLabel.TabIndex = 1;
            this.CurrMeanLabel.Text = "00.00";
            // 
            // CurrStdDevLabel
            // 
            this.CurrStdDevLabel.AutoSize = true;
            this.CurrStdDevLabel.Location = new System.Drawing.Point(250, 60);
            this.CurrStdDevLabel.Name = "CurrStdDevLabel";
            this.CurrStdDevLabel.Size = new System.Drawing.Size(34, 13);
            this.CurrStdDevLabel.TabIndex = 2;
            this.CurrStdDevLabel.Text = "00.00";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(184, 332);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(66, 332);
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
            this.FormGenLabel2.Location = new System.Drawing.Point(12, 165);
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
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "---- Optimized Calibration - Post-Treatment Data ----";
            // 
            // MeanTarBox
            // 
            this.MeanTarBox.Location = new System.Drawing.Point(240, 162);
            this.MeanTarBox.Name = "MeanTarBox";
            this.MeanTarBox.Size = new System.Drawing.Size(50, 20);
            this.MeanTarBox.TabIndex = 12;
            this.MeanTarBox.Text = "1";
            // 
            // PrecisionTarBox
            // 
            this.PrecisionTarBox.Location = new System.Drawing.Point(240, 188);
            this.PrecisionTarBox.Name = "PrecisionTarBox";
            this.PrecisionTarBox.Size = new System.Drawing.Size(50, 20);
            this.PrecisionTarBox.TabIndex = 13;
            this.PrecisionTarBox.Text = "2";
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(240, 214);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(50, 20);
            this.WeightBox.TabIndex = 14;
            this.WeightBox.Text = "3";
            // 
            // FineTuneIterBox
            // 
            this.FineTuneIterBox.Location = new System.Drawing.Point(240, 240);
            this.FineTuneIterBox.Name = "FineTuneIterBox";
            this.FineTuneIterBox.Size = new System.Drawing.Size(50, 20);
            this.FineTuneIterBox.TabIndex = 15;
            this.FineTuneIterBox.Text = "10";
            // 
            // FineTuneSubIterBox
            // 
            this.FineTuneSubIterBox.Location = new System.Drawing.Point(240, 266);
            this.FineTuneSubIterBox.Name = "FineTuneSubIterBox";
            this.FineTuneSubIterBox.Size = new System.Drawing.Size(50, 20);
            this.FineTuneSubIterBox.TabIndex = 16;
            this.FineTuneSubIterBox.Text = "25";
            // 
            // CurrAbsErrLabel
            // 
            this.CurrAbsErrLabel.AutoSize = true;
            this.CurrAbsErrLabel.Location = new System.Drawing.Point(250, 85);
            this.CurrAbsErrLabel.Name = "CurrAbsErrLabel";
            this.CurrAbsErrLabel.Size = new System.Drawing.Size(34, 13);
            this.CurrAbsErrLabel.TabIndex = 17;
            this.CurrAbsErrLabel.Text = "00.00";
            // 
            // CurrAbsErrStdDLabel
            // 
            this.CurrAbsErrStdDLabel.AutoSize = true;
            this.CurrAbsErrStdDLabel.Location = new System.Drawing.Point(250, 111);
            this.CurrAbsErrStdDLabel.Name = "CurrAbsErrStdDLabel";
            this.CurrAbsErrStdDLabel.Size = new System.Drawing.Size(34, 13);
            this.CurrAbsErrStdDLabel.TabIndex = 18;
            this.CurrAbsErrStdDLabel.Text = "00.00";
            // 
            // AbsFitBtn
            // 
            this.AbsFitBtn.AutoSize = true;
            this.AbsFitBtn.Checked = true;
            this.AbsFitBtn.Location = new System.Drawing.Point(14, 11);
            this.AbsFitBtn.Name = "AbsFitBtn";
            this.AbsFitBtn.Size = new System.Drawing.Size(142, 17);
            this.AbsFitBtn.TabIndex = 19;
            this.AbsFitBtn.TabStop = true;
            this.AbsFitBtn.Text = "Absolute Fit (Data - Map)";
            this.AbsFitBtn.UseVisualStyleBackColor = true;
            this.AbsFitBtn.CheckedChanged += new System.EventHandler(this.AbsFitBtn_CheckedChanged);
            // 
            // RelFitBtn
            // 
            this.RelFitBtn.AutoSize = true;
            this.RelFitBtn.Location = new System.Drawing.Point(169, 11);
            this.RelFitBtn.Name = "RelFitBtn";
            this.RelFitBtn.Size = new System.Drawing.Size(142, 17);
            this.RelFitBtn.TabIndex = 20;
            this.RelFitBtn.Text = "Relative Fit (Data / Map)";
            this.RelFitBtn.UseVisualStyleBackColor = true;
            // 
            // FitTypeBox
            // 
            this.FitTypeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FitTypeBox.Controls.Add(this.AbsFitBtn);
            this.FitTypeBox.Controls.Add(this.RelFitBtn);
            this.FitTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FitTypeBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FitTypeBox.Location = new System.Drawing.Point(0, 289);
            this.FitTypeBox.Name = "FitTypeBox";
            this.FitTypeBox.Size = new System.Drawing.Size(325, 34);
            this.FitTypeBox.TabIndex = 21;
            this.FitTypeBox.TabStop = false;
            // 
            // OptimizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 365);
            this.Controls.Add(this.FitTypeBox);
            this.Controls.Add(this.CurrAbsErrStdDLabel);
            this.Controls.Add(this.CurrAbsErrLabel);
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
            this.Name = "OptimizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3. Calibration Statistics and Adjust Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalibrationDataForm_FormClosing);
            this.Load += new System.EventHandler(this.CalibrationDataForm_Load);
            this.Shown += new System.EventHandler(this.CalibrationDataForm_Load);
            this.FitTypeBox.ResumeLayout(false);
            this.FitTypeBox.PerformLayout();
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
#pragma warning disable CS0108 // 'CalibrationDataForm.CancelButton' hides inherited member 'Form.CancelButton'. Use the new keyword if hiding was intended.
        private System.Windows.Forms.Button CancelButton;
#pragma warning restore CS0108 // 'CalibrationDataForm.CancelButton' hides inherited member 'Form.CancelButton'. Use the new keyword if hiding was intended.
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label CurrAbsErrLabel;
        private System.Windows.Forms.Label CurrAbsErrStdDLabel;
        private System.Windows.Forms.RadioButton AbsFitBtn;
        private System.Windows.Forms.RadioButton RelFitBtn;
        private System.Windows.Forms.GroupBox FitTypeBox;
    }
}