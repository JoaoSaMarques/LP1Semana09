using System;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal, ICanFly
    {
        //Number of nipples on the animal
        public int NumberOfNipples { get; }

        //How many wings does it have
        public int NumberOfWings { get; }

        /// <summary>
        /// Bat constructor
        /// </summary>
        public Bat()
        {
            //2 nipples
            NumberOfNipples = 2; 
            //2 wings
            NumberOfWings = 2; 
        }

        /// <summary>
        /// Play sound
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return base.Sound() + "SCREE SCREE";
        }
    }
}
