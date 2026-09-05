using System;

namespace Console_educational_project
{
    public class Mage : Hero
    {
        public int Mana { get; set; }
        private int _spellPower;

        public Mage(string name, int health, int mana, int spellPower) : base(name, health)
        {
            Mana = mana;
            _spellPower = spellPower;
        }

        public override void Attack()
        {
            if (Mana >= 15)
            {
                Mana -= 15;
                Console.WriteLine($"{Name} выпускает огненный шар силой {_spellPower} Осталось маны: {Mana}.");
            }
            else
            {
                
                base.Attack();
            }
        }
    }
}
