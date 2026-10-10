 
 namespace Minigame
{
 public class Player : Caracter
{
   public Player(string name, int health, int damage): base(name, health, damage){} 
   public override void Attack(Caracter target)
        {
            target.Health = target.Health - Damage;
            Console.WriteLine($"{Name} ударил {target.Name} и нанес {Damage} урона , у {target.Name} осталось {target.Health} hp");
        }
       public void Heal()
        {
            Health+=20;
            Console.WriteLine($"{Name} полечился на 20 hp");
        }
}
}