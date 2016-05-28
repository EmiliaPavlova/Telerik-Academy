namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    using System;

    class TriangleSurfaceByTwoSidesAndAnAngle
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double degrees = double.Parse(Console.ReadLine());

            // area = a * b * sin angle / 2
            double angle = Math.PI * degrees / 180;
            double area = a * b * Math.Sin(angle) / 2;
            Console.WriteLine("{0:F2}", area);
        }
    }
}
