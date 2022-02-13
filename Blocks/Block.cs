using System;

namespace ConsoleTetris
{
    public abstract class Block
    {   
        public abstract char Unit { get; }
        public ConsoleColor Color { get; set; }

        public Block(ConsoleColor color) => Color = color;

        public override string ToString() => Unit.ToString();
    }
}
