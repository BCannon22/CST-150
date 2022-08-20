﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Milestone_4
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
            
            int id = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            decimal price = decimal.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);

            var product = new InventoryItem(id, name, price, quantity); 

            inventory.AddItem(product);

            productListBox.Items.Clear();
            inventory.DisplayList(productListBox);
        }

        private void removeButton_Click(object sender, EventArgs e)     //Button for removing an item from the productListBox
        {
            int id = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            decimal price = decimal.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);
            
            var product = new InventoryItem(id, name, price, quantity);

            inventory.RemoveItem(product);

            productListBox.Items.Clear();
            inventory.DisplayList(productListBox);
        }

        private void updateButton_Click(object sender, EventArgs e)    //Button for updating an item within the productListBox
        {
            int id = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            decimal price = decimal.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);

            var product = new InventoryItem(id, name, price, quantity);

            inventory.UpdateProduct(product);

            productListBox.Items.Clear();
            inventory.DisplayList(productListBox);
        }

        private void searchButton_Click(object sender, EventArgs e)       //Button for searching for an item within the productListBox
        {
            int id = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            decimal price = decimal.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);

            var product = new InventoryItem(id, name, price, quantity);

            productListBox.Items.Clear();
            inventory.SearchProduct(productListBox, product);                      
        }

        private void exitButton_Click(object sender, EventArgs e)   //Exit button for application 
        {
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
        }
    }
}
