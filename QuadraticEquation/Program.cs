using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введіть число a");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число b");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число c");
            c = double.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D > 0)
            {
                double x1 = -b + Math.Sqrt(D) / 2 * a;
                double x2 = -b - Math.Sqrt(D) / 2 * a;
                Console.WriteLine($"x1: {x1}, x2: {x2}");
            }
            else if (D == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine($"x: {x}");

            }
            else {
                Console.WriteLine("D < 0, коренів не існує");
            }
        }
    }
}
