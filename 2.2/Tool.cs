using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project._2._2
{
    internal class Tool
    {
        public virtual string Playmusic() {

            return "Проигрывает звук";
            
          }
        public void Print()
        {
            Console.WriteLine($" {Playmusic()} ");
        }

    }
}
