using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.Vehicle_Task
{
    // НАСЛЕДНИК 1
    public class SportsCar : Vehicle
    {
        public SportsCar(string model) : base(model) { }

        // TODO: ПЕРЕОПРЕДЕЛИ метод StartEngine. 
        // Пусть он выводит: "[Model] заводится с громким ревом"
    }
}
