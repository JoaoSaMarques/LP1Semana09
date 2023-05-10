using System;
using System.Collections.Generic; //Using what template suggested

namespace PlayerManager1
{
    public class Program
    {
        /// <summary>
        /// Player List
        /// </summary>
        private List<Player> playerList;

        /// <summary>
        /// Main
        /// </summary>
        private static void Main()
        {
            //Program
            Program prog = new Program();
            prog.Start();
        }
    }
}