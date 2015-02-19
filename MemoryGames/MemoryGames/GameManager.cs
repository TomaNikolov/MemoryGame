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
                    NewGame();
                    break;
            }
        }

        private static void NewGame()
        {

            CardBack[,] cardBack = new CardBack[2, 6];
            for (int row = 0; row < cardBack.GetLength(0); row++)
            {
                for (int col = 0; col < cardBack.GetLength(1); col++)
                {
                    cardBack[row, col] = new CardBack();
                }
            }
            // CardFace[,] cardFace = CardRandomPosition.GetRandomCardFace();
            // GameEngine gameEngine = new GameEngine(cardBack, cardFace, new Player("PlayerName"));
            // gameEngine.Run();
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
        private static void WinGame()
        {
            throw new NotImplementedException();
        }
    }
}
