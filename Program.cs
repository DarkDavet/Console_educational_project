using Console_educational_project.task_1_1;
using Console_educational_project.task_2_1;
using System.Text;

namespace Console_educational_project
{
    internal class Program
    {
        // Задача 1.1 : Написать программу "Копилка".
        // Программа хранит число денег и обладает функцией их пополнения.

        // Задача 1.2 : Написать программу "Шагомер".
        // Программа хранит число шагов и обладает функцией добавления шагов.
        // Есть также функция обнуления счётчика шагов.

        // Задача 2.1 : Написать программу "Доставка".
        // Есть три вида доставок, у каждой есть своя стоимость: обычная доставка стоит 30 р., экспресс 60р. , самовывоз бесплатно.
        // Создать List всех возможных доставок и дать возможность вывести стоимость каждой доставки
        // из списка через отдельную функцию печати.

        // Задача 2.2 : Написать программу "Музыкальные инструменты".
        // Есть два музыкальных инструмента, у каждого есть свой звук: гитара и барабан.
        // Создать список инструментов и через цикл заставить их проиграть их звуки по одному разу.
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = Encoding.UTF8;
            }
            /*
             MoneyBankExecuter moneyBankExecuter = new MoneyBankExecuter();
            moneyBankExecuter.Execute();
            StepCounter stepcounter = new StepCounter();
            stepcounter.AddSteps(1500);
            stepcounter.Reset();
             */
            List<Delivery> deliveries = new List<Delivery>();
            deliveries.Add(new Delivery());
            deliveries.Add(new ExpressDelivery());
            deliveries.Add(new TakeMyselfDelivery());
            
            foreach (var delivery in deliveries)
            {
                delivery.Print();
            }
        }


    }

    interface IDamageable
    {
        void GetDamage(int damage);
        void GetHealth(int damage);
        void GetScore(int damage);
    }
}
