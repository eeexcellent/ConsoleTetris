using System;

namespace ConsoleTetris
{
    public static class ConsoleGraphics
    {
        public static void Draw(Block block, int X, int Y)
        {
            if (block == null) return;
            ConsoleColor initColor = Console.ForegroundColor;

            Console.ForegroundColor = block.Color;
            Console.SetCursorPosition(X, Y);
            Console.Write(block);

            Console.ForegroundColor = initColor;
        }
    }
}
