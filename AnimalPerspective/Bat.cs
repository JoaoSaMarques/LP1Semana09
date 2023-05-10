using System;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal, ICanFly
    {
        //Number of nipples on the animal
        public int NumberOfNipples { get; }

        //How many wings does it have
        public int NumberOfWings { get; }


        //Play sound
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
