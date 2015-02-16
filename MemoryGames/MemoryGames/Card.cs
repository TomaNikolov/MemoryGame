using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGames
{
    public abstract class Card
    {
        public int Hight { get; protected set;}
        public int Weight{ get; protected set;}
        public bool IsVisible { get; set; }

        public Card()
        {

        }
        public abstract void DrowSelf(int positionX, int positionY);
      
      
    }
}
