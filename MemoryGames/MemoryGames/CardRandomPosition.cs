using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGames
{
   public class CardRandomPosition
    {
      private  List<CardFace> gameCard = new List<CardFace>();

      private  string[] cardName = new string[8];//here will be the name of the card

       private Random randomGenerator = new Random();

        public static void FillMatrix()
        {
        }


        internal static CardFace[,] GetRandomCardFace()
        {
            throw new NotImplementedException();
        }
    }
}

