namespace CalibrationHelper
{
    partial class WaitBoxForm
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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // FormGenLabel
            // 
            this.FormGenLabel.AutoSize = true;
            this.FormGenLabel.Location = new System.Drawing.Point(25, 9);
            this.FormGenLabel.Name = "FormGenLabel";
            this.FormGenLabel.Size = new System.Drawing.Size(197, 13);
            this.FormGenLabel.TabIndex = 0;
            this.FormGenLabel.Text = "Optimizing Calibration Map - Please Wait";
            this.FormGenLabel.UseWaitCursor = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(28, 40);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(205, 23);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 1;
            this.ProgressBar.UseWaitCursor = true;
            // 
            // WaitBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 81);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.FormGenLabel);
            this.Name = "WaitBoxForm";
            this.Text = "WaitBoxForm";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.WaitBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormGenLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}