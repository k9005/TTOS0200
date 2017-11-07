using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Shoppingcart
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Shoppingcart(string name, double price)
        {
            Name = name;
            Price = price;
           
        }
    }
}
