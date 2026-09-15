using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
   public class rpgehecutor
    {
        
     public void ehecuterpheroes ()
        {
            
            Warrior warrior_1 = new Warrior("11", 2, 3);
            warrior_1.ShowInfo();
            warrior_1.BlockAttack();
            warrior_1.Attack();

             Mage mage_1=new Mage("1",2,3,4);
             mage_1.Attack();

            Hero hero_the_best = new Hero("John", 1);
            hero_the_best.Attack();


        }
    }
}