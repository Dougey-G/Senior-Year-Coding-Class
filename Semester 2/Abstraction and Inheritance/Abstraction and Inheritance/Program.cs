using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< .merge_file_a03376
            //Console.WriteLine("Please select the character you want");
            //Console.WriteLine("1. Yoshi");
            //Console.WriteLine("2. Octoomba");
            //Console.WriteLine("3. Piranha Plant");
            //Console.WriteLine("4. Mario");
            //Console.WriteLine("5. Epona");
            //Console.WriteLine("6. Donkey Kong");
            //string result = Console.ReadLine();

            //if (result == "1")
            //{
            //    Yoshi.MakeSound();
            //    Yoshi.Eat();
            //}

            //if (result == "2")
            //{
            //    Octoomba.MakeSound();
            //    Octoomba.Eat();
            //}

            //if (result == "3")
            //{
            //    Piranha_Plant.MakeSound();
            //    Piranha_Plant.Eat();
            //}

            //if (result == "4")
            //{
            //    Mario.MakeSound();
            //    Mario.Eat();
            //}

            //if (result == "5")
            //{
            //    Epona.MakeSound();
            //    Epona.Eat();
            //}

            //if (result == "6")
            //{
            //    Donkey_Kong.MakeSound();
            //    Donkey_Kong.Eat();
            //}

            List<Animal> animals = new List<Animal>();
            animals.Add(new Yoshi(25, 5));
            animals.Add(new Octoomba(8, 3));
            animals.Add(new Piranha_Plant(15, 6));
            animals.Add(new Mario(80, 6));
            animals.Add(new Epona(150, 5));
            animals.Add(new Donkey_Kong(450, 5));
            
=======
            List<Animal> animals = new List<Animal>();
            animals.Add(new Yoshi(10, 5, 4, 3));
            animals.Add(new Octoomba(8, 3, 2));
            animals.Add(new Piranha_Plant(15, 6, 3));
            animals.Add(new Mario(80, 5, 4, "Ice"));
            animals.Add(new DonkeyKong(220, 5, 4));
            animals.Add(new Epona(200, 5, 4, 4));
>>>>>>> .merge_file_a01112

            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].MakeSound();
                animals[i].Eat();
            }
            Console.ReadLine();
        }
    }
}
