 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.Vehicle_Task
{

    public class cars 
    {
 
      public void cars_2(){
 
 Vehicle ordinaryCar = new Vehicle("Обычный автомобиль");

        
            SportsCar ferrari = new SportsCar("Ferrari F40");

          
            ElectricCar tesla = new ElectricCar("Tesla Model S");

            
            HybridCar toyota = new HybridCar("Toyota Prius");

           

          
            ordinaryCar.StartEngine();
     

            ferrari.StartEngine();
            

            tesla.StartEngine();


            toyota.StartEngine();
      }
    }
}