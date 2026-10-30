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
                decimal sum = 0;
                foreach (CartItem item in items)
                {
                    sum += item.Product.Price * item.Count;
                }
                return sum;
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

        public void Delete(Product product)
        {
            CartItem found = null;
            foreach (CartItem item in items)
            {
                if (item.Product == product)
                {
                    found = item;
                    break;
                }
            }

            if (found != null)
            {
                found.Count--;
                if (found.Count <= 0)
                {
                    items.Remove(found);
                }
            }
        } 
        public CartItem[] getAll()
        {
            return items.ToArray(); 
        }
    }
}
