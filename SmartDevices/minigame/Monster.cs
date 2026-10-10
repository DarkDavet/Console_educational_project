namespace Minigame
{
    public class Monster: Caracter
    {
        public Monster(string name, int health, int damage): base(name, health, damage){}
        public override void Attack(Caracter target)
        {
             target.Health = target.Health - Damage;
            Console.Writeln($"{Name} ударил {target.Name} и нанес {Damage} урона , у {target.Name} осталось {target.Health} hp");
        }
        
    }
}