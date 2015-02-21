using System;

namespace MemoryGames
{
  public  class ConsoleInput
    {
        public static CardPosition GetPositionFromInput()
        {
            Console.Write("Row: ");
             int row = int.Parse(Console.ReadLine());
             Console.Write("Col: ");
             int col = int.Parse(Console.ReadLine());
             return new CardPosition(row, col);
        }
    }
}
