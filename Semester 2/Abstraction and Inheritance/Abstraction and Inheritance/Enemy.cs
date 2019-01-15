using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Enemy : Animal
    {
        public float ThreatLevel;
        public Enemy(float weight, float height, float ThreatLevel) : base(weight, height)
        {
            this.ThreatLevel = ThreatLevel;
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
