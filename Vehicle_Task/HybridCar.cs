using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.Vehicle_Task
{
    
   
    public class HybridCar : Vehicle
    {
        public HybridCar(string model) : base(model) { }

        
        public override void StartEngine()
        {
           
            base.StartEngine(); 
            
           
            Console.WriteLine($"{Model} переключился на электротягу.");
        }
    }
}
