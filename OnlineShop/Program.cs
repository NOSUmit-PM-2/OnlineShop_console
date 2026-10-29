using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Program
    {
        static Catalog catalog = new Catalog();
        static void ShowCatalog()
        {
            int i = 0;
            foreach(Product product in catalog.getAll())
                Console.WriteLine($"{++i} {product}");
        }

        static void ShowCurrentCart(Cart cart)
        { 
            if (cart.Count == 0)
                Console.WriteLine("Корзина пуста");
            foreach (CartItem item in cart.getAll())
            {
                Console.WriteLine($"{item.Product}\t-\t{item.Count}");
            }
        }

        static void Main(string[] args)
        {
            catalog.Add(new Product("Вертолет", 100, "игрушка веселая" ));
            catalog.Add(new Product("Майка", 1005, "с принтом"));
            catalog.Add(new Product("Тапки", 250, "пляжные"));
            catalog.Add(new Product("Тетрадь", 17, "по информатике"));

            ShowCatalog();
            Console.WriteLine("Введите номер  товара");
            int ind = Convert.ToInt32(Console.ReadLine());

            Cart currentUserCart = new Cart();


            try
            {
                Product product = catalog[ind];

                currentUserCart.Add(product);
                ShowCurrentCart(currentUserCart);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
