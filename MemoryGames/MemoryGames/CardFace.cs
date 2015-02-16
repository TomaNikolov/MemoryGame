using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGames
{
    class CardFace : Card, IPrintable
    {
        public CardFace()
        {
            this.IsVisible = false;
        }
        public override void DrowSelf(int positionX, int positionY)
        {
            throw new NotImplementedException();
        }

        public void Print(int positionX, int positionY)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}
