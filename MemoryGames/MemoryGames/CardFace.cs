using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGames
{
    public class CardFace : Card, IPrintable
    {
        public string CardName { get; set; }
        public CardFace(string cardName)
        {
            this.CardName = cardName;
            this.IsVisible = false;
        }
        public override void DrowSelf(int positionX, int positionY)
        {
            throw new NotImplementedException();
        }

        public void Print(CardPosition topLeft)
        {
            throw new NotImplementedException();

        }

        public static bool operator ==(CardFace firstCardFace, CardFace secondCardFace)
        {
            if (firstCardFace.CardName == secondCardFace.CardName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(CardFace firstCardFace, CardFace secondCardFace)
        {
            return !(firstCardFace == secondCardFace);
        }
    }
}
