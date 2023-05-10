using System;

namespace AnimalPerspective
{
    public class Cat : Animal, IMammal
    {
        public int NumberOfNipples { get; }

        /// <summary>
        /// Constructor of dog
        /// </summary>
        public Cat()
        {
            NumberOfNipples = 8;
        }

        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
    }
}
