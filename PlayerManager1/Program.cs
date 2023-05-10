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

        /// <summary>
        /// Creates a new instance of the player listing program.
        /// </summary>
        private Program()
        {
            playerList = new List<Player>() 
            {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
        }
    }
}