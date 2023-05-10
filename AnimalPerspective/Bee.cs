using System;

namespace AnimalPerspective
{
    public class Bee : Animal, ICanFly
    {
        // Number of wings
        public int NumberOfWings { get; }

        /// <summary>
        /// Bee constructor
        /// </summary>
        public Bee()
        {
            // Number of wings
            NumberOfWings = 4;
        }

        /// <summary>
        /// Sound it makes
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return base.Sound() + "bzzzz!";
        }
    }
}