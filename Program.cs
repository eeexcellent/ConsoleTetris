using System;
using System.Collections.Generic;

namespace ConsoleTetris
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            GameSpace gs = new GameSpace(10, 10, ConsoleColor.DarkCyan);

            gs.Display();

            Console.ReadLine();
        }
    }
}
