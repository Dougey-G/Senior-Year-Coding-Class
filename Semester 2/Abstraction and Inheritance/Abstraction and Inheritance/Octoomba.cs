﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Octoomba : Enemy
    {
        public Octoomba(float weight, float height, float ThreatLevel)
            : base(weight, height, ThreatLevel)
        {
            isCarnivorous = false;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Rocks!");
            Console.WriteLine();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Pomp!");
        }
    }
}
