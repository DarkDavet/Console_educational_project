using Console_educational_project.SmartDevices;
using Console_educational_project.Test_tasks;
using Minigame;
using System.Text;
namespace Console_educational_project

{
    internal class Program
    {

        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = Encoding.UTF8;
               
            }
          Player player= new Player("Воин" , 100, 15);
          Monster monster = new Monster("Гоблин", 50, 10);
          while (player.Health>0&& monster.Health > 0)
            {
                Console.WriteLine("Выберите действие 1- атака, 2-лечение");
                string choise = Console.ReadLine();
                if(choise=="1")player.Attack(monster);
                else if (choise=="2")player.Heal();
                if (monster.Health<=0)break;
                monster.Attack(player);
            }
            Console.WriteLine(player.Health>0 ? "/nПобеда":"/nПройгрыш");
        }
    }
}
