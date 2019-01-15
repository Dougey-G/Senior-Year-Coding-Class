using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Epona : Allies
    {
        public float RunSpeed;
        public Epona(float weight, float height, float FriendshipLevel, float RunSpeed) : base(weight, height, FriendshipLevel)
        {
            isCarnivorous = false;
            this.RunSpeed = RunSpeed;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Apples!");
            Console.WriteLine();
        }

        public override void MakeSound()
        {
            Console.WriteLine("I go " + RunSpeed + " Speed.");
            
        }
    }
}
