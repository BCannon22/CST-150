namespace Activity15
{
    partial class LuckyNumberForm
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
            this.LuckyNumLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LuckyNumLabel
            // 
            this.LuckyNumLabel.BackColor = System.Drawing.Color.DarkOrchid;
            this.LuckyNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LuckyNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuckyNumLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LuckyNumLabel.Location = new System.Drawing.Point(53, 131);
            this.LuckyNumLabel.Name = "LuckyNumLabel";
            this.LuckyNumLabel.Size = new System.Drawing.Size(195, 164);
            this.LuckyNumLabel.TabIndex = 0;
            this.LuckyNumLabel.Text = "2";
            this.LuckyNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your lucky number is";
            // 
            // LuckyNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(306, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LuckyNumLabel);
            this.Name = "LuckyNumberForm";
            this.Text = "Lucky Number";
            this.Load += new System.EventHandler(this.LuckyNumberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LuckyNumLabel;
        private System.Windows.Forms.Label label1;
    }
}