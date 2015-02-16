using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGames
{
    class Player : IPrintable
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public void Print(int positionX, int positionY)
        {
            throw new NotImplementedException();
        }
    }
}
