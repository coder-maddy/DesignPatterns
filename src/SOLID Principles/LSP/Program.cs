using System;

namespace LSP
{
    class Program
    {
        static public int Area(Violation.Rectangle rectangle) => rectangle.Height * rectangle.Width;

        static void Main(string[] args)
        {
            Violation.Rectangle rect = new Violation.Rectangle(10,20);
            Console.WriteLine($"{rect} has area {Area(rect)}");

            Violation.Square sq = new Violation.Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");
            //###############################################
            Shape rc = new Rectangle(10, 20);
            Console.WriteLine($"{rect} has area {rc.Area()}");

            Shape sqr = new Square(10);
            Console.WriteLine($"{sqr} has area {sqr.Area()}");

            Console.ReadLine();
        }
    }
}
