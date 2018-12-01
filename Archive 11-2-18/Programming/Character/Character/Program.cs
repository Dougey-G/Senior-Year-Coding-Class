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

            //Moved current outside of do-while scope so it doesn't get recreated every time we loop through the menu.
            //This way, when we load into current with the 4th menu option, it persists through menu calls.
            Character current = new Character("", "", "", "", "", "");
            do
            {
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
                    //Added a prompt to ask the user who they want to delete.
                    Console.WriteLine("What is the name of the character you want to delete?");
                    DeleteCharacter(Console.ReadLine());
                }

                if (result == "4")
                {
                    //Added prompt to ask the user who they want to load
                    Console.WriteLine("What is the name of the character you want to load?");

                    //Remember, LoadCharacter has a return type, therefore we should use it!
                    current = LoadCharacter(Console.ReadLine());
                    Console.WriteLine();
                }

                if (result == "5")
                {
                    //We don't necesarily want to load a character before we print it. Use 4 to load before you print.
                    PrintCharacter(current);
                    Console.WriteLine();
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
            Console.WriteLine("what attribute do you want to change?");
            Console.WriteLine("1. Height");
            Console.WriteLine("2. EyeColor");
            Console.WriteLine("3. SkinColor");
            Console.WriteLine("4. HairColor");
            Console.WriteLine("5. ShirtColor");
            Console.WriteLine();

            string result2 = Console.ReadLine();

            if (result2 == "1")
            {
                Console.WriteLine("Please enter your New Height for your character");
                character.Height = Console.ReadLine();
            }

            if (result2 == "2")
            {
                Console.WriteLine("Please enter your New EyeColor for your character");
                character.EyeColor = Console.ReadLine();
            }

            if (result2 == "3")
            {
                Console.WriteLine("Please enter your New SkinColor for your character");
                character.SkinColor = Console.ReadLine();
            }

            if (result2 == "4")
            {
                Console.WriteLine("Please enter your New HairColor for your character");
                character.HairColor = Console.ReadLine();
            }

            if (result2 == "5")
            {
                Console.WriteLine("Please enter your New ShirtColor for your character");
                character.ShirtColor = Console.ReadLine();
            }
            SaveCharacter(character);
        }

        static void SaveCharacter(Character character)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + character.Name + @".txt";
            if (File.Exists(path))
            {
                Console.WriteLine(character.Name + " exists, would you like to overwrite? Y, N.");
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
                    Console.WriteLine();
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
                Console.WriteLine(character.Name + " created");
            }
        }

        static bool DeleteCharacter(string Name)
        {
            string path;
            path = AppDomain.CurrentDomain.BaseDirectory + Name + @".txt";

            if (File.Exists(path))
            {
                Character character;
                using (StreamReader sr = new StreamReader(path))
                {
                    character = new Character(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
                }
                Console.WriteLine(Name + " deleted");
                File.Delete(path);
                Console.WriteLine();
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
            Console.WriteLine(Name + " loaded");
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
    }
}