using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    internal class StringsOperation
    {
        public void Interpolate_1()
        {
            int score = 10;
            // было(С++):    sprintf(buf, "Score: %d", score)

            /* стало(С#):*/
            string message = $"Score: {score}";   // знак $ перед кавычками делает интерполяцию возможной

            Console.WriteLine(message);
        }
    }
}
