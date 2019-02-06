using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
<<<<<<< .merge_file_a13036
    class Epona : Animal
    {
        public Epona(float weight, float height)
           : base(weight, height)
        {
            isCarnivorous = false;
=======
    class Epona : Allies
    {
        public float RunSpeed;
        public Epona(float weight, float height, float FriendshipLevel, float RunSpeed) : base(weight, height, FriendshipLevel)
        {
            isCarnivorous = false;
            this.RunSpeed = RunSpeed;
>>>>>>> .merge_file_a02404
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Apples!");
<<<<<<< .merge_file_a13036
=======
            Console.WriteLine();
>>>>>>> .merge_file_a02404
        }

        public override void MakeSound()
        {
<<<<<<< .merge_file_a13036
            Console.WriteLine("Neigh!");
=======
            Console.WriteLine("I go " + RunSpeed + " Speed.");
            
>>>>>>> .merge_file_a02404
        }
    }
}
