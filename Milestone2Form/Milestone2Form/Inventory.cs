using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2Form
{
    internal class Inventory
    {
        List<Product> ProductList = new List<Product>();

        public void AddItem(Product product)
        {
            ProductList.Add(product);
        }
    }
}
