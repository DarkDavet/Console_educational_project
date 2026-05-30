using System.Text;

namespace Console_educational_project
{
    public class Program
    {
        static void Main(string[] args)     // Главый метод всего консольного приложения, точка входа, откуда всё начинает запускаться
        {
            {
                Console.OutputEncoding = Encoding.UTF8;
            }

            StringsOperation stringsOperation = new StringsOperation();  // создание объекта класса StringOperation с именем stringIperation
            //stringsOperation.Interpolate_1();   // вызов метода Interpolate_1() из класса StringsOperation через объект stringsOperation
            //stringsOperation.Interpolate_2();   // вызов метода Interpolate_2() из класса StringsOperation через объект stringsOperation

            stringsOperation.SplitStrings();   // вызов метода SplitStrings() из класса StringsOperation через объект stringsOperation
            stringsOperation.Task_1();
            CheckTraining trainer = new CheckTraining();
            trainer.Check_2();
        }
    }
}
