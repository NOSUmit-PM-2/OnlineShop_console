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

        public int Count 
        {
            get
            {
                int totalCount = 0;
                foreach (CartItem item in items)
                {
                    totalCount += item.Count;
                }
                return totalCount;
            }
            
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalSum = 0;
                foreach (CartItem item in items)
                {
                    totalSum += item.Product.Price * item.Count;
                }
                return totalSum;
            }
        }

        public void Add(Product product)
        {
            foreach (CartItem item in items)
            {
                if (item.Product.Name == product.Name)
                {
                    item.Count++;
                    return;
                }
            }
            items.Add(new CartItem(product));
        }

        public void Delete(Product product)
        {
            CartItem itemToDelete = null;
            foreach (CartItem item in items)
            {
                if (item.Product.Name == product.Name)
                {
                    if (item.Count > 1)
                    {
                        item.Count--;
                        return;
                    }
                    else
                    {
                        itemToDelete= item;
                        break;
                    }
                        
                }
            }
            if (itemToDelete != null)
            {
                items.Remove(itemToDelete);
            }
            
        }
        public CartItem[] getAll()
            { return items.ToArray(); }

    }
}
