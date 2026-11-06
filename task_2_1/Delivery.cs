using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.task_2_1
{
    internal class Delivery
    {
        public int GetCost()
        {
            return 30;
        }
        public void Print()
        {
            Console.WriteLine($"Доставка: {GetCost()} руб.");
        }
    }
}
