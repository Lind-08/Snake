using System;

namespace Snake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(4, 6, 4, '*');
            line.Draw();

            VerticalLine line1 = new VerticalLine(4, 6, 3, '+');
            line1.Draw();
            Console.ReadKey();
        }
    }
}