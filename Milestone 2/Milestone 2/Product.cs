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
    class Product
    {
        public int Id { get; set; }         //Getter and Setters for obtaining values/strings.
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(int Id, string Name, decimal Price, int Quantity)   //Constructs object.
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}