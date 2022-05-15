using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw(); 
            
            Point p2 = new Point(6, 9, '#');
            p2.Draw();

            Console.ReadKey();

        }

    }
}
