using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    public class Warrior : Hero
    {
        // Уникальное свойство, которое есть ТОЛЬКО у Воина
        public int Armor { get; set; }

        // Конструктор наследника. 
        // Через ': base(...)' мы передаем имя и здоровье наверх — в конструктор родителя!
        public Warrior(string name, int health, int armor) : base(name, health)
        {
            Armor = armor; // Свое уникальное свойство заполняем сами
        }

        // Уникальный метод Воина
        public void BlockAttack()
        {
            // Обрати внимание: мы можем использовать baseSpeed, так как оно protected в Hero
            Console.WriteLine($"{Name} заблокировал удар щитом! Скорость в броне: {baseSpeed - 2}");
        }

        // Ключевое слово override заменяет родительский метод на этот
        // Если бы мы НЕ написали override, воин атаковал бы кулаками, как обычный Hero
        public override void Attack()
        {
            Console.WriteLine($"{Name} яростно бьёт мечом! ⚔️");
        }
    }
}
