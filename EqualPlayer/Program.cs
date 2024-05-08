using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var setOfPlayers = new HashSet<Player>();

            setOfPlayers.Add(new Player(PlayerClass.Tank, "Ana"));
            setOfPlayers.Add(new Player(PlayerClass.Slayer, "Paulo"));
            setOfPlayers.Add(new Player(PlayerClass.Tank, "Ana")); 

            foreach (var player in setOfPlayers)
            {
                Console.WriteLine($"{player.Name} is a {player.PClass}");
            }
        }
    }
}