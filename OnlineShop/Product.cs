using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Product
    {
        public decimal Price { get; }
        public string Name { get; }
        public string Description { get; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, string description)
        {
            Price = price;
            Name = name;
            Description = description;
            Quantity = 1;
        }

        public Product(string name, decimal price, string description, int quantity)
        {
            Price = price;
            Name = name;
            Description = description;
            Quantity = quantity;
        }


        public void IncreaseQuantity()
        {
            //if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
            Quantity ++;
        }

        public void DeincreaseQuantity()
        {
            Quantity --;
        }

        public override string ToString()
        {
            return $"{Name} ({Description} - {Price})";
        }
    }
}
