using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MemoryGames
{
    [Serializable]
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
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", this.Name);
            info.AddValue("Score", this.Score);
            info.AddValue("SuccessCoefficient", this.SuccessCoefficient);
        }

    }
}
