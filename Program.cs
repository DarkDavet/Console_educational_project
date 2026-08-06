using System;
using System.Text;

namespace Console_educational_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            ProductCatalog catalog = new ProductCatalog(); 
            
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n Меню интернет-магазина ");
                Console.WriteLine("1 — Показать товары");
                Console.WriteLine("2 — Добавить товар");
                Console.WriteLine("3 — Показать сумму");
                Console.WriteLine("4 — Фильтрация по категории");
                Console.WriteLine("0 — Выход");
                Console.Write("Выберите действие: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        catalog.PrintAllProducts(); 
                        break;
                    case "2":
                        catalog.AddProduct();
                        break;
                    case "3":
                        catalog.TotalPrice(); 
                        break;
                    case "4":
                        catalog.FilterCategory();
                        break;
                    case "0":
                        isRunning = false;
                        Console.WriteLine("Программа завершена");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод. Выберите 1, 2, 3, 4 или 0");
                        break;
                }
            }
        }
    }
}
