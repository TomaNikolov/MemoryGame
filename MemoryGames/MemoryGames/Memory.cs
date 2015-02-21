using System;

namespace MemoryGames
{
    public class Memory
    {
        public static void Main(string[] args)
        {
            Console.SetWindowSize(78, 50);
            GameBackground.Logo();
           GameManager.Menu();
        }

       
    }
}

