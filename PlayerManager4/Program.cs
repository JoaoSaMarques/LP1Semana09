﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayerManager4
{
    public class Program
    {
        private List<Player> playerList;

        private static void Main()
        {
            Program prog = new Program();
            prog.Start();
        }

        private Program()
        {
            playerList = new List<Player>() {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
        }

        private void Start()
        {
            string option;

            do
            {
                ShowMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        ListPlayers(playerList.OrderByDescending(p => p.Score));
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case "4":
                        ListPlayersSortedByName(true);
                        break;
                    case "5":
                        ListPlayersSortedByName(false);
                        break;
                    case "6":
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
                        break;
                }

                Console.Write("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.WriteLine("\n");

            } while (option != "6");
        }

        private void ShowMenu()
        {
            Console.WriteLine("Player Manager Menu:");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players (by score descending)");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. List players by name ascending");
            Console.WriteLine("5. List players by name descending");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
        }

        private void InsertPlayer()
        {
            Console.Write("Enter player name: ");
            string name = Console.ReadLine();

            int score;
            while (true)
            {
                Console.Write("Enter player score (integer): ");
                string scoreInput = Console.ReadLine();
                if (int.TryParse(scoreInput, out score))
                {
                    break;
                }
                Console.WriteLine("Invalid score. Please enter a valid int.");
            }

            Player newPlayer = new Player(name, score);
            playerList.Add(newPlayer);
            Console.WriteLine($"Player '{name}' with score {score} added.");
        }

        private static void ListPlayers(IEnumerable<Player> playersToList)
        {
            Console.WriteLine("\nList of players:");
            foreach (var player in playersToList)
            {
                Console.WriteLine($"Name:{player.Name}, Score:{player.Score}");
            }
        }

        private void ListPlayersWithScoreGreaterThan()
        {
            int minScore;
            while (true)
            {
                Console.Write("Enter minimum score to filter players: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out minScore))
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid int.");
            }

            var filteredPlayers = GetPlayersWithScoreGreaterThan(minScore);
            ListPlayers(filteredPlayers.OrderByDescending(p => p.Score));
        }

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            foreach (var player in playerList)
            {
                if (player.Score > minScore)
                {
                    yield return player;
                }
            }
        }

        private void ListPlayersSortedByName(bool ascending)
        {
            var comparer = new CompareByName(ascending);
            var sortedList = new List<Player>(playerList);
            sortedList.Sort(comparer);
            ListPlayers(sortedList);
        }
    }
}
