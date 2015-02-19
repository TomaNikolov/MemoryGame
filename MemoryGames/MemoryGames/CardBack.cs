using System;

namespace MemoryGames
{
   public class CardBack : Card, IPrintable
    { 
        public CardBack()
        {
            this.IsVisible = true;
        }

        public override void DrowSelf(int row, int col)
        {
            if (IsVisible)
            {
                CardPosition position = CardPosition.GeneratePosition(row, col);
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
