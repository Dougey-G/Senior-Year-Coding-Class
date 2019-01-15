using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Yoshi : Allies
    {
        public float NumberofEggs;
        public Yoshi(float weight, float height, float FriendshipLevel, float NumberofEggs) : base(weight, height, FriendshipLevel)
        {
            isCarnivorous = false;
            this.NumberofEggs = NumberofEggs;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Wigglers!");
            Console.WriteLine();
        }

        public override void MakeSound()
        {
            Console.WriteLine("YOSHI! I have " + NumberofEggs + " Eggs.");
            
        }


    }
}