using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Catalog
    {
        List<Product> listProducts = new List<Product>();

        public Product this[int index]
        {

            get
            {
                index--;
                if (index >= 0 && index < listProducts.Count)
                    return listProducts[index]; 
                throw new IndexOutOfRangeException();    
            }
        }

        public void Add(Product product)
        { 
            listProducts.Add(product);
        }

        public Product[] getAll()
        {
            return listProducts.ToArray();
        }
        public List<Product> ToList()
        {
            return new List<Product>(listProducts);
        }
        public int Count() 
        {  return listProducts.Count; }
        public void RemoveAt(int index)
        { listProducts.RemoveAt(index); }
    }
}
