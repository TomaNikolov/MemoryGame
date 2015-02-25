using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MemoryGames
{
    [Serializable]
    public class CardPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CardPosition()
        {
        }

        public CardPosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("X", this.X);
            info.AddValue("Y", this.Y);
        }
        public static CardPosition GeneratePosition(int row, int col)
        {
            CardPosition[,] Positions = {
                { new CardPosition(2,15), new CardPosition(15,15), new CardPosition(28,15),
                  new CardPosition(41,15), new CardPosition(54,15), new CardPosition(67,15),},
                { new CardPosition(2,26), new CardPosition(15,26), new CardPosition(28,26),
                  new CardPosition(41,26), new CardPosition(54,26), new CardPosition(67,26),},
                { new CardPosition(2,37), new CardPosition(15,37), new CardPosition(28,37),
                  new CardPosition(41,37), new CardPosition(54,37), new CardPosition(67,37),}
                };
            return Positions[row, col];
        }
    }
}
