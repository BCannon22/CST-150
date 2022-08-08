using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double FatCaloriesCalc(double value)   //Method for calculating Fat Grams to calories which accepts arguments.
        {
            return value * 9;
        }

        private double CarbCaloriesCalc(double value)   //Method for calculating Carb Grams to calories which accepts arguments.
        {
            return value * 4;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double fatCalories, carbCalories;   //Decalring variables to hold fat and carb calories values.

            if (double.TryParse(fatGramsInput.Text, out fatCalories))   //Gets value for Fat Grams
            {
                if (double.TryParse(carbGramsInput.Text, out carbCalories))  //Gets value for Carb Grams
                {
                    fatCalories = FatCaloriesCalc(fatCalories);   //Calls method to calulate Fat grams to fat calories.
                    fatCalOutput.Text = fatCalories.ToString("n2"); //Outputs the result. 

                    carbCalories = CarbCaloriesCalc(carbCalories);
                    carbCalOutput.Text = carbCalories.ToString("n2");
                }
                else
                {
                    MessageBox.Show("Enter a valid number for Carb Grams.");  //Shows when incorrect value is put into textbox.
                }
            }
            else
            {
                MessageBox.Show("Enter a valid number for Fat Grams");
            }
        }
    }
}
