using System;

namespace MemoryGames
{
   public class Player 
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int SuccessCoefficient { get; set; }

        public Player(string name)
        {
            this.Name = name;
            this.Score = 0;
            this.SuccessCoefficient = 20;
        }


    }
}
