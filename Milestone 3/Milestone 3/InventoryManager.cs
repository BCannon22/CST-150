using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.ComponentModel;

namespace Milestone_2
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
            Console.WriteLine($"Product {product.Name} with ID of #{product.Id} was added.");
        }

        public void RemoveItem(InventoryItem product)    //Removes an item from inventory.
        {
            ProductList.Remove(product);
            Console.WriteLine($"Product {product.Name} with ID of #{product.Id} was removed.");
        }

        public void DisplayList()    //shows current inventory.
        {
            foreach (var product in ProductList)
            {
                Console.WriteLine($"ID #{product.Id}, Name: {product.Name}, Price:$ {product.Price}, Quantity: {product.Quantity}");
            }
        }

        public void UpdateProduct(InventoryItem product)    //Updates an item.
        {
            product.Quantity = 0;
            product.Price = 0;
            Console.WriteLine($"Updated: ID #{product.Id}, Name: {product.Name}, Price:$ {product.Price}, Quantity: {product.Quantity}");
        }

        public void SearchProduct(InventoryItem product)    //Searches for an item based on id and name.
        {           
            foreach(InventoryItem item in ProductList)
            {
                if(item.Name.Equals(product.Name, StringComparison.CurrentCultureIgnoreCase) || item.Id.Equals(product.Id))
                {
                    Console.WriteLine($"Found ID#{product.Id}, Name: {product.Name}, Price:$ {product.Price}, Quantity: {product.Quantity}");
                    break;
                }
            }
        }
    }
}
