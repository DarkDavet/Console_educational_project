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

    
    public class CharacterService
    {
        
        private List<Character> character_library = new List<Character>();


        public void Register(string character_name, int character_health)
        {
            Character character = new Character(character_name, character_health);
            character_library.Add(character);
            Console.WriteLine($"Персонаж {character.Name} (Здоровье: {character.Health}, Уровень: {character.Level}) успешно зарегистрирован!");
        }

        
        public void RemoveCharacter(string character_name)
        {
            Character characterToRemove = null;

            
            foreach (var character in character_library)
            {
                if (character.Name == character_name)
                {
                    characterToRemove = character;
                    break;
                }
            }

            
            if (characterToRemove != null)
            {
                character_library.Remove(characterToRemove);
                Console.WriteLine($"Персонаж {characterToRemove.Name} удален!");
            }
            else
            {
                Console.WriteLine($"Персонаж с именем {character_name} не существует");
            }
        }
    }

   
   
    }

