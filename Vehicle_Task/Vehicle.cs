using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.Vehicle_Task
{
    // БАЗОВЫЙ КЛАСС
    public class Vehicle
    {
        public string Model { get; set; }
        public Vehicle(string model)
        {
            Model = model;
        }

        // TODO: Сделай этот метод ВИРТУАЛЬНЫМ
        public void StartEngine()
        {
            Console.WriteLine("Двигатель заведен.");
        }
    }
}
