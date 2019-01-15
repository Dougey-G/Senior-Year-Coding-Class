using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Allies : Animal
    {
        public float FriendshipLevel;
        public Allies(float weight, float height, float FriendshipLevel) : base(weight, height)
        {
            this.FriendshipLevel = FriendshipLevel;
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
