namespace PointInACircle
{
    using System;

    class PointInACircle
    {
        public const int X_center = 0;
        public const int Y_center = 0;
        public const int Radius = 2;

        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double checkInside = Math.Pow(x - X_center, 2) + Math.Pow(y - Y_center, 2);
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            if (checkInside <= Math.Pow(Radius, 2))
            {
                Console.WriteLine("yes {0:F2}", distance);
            }
            else
            {
                Console.WriteLine("no {0:F2}", distance);
            }
        }
    }
}
