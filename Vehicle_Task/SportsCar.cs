using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.Vehicle_Task
{
   
    public class SportsCar : Vehicle
    {
        public SportsCar(string model) : base(model) { }

      
        public override void StartEngine()
        {
            Console.WriteLine($"{Model} заводится с громким ревом.");
        }
    }
}
