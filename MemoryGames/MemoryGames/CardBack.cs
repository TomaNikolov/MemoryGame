using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace MemoryGames
{
    [Serializable]
   public class CardBack : Card, IPrintable
   {
       const int cardWidth = 8;
       const int cardHeight = 10;
       public int Height { get; protected set; }
       public int Widht { get; protected set; }
       public CardPosition TopLeft { get; protected set; }
        public CardBack()
        {
            this.IsVisible = true;
            this.Height = cardHeight;
            this.Widht = cardWidth;
            this.TopLeft = new CardPosition();
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("IsVisible", this.IsVisible);
            info.AddValue("Height", this.Height);
            info.AddValue("Widht", this.Widht);
            info.AddValue("TopLeft", this.TopLeft);
        }
        public override void DrowSelf(int row, int col)
        {
            if (IsVisible)
            {
                CardPosition position = CardPosition.GeneratePosition(row, col);
                this.TopLeft = position;
                Print(position);
            }
        }

        public void Print(CardPosition topleft)
        {
            
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("##=##=##");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.Write("#**");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("/\\");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("**#");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.Write("#*");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("//\\\\");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("*#");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.Write("#");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("//");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("??");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("#");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.Write("#");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("??");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("//");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("#");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.Write("#*");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\//");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("*#");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.Write("#**");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("**#");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.WriteLine("##=##=##");
            Console.ResetColor();
        }
    }
}
