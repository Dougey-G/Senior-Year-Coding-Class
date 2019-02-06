using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Octoomba : Enemy
    {
<<<<<<< .merge_file_a11232
        public Octoomba(float weight, float height)
           : base(weight, height)
=======
        public Octoomba(float weight, float height, float ThreatLevel)
            : base(weight, height, ThreatLevel)
>>>>>>> .merge_file_a07308
        {
            isCarnivorous = false;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Rocks!");
<<<<<<< .merge_file_a11232
=======
            Console.WriteLine();
>>>>>>> .merge_file_a07308
        }

        public override void MakeSound()
        {
            Console.WriteLine("Pomp!");
        }
    }
}
