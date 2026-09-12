using System.Text;

namespace Console_educational_project
{
    internal class Program
    {
        // Задание:
        // Создать класс мага, унаследовать от класса Hero
        // Добавить магу уникальное свойство Mana.
        // Создать конструктор по аналогии с классом Warrior
        // В методе Main создать объект Wizard.
        // Вызвать у него унаследованный метод ShowInfo().
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = Encoding.UTF8;
               
            }

            Warrior warrior_1 = new Warrior("11", 2, 3);
            warrior_1.ShowInfo();
            warrior_1.BlockAttack();
            warrior_1.Attack();

             Mage mage_1=new Mage("1",2,3,4);
             mage_1.Attack();

            Hero hero_the_best = new Hero("John", 1);
            hero_the_best.Attack();
            
             Vehicle ordinaryCar = new Vehicle("Обычный автомобиль");

        
            SportsCar ferrari = new SportsCar("Ferrari F40");

          
            ElectricCar tesla = new ElectricCar("Tesla Model S");

            
            HybridCar toyota = new HybridCar("Toyota Prius");

            Console.WriteLine("--- Запуск двигателей через точку --- \n");

          
            ordinaryCar.StartEngine();
            Console.WriteLine();

            ferrari.StartEngine();
            Console.WriteLine();

            tesla.StartEngine();
            Console.WriteLine();

            toyota.StartEngine();

            Console.ReadLine(); 
        }
    }
}
