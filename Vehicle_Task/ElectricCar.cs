using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.Vehicle_Task
{

    public class ElectricCar : Vehicle
    {
        public ElectricCar(string model) : base(model) { }

      
        public override void StartEngine()
        {
            Console.WriteLine($"{Model} заводится бесшумно.");
        }
    }
}
