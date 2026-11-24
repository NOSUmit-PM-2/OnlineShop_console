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

        public void Add(Product product)
        { 
            items.Add(new CartItem(product)); 
        }

        public bool Contains(Product product)
        {
            foreach (var item in items) 
            {
                if (item.Product == product)
                {
                    return true;
                }
            }
            return false;
        }

        public void Delete(int index)
        {
            items.RemoveAt(index);
        }
        public void AddCount(int index)
        {
            items[index].Count++;
        }

        public void MinusCount(int index)
        {
            if (items[index].Count > 0)
                items[index].Count--;
        }

        public CartItem[] getAll()
        { 
            return items.ToArray(); 
        }
    }
}
