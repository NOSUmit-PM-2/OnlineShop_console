using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Cart
    {
        List<CartItem> items = new List<CartItem>();

        public int Count { get {return items.Count();} }

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (CartItem item in items)
                    total += item.Sum;
                return total;
            }
        }

        public void Add(Product product)
        {
            foreach (CartItem item in items)
            {
                if (item.Product == product)
                {
                    item.Count++;
                    return;
                }
            }
            items.Add(new CartItem(product));
        }

        public void Increase(CartItem item)
        {
            item.Count++;
        }

        public void Decrease(CartItem item)
        {
            item.Count--;
            if (item.Count <= 0)
                items.Remove(item);
        }

        public void Delete(CartItem item)
        {
            items.Remove(item);
        }

        public CartItem[] getAll()
            { return items.ToArray(); }

    }
}
