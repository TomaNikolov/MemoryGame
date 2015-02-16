using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGames
{
    class CardBack : Card, IPrintable
    {
        public CardBack()
        {
            this.IsVisible = true;
        }
        public override void DrowSelf(int positionX, int positionY)
        {
            if (IsVisible)
            {
                Print(positionX, positionY);
            }
        }


        public void Print(int positionX, int positionY)
        {
            Console.SetCursorPosition(positionX, positionY);
        }
    }
}
