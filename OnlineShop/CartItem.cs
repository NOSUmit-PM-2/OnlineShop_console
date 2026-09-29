using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class CartItem
    {
        public Product ProductItem { get; set; }
        public int Count { get; set; }
        public CartItem(Product product) 
        { 
            ProductItem = product;
            Count = 1;
        }
        
    }
}
