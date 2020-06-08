namespace CalibrationHelper
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.YArrayBox = new System.Windows.Forms.TextBox();
            this.XArrayBox = new System.Windows.Forms.TextBox();
            this.ZArrayBox = new System.Windows.Forms.TextBox();
            this.XArrayLabel = new System.Windows.Forms.Label();
            this.YArrayLabel = new System.Windows.Forms.Label();
            this.ZArrayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(167, 353);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(49, 353);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // YArrayBox
            // 
            this.YArrayBox.AcceptsReturn = true;
            this.YArrayBox.AllowDrop = true;
            this.YArrayBox.Location = new System.Drawing.Point(118, 35);
            this.YArrayBox.MaxLength = 200000;
            this.YArrayBox.Multiline = true;
            this.YArrayBox.Name = "YArrayBox";
            this.YArrayBox.Size = new System.Drawing.Size(60, 300);
            this.YArrayBox.TabIndex = 7;
            this.YArrayBox.Text = resources.GetString("YArrayBox.Text");
            // 
            // XArrayBox
            // 
            this.XArrayBox.AcceptsReturn = true;
            this.XArrayBox.AllowDrop = true;
            this.XArrayBox.Location = new System.Drawing.Point(19, 35);
            this.XArrayBox.MaxLength = 200000;
            this.XArrayBox.Multiline = true;
            this.XArrayBox.Name = "XArrayBox";
            this.XArrayBox.Size = new System.Drawing.Size(60, 300);
            this.XArrayBox.TabIndex = 8;
            this.XArrayBox.Text = resources.GetString("XArrayBox.Text");
            // 
            // ZArrayBox
            // 
            this.ZArrayBox.AcceptsReturn = true;
            this.ZArrayBox.AllowDrop = true;
            this.ZArrayBox.Location = new System.Drawing.Point(219, 35);
            this.ZArrayBox.MaxLength = 200000;
            this.ZArrayBox.Multiline = true;
            this.ZArrayBox.Name = "ZArrayBox";
            this.ZArrayBox.Size = new System.Drawing.Size(60, 300);
            this.ZArrayBox.TabIndex = 9;
            this.ZArrayBox.Text = resources.GetString("ZArrayBox.Text");
            // 
            // XArrayLabel
            // 
            this.XArrayLabel.AutoSize = true;
            this.XArrayLabel.Location = new System.Drawing.Point(14, 16);
            this.XArrayLabel.Name = "XArrayLabel";
            this.XArrayLabel.Size = new System.Drawing.Size(71, 13);
            this.XArrayLabel.TabIndex = 10;
            this.XArrayLabel.Text = "X Data points";
            // 
            // YArrayLabel
            // 
            this.YArrayLabel.AutoSize = true;
            this.YArrayLabel.Location = new System.Drawing.Point(113, 15);
            this.YArrayLabel.Name = "YArrayLabel";
            this.YArrayLabel.Size = new System.Drawing.Size(71, 13);
            this.YArrayLabel.TabIndex = 11;
            this.YArrayLabel.Text = "Y Data points";
            // 
            // ZArrayLabel
            // 
            this.ZArrayLabel.AutoSize = true;
            this.ZArrayLabel.Location = new System.Drawing.Point(214, 15);
            this.ZArrayLabel.Name = "ZArrayLabel";
            this.ZArrayLabel.Size = new System.Drawing.Size(71, 13);
            this.ZArrayLabel.TabIndex = 12;
            this.ZArrayLabel.Text = "Z Data points";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 385);
            this.Controls.Add(this.ZArrayLabel);
            this.Controls.Add(this.YArrayLabel);
            this.Controls.Add(this.XArrayLabel);
            this.Controls.Add(this.ZArrayBox);
            this.Controls.Add(this.XArrayBox);
            this.Controls.Add(this.YArrayBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Name = "DataForm";
            this.Text = "2. Insert Data for X, Y and f(x,y)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XArrayLabel;
        private System.Windows.Forms.Label YArrayLabel;
        private System.Windows.Forms.Label ZArrayLabel;
        private System.Windows.Forms.TextBox XArrayBox;
        private System.Windows.Forms.TextBox YArrayBox;
        private System.Windows.Forms.TextBox ZArrayBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}