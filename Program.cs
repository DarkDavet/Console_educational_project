using System.Text;

namespace Console_educational_project
{
    internal class Program
    {
        // Задание:
        // Создать класс мага
        // Добавить магу уникальное свойство Mana.
        // В методе Main создать объекты Warrior и Wizard.
        // Вызвать у обоих унаследованный метод ShowInfo().
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
