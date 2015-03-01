﻿using System;
using System.Collections.Generic;
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
                GameBackground.MenuBackground(position, ConsoleColor.Cyan, ConsoleColor.Blue); //Changed 20:49, 21.2 - Ivan (was magenta, red);

                Thread.Sleep(400);
            }
            GameBackground.CleanBackground();
            switch (position)
            {
                case 0:
                    NewGame(1);
                    break;
                case 1:
                    LoadGame();
                    break;
                case 2: //added
                    Help.ShowHelp();
                    break;
            }
        }

        private static void NewGame(int level)
        {

            CardBack[,] cardBack = CardRandomPosition.GetCardBack(level);
            CardFace[,] cardFace = CardRandomPosition.GetRandomCardFace(cardBack.GetLength(0), cardBack.GetLength(1));
             GameEngine gameEngine = new GameEngine(cardBack, cardFace, new Player(ConsoleInput.GetInput()), level); // 22:02, 21.2 Ivan (was "PlayerName")
            gameEngine.Run();
        }
        private static void LoadGame()
        {
            Serializer serializer = new Serializer();
            SerializeObject serializeObject = new SerializeObject();
            serializeObject = serializer.DeSerializeObject("../../../Save.memory");
            GameEngine gameEngine = serializeObject.GameEngine;
            gameEngine.Run();
        }
        public static void ExitGame()
        {
            Environment.Exit(0);
        }
        public static void WinGame()
        {

            GameBackground.CleanBackground();
            Console.SetCursorPosition(28, 16); // was 12
            Console.WriteLine("Congratulations, You Win!"); //changed   
            Console.SetCursorPosition(28, 18);
            Console.WriteLine("Press ESCAPE to close the game");
            Console.SetCursorPosition(28, 19);
            Console.WriteLine("and save your score!");
            Thread.Sleep(5000);
            GameBackground.CleanBackground();
        }

        public static void NextLevel(int level)
        {
            throw new NotImplementedException();
        }

        public static void SaveGame(CardBack[,] cardBack, CardFace[,] cardFace, Player player, List<CardPosition> list, int level)
        {
            GameEngine saveGame = new GameEngine(cardBack,cardFace, player, level);
            SerializeObject serializeObject = new SerializeObject();
            serializeObject.GameEngine = saveGame;
            Serializer serializer = new Serializer();
            serializer.SerializeObject("../../../Save.memory", serializeObject);
        }

        public static void SaveScore(Player player) // new, 1.3.
        {
            string playerToWrite = player.Name;
            string scoreToWrite = player.Score.ToString();

            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append(playerToWrite);
            builder.Append(" ");
            builder.Append(scoreToWrite);

            string playerAndScore = builder.ToString();

            HighScores.Write(playerAndScore);
            
        }
    }
}
