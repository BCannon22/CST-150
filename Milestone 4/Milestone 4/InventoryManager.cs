using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_4
{
    class InventoryManager
    {
        public List<InventoryItem> ProductList { get; set; }   //Creates a list to hold products.

        public InventoryManager()
        {
            ProductList = new List<InventoryItem>();
        }
        public void AddItem(InventoryItem product)    //Adds an item to inventory.
        {        
            ProductList.Add(product);           
        }

        public void RemoveItem(InventoryItem product)    //Removes an item from inventory.
        {
            foreach(InventoryItem item in ProductList)
            {
                if (item.Name.Equals(product.Name, StringComparison.CurrentCultureIgnoreCase) || item.Id.Equals(product.Id))
                {
                    ProductList.Remove(item);
                    break;
                }
            }        
        }

        public void DisplayList(System.Windows.Forms.ListBox productListBox)    //shows current inventory.
        {         
            foreach (var product in ProductList)
            {
                productListBox.Items.Add($"ID #{product.Id}, Name: {product.Name}, Price: ${product.Price}, Quantity: {product.Quantity}");
            }   
        }

        public void UpdateProduct(InventoryItem product)    //Updates an item.
        {
            foreach(InventoryItem item in ProductList)
            {
                if (item.Name.Equals(product.Name, StringComparison.CurrentCultureIgnoreCase) || item.Id.Equals(product.Id))
                {
                    item.Id = product.Id;
                    item.Name = product.Name;
                    item.Price = product.Price;
                    item.Quantity = product.Quantity;                   
                }
            }
        }

        public void SearchProduct(System.Windows.Forms.ListBox productListBox, InventoryItem product)    //Searches for an item based on id and name.
        {
            foreach (InventoryItem item in ProductList)
            {
                if (item.Name.Equals(product.Name, StringComparison.CurrentCultureIgnoreCase) || item.Id.Equals(product.Id))
                {
                    productListBox.Items.Add($"ID #{product.Id}, Name: {product.Name}, Price: ${product.Price}, Quantity: {product.Quantity}");
                    break;
                }
            }
        }
    }
}
