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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FormGenLabel2 = new System.Windows.Forms.Label();
            this.FormTitleLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MeanTarBox = new System.Windows.Forms.TextBox();
            this.StdDevTarBox = new System.Windows.Forms.TextBox();
            this.Phase1IterBox = new System.Windows.Forms.TextBox();
            this.Phase2IterBox = new System.Windows.Forms.TextBox();
            this.Phase3IterBox = new System.Windows.Forms.TextBox();
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
            this.FormGenLabel2.Size = new System.Drawing.Size(157, 130);
            this.FormGenLabel2.TabIndex = 9;
            this.FormGenLabel2.Text = "Target Data Fit - Mean Value:\r\n\r\nTarget Data Fit - Std. Deviation:\r\n\r\nPhase 1 Ite" +
    "ration Limit:\r\n\r\nPhase 2 Iteration Limit:\r\n\r\nPhase 3 Iteration Limit:\r\n\r\n";
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
            this.MeanTarBox.Location = new System.Drawing.Point(201, 104);
            this.MeanTarBox.Name = "MeanTarBox";
            this.MeanTarBox.Size = new System.Drawing.Size(100, 20);
            this.MeanTarBox.TabIndex = 12;
            this.MeanTarBox.Text = "1";
            // 
            // StdDevTarBox
            // 
            this.StdDevTarBox.Location = new System.Drawing.Point(201, 130);
            this.StdDevTarBox.Name = "StdDevTarBox";
            this.StdDevTarBox.Size = new System.Drawing.Size(100, 20);
            this.StdDevTarBox.TabIndex = 13;
            this.StdDevTarBox.Text = "0";
            // 
            // Phase1IterBox
            // 
            this.Phase1IterBox.Location = new System.Drawing.Point(201, 156);
            this.Phase1IterBox.Name = "Phase1IterBox";
            this.Phase1IterBox.Size = new System.Drawing.Size(100, 20);
            this.Phase1IterBox.TabIndex = 14;
            this.Phase1IterBox.Text = "20";
            // 
            // Phase2IterBox
            // 
            this.Phase2IterBox.Location = new System.Drawing.Point(201, 182);
            this.Phase2IterBox.Name = "Phase2IterBox";
            this.Phase2IterBox.Size = new System.Drawing.Size(100, 20);
            this.Phase2IterBox.TabIndex = 15;
            this.Phase2IterBox.Text = "20";
            // 
            // Phase3IterBox
            // 
            this.Phase3IterBox.Location = new System.Drawing.Point(201, 208);
            this.Phase3IterBox.Name = "Phase3IterBox";
            this.Phase3IterBox.Size = new System.Drawing.Size(100, 20);
            this.Phase3IterBox.TabIndex = 16;
            this.Phase3IterBox.Text = "20";
            // 
            // CalibrationDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 294);
            this.Controls.Add(this.Phase3IterBox);
            this.Controls.Add(this.Phase2IterBox);
            this.Controls.Add(this.Phase1IterBox);
            this.Controls.Add(this.StdDevTarBox);
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
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label FormGenLabel2;
        private System.Windows.Forms.Label FormTitleLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MeanTarBox;
        private System.Windows.Forms.TextBox StdDevTarBox;
        private System.Windows.Forms.TextBox Phase1IterBox;
        private System.Windows.Forms.TextBox Phase2IterBox;
        private System.Windows.Forms.TextBox Phase3IterBox;
    }
}