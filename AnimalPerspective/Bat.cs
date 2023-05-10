using System;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
