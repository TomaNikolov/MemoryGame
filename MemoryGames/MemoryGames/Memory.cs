// Everything starts here.
// Window size is set, logo is printed and game menu is called.

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

