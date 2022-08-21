using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Milestone_5
{
    public partial class InventoryManagerForm : Form
    {
        private InventoryManager inventory = new InventoryManager();

        public InventoryManagerForm()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)    //Button for adding an item to the productListBox
        {           
            string name = nameTextBox.Text;           

            if (int.TryParse(idTextBox.Text, out int id))
            {
                if(decimal.TryParse(priceTextBox.Text, out decimal price))
                {
                    if(int.TryParse(quantityTextBox.Text, out int quantity))
                    {
                        if (string.IsNullOrEmpty(nameTextBox.Text))
                        {
                            MessageBox.Show("Please fill all fields");
                        }
                        else
                        {
                            var product = new InventoryItem(id, name, price, quantity); 

                            inventory.AddItem(product);

                            productListBox.Items.Clear();
                            inventory.DisplayList(productListBox);
                        }

                    }
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)     //Button for removing an item from the productListBox
        {
            string name = nameTextBox.Text;

            if (int.TryParse(idTextBox.Text, out int id))
            {
                if (decimal.TryParse(priceTextBox.Text, out decimal price))
                {
                    if (int.TryParse(quantityTextBox.Text, out int quantity))
                    {
                        if (string.IsNullOrEmpty(nameTextBox.Text))
                        {
                            MessageBox.Show("Please fill all fields");
                        }
                        else
                        {
                            var product = new InventoryItem(id, name, price, quantity);

                            inventory.RemoveItem(product);

                            productListBox.Items.Clear();
                            inventory.DisplayList(productListBox);
                        }

                    }
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)    //Button for updating an item within the productListBox
        {
            string name = nameTextBox.Text;

            if (int.TryParse(idTextBox.Text, out int id))
            {
                if (decimal.TryParse(priceTextBox.Text, out decimal price))
                {
                    if (int.TryParse(quantityTextBox.Text, out int quantity))
                    {
                        if (string.IsNullOrEmpty(nameTextBox.Text))
                        {
                            MessageBox.Show("Please have ID and Name typed in.");
                        }
                        else
                        {
                            var product = new InventoryItem(id, name, price, quantity);

                            inventory.UpdateProduct(product);

                            productListBox.Items.Clear();
                            inventory.DisplayList(productListBox);
                        }
                    }
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)       //Button for searching for an item within the productListBox
        {
            string name = nameTextBox.Text;

            if (int.TryParse(idTextBox.Text, out int id))
            {
                if (decimal.TryParse(priceTextBox.Text, out decimal price))
                {
                    if (int.TryParse(quantityTextBox.Text, out int quantity))
                    {
                        if (string.IsNullOrEmpty(nameTextBox.Text))
                        {
                            MessageBox.Show("Please fill all fields");
                        }
                        else
                        {
                            var product = new InventoryItem(id, name, price, quantity);
                          
                            productListBox.Items.Clear();
                            inventory.SearchProduct(productListBox, product);
                        }

                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)   //Exit button for application and saves products to file when save and exit button is clicked on.
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("ProductList.txt");
            foreach (var item in inventory.ProductList)
            {
                outputFile.WriteLine(string.Format("{0},{1},{2},{3}", item.Id.ToString(), item.Name, item.Price.ToString(), item.Quantity.ToString()));
                
            }
            outputFile.Close();
            this.Close();
        }
        
        private void InventoryManagerForm_Load(object sender, EventArgs e)   //boolean for login. Shows login form and if true enters inventory manager form.
        {         
            LoginForm loginForm = new LoginForm();
            loginForm.LoggedIn = false;
            loginForm.ShowDialog();

            if (!loginForm.LoggedIn)
            {
                this.Close();
                Application.Exit();
                return;
            }

            StreamReader inputFile;                   //Adds a predetermined product list to the Array List on load.
            inputFile = File.OpenText("ProductList.txt");
            string line;

            while ((line = inputFile.ReadLine()) != null)
            {
                string[] props = line.Split(',');
                string name = props[1];
                if (int.TryParse(props[0], out int id))
                {
                    if (decimal.TryParse(props[2], out decimal price))
                    {
                        if (int.TryParse(props[3], out int quantity))
                        {
                            var product = new InventoryItem(id, name, price, quantity);

                            inventory.AddItem(product);
                            productListBox.Items.Clear();
                            inventory.DisplayList(productListBox);                           
                        }
                    }
                }
            }
            inputFile.Close();
        }
    }
}

