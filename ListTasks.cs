using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
 {
    public class ListTasks
    {
     public void ExecuteTask1()
         {
  


        List<string> serverLogs = new List<string>();


        serverLogs.Add("Пользователь вошел");
        serverLogs.Add("Ошибка подключения к БД");
        serverLogs.Add("Файл скачан");


        Console.WriteLine($"Всего записано логов: {serverLogs.Count}");
        Console.WriteLine($"Текущие логи: {string.Join(" | ", serverLogs)}\n");

        Console.WriteLine("-> Исправляем ошибку... Удаление лога 'Ошибка подключения к БД'.");
        serverLogs.Remove("Ошибка подключения к БД");
        Console.WriteLine($"Осталось логов: {serverLogs.Count}\n");


        Console.WriteLine("Проверка статуса сессии...");
        if (serverLogs.Contains("Пользователь вошел"))
           {
        Console.WriteLine("Сессия активна");
           }
        else
           {
        Console.WriteLine("Предупреждение: Лог входа не найден.");
           }

         }


    }
}
