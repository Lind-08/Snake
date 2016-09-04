using System;

namespace Snake
{
    internal class Point
    {
        private int x;
        private int y;
        private char sym;

        public Point()
        {
            x = 0;
            y = 0;
            sym = '\0';
        }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}