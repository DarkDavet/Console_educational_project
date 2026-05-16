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
            Console.WriteLine("Hello, World!");

            StringsOperation stringsOperation = new StringsOperation();
            stringsOperation.Interpolate_1();
            stringsOperation.Interpolate_2();

        }
    }
}
