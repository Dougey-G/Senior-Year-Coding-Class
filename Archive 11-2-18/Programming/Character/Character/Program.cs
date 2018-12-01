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
            string result;

            do
            {
                Character current = new Character("", "", "", "", "", "");
                Console.WriteLine("1. Create Character");
                Console.WriteLine("2. Modify Character");
                Console.WriteLine("3. Delete Character");
                Console.WriteLine("4. Load Character");
                Console.WriteLine("5. Print Character");
                Console.WriteLine("6. Exit");

                result = Console.ReadLine();
                if (result == "1")
                {
                    current = CreateCharacter();
                }

                if (result == "2")
                {
                    ModifyCharacter(current);
                }

                if (result == "3")
                {
                    DeleteCharacter(Console.ReadLine());
                }

                if (result == "4")
                {
                    LoadCharacter(Console.ReadLine());
                }

                if (result == "5")
                {
                    LoadCharacter(Console.ReadLine());
                    PrintCharacter(current);
                }


            } while (result != "6");
            

           
        }

        //This Method is Good
        private static Character CreateCharacter()
        {
            string Name;
            Console.WriteLine("Please enter your character's Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter your character's Height (12 inches = 1 foot)");
            string Height = Console.ReadLine();
            Console.WriteLine("Please enter your character's Eye Color");
            string EyeColor = Console.ReadLine();
            Console.WriteLine("Please enter your character's SkinColor");
            string SkinColor = Console.ReadLine();
            Console.WriteLine("Please enter your character's HairColor");
            string HairColor = Console.ReadLine();
            Console.WriteLine("Please enter your character's ShirtColor");
            string ShirtColor = Console.ReadLine();

            Character character = new Character(Name, Height, EyeColor, SkinColor, HairColor, ShirtColor);

            SaveCharacter(character);

            Console.WriteLine();

            return character;

        }


        static void ModifyCharacter(Character character)
        {
            string result = Console.ReadLine();

            Console.WriteLine("what attribute do you want to change?");
            Console.WriteLine("1. Height");
            Console.WriteLine("2. EyeColor");
            Console.WriteLine("3. SkinColor");
            Console.WriteLine("4. HairColor");
            Console.WriteLine("5. ShirtColor");

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

            if (result == "5")
            {
                Console.WriteLine("Please enter your New ShirtColor for your character");
                character.ShirtColor = Console.ReadLine();
            }
            //character.CharacterName = modifyCharacter(CharacterName, Height, EyeColor, SkinColor, HairColor) or ModifyCharacter;

        }
        static void SaveCharacter(Character character)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + character.Name + @".txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists, would you like to overwrite? Y, N.");
                if (Console.ReadLine()[0] == 'y')
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(character.Name);
                        sw.WriteLine(character.Height);
                        sw.WriteLine(character.EyeColor);
                        sw.WriteLine(character.SkinColor);
                        sw.WriteLine(character.HairColor);
                        sw.WriteLine(character.ShirtColor);
                    }
                    Console.WriteLine("File overwritten");
                }
                else
                    Console.WriteLine("Nothing overwritten");
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(character.Name);
                    sw.WriteLine(character.Height);
                    sw.WriteLine(character.EyeColor);
                    sw.WriteLine(character.SkinColor);
                    sw.WriteLine(character.HairColor);
                    sw.WriteLine(character.ShirtColor);
                }
                Console.WriteLine("File created");
            }

        }
        static bool DeleteCharacter(string Name)
        {
            //if (DeleteCharacter == true)
            //{
            //    Console.WriteLine(character + "deleted");
            //}
            //return false;
            string path;
            path = AppDomain.CurrentDomain.BaseDirectory + Name + @".txt";

            if (File.Exists(path))
            {
                //Console.WriteLine("The file exists.");
                foreach (string filepath in Directory.EnumerateFiles(path, "*.xml"))
                {
                    string contents = File.ReadAllText(path);
                }
                File.Delete(path);
                return true;

            }

            else
            {
                Console.WriteLine(Name + "not found, therefore was not deleted");
                return false;
            }
        }

        static Character LoadCharacter(string Name)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + Name + @".txt";
            Character character;
            using (StreamReader sr = new StreamReader(path))
            {
                character = new Character(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());

            }
            return character;
        }

       static void PrintCharacter(Character character)
        {
            Console.WriteLine(character.Name);
            Console.WriteLine(character.Height);
            Console.WriteLine(character.EyeColor);
            Console.WriteLine(character.SkinColor);
            Console.WriteLine(character.HairColor);
            Console.WriteLine(character.ShirtColor);
        }

       //static List<Character> LoadCharcters()
       // {
       //     //loadCharacter = Character;
       //     return null;
       // }
        static void ListCharacters(List<Character> characters)
        {
            //parameter attributes
        }
    }
}