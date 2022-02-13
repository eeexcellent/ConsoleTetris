using System;

namespace ConsoleTetris
{
    public class BorderBlock : Block
    {
        public override char Unit => Global.BorderBlockUnit;

        public BorderBlock(ConsoleColor color) : base(color)
        {
        }
    }
}
