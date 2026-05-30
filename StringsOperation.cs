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
           // Console.WriteLine(classes);  // ?

            Console.WriteLine(classes[0] + " " + classes[1] + " "+ classes[2]);

            string[] words = { "warrior", "mage", "rogue" };
            string result = string.Join(", ", words);

            Console.WriteLine(result);
            //string[] words = { "Warrior", "Mage", "Rogue" };
            //string result = "";

           for (int i = 0; i < words.Length; i++)
           {
               result += words[i];
               if (i < words.Length - 1)
               {
                   result += ", ";
               }
           }

           foreach (string word in classes)
            {
                Console.WriteLine($"{word}");
            }


            Console.WriteLine(result); 
        }

        public void JoinStrings()
        {
            string[] classes = { "Warrior", "Mage", "Rogue" };
            // было:
            Console.WriteLine(classes);
            string result = string.Join(" vs ", classes);
            // стало:
            Console.WriteLine(result);
        }

        /*
         Задача #1: «Парсер инвентаря»
         - У нас есть строка от старой системы: "Меч|Щит|Зелье|Шлем".
         - Раздели её по символу |.
         - Выведи в консоль количество предметов (используй .Length).
         - Замени «Зелье» на «Супер-зелье» в массиве.
         - Склей обратно через запятую и выведи результат.
         */

        public void Task_1()
        {
            string rawData = "Меч|Щит|Зелье|Шлем";
            string[] inventory = rawData.Split('|');
            Console.WriteLine($"{inventory.Length}");
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "Зелье")
                {
                    inventory[i] = "Супер зелье";
                }
             }
            string result = string.Join(", ", inventory);
            Console.WriteLine(result);
        }

        /*
        Задача #2: «Чат-команда»
        - С помощью Split(' ') достань координаты (это будут строки "100" и "250").
        - Преврати их в числа (используй int.Parse()).
        - Выведи сообщение: "Телепортация в точку X: 100, Y: 250 прошла успешно!" используя интерполяцию.
        */
    }
}
