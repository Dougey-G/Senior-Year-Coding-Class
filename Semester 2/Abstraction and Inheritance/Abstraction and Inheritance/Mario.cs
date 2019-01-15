using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Mario : Allies
    {
        public string CurrentPowerUp;
        public Mario(float weight, float height, float FriendshipLevel, string CurrentPowerUp) : base(weight, height, FriendshipLevel)
        {
            isCarnivorous = false;
            this.CurrentPowerUp = CurrentPowerUp;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Mushrooms!");
            Console.WriteLine();
        }

        public override void MakeSound()
        {
            Console.WriteLine("It's a me, "+ CurrentPowerUp + " Mario.");
            
        }
    }
}
