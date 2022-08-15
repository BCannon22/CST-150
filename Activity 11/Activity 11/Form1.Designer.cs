namespace Activity_11
{
    partial class diceRoller
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
            this.rollDice = new System.Windows.Forms.Button();
            this.dice1Rolls = new System.Windows.Forms.RichTextBox();
            this.dice2Rolls = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rollDice
            // 
            this.rollDice.Location = new System.Drawing.Point(12, 53);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(110, 81);
            this.rollDice.TabIndex = 0;
            this.rollDice.Text = "Roll Dice";
            this.rollDice.UseVisualStyleBackColor = true;
            this.rollDice.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // dice1Rolls
            // 
            this.dice1Rolls.Location = new System.Drawing.Point(139, 53);
            this.dice1Rolls.Name = "dice1Rolls";
            this.dice1Rolls.Size = new System.Drawing.Size(111, 96);
            this.dice1Rolls.TabIndex = 1;
            this.dice1Rolls.Text = "";
            // 
            // dice2Rolls
            // 
            this.dice2Rolls.Location = new System.Drawing.Point(256, 53);
            this.dice2Rolls.Name = "dice2Rolls";
            this.dice2Rolls.Size = new System.Drawing.Size(120, 96);
            this.dice2Rolls.TabIndex = 2;
            this.dice2Rolls.Text = "";
            // 
            // diceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(388, 276);
            this.Controls.Add(this.dice2Rolls);
            this.Controls.Add(this.dice1Rolls);
            this.Controls.Add(this.rollDice);
            this.Name = "diceRoller";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rollDice;
        private System.Windows.Forms.RichTextBox dice1Rolls;
        private System.Windows.Forms.RichTextBox dice2Rolls;
    }
}

