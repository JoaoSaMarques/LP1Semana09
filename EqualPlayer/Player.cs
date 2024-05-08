using System;

namespace EqualPlayer
{
    public class Player
    {
        public PlayerClass PClass { get; }
        public string Name { get; }
        public Player(PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + PClass.GetHashCode();
                hash = hash * 23 + Name.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Player player))
                return false;

            return PClass == player.PClass && Name == player.Name;
        }
    }
}
