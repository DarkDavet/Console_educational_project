using Console_educational_project.task_1_1;
using Console_educational_project.task_2_1;
using System.Text;
using Console_educational_project._2._2;
using Console_educational_project._3._1;
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

        // Задача 3.1 : Написать программу для вычисления площади разных фигур,
        // используя интерфейсы.Посчитать сумму площадей всех добавленных фигур.

        // Задача 3.2 : Написать программу для расчёта расходов на товары и услуги, используя интерфейсы.
        // Создать товар в виде  книги с названием и ценой.
        // Создать услугу поездки на такси со стоимостью посадки 5 р. и 1 р. за километр.
        // Поместить купленную за 25 р. книгу и поездку на такси на 5 км. в один список и посчитать, сколько потрачено всего.
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
            List<Tool> instuments = new List<Tool>();
            instuments.Add(new Drum() );
            instuments.Add(new Guitar());
            foreach (var instrument in instuments) 
            {
                instrument.Print();
            }

            List<IHasArea> figuries = new List<IHasArea>();
            figuries.Add(new Circle(2));
            figuries.Add(new Square(4));
            figuries.Add(new Square(2));

            double area_sum = 0;
            foreach (IHasArea figure in figuries)
            {
                double area = 0;
                area = figure.GetArea();
                area_sum += area;
            }
            Console.WriteLine($"Общая площадь: {area_sum:F2}");

        }


    }

    interface IDamageable
    {
        void GetDamage(int damage);
        void GetHealth(int damage);
        void GetScore(int damage);
    }
}
