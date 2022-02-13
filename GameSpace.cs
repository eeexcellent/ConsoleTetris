using System;

namespace ConsoleTetris
{
    internal class GameSpace
    {
        public const int BorderSize = 1;
        public int Width { get; private set; }
        public int Height { get; private set; }
        public ConsoleColor BorderColor { get; private set; }

        private Block[,] _rectangle;

        public GameSpace(int width, int height, ConsoleColor borderColor)
        {
            if (width <= 0 || height <= 0) throw new ArgumentException();

            Width = width + BorderSize * 2;
            Height = height + BorderSize * 2;
            BorderColor = borderColor;
            _rectangle = new Block[Width, Height];

            CreateBorder();
        }

        public Block this[int X, int Y]
        {
            get
            {
                if((X < 0 || Y < 0) || (X > Width - 1 || Y > Height - 1))
                {
                    return null;
                }
                else
                {
                    return _rectangle[X, Y];
                }
            }
            set
            {
                if ((X < 0 || Y < 0) || (X > Width - 1 || Y > Height - 1))
                {
                    return;
                }
                if(_rectangle[X,Y] is not BorderBlock)
                {
                    _rectangle[X, Y] = value;
                }
            }
        }
        public void Display()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    ConsoleGraphics.Draw(_rectangle[x, y], x, y);
                }
            }

        }

        private void CreateBorder()
        {
            for (int depth = 0; depth < BorderSize; depth++)
            {
                for (int x = 0; x < Width; x++)
                {
                    _rectangle[x, depth] = new BorderBlock(BorderColor); // Top
                    _rectangle[x, depth + Height - BorderSize ] = new BorderBlock(BorderColor); // Bottom
                }
                for (int y = BorderSize ; y < Height - BorderSize; y++)
                {
                    _rectangle[depth, y] = new BorderBlock(BorderColor); // Left
                    _rectangle[depth + Width - BorderSize, y] = new BorderBlock(BorderColor); // Right
                }
            }
        }
        private void ForEach(Action<Block> action)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    action(_rectangle[x, y]);
                }
            }
        }
    }
}
