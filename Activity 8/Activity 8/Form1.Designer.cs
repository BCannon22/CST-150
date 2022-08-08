namespace Activity_8
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
            this.fatGramsInput = new System.Windows.Forms.TextBox();
            this.carbGramsInput = new System.Windows.Forms.TextBox();
            this.fatGramsLabel = new System.Windows.Forms.Label();
            this.carbGramsLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.carbCalLabel = new System.Windows.Forms.Label();
            this.fatCalOutput = new System.Windows.Forms.TextBox();
            this.carbCalOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fatGramsInput
            // 
            this.fatGramsInput.Location = new System.Drawing.Point(229, 80);
            this.fatGramsInput.Name = "fatGramsInput";
            this.fatGramsInput.Size = new System.Drawing.Size(100, 20);
            this.fatGramsInput.TabIndex = 0;
            // 
            // carbGramsInput
            // 
            this.carbGramsInput.Location = new System.Drawing.Point(229, 148);
            this.carbGramsInput.Name = "carbGramsInput";
            this.carbGramsInput.Size = new System.Drawing.Size(100, 20);
            this.carbGramsInput.TabIndex = 1;
            // 
            // fatGramsLabel
            // 
            this.fatGramsLabel.AutoSize = true;
            this.fatGramsLabel.Location = new System.Drawing.Point(53, 83);
            this.fatGramsLabel.Name = "fatGramsLabel";
            this.fatGramsLabel.Size = new System.Drawing.Size(161, 13);
            this.fatGramsLabel.TabIndex = 2;
            this.fatGramsLabel.Text = "How many fat grams consumed?";
            // 
            // carbGramsLabel
            // 
            this.carbGramsLabel.AutoSize = true;
            this.carbGramsLabel.Location = new System.Drawing.Point(53, 151);
            this.carbGramsLabel.Name = "carbGramsLabel";
            this.carbGramsLabel.Size = new System.Drawing.Size(170, 13);
            this.carbGramsLabel.TabIndex = 3;
            this.carbGramsLabel.Text = "How many carb grams consumed?";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(56, 206);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fat Calories:";
            // 
            // carbCalLabel
            // 
            this.carbCalLabel.AutoSize = true;
            this.carbCalLabel.Location = new System.Drawing.Point(53, 320);
            this.carbCalLabel.Name = "carbCalLabel";
            this.carbCalLabel.Size = new System.Drawing.Size(72, 13);
            this.carbCalLabel.TabIndex = 6;
            this.carbCalLabel.Text = "Carb Calories:";
            // 
            // fatCalOutput
            // 
            this.fatCalOutput.Location = new System.Drawing.Point(229, 259);
            this.fatCalOutput.Name = "fatCalOutput";
            this.fatCalOutput.ReadOnly = true;
            this.fatCalOutput.Size = new System.Drawing.Size(100, 20);
            this.fatCalOutput.TabIndex = 7;
            // 
            // carbCalOutput
            // 
            this.carbCalOutput.Location = new System.Drawing.Point(229, 313);
            this.carbCalOutput.Name = "carbCalOutput";
            this.carbCalOutput.ReadOnly = true;
            this.carbCalOutput.Size = new System.Drawing.Size(100, 20);
            this.carbCalOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 412);
            this.Controls.Add(this.carbCalOutput);
            this.Controls.Add(this.fatCalOutput);
            this.Controls.Add(this.carbCalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.carbGramsLabel);
            this.Controls.Add(this.fatGramsLabel);
            this.Controls.Add(this.carbGramsInput);
            this.Controls.Add(this.fatGramsInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fatGramsInput;
        private System.Windows.Forms.TextBox carbGramsInput;
        private System.Windows.Forms.Label fatGramsLabel;
        private System.Windows.Forms.Label carbGramsLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label carbCalLabel;
        private System.Windows.Forms.TextBox fatCalOutput;
        private System.Windows.Forms.TextBox carbCalOutput;
    }
}

