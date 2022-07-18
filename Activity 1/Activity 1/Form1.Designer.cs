namespace Activity_1
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
            this.components = new System.ComponentModel.Container();
            this.btnClickThis = new System.Windows.Forms.Button();
            this.SubmitComplete = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MaleCheck = new System.Windows.Forms.CheckBox();
            this.UserDetails = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FemaleCheck = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(18, 225);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(75, 23);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Submit";
            this.toolTip2.SetToolTip(this.btnClickThis, "Submit form.");
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // SubmitComplete
            // 
            this.SubmitComplete.AutoSize = true;
            this.SubmitComplete.Location = new System.Drawing.Point(99, 230);
            this.SubmitComplete.Name = "SubmitComplete";
            this.SubmitComplete.Size = new System.Drawing.Size(0, 13);
            this.SubmitComplete.TabIndex = 1;
            this.SubmitComplete.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 2;
            this.toolTip2.SetToolTip(this.textBox1, "Enter your first name.");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MaleCheck
            // 
            this.MaleCheck.AutoSize = true;
            this.MaleCheck.Location = new System.Drawing.Point(279, 54);
            this.MaleCheck.Name = "MaleCheck";
            this.MaleCheck.Size = new System.Drawing.Size(49, 17);
            this.MaleCheck.TabIndex = 3;
            this.MaleCheck.Text = "Male";
            this.MaleCheck.UseVisualStyleBackColor = true;
            this.MaleCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // UserDetails
            // 
            this.UserDetails.AutoSize = true;
            this.UserDetails.Location = new System.Drawing.Point(15, 18);
            this.UserDetails.Name = "UserDetails";
            this.UserDetails.Size = new System.Drawing.Size(64, 13);
            this.UserDetails.TabIndex = 5;
            this.UserDetails.Text = "User Details";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(15, 54);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 6;
            this.FirstName.Text = "First Name";
            this.toolTip2.SetToolTip(this.FirstName, "Enter your first name.");
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(15, 85);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 7;
            this.LastName.Text = "Last Name";
            this.toolTip2.SetToolTip(this.LastName, "Enter your last name.");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 8;
            this.toolTip2.SetToolTip(this.textBox2, "Enter your last name.");
            // 
            // FemaleCheck
            // 
            this.FemaleCheck.AutoSize = true;
            this.FemaleCheck.Location = new System.Drawing.Point(279, 87);
            this.FemaleCheck.Name = "FemaleCheck";
            this.FemaleCheck.Size = new System.Drawing.Size(60, 17);
            this.FemaleCheck.TabIndex = 9;
            this.FemaleCheck.Text = "Female";
            this.FemaleCheck.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.toolTip2.SetToolTip(this.dateTimePicker1, "Select date of submission. ");
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 311);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FemaleCheck);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.UserDetails);
            this.Controls.Add(this.MaleCheck);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClickThis);
            this.Controls.Add(this.SubmitComplete);
            this.Name = "Form1";
            this.Text = "Activity 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label SubmitComplete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox MaleCheck;
        private System.Windows.Forms.Label UserDetails;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox FemaleCheck;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

