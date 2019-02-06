using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Piranha_Plant : Enemy
    {
<<<<<<< .merge_file_a06588
        public Piranha_Plant(float weight, float height)
           : base(weight, height)
=======
        public Piranha_Plant(float weight, float height, float ThreatLevel)
            : base(weight, height, ThreatLevel)
>>>>>>> .merge_file_a12868
        {
            isCarnivorous = false;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Fire Balls!");
<<<<<<< .merge_file_a06588
=======
            Console.WriteLine();
>>>>>>> .merge_file_a12868
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chomp, Chomp!");
        }
    }
}
