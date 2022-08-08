using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2
{
    class Inventory
    {
         public static List<Product> ProductList { get; set; }

        static Inventory()
        {
            ProductList = new List<Product>();
        }
        public void AddItem(Product product)
        {
            ProductList.Add(product);
        }

        public void RemoveItem(Product product)
        {
            ProductList.Remove(product);
        }
    }
}