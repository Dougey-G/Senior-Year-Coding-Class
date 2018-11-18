using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Character
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        Character CreateCharacter()
        {
            string CharacterName;
            Console.WriteLine("Please enter your name");
            CharacterName = Console.ReadLine();
            
            string Height;
            // Height
            //{
            // int.Parse(Console.ReadLine());
            // result = '0';
            // Console.WriteLine("Please enter your height in inches(Hint: 12 inches = 1ft)":
            // 
            //}

            string EyeColor;
            // Red, Blue, Green, Yellow, Purple, Orange, Light Green, Light Blue, Hazel
            // Eye Color

            string SkinColor;
            // string.Parse(Console.ReadLine)
            // White, Tan, Brown/Black (African American) 
            // Skin Color

            string HairColor;
            // Blonde, Brunette, Black, Red Head/Ginger, 
            // Hair Color
            return null;
        }
        void ModifyCharacter(Character character)
        {
            Console.WriteLine("what attribute do you want to change");
        }
        void SaveCharacter(Character character)
        {
            //LocalDataStoreSlot
        }
        bool DeleteCharacter(List<Character> characters, string characterName)
        {
            //if (DeleteCharacter == true)
            //{
            //    Console.WriteLine(character + "deleted");
            //}
            //return false;

            if (File.Exists("MyFile.txt"))
            {
                Console.WriteLine("The file exists.");
            }

        }
        Character LoadCharacter(string characterName)
        {
            createCharacter = true;
            return createCharacter;
        }
        List<Character> LoadCharcters()
        {
            loadCharacter = character; 
            return null;
        }
        void ListCharacters(List<Character> characters)
        {
            //parameter attributes
        }
    }
}