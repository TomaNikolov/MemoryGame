using System;

namespace MemoryGames
{
    public class Memory
    {
        public static void Main(string[] args)
        {
           // Console.SetBufferSize(78, 40);
            Console.SetWindowSize(78, 50);
            GameBackground.Logo();
           GameManager.Menu();
        }

       
    }
}

