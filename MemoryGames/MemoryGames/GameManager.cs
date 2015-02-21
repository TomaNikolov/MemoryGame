using System;
using System.Threading;

namespace MemoryGames
{
    public class GameManager
    {
        public static void Menu()
        {
           const int menuItemCount = 3;
            int menuSwitchPosition = 0;
            int position = 0;

            for (int row = 0; row < menuItemCount; row++)
            {
                GameBackground.MenuBackground(row, ConsoleColor.Black, ConsoleColor.Red);
            }

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key.Equals(ConsoleKey.UpArrow))
                    {
                        if (menuSwitchPosition > 0)
                        {
                            menuSwitchPosition--;
                        }
                    }
                    if (keyInfo.Key.Equals(ConsoleKey.DownArrow))
                    {
                        menuSwitchPosition++;
                    }
                    if (keyInfo.Key.Equals(ConsoleKey.Enter))
                    {
                        break;
                    }
                }
                GameBackground.MenuBackground(position, ConsoleColor.Black, ConsoleColor.Red);
                position = menuSwitchPosition % menuItemCount;
                GameBackground.MenuBackground(position, ConsoleColor.Magenta, ConsoleColor.Red);

                Thread.Sleep(400);
            }
            GameBackground.CleanBackground();
            switch (position)
            {
                case 0:
                    NewGame(1);
                    break;
            }
        }

        private static void NewGame(int level)
        {

            CardBack[,] cardBack = CardRandomPosition.GetCardBack(level);
            CardFace[,] cardFace = CardRandomPosition.GetRandomCardFace(cardBack.GetLength(0), cardBack.GetLength(1));
             GameEngine gameEngine = new GameEngine(cardBack, cardFace, new Player("PlayerName"), level);
            gameEngine.Run();
        }
        private static void LoadGame()
        {
            throw new NotImplementedException();
        }
        private static void SaveGame()
        {
            throw new NotImplementedException();
        }
        private static void ExitGame()
        {
            throw new NotImplementedException();
        }
        public static void WinGame()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, 15);
            Console.WriteLine("Win");
        }

        public static void NextLevel(int level)
        {
            throw new NotImplementedException();
        }
    }
}
