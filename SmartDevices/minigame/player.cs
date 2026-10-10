 
 namespace Minigame
{
 public class Player : Caracter
{
   public Player(string name, int health, int damage): base(name, health, damage){} 
   public override void Attack(Caracter target)
        {
            target.Health = target.Health - Damage;
            Console.Writeln($"{Name} ударил {target.Name} и нанес {Damage} урона");
        }
       public void Heal()
        {
            Health+=20;
            Console.Writeln($"{Name} полечился на 20 hp");
        }
}
}