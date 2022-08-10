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
    class Test
    {
        static void Main(string[] args)
        {
            var lightbulb = new Product(12, "Lightbulb", 5.00m, 1);   //Creates product from the product class
            Console.WriteLine($"New product id #{lightbulb.Id} was created for {lightbulb.Name}, for a price of ${lightbulb.Price}, and {lightbulb.Quantity} was added.");
            Console.ReadLine();


            var inventory = new Inventory();   //calls for inventory class
            
            inventory.AddItem(lightbulb);  //adds item to inventory.
            inventory.DisplayList(); //shows current inventory.
            Console.ReadLine();

            inventory.RemoveItem(lightbulb);  //Removes item from inventory.
            inventory.DisplayList(); //shows current inventory.
            Console.ReadLine();
        }
    }
}
