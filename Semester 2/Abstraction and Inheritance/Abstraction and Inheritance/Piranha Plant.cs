using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Piranha_Plant : Animal
    {
        public Piranha_Plant(float weight, float height)
            : base(weight, height)
        {
            isCarnivorous = false;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Fire Balls!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chomp, Chomp!");
        }
    }
}
