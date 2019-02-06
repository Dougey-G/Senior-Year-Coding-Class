using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Donkey_Kong : Animal
    {
        public Donkey_Kong(float weight, float height)
           : base(weight, height)
        {
            isCarnivorous = false;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Bananas!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("OO OO Aw!");
        }
    }
}
