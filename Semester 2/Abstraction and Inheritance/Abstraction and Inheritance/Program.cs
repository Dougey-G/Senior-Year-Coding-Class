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
            Console.WriteLine("Please select the character you want");

            List<Animal> animals = new List<Animal>();
            animals.Add(new Yoshi(10, 5));
            animals.Add(new Octoomba(8, 3));
            animals.Add(new Piranha_Plant(15, 6));

            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].MakeSound();
                animals[i].Eat();
            }
        }
    }
}
