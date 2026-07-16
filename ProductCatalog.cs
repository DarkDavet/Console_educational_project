using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
     public class ProductCatalog
     {
        private List<Product> shopCart = new List<Product>
        {
            new Product { Name = "Ноутбук", Price = 70000, Category = "Электроника" },
            new Product { Name = "Мышка", Price = 3000, Category = "Аксессуары" },
            new Product { Name = "Клавиатура", Price = 5000, Category = "Аксессуары" }
        };
     }
}
