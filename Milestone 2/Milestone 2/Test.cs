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
            var donut = new InventoryItem(12, "Donut", 5.00m, 1);   //Creates products from the InventoryItem class
            var tea = new InventoryItem(11, "Tea", 2.50m, 2);
            Console.WriteLine($"New product id #{donut.Id} was created for {donut.Name}, for a price of ${donut.Price}, and {donut.Quantity} was added.");
            Console.WriteLine($"New product id #{tea.Id} was created for {tea.Name}, for a price of ${tea.Price}, and {tea.Quantity} was added.");
            Console.ReadLine();


            var inventory = new InventoryManager();   //calls for inventory manager class
            
            inventory.AddItem(donut);  //adds item to inventory.
            Console.WriteLine("Current Inventory is:");
            inventory.DisplayList(); //shows current inventory.
            Console.ReadLine();

            inventory.AddItem(tea);
            Console.WriteLine("Current Inventory is:");
            inventory.DisplayList(); 
            Console.ReadLine();

            inventory.RemoveItem(donut);  //Removes item from inventory.
            Console.WriteLine("Current Inventory is:");
            inventory.DisplayList(); //shows current inventory.
            Console.ReadLine();
        }
    }
}
