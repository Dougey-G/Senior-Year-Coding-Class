using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class DonkeyKong: Allies
    {

        public DonkeyKong(float weight, float height, float FriendshipLevel)
            : base(weight, height, FriendshipLevel)
        {
            isCarnivorous = false;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Bananas!");
            Console.WriteLine();
        }

        public override void MakeSound()
        {
            Console.WriteLine("OO OO AW!");
        }
    }
}
