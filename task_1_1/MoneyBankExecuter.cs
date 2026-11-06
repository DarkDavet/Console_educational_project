using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.task_1_1
{
    internal class MoneyBankExecuter
    {
        public void Execute()
        {
            MoneyBank moneyBank = new MoneyBank();

            moneyBank.Put(50);
            moneyBank.Put(-20);
            Console.WriteLine(moneyBank.Money);
        }
    }
}
