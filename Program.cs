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

    abstract class Character
    {
        public string Name;
        public Character(string name)
        {
            Name = name;
        }
        public abstract void Speak();
    }
    class Enemy: Character, BreakableObject
    {
        public Enemy(string name): base(name){}
        public override void Speak()
        {
            Console.WriteLine( $"{Name} говорит")
        }
        
    }
    class Player: Character
    {
        public Player(string name): base(name){}
        public override void Speak()
        {
            Console.WriteLine( $"{Name} громко говорит");
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
 class WoodenBox : GameItem
    {
          public  WoodenBox(): base ("Деревянный ящик")
        {
            
        }
    }
    
}
