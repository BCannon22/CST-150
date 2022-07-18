using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temperature;  //Sets variable for temperature.
            double fahrenheit;   //Sets variable for fahrenheit.
            
            fahrenheit = double.Parse(textBox1.Text);   //Coverts textbox to a double variable so it can used in a math formula.

            temperature = (fahrenheit - 32) * .5556;   //Takes the number from textBox 1 and converts it into celsius.

            textBox2.Text = temperature.ToString("n2");  //Displays the number in celsius in text box 2.

        }
    }
}
