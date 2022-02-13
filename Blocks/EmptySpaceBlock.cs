using System;

namespace ConsoleTetris
{
    public class EmptySpaceBlock : Block
    {
        public override char Unit => Global.EmptySpaceBlockUnit;

        public EmptySpaceBlock() : base(Console.ForegroundColor)
        {
        }
    }
}
