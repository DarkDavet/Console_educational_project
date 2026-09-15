using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.SmartDevices
{
    public class SmartLamp : SmartDevice
    {
        public string Color { get; set; }

        public SmartLamp(string brand, int power, string color) : base(brand, power)
        {
            Color = color;
        }

        // ОБЯЗАТЕЛЬНАЯ реализация абстрактного метода родителя
        public override void PerformWork()
        {
            if (IsOn)
            {
                Console.WriteLine($"💡 [{Brand}] Лампа включеная и светит цветом {Color}, потребляя {PowerConsumption} Вт.");
            }
            else
            {
                Console.WriteLine($"❌ [{Brand}] Лампа выключена. Сначала включи её через TogglePower()!");
            }
        }
    }
}
