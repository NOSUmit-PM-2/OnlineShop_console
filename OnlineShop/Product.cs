using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Product
    {
        public decimal Price { get; }
        public string Name { get; }
        public string Description { get; }

        public Product(string name, decimal price, string description)
        {
            Price = price;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name} ({Description} - {Price})";
        }
    }
}
