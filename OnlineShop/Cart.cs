using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Cart
    {
        List<CartItem> items;

        public void Add(Product product)
            { items.Add(new CartItem(product)); }

        public void Delete()
            {  }

        public CartItem[] getAll()
            { return items.ToArray(); }

    }
}
