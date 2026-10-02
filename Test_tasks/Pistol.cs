using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.Test_tasks
{
    class Pistol : Weapon
    {
          public override void  Reload()
        {
            Console.WriteLine("Пистолет перезаряжен.");
        }
    }
}
