using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public void OrderForm_Load(object sender, EventArgs e)
        {
            List<string> nameList = new List<string>();     //Creates an array list to hold the various items.

            nameList.Add("Donuts");
            nameList.Add("Cupcakes");
            nameList.Add("Pancakes");

            foreach (string name in nameList)    //Displays items in the product list box for selection.
            {
                productList.Items.Add(name);
            }
        }
        private void orderButton_Click(object sender, EventArgs e)
        {

            if (productList.SelectedItem == null)         //Incase the user doesn't select an item in the listbox, it throws an error message and allows the program to keep running.
            {
                MessageBox.Show("Please select an item");
                return;
            }
            string product = productList.SelectedItem.ToString();          //strings the item that is selected in the product list box to a variable for the program to use.

            if (regularButton.Checked)               //Logic for output if regular radion button was choosen
            {
                if (sprinklesBox.Checked && syrupBox.Checked && sugarBox.Checked)
                {
                MessageBox.Show("You have ordered " + product + " with sprinkles, syrup, and powder sugar.");
                }
                else if (sprinklesBox.Checked && syrupBox.Checked)
                {
                MessageBox.Show("You have ordered " + product + " with sprinkles and syrup");
                }
                else if (syrupBox.Checked && sugarBox.Checked)
                {
                MessageBox.Show("You have ordered " + product + " with syrup, and powder sugar.");
                }
                else if (sprinklesBox.Checked && sugarBox.Checked)
                {
                MessageBox.Show("You have ordered " + product + " with sprinkles and powder sugar.");
                }
                else if (sprinklesBox.Checked)
                {
                MessageBox.Show("You have ordered " + product + " with sprinkles");
                }
                else if (syrupBox.Checked)
                {
                 MessageBox.Show("You have ordered " + product + " with syrup");
                }
                else if (sugarBox.Checked)
                {
                MessageBox.Show("You have ordered " + product + " with sugar");
                }
                else
                {
                MessageBox.Show("You have ordered " + product);
                }

                }

            if (filledButton.Checked)          //Logic for output if filled radio button was choosen.
            {
                if (sprinklesBox.Checked && syrupBox.Checked && sugarBox.Checked)
                {
                    MessageBox.Show("You have ordered filled " + product + " with sprinkles, syrup, and powder sugar.");
                }
                else if (sprinklesBox.Checked && syrupBox.Checked)
                {
                    MessageBox.Show("You have ordered filled " + product + " with sprinkles and syrup");
                }
                else if (syrupBox.Checked && sugarBox.Checked)
                {
                    MessageBox.Show("You have ordered filled " + product + " with syrup, and powder sugar.");
                }
                else if (sprinklesBox.Checked && sugarBox.Checked)
                {
                    MessageBox.Show("You have ordered filled " + product + " with sprinkles and powder sugar.");
                }
                else if (sprinklesBox.Checked)
                {
                    MessageBox.Show("You have ordered filled " + product + " with sprinkles");
                }
                else if (syrupBox.Checked)
                {
                    MessageBox.Show("You have ordered filled " + product + " with syrup");
                }
                else if (sugarBox.Checked)
                {
                    MessageBox.Show("You have ordered filled " + product + " with sugar");
                }
                else
                {
                    MessageBox.Show("You have ordered filled " + product);
                }

            }
        }

        private void exitButton_Click(object sender, EventArgs e)  //Closes form
        {
            this.Close();
        }
    }
}
