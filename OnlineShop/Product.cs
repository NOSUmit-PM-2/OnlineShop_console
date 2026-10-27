using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Product
    {
        //int Id { get; }
        //static int article = 0;

        Guid Id { get; }

        public decimal Price { get; }
        public string Name { get; }
        public string Description { get; }

        public Product(string name, decimal price, string description)
        {
            Id = Guid.NewGuid();
            Price = price;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Id}: {Name} ({Description} - {Price})";
        }
    }
}
