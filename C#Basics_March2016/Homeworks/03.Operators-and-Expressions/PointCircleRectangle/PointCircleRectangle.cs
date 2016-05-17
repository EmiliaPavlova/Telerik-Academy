namespace PointCircleRectangle
{
    using System;

    class PointCircleRectangle
    {
        public const int X_center = 1;
        public const int Y_center = 1;
        public const double Radius = 1.5;
        public const int RectangleTop = 1;
        public const int RectangleLeft = -1;
        public const int RectangleWidth = 6;
        public const int RectangleHeight = 2;


        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double checkInsideCircle = Math.Pow(x - X_center, 2) + Math.Pow(y - Y_center, 2);
            if (checkInsideCircle <= Radius * Radius)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }

            if ((RectangleLeft <= x && x <= RectangleLeft + RectangleWidth) && 
                (RectangleTop < y && y <= RectangleTop + RectangleHeight))
            {
                Console.WriteLine("outside rectangle");
            }
            else
            {
                Console.WriteLine("inside rectangle");
            }
        }
    }
}
