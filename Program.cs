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
        }
    }
}
