using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Count { get; set; }
        public CartItem(Product product) 
        { 
            this.Product = product;
            this.Count = 1;
        }
        
        public override string ToString()
        {
            return $"{Product.Name} количество {Count} цена {Count * Product.Price}";
        }

    }
}
