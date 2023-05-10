using System;

namespace AnimalPerspective
{
    public class Dog : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
