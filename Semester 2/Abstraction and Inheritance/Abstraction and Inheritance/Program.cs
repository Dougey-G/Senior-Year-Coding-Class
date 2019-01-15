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
            List<Animal> animals = new List<Animal>();
            animals.Add(new Yoshi(10, 5, 4, 3));
            animals.Add(new Octoomba(8, 3, 2));
            animals.Add(new Piranha_Plant(15, 6, 3));
            animals.Add(new Mario(80, 5, 4, "Ice"));
            animals.Add(new DonkeyKong(220, 5, 4));
            animals.Add(new Epona(200, 5, 4, 4));

            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].MakeSound();
                animals[i].Eat();
            }
            Console.ReadLine();
        }
    }
}
