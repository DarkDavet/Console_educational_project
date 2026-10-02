using Console_educational_project.SmartDevices;
using Console_educational_project.Test_tasks;
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
            Weapon myWeapon = new Weapon();

            int ammo = "10"; 

            for (int i = 0; i < ammo; i--)
            {
                Console.WriteLine("Стреляем!");
            }
        }
    }
}
