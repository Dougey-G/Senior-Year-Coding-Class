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

        //This Method is Good
        private Character CreateCharacter()
        {
            string CharacterName;
            Console.WriteLine("Please enter your character's name");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Please enter your character's Height");
            string Height = Console.ReadLine();
            Console.WriteLine("Please enter your character's Eye Color");
            string EyeColor = Console.ReadLine();
            Console.WriteLine("Please enter your character's SkinColor");
            string SkinColor = Console.ReadLine();
            Console.WriteLine("Please enter your character's HairColor");
            string HairColor = Console.ReadLine();

            Character character = new Character(CharacterName, Height, EyeColor, SkinColor, HairColor);

            SaveCharacter(character);

            return character;

        }


        static void ModifyCharacter(Character character)
        {
            string result = Console.ReadLine();

            Console.WriteLine("what attribute do you want to change");
            Console.WriteLine("1. Height");
            Console.WriteLine("2. EyeColor");
            Console.WriteLine("3. SkinColor");
            Console.WriteLine("4. HairColor");

            if (result == "1")
            {
                Console.WriteLine("Please enter your New Height for your character");
                character.Height = Console.ReadLine();
            }

            if (result == "2")
            {
                Console.WriteLine("Please enter your New EyeColor for your character");
                character.EyeColor = Console.ReadLine();
            }

            if (result == "3")
            {
                Console.WriteLine("Please enter your New SkinColor for your character");
                character.SkinColor = Console.ReadLine();
            }

            if (result == "4")
            {
                Console.WriteLine("Please enter your New HairColor for your character");
                character.HairColor = Console.ReadLine();
            }

            character.CharacterName = //modifyCharacter(CharacterName, Height, EyeColor, SkinColor, HairColor) or ModifyCharacter;

        }
        static void SaveCharacter(Character character)
        {
            //LocalDataStoreSlot
            if (File.Exists("MyFile.txt"))
            {
                Console.WriteLine("The file exists.");

                string path;
                path = AppDomain.CurrentDomain.BaseDirectory + @"Character.txt";

                using (StreamWriter sw = new StreamWriter(path))
                    sw.Dispose();




            }
        }
        bool DeleteCharacter(List<Character> characters, string characterName)
        {
            //if (DeleteCharacter == true)
            //{
            //    Console.WriteLine(character + "deleted");
            //}
            //return false;
            string path;
            path = AppDomain.CurrentDomain.BaseDirectory + @"Character.txt";

            if (File.Exists("MyFile.txt"))
            {
                //Console.WriteLine("The file exists.");
                foreach (string filepath in Directory.EnumerateFiles(path, "*.xml"))
                {
                    string contents = File.ReadAllText(path);
                }
                File.Delete(@"Mario.txt");
                return true;

            }

            else
            {
                Console.WriteLine(character + "not found, therefore was not deleted");
                return false;
            }
        }
        Character LoadCharacter(string characterName)
        {
            string path;
            path = AppDomain.CurrentDomain.BaseDirectory + characterName + ".txt";
            Character character;
            using (StreamReader sr = new StreamReader(path))
            {
                character = new Character(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());

            }
            //createCharacter = true;
            //return createCharacter;
            return character;
        }
        List<Character> LoadCharcters()
        {
            loadCharacter = character;
            return null;
        }
        static void ListCharacters(List<Character> characters)
        {
            //parameter attributes
        }
    }
}