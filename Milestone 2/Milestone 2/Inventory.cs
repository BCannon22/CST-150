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
    class Inventory
    {
        public List<Product> ProductList { get; set; }   //Creates a list to hold products.

        public Inventory()
        {
            ProductList = new List<Product>();
        }
        public void AddItem(Product product)    //Adds an item to inventory.
        {
            ProductList.Add(product);
            Console.WriteLine($"Product {product.Name} with ID of #{product.Id} was added.");
        }

        public void RemoveItem(Product product)    //Removes an item from inventory.
        {
            ProductList.Remove(product);
            Console.WriteLine($"Product {product.Name} with ID of #{product.Id} was removed.");
        }

        public void DisplayList()    //shows current inventory.
        {
            foreach (var product in ProductList)
            {
                Console.WriteLine($"Product: ID #{product.Id}, Name: {product.Name}, Price:${product.Price}, Quantity:{product.Quantity}");
            }
        }
    }
}