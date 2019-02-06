using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Yoshi : Allies
    {
<<<<<<< .merge_file_a11756
        public Yoshi(float weight, float height)
           : base(weight, height)
        {
            isCarnivorous = true;
=======
        public float NumberofEggs;
        public Yoshi(float weight, float height, float FriendshipLevel, float NumberofEggs) : base(weight, height, FriendshipLevel)
        {
            isCarnivorous = false;
            this.NumberofEggs = NumberofEggs;
>>>>>>> .merge_file_a06540
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Wigglers!");
<<<<<<< .merge_file_a11756
=======
            Console.WriteLine();
>>>>>>> .merge_file_a06540
        }

        public override void MakeSound()
        {
            Console.WriteLine("YOSHI! I have " + NumberofEggs + " Eggs.");
            
        }


    }
}