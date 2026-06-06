using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    public class MusicService
    {
        private Track? track_1;    // поле - переменная, которая объявляется на уровне класса,
                                   // доступно в любом месте класса и вне этого класса, если позволяет модификатор

        public void Register()
        {
       //   Track track_1 = new Track("Brutal", "GDragon");    если объявить переменную внутри метода,
       //                                                      то она будет доступна только в пределах этого метода

            track_1 = new Track("Brutal", "GDragon");

            Console.WriteLine($"Песня {track_1.Title} артиста {track_1.Artist} успешно зарегистрирована!");
        }
    }
}
