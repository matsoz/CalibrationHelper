namespace CalibrationHelper
{
    partial class TableForm
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
            this.TableBox = new System.Windows.Forms.TextBox();
            this.XArrayBox = new System.Windows.Forms.TextBox();
            this.YArrayBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.TableLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TableBox
            // 
            this.TableBox.AcceptsReturn = true;
            this.TableBox.AcceptsTab = true;
            this.TableBox.AllowDrop = true;
            this.TableBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableBox.Location = new System.Drawing.Point(130, 70);
            this.TableBox.MaxLength = 60000;
            this.TableBox.Multiline = true;
            this.TableBox.Name = "TableBox";
            this.TableBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TableBox.Size = new System.Drawing.Size(370, 176);
            this.TableBox.TabIndex = 0;
            this.TableBox.Text = "1\t1\t1\t1\t1\t1\t1\t1\t1\r\n1\t1\t1\t1\t1\t1\t1\t1\t1\r\n1\t1\t1\t1\t1\t1\t1\t1\t1\r\n1\t1\t1\t1\t1\t1\t1\t1\t1\r\n1\t1\t1" +
    "\t1\t1\t1\t1\t1\t1\r\n1\t1\t1\t1\t1\t1\t1\t1\t1\r\n1\t1\t1\t1\t1\t1\t1\t1\t1\r\n1\t1\t1\t1\t1\t1\t1\t1\t1\r\n1\t1\t1\t1\t1" +
    "\t1\t1\t1\t1\r\n";
            this.TableBox.WordWrap = false;
            // 
            // XArrayBox
            // 
            this.XArrayBox.AcceptsTab = true;
            this.XArrayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XArrayBox.Location = new System.Drawing.Point(131, 26);
            this.XArrayBox.Name = "XArrayBox";
            this.XArrayBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.XArrayBox.Size = new System.Drawing.Size(370, 20);
            this.XArrayBox.TabIndex = 1;
            this.XArrayBox.Text = "200\t400\t600\t800\t1000\t1200\t1500\t2000\t2500\r\n";
            this.XArrayBox.WordWrap = false;
            // 
            // YArrayBox
            // 
            this.YArrayBox.AcceptsReturn = true;
            this.YArrayBox.AllowDrop = true;
            this.YArrayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YArrayBox.Location = new System.Drawing.Point(74, 70);
            this.YArrayBox.MaxLength = 60000;
            this.YArrayBox.Multiline = true;
            this.YArrayBox.Name = "YArrayBox";
            this.YArrayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.YArrayBox.Size = new System.Drawing.Size(51, 176);
            this.YArrayBox.TabIndex = 2;
            this.YArrayBox.Text = "600\r\n800\r\n900\r\n1000\r\n1200\r\n1500\r\n2000\r\n4000\r\n6000\r\n";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(155, 257);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(321, 257);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(5, 137);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(63, 26);
            this.YLabel.TabIndex = 5;
            this.YLabel.Text = "Y Axis\r\nBreakpoints";
            this.YLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(265, 7);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(95, 13);
            this.XLabel.TabIndex = 6;
            this.XLabel.Text = "X Axis Breakpoints";
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(264, 53);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(100, 13);
            this.TableLabel.TabIndex = 7;
            this.TableLabel.Text = "Table Values - f(x,y)";
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 290);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.YArrayBox);
            this.Controls.Add(this.XArrayBox);
            this.Controls.Add(this.TableBox);
            this.Name = "TableForm";
            this.Text = "1. Insert Calibration Table and Breakpoints here";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.TextBox XArrayBox;
        private System.Windows.Forms.TextBox YArrayBox;
        private System.Windows.Forms.TextBox TableBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
    }
}