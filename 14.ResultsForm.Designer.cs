namespace CalibrationHelper
{
    partial class ResultsForm
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
            this.FormTitleLabel1 = new System.Windows.Forms.Label();
            this.CurrStdDevLabel = new System.Windows.Forms.Label();
            this.CurrMeanLabel = new System.Windows.Forms.Label();
            this.FormGenLabel = new System.Windows.Forms.Label();
            this.FormTitleLabel2 = new System.Windows.Forms.Label();
            this.OptmStdDevLabel = new System.Windows.Forms.Label();
            this.OptmMeanLabel = new System.Windows.Forms.Label();
            this.FormGenLabel2 = new System.Windows.Forms.Label();
            this.TableLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.YArrayBox = new System.Windows.Forms.TextBox();
            this.XArrayBox = new System.Windows.Forms.TextBox();
            this.TableBox = new System.Windows.Forms.TextBox();
            this.CurrAbsErrMeanLabel = new System.Windows.Forms.Label();
            this.OptmAbsErrMeanLabel = new System.Windows.Forms.Label();
            this.CurrAbsErrStdDLabel = new System.Windows.Forms.Label();
            this.OptmAbsErrStdDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormTitleLabel1
            // 
            this.FormTitleLabel1.AutoSize = true;
            this.FormTitleLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FormTitleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleLabel1.ForeColor = System.Drawing.Color.Red;
            this.FormTitleLabel1.Location = new System.Drawing.Point(12, 10);
            this.FormTitleLabel1.Name = "FormTitleLabel1";
            this.FormTitleLabel1.Size = new System.Drawing.Size(317, 15);
            this.FormTitleLabel1.TabIndex = 14;
            this.FormTitleLabel1.Text = "--------- Current Calibration - Pre-Treatment Data ---------";
            // 
            // CurrStdDevLabel
            // 
            this.CurrStdDevLabel.AutoSize = true;
            this.CurrStdDevLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrStdDevLabel.ForeColor = System.Drawing.Color.Red;
            this.CurrStdDevLabel.Location = new System.Drawing.Point(251, 61);
            this.CurrStdDevLabel.Name = "CurrStdDevLabel";
            this.CurrStdDevLabel.Size = new System.Drawing.Size(39, 13);
            this.CurrStdDevLabel.TabIndex = 13;
            this.CurrStdDevLabel.Text = "00.00";
            // 
            // CurrMeanLabel
            // 
            this.CurrMeanLabel.AutoSize = true;
            this.CurrMeanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrMeanLabel.ForeColor = System.Drawing.Color.Red;
            this.CurrMeanLabel.Location = new System.Drawing.Point(251, 35);
            this.CurrMeanLabel.Name = "CurrMeanLabel";
            this.CurrMeanLabel.Size = new System.Drawing.Size(39, 13);
            this.CurrMeanLabel.TabIndex = 12;
            this.CurrMeanLabel.Text = "00.00";
            // 
            // FormGenLabel
            // 
            this.FormGenLabel.AutoSize = true;
            this.FormGenLabel.Location = new System.Drawing.Point(12, 34);
            this.FormGenLabel.Name = "FormGenLabel";
            this.FormGenLabel.Size = new System.Drawing.Size(210, 91);
            this.FormGenLabel.TabIndex = 11;
            this.FormGenLabel.Text = "Current Data Fit - Relative Error Mean:\r\n\r\nCurrent Data Fit - Relative Error Std." +
    " Dev.:\r\n\r\nCurrent Data Fit - Absolute Error Mean:\r\n\r\nCurrent Data Fit - Absolute" +
    "  Error Std. Dev.:\r\n";
            // 
            // FormTitleLabel2
            // 
            this.FormTitleLabel2.AutoSize = true;
            this.FormTitleLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FormTitleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleLabel2.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormTitleLabel2.Location = new System.Drawing.Point(12, 138);
            this.FormTitleLabel2.Name = "FormTitleLabel2";
            this.FormTitleLabel2.Size = new System.Drawing.Size(317, 15);
            this.FormTitleLabel2.TabIndex = 18;
            this.FormTitleLabel2.Text = "------ Optimized Calibration - Post -Treatment Data ------";
            // 
            // OptmStdDevLabel
            // 
            this.OptmStdDevLabel.AutoSize = true;
            this.OptmStdDevLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptmStdDevLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.OptmStdDevLabel.Location = new System.Drawing.Point(251, 188);
            this.OptmStdDevLabel.Name = "OptmStdDevLabel";
            this.OptmStdDevLabel.Size = new System.Drawing.Size(39, 13);
            this.OptmStdDevLabel.TabIndex = 17;
            this.OptmStdDevLabel.Text = "00.00";
            // 
            // OptmMeanLabel
            // 
            this.OptmMeanLabel.AutoSize = true;
            this.OptmMeanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptmMeanLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.OptmMeanLabel.Location = new System.Drawing.Point(251, 162);
            this.OptmMeanLabel.Name = "OptmMeanLabel";
            this.OptmMeanLabel.Size = new System.Drawing.Size(39, 13);
            this.OptmMeanLabel.TabIndex = 16;
            this.OptmMeanLabel.Text = "00.00";
            // 
            // FormGenLabel2
            // 
            this.FormGenLabel2.AutoSize = true;
            this.FormGenLabel2.Location = new System.Drawing.Point(12, 162);
            this.FormGenLabel2.Name = "FormGenLabel2";
            this.FormGenLabel2.Size = new System.Drawing.Size(222, 91);
            this.FormGenLabel2.TabIndex = 15;
            this.FormGenLabel2.Text = "Optimized Data Fit - Relative Error Mean:\r\n\r\nOptimized Data Fit - Relative Error " +
    "Std. Dev.:\r\n\r\nOptimized Data Fit - Absolute Error Mean:\r\n\r\nOptimized Data Fit - " +
    "Absolute  Error Std. Dev.:\r\n";
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(586, 58);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(149, 13);
            this.TableLabel.TabIndex = 24;
            this.TableLabel.Text = "Optimized Table Values - f(x,y)";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(615, 11);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(95, 13);
            this.XLabel.TabIndex = 23;
            this.XLabel.Text = "X Axis Breakpoints";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(355, 141);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(63, 26);
            this.YLabel.TabIndex = 22;
            this.YLabel.Text = "Y Axis\r\nBreakpoints";
            this.YLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // YArrayBox
            // 
            this.YArrayBox.AcceptsReturn = true;
            this.YArrayBox.AllowDrop = true;
            this.YArrayBox.Location = new System.Drawing.Point(424, 74);
            this.YArrayBox.Multiline = true;
            this.YArrayBox.Name = "YArrayBox";
            this.YArrayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.YArrayBox.Size = new System.Drawing.Size(51, 176);
            this.YArrayBox.TabIndex = 21;
            // 
            // XArrayBox
            // 
            this.XArrayBox.AcceptsTab = true;
            this.XArrayBox.Location = new System.Drawing.Point(481, 30);
            this.XArrayBox.Name = "XArrayBox";
            this.XArrayBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.XArrayBox.Size = new System.Drawing.Size(370, 20);
            this.XArrayBox.TabIndex = 20;
            this.XArrayBox.WordWrap = false;
            // 
            // TableBox
            // 
            this.TableBox.AcceptsReturn = true;
            this.TableBox.AcceptsTab = true;
            this.TableBox.AllowDrop = true;
            this.TableBox.Location = new System.Drawing.Point(480, 74);
            this.TableBox.Multiline = true;
            this.TableBox.Name = "TableBox";
            this.TableBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TableBox.Size = new System.Drawing.Size(370, 176);
            this.TableBox.TabIndex = 19;
            this.TableBox.WordWrap = false;
            // 
            // CurrAbsErrMeanLabel
            // 
            this.CurrAbsErrMeanLabel.AutoSize = true;
            this.CurrAbsErrMeanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrAbsErrMeanLabel.ForeColor = System.Drawing.Color.Red;
            this.CurrAbsErrMeanLabel.Location = new System.Drawing.Point(251, 86);
            this.CurrAbsErrMeanLabel.Name = "CurrAbsErrMeanLabel";
            this.CurrAbsErrMeanLabel.Size = new System.Drawing.Size(39, 13);
            this.CurrAbsErrMeanLabel.TabIndex = 25;
            this.CurrAbsErrMeanLabel.Text = "00.00";
            // 
            // OptmAbsErrMeanLabel
            // 
            this.OptmAbsErrMeanLabel.AutoSize = true;
            this.OptmAbsErrMeanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptmAbsErrMeanLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.OptmAbsErrMeanLabel.Location = new System.Drawing.Point(251, 214);
            this.OptmAbsErrMeanLabel.Name = "OptmAbsErrMeanLabel";
            this.OptmAbsErrMeanLabel.Size = new System.Drawing.Size(39, 13);
            this.OptmAbsErrMeanLabel.TabIndex = 26;
            this.OptmAbsErrMeanLabel.Text = "00.00";
            // 
            // CurrAbsErrStdDLabel
            // 
            this.CurrAbsErrStdDLabel.AutoSize = true;
            this.CurrAbsErrStdDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrAbsErrStdDLabel.ForeColor = System.Drawing.Color.Red;
            this.CurrAbsErrStdDLabel.Location = new System.Drawing.Point(251, 112);
            this.CurrAbsErrStdDLabel.Name = "CurrAbsErrStdDLabel";
            this.CurrAbsErrStdDLabel.Size = new System.Drawing.Size(39, 13);
            this.CurrAbsErrStdDLabel.TabIndex = 27;
            this.CurrAbsErrStdDLabel.Text = "00.00";
            // 
            // OptmAbsErrStdDLabel
            // 
            this.OptmAbsErrStdDLabel.AutoSize = true;
            this.OptmAbsErrStdDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptmAbsErrStdDLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.OptmAbsErrStdDLabel.Location = new System.Drawing.Point(251, 240);
            this.OptmAbsErrStdDLabel.Name = "OptmAbsErrStdDLabel";
            this.OptmAbsErrStdDLabel.Size = new System.Drawing.Size(39, 13);
            this.OptmAbsErrStdDLabel.TabIndex = 28;
            this.OptmAbsErrStdDLabel.Text = "00.00";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 262);
            this.Controls.Add(this.OptmAbsErrStdDLabel);
            this.Controls.Add(this.CurrAbsErrStdDLabel);
            this.Controls.Add(this.OptmAbsErrMeanLabel);
            this.Controls.Add(this.CurrAbsErrMeanLabel);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.YArrayBox);
            this.Controls.Add(this.XArrayBox);
            this.Controls.Add(this.TableBox);
            this.Controls.Add(this.FormTitleLabel2);
            this.Controls.Add(this.OptmStdDevLabel);
            this.Controls.Add(this.OptmMeanLabel);
            this.Controls.Add(this.FormGenLabel2);
            this.Controls.Add(this.FormTitleLabel1);
            this.Controls.Add(this.CurrStdDevLabel);
            this.Controls.Add(this.CurrMeanLabel);
            this.Controls.Add(this.FormGenLabel);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 20);
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "4. Calibration Optimized results and comparison";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultsForm_FormClosing);
            this.Shown += new System.EventHandler(this.ResultsForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormTitleLabel1;
        private System.Windows.Forms.Label CurrStdDevLabel;
        private System.Windows.Forms.Label CurrMeanLabel;
        private System.Windows.Forms.Label FormGenLabel;
        private System.Windows.Forms.Label FormTitleLabel2;
        private System.Windows.Forms.Label OptmStdDevLabel;
        private System.Windows.Forms.Label OptmMeanLabel;
        private System.Windows.Forms.Label FormGenLabel2;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox YArrayBox;
        private System.Windows.Forms.TextBox XArrayBox;
        private System.Windows.Forms.TextBox TableBox;
        private System.Windows.Forms.Label CurrAbsErrMeanLabel;
        private System.Windows.Forms.Label OptmAbsErrMeanLabel;
        private System.Windows.Forms.Label CurrAbsErrStdDLabel;
        private System.Windows.Forms.Label OptmAbsErrStdDLabel;
    }
}