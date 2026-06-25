using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    
    public class Character
    {
        private int _health;
        public string Name { get; set; }
        public int Level { get; private set; }

        public int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public Character(string name, int health)
        {
            Name = name;
            Level = 1;      
            Health = health; 
        }
    }

    
  
   
   
    }

