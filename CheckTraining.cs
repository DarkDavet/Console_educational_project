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
            heroName = heroName.ToUpper(); // Метод делает строку заглавными буквами

            Console.WriteLine(heroName); // Что выведет здесь?

            // В C# строки нельзя изменить.
            // Метод ToUpper() не меняет старую строку, а создает и возвращает новую.
            // Чтобы сработало, нужно написать: heroName = heroName.ToUpper();.
        }

        public void Check_3()
        {
            string bagA = "";
            string bagB = null;

        }

        public void Check_4()
        {
            int[] teamA = { 1, 2, 3 };
            int[] teamB = teamA; 

            teamB[0] = 999; 

            Console.WriteLine(teamA[0]); // Что выведет здесь?
        }
    }
}
