using System;

namespace PlayerManager1
{
    public class Player
    {
        //Name
        public string Name { get; }
        //Score
        public int Score { get; set; }

        /// <summary>
        /// Player Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
