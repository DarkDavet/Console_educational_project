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

            // bagA — это пустой кошелек (он есть, просто в нем 0 монет).
            // bagB — это когда у игрока вообще нет кошелька.

            // Можно попробовать вызвать bagA.Length (вернет 0) и bagB.Length (программа вылетит с ошибкой NullReferenceException).

        }

        public void Check_4()
        {
            int[] teamA = { 1, 2, 3 };
            int[] teamB = teamA; 

            teamB[0] = 999; 

            Console.WriteLine(teamA[0]); // Что выведет здесь?

            // Суть: Массивы (и любые классы) — это «ссылочные» типы.
            // Переменные хранят не сам объект, а адрес в памяти.
            // Когда мы пишем teamB = teamA, мы просто копируем адрес. 
            // Оба имени указывают на один и тот же массив.
        }

        public void Check_5()
        {
            int playerHp = 100;
            Heal(playerHp);

            Console.WriteLine(playerHp); // Что выведет здесь?
        }

        public void Heal(int hp)
        {
            hp += 50;
        }

        public void Check_6()
        {
            string magicWord = "Абра";
            string spell = magicWord;

            magicWord += "Кадабра"; // Создаем новую строку

            Console.WriteLine(spell); // Что выведет здесь?
        }
    }
}
