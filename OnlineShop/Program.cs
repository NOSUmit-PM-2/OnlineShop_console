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
            catalog.Add(new Food("Молоко", 120, "ergerge", "10.10.2026", 10));

            ShowCatalog();
            Console.WriteLine("Введите номер  товара");
            int ind = Convert.ToInt32(Console.ReadLine());

            //Food f = (Food)catalog[ind];
            if (catalog[ind] is Food)
            {
                Food f = catalog[ind] as Food;
                Console.WriteLine(f.ExpirationDate);
            }

            //Cart currentUserCart = new Cart();
            // это плохо 
            //Product product = catalog.getAll()[ind];

            //Product product = catalog[ind];
            //if (product == null)
            //    Console.WriteLine("Аккуратно введите правильный номер");
            //else
            //{
            //    currentUserCart.Add(product);
            //    ShowCurrentCart(currentUserCart);
            //}

            //try
            //{
            //    Product product = catalog[ind];

            //    currentUserCart.Add(product);
            //    ShowCurrentCart(currentUserCart);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
