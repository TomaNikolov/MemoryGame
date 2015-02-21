using System;

namespace MemoryGames
{

    public class GameBackground
    {
        public static void Logo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('#', 77));
            Console.Write("#");
            Console.SetCursorPosition(76, 1);
            Console.WriteLine("#");
            Console.Write("#");
            Console.SetCursorPosition(76, 2);
            Console.WriteLine("#");
            Console.Write("#");
            Console.SetCursorPosition(35, 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Memory");
            Console.SetCursorPosition(30, 3);
            Console.Write("By Team \"Daegon\"");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(76, 3);
            Console.WriteLine("#");
            Console.Write("#");
            Console.SetCursorPosition(76, 4);
            Console.WriteLine("#");

            Console.SetCursorPosition(0, 5);
            Console.WriteLine(new string('#', 77));
            Console.ResetColor();
        }
       
        public static void MenuBackground(int position, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            switch (position)
            {
                case 0:
                    Console.SetCursorPosition(30, 7);
                    Console.BackgroundColor = backgroundColor;
                    Console.ForegroundColor = foregroundColor;
                    Console.WriteLine("      New Game      ");
                    break;
                case 1:
                    Console.SetCursorPosition(30, 9);
                    Console.BackgroundColor = backgroundColor;
                    Console.ForegroundColor = foregroundColor;
                    Console.WriteLine("      Load Game     ");
                    break;
                case 2:
                    Console.SetCursorPosition(30, 11);
                    Console.BackgroundColor = backgroundColor;
                    Console.ForegroundColor = foregroundColor;
                    Console.WriteLine("        Help        ");
                    break;
            }
            Console.ResetColor();
        }
        public static void CleanBackground()
        {
            for (int row = 6; row < Console.WindowHeight - 1; row++)
            {
                 Console.SetCursorPosition(0, row);
                 Console.WriteLine(new string(' ', 77));
            }
        }
    }
}
