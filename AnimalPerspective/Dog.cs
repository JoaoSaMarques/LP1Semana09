using System;

namespace AnimalPerspective
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples { get; }

        /// <summary>
        /// Constructor of dog
        /// </summary>
        public Dog()
        {
            NumberOfNipples = 10;
        }

        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
