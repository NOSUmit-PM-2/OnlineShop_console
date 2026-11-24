
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop
{
    public class Cart
    {
        List<CartItem> items = new List<CartItem>();

        public int Count
        {
            get { return items.Count; }
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

        public void Increase(int index)
        {
            items[index].Count++;
        }

        public void Decrease(int index)
        {
            items[index].Count--;

            if (items[index].Count == 0)
            {
                items.RemoveAt(index);
            }
        }

        public decimal GetTotal()
        {
            decimal sum = 0;

            foreach (CartItem item in items)
            {
                sum += item.Product.Price * item.Count;
            }

            return sum;
        }

        public CartItem[] getAll()
        {
            return items.ToArray();
        }
    }
}
