using System;
using System.Collections.Generic;

namespace Console_educational_project
{
    // Задача 1:  добавь класс Barrel (бочка, наследник GameItem ),
    // который можно ударить мечом. Прочность 20. Когда прочность падает до 0,
    // бочка пишет БАБАХ! или что-то в этом роде . 
    // Добавь бочку в список targets . Класс Sword менять нельзя.

    // Задача 2. Создай интерфейс IHealable с методом void Heal(int amount).
    // Пусть Player реализует и IDamageable, и IHealable . 
    // Здоровье игрока 100, выше 100 подняться не может, ниже 0 — не опускается.
    // Создай класс HealthPotion с методом Use(IHealable target) , который лечит на 25.
    // Ударь игрока мечом два раза, потом используй зелье.
    internal class Program
    {
        static void Main(string[] args)
        {
            Sword mysword= new Sword();

            List<IDamageable> targets = new List<IDamageable>();
            targets.Add(new Enemy("Троль"));
            targets.Add(new  WoodenBox()); 
            targets.Add(new  Door()); 
            targets.Add(new Barrel());
            foreach (IDamageable target in targets)
            {
                mysword.Attack(target);
            }

             IDamageable barrel_1 = new Barrel();
             mysword.Attack(barrel_1);
             mysword.Attack(barrel_1);

            Console.WriteLine();
            Console.WriteLine("Удар по одной цели с интерфейсом:");
            IDamageable target_concrete = new WoodenBox();
            Console.WriteLine(target_concrete.Health);
            mysword.Attack(target_concrete);
            Door door = new Door();
            mysword.Attack(door);
        }
    }
    abstract class BreakableObject()
    {
        public abstract void TakeDamage(int amount);
    }
    interface IFlyable
    {
        int Height {get; set;}
        void Fly();
    }

    interface IDamageable
    {
        int Health {get;}
        void TakeDamage(int amount); // метод: "меня можно ударить"
    }

    abstract class Character
    {
        public string Name;
        public Character(string name)
        {
            Name = name;
        }
        public abstract void Speak();
    }
    class Enemy: Character, IDamageable
    {
     public  int  Health {get;set;}
        public Enemy(string name): base(name){}
  
        public override void Speak()
        {
            Console.WriteLine( $"{Name} говорит");
        }
        public void TakeDamage(int amount)
        {
          Health= Health-amount;
          Console.WriteLine($"{ Name } получил урон! Прочность: {Health}");
        }
    }
        
    class Player: Character, IDamageable
    {
        public  int  Health {get;set;}
        public Player(string name): base(name){}
        public override void Speak()
        {
            Console.WriteLine( $"{Name} громко говорит");
        }

        public void TakeDamage(int amount)
        {
          Health= Health-amount;
          Console.WriteLine($"{ Name } получил урон! Прочность: {Health}");
        }
    }
    class GameItem
    {
        public string Title;
        public GameItem(string title)
        {
            Title = title;
        }
    }
 class WoodenBox : GameItem, IDamageable
    {
        public int Health {get; private set;} = 30;
          public  WoodenBox(): base ("Деревянный ящик")
        {
            
        }

        public void TakeDamage(int amount)
        {
          Health= Health-amount;
          Console.WriteLine($"{Title} получил урон! Прочность: {Health}");
        }
    }
    class Door : GameItem, IDamageable
    {
    public int Health { get; private set; } = 50;

    public Door() : base("Деревянная дверь")
    {
    }

    public void TakeDamage(int amount)
    {
        Health = Health - amount/2;
        if (Health < 0) Health = 0;
         Console.WriteLine($"{Title} еле получила урон! Прочность: {Health}");
    
    }
    }
    class Sword
    {
        public int Damage=15;
        public void Attack(IDamageable target)
        {
            Console.Write("Удар мечом");
            target.TakeDamage(Damage);
        }
    }
    class Barrel : GameItem, IDamageable
    {
    public int Health { get; private set; } = 20;

    public Barrel() : base("Деревянная бочка")
    {
    }

    public void TakeDamage(int amount)
    {
        Health = Health - amount;
        if (Health <= 0)
            {
             Health = 0;   
              Console.WriteLine("БАБАХ!");
            } 
         
    
    }
    }

}
