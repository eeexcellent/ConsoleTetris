using System;

namespace ConsoleTetris
{
    public class SegmentBlock : Block
    {
        public override char Unit => Global.SegmentBlockUnit;

        public SegmentBlock(ConsoleColor color) : base(color)
        {
        }
    }
}
