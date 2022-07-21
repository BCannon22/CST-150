namespace Time_Calculator
{
    partial class TimeCalculator
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
            this.convertTime = new System.Windows.Forms.Button();
            this.ClearText = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Seconds = new System.Windows.Forms.Label();
            this.secondsText = new System.Windows.Forms.TextBox();
            this.ConvertedTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // convertTime
            // 
            this.convertTime.Location = new System.Drawing.Point(87, 107);
            this.convertTime.Name = "convertTime";
            this.convertTime.Size = new System.Drawing.Size(75, 23);
            this.convertTime.TabIndex = 0;
            this.convertTime.Text = "Time is:";
            this.convertTime.UseVisualStyleBackColor = true;
            this.convertTime.Click += new System.EventHandler(this.ConvertedTime_Click);
            // 
            // ClearText
            // 
            this.ClearText.Location = new System.Drawing.Point(59, 188);
            this.ClearText.Name = "ClearText";
            this.ClearText.Size = new System.Drawing.Size(75, 23);
            this.ClearText.TabIndex = 1;
            this.ClearText.Text = "Clear";
            this.ClearText.UseVisualStyleBackColor = true;
            this.ClearText.Click += new System.EventHandler(this.ClearText_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(193, 188);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.Location = new System.Drawing.Point(56, 57);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(106, 13);
            this.Seconds.TabIndex = 3;
            this.Seconds.Text = "How many seconds?";
            // 
            // secondsText
            // 
            this.secondsText.Location = new System.Drawing.Point(168, 54);
            this.secondsText.Name = "secondsText";
            this.secondsText.Size = new System.Drawing.Size(100, 20);
            this.secondsText.TabIndex = 4;
            // 
            // ConvertedTime
            // 
            this.ConvertedTime.Location = new System.Drawing.Point(168, 107);
            this.ConvertedTime.Name = "ConvertedTime";
            this.ConvertedTime.ReadOnly = true;
            this.ConvertedTime.Size = new System.Drawing.Size(100, 20);
            this.ConvertedTime.TabIndex = 6;
            // 
            // TimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(317, 288);
            this.Controls.Add(this.ConvertedTime);
            this.Controls.Add(this.secondsText);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearText);
            this.Controls.Add(this.convertTime);
            this.Name = "TimeCalculator";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertTime;
        private System.Windows.Forms.Button ClearText;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.TextBox secondsText;
        private System.Windows.Forms.TextBox ConvertedTime;
    }
}

