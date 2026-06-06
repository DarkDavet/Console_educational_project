using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    public class Track_Alternative
    {
        private string _title; // поле, которое защищает свойство Title
        public string Title
        {
            get    // логика, которая выполняется, если мы хотим получить данные из поля _title
            {
                return _title;
            }
            set    // логика, которая выполняется, если мы хотим записать данные в поле _title
            {
                if (value == "")
                {
                    Console.WriteLine("Ошибка! Название трека не может быть пустым!");
                }
                else
                {
                    _title = value; // value — это то, что пытаются записать в свойство
                }
            }
        }
        public string Artist { get; }    // у этого свойства можно только читать данные, записывать нельзя

        public string Label { get; set; }   // у этого свойства можно как читать данные, так и записывать без ограничений

        public Track_Alternative(string title, string artist, string label)
        {
            Title = title;
            Artist = artist;
            Label = label;
        }
    }
}
