using System;

namespace MemoryGames
{
    public class CardPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CardPosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public static CardPosition GeneratePosition(int row, int col)
        {
            CardPosition[,] Positions = {
                { new CardPosition(2,15), new CardPosition(15,15), new CardPosition(28,15),
                  new CardPosition(41,15), new CardPosition(54,15), new CardPosition(67,15),},
                { new CardPosition(2,26), new CardPosition(15,26), new CardPosition(28,26),
                  new CardPosition(41,26), new CardPosition(54,26), new CardPosition(67,26),}
                };
            return Positions[row, col];
        }
    }
}
