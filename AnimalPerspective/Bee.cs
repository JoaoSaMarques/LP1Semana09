using System;

namespace OverrideVsNew
{
    public class Bee : Animal, ICanFly
    {
        //Number of wings
        public int NumberOfWings { get; }

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
