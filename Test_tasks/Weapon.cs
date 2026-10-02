using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.Test_tasks
{
    abstract class Weapon
    {
        public Fire()
        {
            Console.WriteLine("Выстрел!");
        }

        public abstract void Reload()
        {
            Console.WriteLine("Перезарядка");
        }
    }
}
