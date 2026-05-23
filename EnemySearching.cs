using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    public class EnemySearching
    {
        private double[] enemiesHealth = { 50.3, 3, 80, 5, 100, 20 };

        public void FindEnemy()
        {
            Console.WriteLine("Враги с малым количеством здоровья (HP меньше 20):");
            foreach (int hp in enemiesHealth)
            {
                if (hp < 20)
                {
                    Console.WriteLine("Враг найден! HP: " + hp);
                }

            }

            for (int i = 0; i < enemiesHealth.Length; i++)
            {
                if (enemiesHealth[i] > 20)
                {
                    Console.WriteLine("Враг найден! HP: " + enemiesHealth[i]);
                }
            }
        }
    }
}
