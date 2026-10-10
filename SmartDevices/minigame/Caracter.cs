

namespace Minigame
{
    public  abstract  class Caracter
    {
        public string Name {get;set;}
        public int Health{get;set;}
        public int Damage{get;set;}

        public Caracter(string name,int health, int damage)
        {
            Name = name;
            Health=health;
            Damage=damage;
        }
        public abstract void Attack(Caracter target);
        
        
    }
    
}