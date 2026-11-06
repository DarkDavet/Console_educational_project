using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.task_1_1
{
    internal class MoneyBank
    {
       public int Money { get; private set; }

        public void Put(int amount)
        {
            if (amount > 0)
            {
                Money += amount;
            }
        }
    }
}
