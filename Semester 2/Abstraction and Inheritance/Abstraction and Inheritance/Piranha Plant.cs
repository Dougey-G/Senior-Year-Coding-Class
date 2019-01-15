using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Piranha_Plant : Enemy
    {
        public Piranha_Plant(float weight, float height, float ThreatLevel)
            : base(weight, height, ThreatLevel)
        {
            isCarnivorous = false;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Fire Balls!");
            Console.WriteLine();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chomp, Chomp!");
        }
    }
}
