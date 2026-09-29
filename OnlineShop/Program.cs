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
        static void Show()
        {
            int i = 0;
            foreach(Product product in catalog.getAll())
                Console.WriteLine($"{++i} {product}");
        }
        static void Main(string[] args)
        {
            catalog.Add(new Product("Вертолет", 100, "игрушка веселая" ));
            catalog.Add(new Product("Майка", 1005, "с принтом"));
            catalog.Add(new Product("Тапки", 250, "пляжные"));
            catalog.Add(new Product("Тетрадь", 17, "по информатике"));

            Show();
            Console.WriteLine("Введите номер  товара");
            int ind = Convert.ToInt32(Console.ReadLine());

        }
    }
}
