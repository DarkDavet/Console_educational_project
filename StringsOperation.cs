using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    public class StringsOperation
    {
        public void Interpolate_1()
        {
            int score = 10;
            // было(С++):    sprintf(buf, "Score: %d", score)

            /* стало(С#):*/
            string message = $"Score: {score}";   // знак $ перед кавычками делает интерполяцию возможной

            Console.WriteLine(message);
        }

        public void Interpolate_2()
        {
            //  Используя интерполяцию, как бы выглядела фраза: "Игрок [Имя] набрал [Очки] очков"
            string name = "Алексей";
            int score = 250;

            string message = $"Игрок {name} набрал {score} очков";

            Console.WriteLine(message);
        }

        /// <summary>
        /// Разделяет строку на массив строк, отделяя элементы по разделителю
        /// </summary>
        public void SplitStrings()
        {
            string input = "Warrior,Mage,Rogue";

            //было:
            Console.WriteLine(input);

            string[] classes = input.Split(','); // Теперь в массиве 3 элемента
                                                 //стало:
            Console.WriteLine(classes);  // ?
        }
    }
}
