using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SHOP_CHECK_PROG
{
    struct Shop_Check
    {
        public string nameShop;
        public DateTime timeN;
        public string cashier;
        public List<Product> Products;

        public struct Product
        {
            public string name;
            public int cost;
            public int kolich;
        }
        public void CheckInfo(string name,DateTime time,
            string nameCash)
        {
            Console.WriteLine("\t\t\t\t\tУниверсам \"" + name + "\"" +
                "\n\t\t\t\tСписок ваших покупок и прочая информация:" +
                "\n\t\t\t\tНазвание магазина: " + name + "\n\t\t\t\tВремя: " + time + 
                "\n\t\t\t\tИмя кассира: " + nameCash + 
                "\n\t\t\t\tТовары которые были куплены: \n");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Shop_Check shop = new Shop_Check();
            shop.nameShop = "Пупа и Лупа";
            shop.timeN = DateTime.Now;
            shop.cashier = "Васян Труба";
            shop.Products = new List<Shop_Check.Product>()
            {
                new Shop_Check.Product{name = "Хлеб Украинский",cost = 12, kolich = 1},
                new Shop_Check.Product{name = "Несквик", cost = 25, kolich = 3},
                new Shop_Check.Product{name = "Пиво Львiвське",cost = 30, kolich = 1}
            };
            shop.CheckInfo(shop.nameShop,shop.timeN,shop.cashier);
            int total = 0;
            foreach (var product in shop.Products)
            {
                Console.WriteLine("\t\t\t\tНаименование: " + product.name +
                    "\n\t\t\t\tЦена: " + product.cost +
                    "\n\t\t\t\tКоличество: " + product.kolich + "\n");
                total += product.cost * product.kolich;
            }
            Console.WriteLine("\t\t\tОбщая сумма, потраченная на товары: " + total + "грн" +
                "\n\t\t\tКоличество товаров: " + shop.Products.Count);
            Console.ReadKey();
        }
    }
}
