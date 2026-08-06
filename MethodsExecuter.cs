using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    public class MethodsExecuter
    {
        // Метод-исполнитель - выполняет ту логику, что прописана внутри.
        // В данном случае печатает приветствие в консоль
        // Без параметров; ничего не возвращает
        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Привет! Добро пожаловать в систему.");
        }

        public void CalculateSomething()
        {
            int a = 10;
            int b = 20;

            int result = a + b;

            Console.WriteLine($"{a} + {b} = {result}");
        }

        //Задание 1: Метод ShowHelp()
        //Тип: Ничего не принимает, ничего не возвращает.
        //При вызове выводит в консоль три строчки с инструкцией для пользователя:
        //"Для старта нажмите Enter"
        //"Для выхода нажмите ESC"
        //"Для помощи напишите /help"
    }
}
