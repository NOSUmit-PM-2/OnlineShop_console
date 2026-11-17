using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class CatalogEnumerator : IEnumerator
    {
        List<Product> listProducts;

        public CatalogEnumerator(List<Product>  listProducts)
        {
            this.listProducts = listProducts;
        }
        public object Current 
        { 
            get { return listProducts[CurIndex]; } 
        }
        int CurIndex = -1;

        public bool MoveNext()
        {
            //CurIndex++;
            //if (CurIndex >= listProducts.Count)
            //{
            //    return false;
            //}
            //return true;

            CurIndex++;

            if (CurIndex >= listProducts.Count)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            CurIndex = 0;
        }
    }
    public class Catalog:IEnumerable
    {
        List<Product> listProducts =  new List<Product>();

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
            listProducts.Add(product);
        }

        public Product[] getAll()
        {
            return listProducts.ToArray();
        }

        public IEnumerator GetEnumerator()
        {
            return new CatalogEnumerator(listProducts);
        }
    }
}
