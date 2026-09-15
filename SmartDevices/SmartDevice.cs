using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.SmartDevices
{
    public abstract class SmartDevice
    {
        public string Brand { get; set; }
        public int PowerConsumption { get; set; } 
        public bool IsOn { get; private set; }    

        public SmartDevice(string brand, int power)
        {
            Brand = brand;
            PowerConsumption = power;
            IsOn = false; 
        }

        // ОБЫЧНЫЙ МЕТОД (уже реализован, одинаков для всех)
        public void TogglePower()
        {
            IsOn = !IsOn;
            string status = IsOn ? "ВКЛЮЧЕН" : "ВЫКЛЮЧЕН";
            Console.WriteLine($"[{Brand}] Теперь устройство {status}.");
        }

        // АБСТРАКТНЫЙ МЕТОД
        // Все приборы работают по-разному. Метод не имеет тела {}, только сигнатуру.
        public abstract void PerformWork();
    }
}
