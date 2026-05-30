using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    public class CheckTraining
    {
        public void Check_1()
        {
            int level = 10;
            int nextLevel = level;
            nextLevel = 20;

            Console.WriteLine(level); // Что выведет здесь?

            // Суть: В C# int — это «значимый» тип.
            // Когда мы пишем nextLevel = level, создается полная копия числа.
            // Изменение копии не трогает оригинал.
        }

        public void Check_2()
        {
            string heroName = "геральт";
            heroName.ToUpper(); // Метод делает строку заглавными буквами

            Console.WriteLine(heroName); // Что выведет здесь?
        }
    }
}
