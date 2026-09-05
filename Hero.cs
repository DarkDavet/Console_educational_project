using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{

    // БАЗОВЫЙ (РОДИТЕЛЬСКИЙ КЛАСС)
    public class Hero
    {
        // Public: свойства видны везде (и во внешних классах, и в наследниках)
        public string Name { get; set; }
        public int Health { get; set; }

        // Protected: скрыто от внешних классов, но доступно внутри классов-наследников
        protected int baseSpeed = 10;

        // Конструктор базового класса - срабатывает при создании объекта класса Hero
        public Hero(string name, int health)
        {
            Name = name;
            Health = health;
        }

        // Общий метод, который автоматически достанется всем потомкам
        public void ShowInfo()
        {
            Console.WriteLine($"[Герой] Имя: {Name} | Здоровье: {Health} ОЗ | Базовая скорость: {baseSpeed}"); //
        }

        // Переопределить метод Attack для Wizard, чтобы в консоль выводилось сообщение о запуске огненного шара
        // И чтобы обязательно в консоли писалось имя, кто запускает шар 
        // Создать объект класса Wizard в методе Main() класса Program
        // Вызвать через него методо Attack() и посмотреть правильность выполнения результата для мага
        public override void Attack()
        {
            Console.WriteLine($"{Name} читает заклинание и выпускает ОГНЕННЫЙ ШАР! 🔥");
        }
    }
}
