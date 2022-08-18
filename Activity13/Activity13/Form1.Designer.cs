namespace Activity13
{
    partial class TicTacToeForm
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
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.row1Col1Box = new System.Windows.Forms.Label();
            this.row1Col2Box = new System.Windows.Forms.Label();
            this.row1Col3Box = new System.Windows.Forms.Label();
            this.row2Col1Box = new System.Windows.Forms.Label();
            this.row2Col2Box = new System.Windows.Forms.Label();
            this.row2Col3Box = new System.Windows.Forms.Label();
            this.row3Col1Box = new System.Windows.Forms.Label();
            this.row3Col2Box = new System.Windows.Forms.Label();
            this.row3Col3Box = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.Location = new System.Drawing.Point(110, 383);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 10;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(207, 383);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // winnerLabel
            // 
            this.winnerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winnerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(110, 350);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(172, 20);
            this.winnerLabel.TabIndex = 12;
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row1Col1Box
            // 
            this.row1Col1Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row1Col1Box.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row1Col1Box.Location = new System.Drawing.Point(27, 23);
            this.row1Col1Box.Name = "row1Col1Box";
            this.row1Col1Box.Size = new System.Drawing.Size(94, 95);
            this.row1Col1Box.TabIndex = 13;
            this.row1Col1Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row1Col2Box
            // 
            this.row1Col2Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row1Col2Box.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row1Col2Box.Location = new System.Drawing.Point(140, 23);
            this.row1Col2Box.Name = "row1Col2Box";
            this.row1Col2Box.Size = new System.Drawing.Size(94, 95);
            this.row1Col2Box.TabIndex = 14;
            this.row1Col2Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row1Col3Box
            // 
            this.row1Col3Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row1Col3Box.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row1Col3Box.Location = new System.Drawing.Point(251, 23);
            this.row1Col3Box.Name = "row1Col3Box";
            this.row1Col3Box.Size = new System.Drawing.Size(94, 95);
            this.row1Col3Box.TabIndex = 15;
            this.row1Col3Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row2Col1Box
            // 
            this.row2Col1Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row2Col1Box.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row2Col1Box.Location = new System.Drawing.Point(27, 131);
            this.row2Col1Box.Name = "row2Col1Box";
            this.row2Col1Box.Size = new System.Drawing.Size(94, 95);
            this.row2Col1Box.TabIndex = 16;
            this.row2Col1Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row2Col2Box
            // 
            this.row2Col2Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row2Col2Box.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row2Col2Box.Location = new System.Drawing.Point(140, 131);
            this.row2Col2Box.Name = "row2Col2Box";
            this.row2Col2Box.Size = new System.Drawing.Size(94, 95);
            this.row2Col2Box.TabIndex = 17;
            this.row2Col2Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row2Col3Box
            // 
            this.row2Col3Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row2Col3Box.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row2Col3Box.Location = new System.Drawing.Point(251, 131);
            this.row2Col3Box.Name = "row2Col3Box";
            this.row2Col3Box.Size = new System.Drawing.Size(94, 95);
            this.row2Col3Box.TabIndex = 18;
            this.row2Col3Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row3Col1Box
            // 
            this.row3Col1Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row3Col1Box.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row3Col1Box.Location = new System.Drawing.Point(27, 238);
            this.row3Col1Box.Name = "row3Col1Box";
            this.row3Col1Box.Size = new System.Drawing.Size(94, 95);
            this.row3Col1Box.TabIndex = 19;
            this.row3Col1Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row3Col2Box
            // 
            this.row3Col2Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row3Col2Box.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row3Col2Box.Location = new System.Drawing.Point(140, 238);
            this.row3Col2Box.Name = "row3Col2Box";
            this.row3Col2Box.Size = new System.Drawing.Size(94, 95);
            this.row3Col2Box.TabIndex = 20;
            this.row3Col2Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row3Col3Box
            // 
            this.row3Col3Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row3Col3Box.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row3Col3Box.Location = new System.Drawing.Point(251, 238);
            this.row3Col3Box.Name = "row3Col3Box";
            this.row3Col3Box.Size = new System.Drawing.Size(94, 95);
            this.row3Col3Box.TabIndex = 21;
            this.row3Col3Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 435);
            this.Controls.Add(this.row3Col3Box);
            this.Controls.Add(this.row3Col2Box);
            this.Controls.Add(this.row3Col1Box);
            this.Controls.Add(this.row2Col3Box);
            this.Controls.Add(this.row2Col2Box);
            this.Controls.Add(this.row2Col1Box);
            this.Controls.Add(this.row1Col3Box);
            this.Controls.Add(this.row1Col2Box);
            this.Controls.Add(this.row1Col1Box);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Name = "TicTacToeForm";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label row1Col1Box;
        private System.Windows.Forms.Label row1Col2Box;
        private System.Windows.Forms.Label row1Col3Box;
        private System.Windows.Forms.Label row2Col1Box;
        private System.Windows.Forms.Label row2Col2Box;
        private System.Windows.Forms.Label row2Col3Box;
        private System.Windows.Forms.Label row3Col1Box;
        private System.Windows.Forms.Label row3Col2Box;
        private System.Windows.Forms.Label row3Col3Box;
    }
}

