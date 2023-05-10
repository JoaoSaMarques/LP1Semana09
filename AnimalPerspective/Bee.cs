using System;

namespace OverrideVsNew
{
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
