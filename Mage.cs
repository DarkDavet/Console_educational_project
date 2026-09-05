using System;

namespace Console_educational_project
{
    public class Mage : Hero
    {
        public int Mana { get; set; }
        private int spellPower;

        public Mage(string name, int health, int mana, int spellPower) : base(name, health)
        {
            Mana = mana;
            this.spellPower = spellPower;
        }

        public void CastSpell()
        {
            if (Mana >= 10)
            {
                Mana -= 10;
                Console.WriteLine($"{Name} колдует заклинание Сила магии: {spellPower}. Осталось маны: {Mana}. Скорость: {baseSpeed}");
            }
            else
            {
                Console.WriteLine($"У {Name} недостаточно маны");
            }
        }
    }
}
