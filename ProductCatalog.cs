using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    /*
         Задание «Каталог товаров в интернет-магазине»:
        1) Создай класс Product (Товар), у которого будут три поля: Name (название), Price (цена) и Category (категория).
        2) Создай класс ProductCatalog. В нём создай список товаров List<Product> shopCart.
        3) Добавь в список 3 любых товара (например, Ноутбук за 70000, Мышка за 3000, Клавиатура за 5000),используя синтаксис инициализации объектов (например: new Product { Name = "...", Price = ... }).
        4) Напиши цикл foreach, который перебирает корзину и выводит в консоль информацию о каждом товаре в формате: "Товар: [Название], Цена: [Цена] руб.".
        5) Посчитай и выведи общую стоимость всех товаров в корзине.
        6) В классе Program, в методе Main создай объект класса ProductCatalog.
        7) Вызови через этот объект методы вывода информации о товарах и подсчёта общей стоимости, чтобы посмотреть результат в окне консоли

        8) (Интерактивное меню): Оформи метод Main так, чтобы программа не закрывалась сразу, 
        а предлагала пользователю выбор действий через консоль (1 — Показать товары, 2 — Добавить товар, 3 — Показать сумму, 0 — Выход).
        9) 10 (Фильтрация): Напиши метод, который выводит товары только определенной категории, введенной пользователем. 
         // prod.Category.Equals(searchCategory)
        */
    public class ProductCatalog
    {
        private List<Product> shopCart = new List<Product>
        {
            new Product { Name = "Ноутбук", Price = 70000, Category = "Электроника" },
            new Product { Name = "Мышка", Price = 3000, Category = "Аксессуары" },
            new Product { Name = "Клавиатура", Price = 5000, Category = "Аксессуары" }
        };

        public void PrintAllProducts()
        {
            foreach (Product prod in shopCart)
            {
                Console.WriteLine($"Товар: {prod.Name}, Цена: {prod.Price} руб. [{prod.Category}]");
            }
        }
        public void TotalPrice()
        {
            decimal total = 0;
    
            foreach (var product in shopCart)
            {
                total += product.Price;
            }

            Console.WriteLine($"Общая стоимость всех товаров: {total} руб.");
        }
        public void AddProduct()
        {
            Console.Write("Введите название товара ");
            string name = Console.ReadLine();

            Console.Write("Введите цену товара ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                Console.WriteLine(" Неверный формат цены");
                return;
            }

            Console.Write("Введите категорию товара ");
            string category = Console.ReadLine();

            shopCart.Add(new Product { Name = name, Price = price, Category = category });
            Console.WriteLine("Товар добавлен");
        }
    }
}
