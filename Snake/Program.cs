using System;

namespace Snake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            p.Draw();
            Console.ReadKey();
        }
    }
}