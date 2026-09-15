using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.SmartDevices
{
    public class SmartDevicesExecuter
    {
        public void ExecuteSmartLamps()
        {
            Console.WriteLine(" Система умный\n");

            // SmartDevice device = new SmartDevice("Китай-Прибор", 100);  ---- объект абстрактного класса создавать нельзя !!!

            SmartLamp livingRoomLamp = new SmartLamp("Philips Hue", 9, "Тёплый белый");

            livingRoomLamp.PerformWork();

        }
    }
}
