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

        /// <summary>
        /// Program utilized for main (The actual game/console)
        /// </summary>
        private void Start()
        {
            string option;

            do
            {
                ShowMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    //First option
                    case "1":
                        InsertPlayer();
                        break;
                    //Second option
                    case "2":
                        ListPlayers(playerList);
                        break;
                    //Third option
                    case "3":
                        ListPlayersWithScoreGreaterThan();
                        break;
                    //Forth option
                    case "4":
                        Console.WriteLine("Bye!");
                        break;
                    //Basically if none of the 4
                    default:
                        Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
                        break;
                }

                //Press key to continue
                Console.Write("\nPress any key to continue...");
                //Read input
                Console.ReadKey(true);
                //Spacing
                Console.WriteLine("\n");

            } while (option != "4");
        }

        //Menu
        private void ShowMenu()
        {
            Console.WriteLine("Player Manager Menu");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than a value");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your option: ");
        }

        /// <summary>
        /// Inserts a new player in the player list.
        /// </summary>
        private void InsertPlayer()
        {
            //Requires player input to write their name
            Console.Write("Enter player name: ");
            string name = Console.ReadLine();
            //Requires player input to write score and convert to int.
            Console.Write("Enter player score: ");
            int score = int.Parse(Console.ReadLine());

            //Based on info create new player
            Player newPlayer = new Player(name, score);
            playerList.Add(newPlayer);

            Console.WriteLine("Player inserted successfully!");
        }

        /// <summary>
        /// Show all players in a list of players. This method can be static
        /// because it doesn't depend on anything associated with an instance
        /// of the program. Namely, the list of players is given as a parameter
        /// to this method.
        /// </summary>
        private static void ListPlayers(IEnumerable<Player> playersToList)
        {
            Console.WriteLine("Player List:");
            foreach (Player player in playersToList)
            {
                Console.WriteLine($"Name: {player.Name}, Score: {player.Score}");
            }
        }

        /// <summary>
        /// Show all players with a score higher than a user-specified value.
        /// </summary>
        private void ListPlayersWithScoreGreaterThan()
        {
            Console.Write("Enter the minimum score: ");
            int minScore = int.Parse(Console.ReadLine());

            IEnumerable<Player> playersWithHigherScore = GetPlayersWithScoreGreaterThan(minScore);
            ListPlayers(playersWithHigherScore);
        }

        /// <summary>
        /// Get players with a score higher than a given value.
        /// </summary>
        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            List<Player> coolPlayers = new List<Player>();

            foreach (Player player in playerList)
            {
                if (player.Score > minScore)
                {
                    coolPlayers.Add(player);
                }
            }

            return coolPlayers;
        }
    }
}