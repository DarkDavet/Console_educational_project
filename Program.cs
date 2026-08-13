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
             MethodsExecuter  welcomeMessege = new  MethodsExecuter();
          welcomeMessege.CalculateSomething();
          welcomeMessege.PrintWelcomeMessage();
          welcomeMessege.ShowHelp();

          // вариант 1
          string name = "Rodion";
          welcomeMessege.PrintWelcomeMessage2(name);
          int a=1;
          int b=2;
          welcomeMessege.CalculateSomething2(a,b);
          // вариант 2
          welcomeMessege.PrintWelcomeMessage2("Rodion");
          welcomeMessege.CalculateSomething2(1,2);
        }
    }
}
