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

        public void Delete(int index)
        {  
            items.RemoveAt(index);
        }

        public CartItem[] getAll()
        { 
            return items.ToArray(); 
        }
    }
}
