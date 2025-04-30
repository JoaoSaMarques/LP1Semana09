using System;

namespace PlayerManager4
{
    /// <summary>
    /// Represents a player with a name and score.
    /// </summary>
    public class Player : IComparable<Player>
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

        /// <summary>
        /// Compares this player to another player by score descending.
        /// </summary>
        /// <param name="other">The other player to compare to.</param>
        /// <returns>
        /// A negative number if this player has a higher score than other,
        /// zero if scores are equal, positive if this player has a lower score.
        /// </returns>
        public int CompareTo(Player other)
        {
            if (other == null) return -1;
            // Descending order by score
            return other.Score.CompareTo(this.Score);
        }
    }
}
