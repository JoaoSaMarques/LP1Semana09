using System;

namespace PlayerManager1
{
    /// <summary>
    /// Represents a player with a name and score.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets the player's name (read-only).
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets or sets the player's score.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Initializes a new instance of the Player class.
        /// </summary>
        /// <param name="name">The player's name.</param>
        /// <param name="score">The player's score.</param>
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
