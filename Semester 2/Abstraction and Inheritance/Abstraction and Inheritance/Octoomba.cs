using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Octoomba : Animal
    {

        public Octoomba(float weight, float height)
            : base(weight, height)
        {
            isCarnivorous = false;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Rocks!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Pomp!");
        }
    }
}
