using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGames
{
    public class CardRandomPosition
    {
        public static CardFace[,] GetRandomCardFace(int dimentionZero, int dimentionOne)
        {
            const int pair = 2;
            const int pairCount = 9;
            CardFace[,] cardFace = new CardFace[dimentionZero, dimentionOne];
            Random randomGenerator = new Random();
            List<CardFace> gameCard = new List<CardFace>();
            int allCard = dimentionZero * dimentionOne;
            int currentGameCardPair = allCard / pair;
            string[] cardName = new string[pairCount] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            for (int element = 0, j = 0; element < allCard; element++, j++)
            {
                if (j == currentGameCardPair)
                {
                    j = 0;
                }
                gameCard.Add(new CardFace(cardName[j]));
            }
            for (int row = 0; row < dimentionZero; row++)
            {
                for (int col = 0; col < dimentionOne; col++)
                {
                    int randomElement = randomGenerator.Next(0, gameCard.Count);
                    cardFace[row, col] = gameCard[randomElement];
                    gameCard.RemoveAt(randomElement);

                }
            }
            return cardFace;
        }

        public static CardBack[,] GetCardBack(int level)
        {
            const int colEnd = 6;
            CardBack[,] cardBack = new CardBack[level, colEnd];
            for (int row = 0; row < cardBack.GetLength(0); row++)
            {
                for (int col = 0; col < cardBack.GetLength(1); col++)
                {
                    cardBack[row, col] = new CardBack();
                }
            }
            return cardBack;
        }
    }
}

