namespace Activity14
{
    partial class OrderForm
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
            this.productList = new System.Windows.Forms.ListBox();
            this.filledButton = new System.Windows.Forms.RadioButton();
            this.regularButton = new System.Windows.Forms.RadioButton();
            this.sprinklesBox = new System.Windows.Forms.CheckBox();
            this.syrupBox = new System.Windows.Forms.CheckBox();
            this.sugarBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(26, 56);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(120, 95);
            this.productList.TabIndex = 0;
            // 
            // filledButton
            // 
            this.filledButton.AutoSize = true;
            this.filledButton.Location = new System.Drawing.Point(198, 93);
            this.filledButton.Name = "filledButton";
            this.filledButton.Size = new System.Drawing.Size(49, 17);
            this.filledButton.TabIndex = 1;
            this.filledButton.TabStop = true;
            this.filledButton.Text = "Filled";
            this.filledButton.UseVisualStyleBackColor = true;
            // 
            // regularButton
            // 
            this.regularButton.AutoSize = true;
            this.regularButton.Location = new System.Drawing.Point(198, 56);
            this.regularButton.Name = "regularButton";
            this.regularButton.Size = new System.Drawing.Size(62, 17);
            this.regularButton.TabIndex = 2;
            this.regularButton.TabStop = true;
            this.regularButton.Text = "Regular";
            this.regularButton.UseVisualStyleBackColor = true;
            // 
            // sprinklesBox
            // 
            this.sprinklesBox.AutoSize = true;
            this.sprinklesBox.Location = new System.Drawing.Point(26, 205);
            this.sprinklesBox.Name = "sprinklesBox";
            this.sprinklesBox.Size = new System.Drawing.Size(69, 17);
            this.sprinklesBox.TabIndex = 3;
            this.sprinklesBox.Text = "Sprinkles";
            this.sprinklesBox.UseVisualStyleBackColor = true;
            // 
            // syrupBox
            // 
            this.syrupBox.AutoSize = true;
            this.syrupBox.Location = new System.Drawing.Point(26, 237);
            this.syrupBox.Name = "syrupBox";
            this.syrupBox.Size = new System.Drawing.Size(53, 17);
            this.syrupBox.TabIndex = 4;
            this.syrupBox.Text = "Syrup";
            this.syrupBox.UseVisualStyleBackColor = true;
            // 
            // sugarBox
            // 
            this.sugarBox.AutoSize = true;
            this.sugarBox.Location = new System.Drawing.Point(26, 269);
            this.sugarBox.Name = "sugarBox";
            this.sugarBox.Size = new System.Drawing.Size(93, 17);
            this.sugarBox.TabIndex = 5;
            this.sugarBox.Text = "Powder Sugar";
            this.sugarBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toppings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bakery Goods";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(29, 341);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 9;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(184, 341);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(286, 420);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sugarBox);
            this.Controls.Add(this.syrupBox);
            this.Controls.Add(this.sprinklesBox);
            this.Controls.Add(this.regularButton);
            this.Controls.Add(this.filledButton);
            this.Controls.Add(this.productList);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.RadioButton filledButton;
        private System.Windows.Forms.RadioButton regularButton;
        private System.Windows.Forms.CheckBox sprinklesBox;
        private System.Windows.Forms.CheckBox syrupBox;
        private System.Windows.Forms.CheckBox sugarBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button exitButton;
    }
}

