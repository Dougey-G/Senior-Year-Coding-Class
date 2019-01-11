using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    abstract class Animal
    {
        protected float weight;
        protected float height;
        protected bool isCarnivorous;

        public Animal(float weight, float height)
        {
            this.weight = weight;
            this.height = height;
        }

        public virtual void Eat()
        {
            Console.Write("I'm eating");
        }

        public abstract void MakeSound();
    }
}
