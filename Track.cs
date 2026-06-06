using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    public class Track
    {
        public string Title { get; set; }     // свойства
        public string Artist { get; set; }    // позволяют хранить в себе значения, как поля,
                                              // но с использованием модификаторов доступа

        public Track(string title, string artist)     // конструктор: специальный метод,
                                                      // который срабатывает один раз при создании объекта этого класса
                                                      // называется обязательно именем этого класса
        {
            Title = title;
            Artist = artist;
        }
    }
}
