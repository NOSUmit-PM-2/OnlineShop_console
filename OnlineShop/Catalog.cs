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
        int article;

        public Product this[int index]
        {
            //get 
            //{
            //    index--;
            //    if (index >= 0 && index < listProducts.Count)
            //        return listProducts[index]; 
            //    return null;
            //}

            get
            {
                index--;
                if (index >= 0 && index < listProducts.Count)
                    return listProducts[index]; 
                throw new IndexOutOfRangeException();    
            }

            //set { ... }
        }

        public void Add(Product product)
        { 
            article++;
            listProducts.Add(product);
        }

        public Product[] getAll()
        {
            return listProducts.ToArray();
        }

    }
}
