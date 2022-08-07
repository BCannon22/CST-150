using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try   //Try to complete in the code.
            {


                double temperature;  //Sets variable for temperature.
                double fahrenheit;   //Sets variable for fahrenheit.

                fahrenheit = double.Parse(farenheitText.Text);   //Coverts textbox to a double variable so it can used in a math formula.

                temperature = (fahrenheit - 32) * .5556;   //Takes the number from textBox 1 and converts it into celsius.

                celsiusText.Text = temperature.ToString("n3");  //Displays the number in celsius in text box 2.
            }
            catch (Exception ex)   //If any errors appear it will catch it and output this messagebox. 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
