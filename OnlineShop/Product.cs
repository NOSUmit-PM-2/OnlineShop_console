using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OnlineShop
{
    public class Product
    {
        //static int article = 0;
        //public int Id { get; }
        Guid Id { get; }
        public decimal Price { get; }
        public string Name { get; }
        public string Description { get; }

        public Product(string name, decimal price, string description)
        {
            //Id = article++;
            Id = Guid.NewGuid();
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
