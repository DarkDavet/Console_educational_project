using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.Vehicle_Task
{
    // НАСЛЕДНИК 2
    // TODO: УНАСЛЕДУЙ этот класс от класса Vehicle
    public class ElectricCar: Vehicle
    {
        public ElectricCar(string model) : base(model) { }

        // TODO: ПЕРЕОПРЕДЕЛИ метод StartEngine. 
        // Пусть он выводит: "[Model] заводится бесшумно."
    }
}
