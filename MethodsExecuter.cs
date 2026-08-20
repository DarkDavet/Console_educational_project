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


        public void ShowHelp()
        {
            Console.WriteLine("Для старта нажмите Enter");
            Console.WriteLine("Для выхода нажмите ESC");
            Console.WriteLine("Для помощи напишите /help");
        }

        // Метод "Исполнитель-приёмник" - принимает данные(параметры) извне
        // и выполняет ту логику, что прописана внутри, используя принятые данные.
        // Принимает на вход имя пользователя (string name) и здоровается лично с ним
        // С одним параметром; ничего не возвращает
        public void PrintWelcomeMessage2(string name)
        {
            Console.WriteLine($"Привет, {name}! Рады тебя видеть.");
        }

        // С двумя параметрами; ничего не возвращает
        public void CalculateSomething2(int a, int b)
        {
            int result = a + b;

            Console.WriteLine($"{a} + {b} = {result}");
        }

        // Метод "Информатор" - сообщает и передаёт данные указанного возвращаемого типа (в данном случае - string)
        // Если вызвать этот метод, то он сообщает текущую версию программы
        // Без параметров; возвращает данные типа string
        public string GetProgramVersion()
        {
            return "v1.4.2-beta";
        }

        // Без параметров; возвращает данные типа int
        public int GetUserId()
        {
            int userId = 123;
            return userId;
        }

        // Метод "Универсал" - и принимает данные(параметры) и передаёт данные указанного возвращаемого типа 
        // Принимает два числа, складывает их и возвращает результат в виде числа
        public int CalculateSomething3(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int CountAllUsers(List<string> users)
        {
            int count = 0;
            foreach (string user in users)
            {
                count++;
            }
            return count;
        }
    }
}