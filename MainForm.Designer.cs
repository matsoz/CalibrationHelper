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
            this.Step3Button = new System.Windows.Forms.Button();
            this.Step4Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormGenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Step1Button
            // 
            this.Step1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Step1Button.Location = new System.Drawing.Point(498, 146);
            this.Step1Button.Name = "Step1Button";
            this.Step1Button.Size = new System.Drawing.Size(230, 40);
            this.Step1Button.TabIndex = 0;
            this.Step1Button.Text = "1. Current Calibration Array/Table Insert";
            this.Step1Button.UseVisualStyleBackColor = false;
            this.Step1Button.Click += new System.EventHandler(this.Step1Button_Click);
            // 
            // Step2Button
            // 
            this.Step2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Step2Button.Location = new System.Drawing.Point(498, 191);
            this.Step2Button.Name = "Step2Button";
            this.Step2Button.Size = new System.Drawing.Size(230, 40);
            this.Step2Button.TabIndex = 1;
            this.Step2Button.Text = "2. Data Acquired (x,y,z) Insert";
            this.Step2Button.UseVisualStyleBackColor = false;
            this.Step2Button.Click += new System.EventHandler(this.Step2Button_Click);
            // 
            // Step3Button
            // 
            this.Step3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Step3Button.Location = new System.Drawing.Point(498, 237);
            this.Step3Button.Name = "Step3Button";
            this.Step3Button.Size = new System.Drawing.Size(230, 40);
            this.Step3Button.TabIndex = 2;
            this.Step3Button.Text = "3. Calibration Statistics and Optimizaton settings";
            this.Step3Button.UseVisualStyleBackColor = false;
            this.Step3Button.Click += new System.EventHandler(this.Step3Button_Click);
            // 
            // Step4Button
            // 
            this.Step4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Step4Button.Location = new System.Drawing.Point(498, 283);
            this.Step4Button.Name = "Step4Button";
            this.Step4Button.Size = new System.Drawing.Size(230, 40);
            this.Step4Button.TabIndex = 3;
            this.Step4Button.Text = "4. Optimization Results";
            this.Step4Button.UseVisualStyleBackColor = false;
            this.Step4Button.Click += new System.EventHandler(this.Step4Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = global::CalibrationHelper.Properties.Resources.surface_3d;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 327);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormGenLabel
            // 
            this.FormGenLabel.AutoSize = true;
            this.FormGenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormGenLabel.Location = new System.Drawing.Point(504, 23);
            this.FormGenLabel.Name = "FormGenLabel";
            this.FormGenLabel.Size = new System.Drawing.Size(214, 96);
            this.FormGenLabel.TabIndex = 5;
            this.FormGenLabel.Text = "Generate 2D Curve or 3D Map\r\n from Data Points.\r\n\r\nCompare Old mapping\r\nvs.\r\nOpti" +
    "mized mapping.\r\n";
            this.FormGenLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 337);
            this.Controls.Add(this.FormGenLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Step4Button);
            this.Controls.Add(this.Step3Button);
            this.Controls.Add(this.Step2Button);
            this.Controls.Add(this.Step1Button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Calibration Helper v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Step1Button;
        private System.Windows.Forms.Button Step2Button;
        private System.Windows.Forms.Button Step3Button;
        private System.Windows.Forms.Button Step4Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FormGenLabel;
    }
}

