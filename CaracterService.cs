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

   
   
    

