using System;

namespace Console_educational_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
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
}
