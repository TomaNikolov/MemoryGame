using System;
using System.Collections.Generic;
using System.Threading;

namespace MemoryGames
{
    public class GameEngine
    {
        public CardBack[,] CardBack { get; set; }
        public CardFace[,] CardFace { get; set; }
        public Player Player { get; set; }
        public HashSet<CardPosition> Check { get; set; }

        public GameEngine(CardBack[,] cardBack, CardFace[,] cardFace, Player player)
        {
            this.CardFace = cardFace;
            this.CardBack = CardBack;
            this.Player = player;
            this.Check = new HashSet<CardPosition>();
        }
        public void Run()
        {
            //TODO Score,  win, exit and player
            GameBackground.Grid();
            while (true)
            {
                Refresh();
                CardPosition firstcard = ConsoleInput.GetPositionFromInput();
                this.CardFace[firstcard.X - 1, firstcard.Y - 1].IsVisible = true;
                this.CardBack[firstcard.X - 1, firstcard.Y - 1].IsVisible = false;
                Refresh();
                CardPosition secondCard = ConsoleInput.GetPositionFromInput();
                this.CardFace[secondCard.X - 1, secondCard.Y - 1].IsVisible = true;
                this.CardBack[secondCard.X - 1, secondCard.Y - 1].IsVisible = false;
                Refresh();
                if (this.CardFace[firstcard.X - 1, firstcard.Y - 1] ==
                   this.CardFace[secondCard.X - 1, secondCard.Y - 1])
                {
                    this.Check.Add(new CardPosition(firstcard.X - 1, firstcard.Y - 1));
                    this.Check.Add(new CardPosition(secondCard.X - 1, secondCard.Y - 1));
                }
                else
                {
                    this.CardFace[firstcard.X - 1, firstcard.Y - 1].IsVisible = false;
                    this.CardBack[firstcard.X - 1, firstcard.Y - 1].IsVisible = true;
                    this.CardFace[secondCard.X - 1, secondCard.Y - 1].IsVisible = false;
                    this.CardBack[secondCard.X - 1, secondCard.Y - 1].IsVisible = true;
                }
                Thread.Sleep(800);
            }
        }

        private void Refresh()
        {
            for (int i = 0; i < this.CardBack.GetLength(0); i++)
            {
                for (int j = 0; j < this.CardBack.GetLength(1); j++)
                {
                    this.CardBack[i, j].DrowSelf(i, j);
                    this.CardFace[i, j].DrowSelf(i, j);
                }
            }
        }
    }
}
