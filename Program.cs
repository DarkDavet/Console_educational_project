using System.Text;
using Console_educational_project.Vehicle_Task ;
using Console_educational_project.SmartDevices;
namespace Console_educational_project

// Задание 1 : Создание робота-пылесоса
// Создай класс SmartVacuum (Умный пылесос), который наследуется от SmartDevice.
// Добавь ему уникальное свойство WaterTankCapacity (объём бака для воды в литрах, тип double).
// Напиши конструктор, который принимает бренд, мощность и объём бака, передавая нужные данные через base().
// Реализуй (переопредели через override) обязательный абстрактный метод PerformWork().
// Если пылесос включен (IsOn == true), пусть он выводит в консоль:
// "[Бренд] в работе, убирает дом. Объём бака для влажной уборки: [Объём] л.".
// Если выключен — сообщает, что питания нет.
// В классе SmartDevicesExecuter создай метод для выполнения команд с пылесосом
// Создай в этом методе пылесос любого бренда, включи его и запусти работу.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = Encoding.UTF8;
               
            }
           //rpgehecutor rpg = new  rpgehecutor();
           //rpg.ehecuterpheroes ();
           //cars car = new cars();
          // car.cars_2();
          SmartDevicesExecuter Device = new     SmartDevicesExecuter();
           Device.ExecuteSmartLamps();
           

            
        }
    }
}
