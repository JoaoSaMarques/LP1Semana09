using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool ascending;

        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }

        public int Compare(Player x, Player y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return ascending ? -1 : 1;
            if (y == null) return ascending ? 1 : -1;

            int result = string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
            return ascending ? result : -result;
        }
    }
}
