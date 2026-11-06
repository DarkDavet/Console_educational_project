using System;

namespace Console_educational_project
{
    public class StepCounter
    {
        private int stepsCount;
        public StepCounter()
        {
            stepsCount=0;
        }
        public void AddSteps(int steps)
        {
            if (steps > 0)
            {
                 stepsCount+=steps;
                 Console.WriteLine("пройдено {stepsCount} шагов");
            }
            else
            {
                Console.WriteLine("Число шагов должно быть больше 0");
            }

        }
         public void Reset()
        {
           stepsCount=0; 
            Console.WriteLine("Число шагов обнулено");
        }
        
    }
}