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
            { items.Add(new CartItem(product)); }

        public void Delete(CartItem delItem)
        {
            items.Remove(delItem);
        }

        public CartItem this[int index]
        {
            get {
                if(index >= 0 && index < items.Count)
                    return items[index];
                else
                    throw new IndexOutOfRangeException();
            }
        }
        
        public CartItem[] getAll()
        { 
            return items.ToArray(); 
        }

    }
}
