namespace Activity_7
{
    partial class PiCalc
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
            this.TermNumber = new System.Windows.Forms.Label();
            this.TermsTextBox = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TermNumber
            // 
            this.TermNumber.AutoSize = true;
            this.TermNumber.Location = new System.Drawing.Point(45, 70);
            this.TermNumber.Name = "TermNumber";
            this.TermNumber.Size = new System.Drawing.Size(113, 13);
            this.TermNumber.TabIndex = 0;
            this.TermNumber.Text = "Enter number of terms:";
            // 
            // TermsTextBox
            // 
            this.TermsTextBox.Location = new System.Drawing.Point(164, 67);
            this.TermsTextBox.Name = "TermsTextBox";
            this.TermsTextBox.Size = new System.Drawing.Size(100, 20);
            this.TermsTextBox.TabIndex = 1;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(48, 106);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(110, 51);
            this.CalcButton.TabIndex = 2;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Location = new System.Drawing.Point(45, 191);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(0, 13);
            this.Results.TabIndex = 3;
            // 
            // PiCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.TermsTextBox);
            this.Controls.Add(this.TermNumber);
            this.Name = "PiCalc";
            this.Text = "PI Approximation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TermNumber;
        private System.Windows.Forms.TextBox TermsTextBox;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label Results;
    }
}

