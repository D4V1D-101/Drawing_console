using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle circle = new Circle(7.5);
            //circle.Radius = 6;

            //Console.WriteLine(circle.Getarea());
            //Console.WriteLine(circle.ker());
            //Console.WriteLine(circle.ter());
            //Console.ReadKey();

            Box keret = new Box(6,6,20,20, ConsoleColor.Green);
            keret.Draw();
            Console.ReadKey();

        }

    }
}
