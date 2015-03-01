using System;
// help class shows instructions about how to play the game, gives credits to the members of the team

namespace MemoryGames
{
    class Help
    {
        public static void ShowHelp()
        {
            GameBackground.CleanBackground();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(38, 11);
            Console.WriteLine("Help\n\n");

            Console.Write(new string(' ', 6));
            Console.WriteLine("1. At the start of the game all of the cards are laid face down.");

            Console.Write(new string(' ', 6));
            Console.WriteLine("2. Only two cards are flipped face up over each turn.");

            Console.Write(new string(' ', 6));
            Console.WriteLine("3. The object is to turn over pairs of matching cards.");

            Console.Write(new string(' ', 6));
            Console.WriteLine("4. If the cards are the same, they remain flipped until game ends.");

            Console.Write(new string(' ', 6));
            Console.WriteLine("5. If they are not the same, they are flipped back.");
            //----------------------------------------------------------------------

            Console.WriteLine("\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(36, 22);
            Console.WriteLine("Credits:\n");

            Console.SetCursorPosition(0, 24);
            Console.Write(new string(' ', 6));
            Console.WriteLine("tomasaa, milislavski, mihail.madzharo, martina_vass, Acrelion, \n      ScrublordBG, filkin1912");


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(31, 27);
            Console.WriteLine("Current Highscores");
            
            HighScores.Read(); // HighScores are being called here to read the file
                               // and show the current 5 highscores.


            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(27, 44);
            Console.WriteLine("Press any key to return.");
            Console.SetCursorPosition(28, 45);
            Console.WriteLine("          ...           ");
            Console.SetCursorPosition(39, 46);

            Console.ReadLine();
            GameBackground.CleanBackground();
            GameManager.Menu();

        }


    }
}
