using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
<<<<<<< .merge_file_a07464
    class Mario : Animal
    {
        public Mario(float weight, float height)
           : base(weight, height)
        {
            isCarnivorous = false;
=======
    class Mario : Allies
    {
        public string CurrentPowerUp;
        public Mario(float weight, float height, float FriendshipLevel, string CurrentPowerUp) : base(weight, height, FriendshipLevel)
        {
            isCarnivorous = false;
            this.CurrentPowerUp = CurrentPowerUp;
>>>>>>> .merge_file_a10124
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Mushrooms!");
<<<<<<< .merge_file_a07464
=======
            Console.WriteLine();
>>>>>>> .merge_file_a10124
        }

        public override void MakeSound()
        {
<<<<<<< .merge_file_a07464
            Console.WriteLine("It's a me Mario, Let's a go!");
=======
            Console.WriteLine("It's a me, "+ CurrentPowerUp + " Mario.");
            
>>>>>>> .merge_file_a10124
        }
    }
}
