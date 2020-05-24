namespace CalibrationHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Step1Button = new System.Windows.Forms.Button();
            this.Step2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Step1Button
            // 
            this.Step1Button.Location = new System.Drawing.Point(34, 12);
            this.Step1Button.Name = "Step1Button";
            this.Step1Button.Size = new System.Drawing.Size(192, 39);
            this.Step1Button.TabIndex = 0;
            this.Step1Button.Text = "1. Calibration Table Insert";
            this.Step1Button.UseVisualStyleBackColor = true;
            this.Step1Button.Click += new System.EventHandler(this.Step1Button_Click);
            // 
            // Step2Button
            // 
            this.Step2Button.Location = new System.Drawing.Point(34, 57);
            this.Step2Button.Name = "Step2Button";
            this.Step2Button.Size = new System.Drawing.Size(192, 38);
            this.Step2Button.TabIndex = 1;
            this.Step2Button.Text = "2. Data Acquired Insert";
            this.Step2Button.UseVisualStyleBackColor = true;
            this.Step2Button.Click += new System.EventHandler(this.Step2Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 335);
            this.Controls.Add(this.Step2Button);
            this.Controls.Add(this.Step1Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Calibration Helper v1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Step1Button;
        private System.Windows.Forms.Button Step2Button;
    }
}

