namespace TriangleSurfaceByThreeSides
{
    using System;

    class TriangleSurfaceByThreeSides
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            Console.WriteLine("{0:F2}", area);
        }
    }
}
