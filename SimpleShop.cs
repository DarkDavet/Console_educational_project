using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    internal class SimpleShop
    {
        private int playerMoney = 100;
        private int itemPrice = 120;
        private string itemName = "Рюкзак";

        private void Buy()
        {
            if (playerMoney >= itemPrice)
            {
                playerMoney -= itemPrice;
                Console.WriteLine("Вы купили " + itemName);
                Console.WriteLine("Остаток золота: " + playerMoney);
            }
            else
            {
                int missing = itemPrice - playerMoney;
                Console.WriteLine($"Недостаточно золота! Нужно еще {missing} монет.");
            }
        }
    }
}
