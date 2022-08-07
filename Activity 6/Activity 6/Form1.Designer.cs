namespace Activity_6
{
    partial class Form1
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
            this.convertButton = new System.Windows.Forms.Button();
            this.ferenheitLabel = new System.Windows.Forms.Label();
            this.celsiusLabel = new System.Windows.Forms.Label();
            this.farenheitText = new System.Windows.Forms.TextBox();
            this.celsiusText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(15, 111);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(88, 48);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // ferenheitLabel
            // 
            this.ferenheitLabel.AutoSize = true;
            this.ferenheitLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ferenheitLabel.Location = new System.Drawing.Point(12, 58);
            this.ferenheitLabel.Name = "ferenheitLabel";
            this.ferenheitLabel.Size = new System.Drawing.Size(193, 15);
            this.ferenheitLabel.TabIndex = 1;
            this.ferenheitLabel.Text = "Current temperature in farenheit:";
            // 
            // celsiusLabel
            // 
            this.celsiusLabel.AutoSize = true;
            this.celsiusLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celsiusLabel.Location = new System.Drawing.Point(12, 189);
            this.celsiusLabel.Name = "celsiusLabel";
            this.celsiusLabel.Size = new System.Drawing.Size(182, 15);
            this.celsiusLabel.TabIndex = 2;
            this.celsiusLabel.Text = "Current temperature in celsius:";
            // 
            // farenheitText
            // 
            this.farenheitText.Location = new System.Drawing.Point(211, 56);
            this.farenheitText.Name = "farenheitText";
            this.farenheitText.Size = new System.Drawing.Size(100, 20);
            this.farenheitText.TabIndex = 3;
            // 
            // celsiusText
            // 
            this.celsiusText.Location = new System.Drawing.Point(211, 184);
            this.celsiusText.Name = "celsiusText";
            this.celsiusText.ReadOnly = true;
            this.celsiusText.Size = new System.Drawing.Size(100, 20);
            this.celsiusText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 272);
            this.Controls.Add(this.celsiusText);
            this.Controls.Add(this.farenheitText);
            this.Controls.Add(this.celsiusLabel);
            this.Controls.Add(this.ferenheitLabel);
            this.Controls.Add(this.convertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label ferenheitLabel;
        private System.Windows.Forms.Label celsiusLabel;
        private System.Windows.Forms.TextBox farenheitText;
        private System.Windows.Forms.TextBox celsiusText;
    }
}

