
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.SmartDevices
{
    public class Smartvacuum : SmartDevice
    {
        public double Watertank { get; set; }

        public Smartvacuum(string brand, int power, double watertank) : base(brand, power)
        {
            Watertank = watertank;
        }

        // ОБЯЗАТЕЛЬНАЯ реализация абстрактного метода родителя
        public override void PerformWork()
        {
            if (IsOn)
            {
                Console.WriteLine($"💡 [{Brand}] Обьем оставшейся воды {watertank}, потребляет {PowerConsumption} Вт.");
            }
            else
            {
                Console.WriteLine($"❌ [{Brand}] робот пылесос выключен");
            }
        }
    }
}
