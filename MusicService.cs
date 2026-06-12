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
        private Track? track_2;    // Второе поле для нового трека
        private Track? track_3;    // Третье поле для нового трека

        public void Register()
        {
       //   Track track_1 = new Track("Brutal", "GDragon");    если объявить переменную внутри метода,
       //                                                      то она будет доступна только в пределах этого метода

            track_1 = new Track("Brutal", "GDragon");
            Console.WriteLine($"Песня {track_1.Title} артиста {track_1.Artist} успешно зарегистрирована!");

            track_2 = new Track("Yesterday", " Beatles");
            Console.WriteLine($"Песня {track_2.Title} артиста {track_2.Artist} успешно зарегистрирована!");

            track_3 = new Track("Smells Like Teen Spirit", "Nirvana");
            Console.WriteLine($"Песня {track_3.Title} артиста {track_3.Artist} успешно зарегистрирована!");
        }
    }
}