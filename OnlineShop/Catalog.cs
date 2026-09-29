using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Catalog
    {
        List<Product> listProducts = new List<Product>();

        public void Add(Product product)
        { 
            listProducts.Add(product);
        }

        public Product[] getAll()
        {
            return listProducts.ToArray();
        }

    }
}
