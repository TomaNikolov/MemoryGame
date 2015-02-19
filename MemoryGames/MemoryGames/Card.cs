using System;

namespace MemoryGames
{
     

    public abstract class Card
    {
        public bool IsVisible { get; set; }

        public Card()
        {

        }

        public abstract void DrowSelf(int positionX, int positionY);
    }
}
