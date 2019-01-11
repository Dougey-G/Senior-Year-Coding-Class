using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Yoshi : Animal
    {
        public Yoshi(float weight, float height)
            : base(weight, height)
        {
            isCarnivorous = false;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Wigglers!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("YOSHI!");
        }
    }
}