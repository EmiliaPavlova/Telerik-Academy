namespace Shapes
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            IShape[] shapes =
            {
                new Rectangle(3, 4),
                new Triangle(5.5, 3),
                new Square(6)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("This is a {0} with area: {1:f2}", shape.GetType().Name.ToLower(), shape.CalculateSurface());
            }
        }
    }
}
