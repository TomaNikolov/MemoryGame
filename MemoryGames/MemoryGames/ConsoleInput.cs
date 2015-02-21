using System;

namespace MemoryGames
{
  public  class ConsoleInput
    {

      public static string GetInput() //21:10, 21.2.
      {
          //Gets the player name.

          Console.SetCursorPosition(34, 8);
          Console.WriteLine("Your name?");

          Console.SetCursorPosition(37, 11);
          string input = Console.ReadLine();

          while (CheckInput(input) != true)
	      {
              GameBackground.CleanBackground(); //22:10, 21.2

              Console.SetCursorPosition(27, 8);
              Console.WriteLine("Name too short. Try again.");

              Console.SetCursorPosition(37, 11);
              input = Console.ReadLine();
	      }

          GameBackground.CleanBackground();
          return input;
      }

      public static bool CheckInput(string input) //21:10, 21.2.
      {
          if (input.Length != 0)
          {
              return true;
          }
          return false;
      }
      
    }
}
