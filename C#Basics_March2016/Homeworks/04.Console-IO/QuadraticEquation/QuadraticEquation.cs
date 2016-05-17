namespace QuadraticEquation
{
    using System;

    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if ((b * b) - (4 * a * c) >= 0)
            {
                double x1 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                double x2 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                if (x1 == x2)
                    Console.WriteLine("{0:F2}", x1);
                else if (x1 < x2)
                {
                    Console.WriteLine("{0:F2}\r\n{1:F2}", x1, x2);
                }
                else
                {
                    Console.WriteLine("{0:F2}\r\n{1:F2}", x2, x1);
                }
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
