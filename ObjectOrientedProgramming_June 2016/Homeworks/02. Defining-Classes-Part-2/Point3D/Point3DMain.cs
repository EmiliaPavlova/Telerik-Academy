namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            PathStorage.Save("1 2 3|12 34 4", "coordinates");
            var points = new List<Point3D>
            {
                new Point3D(1, 3, 5),
                new Point3D(2, 3, 5),
                new Point3D(5, 13, 51),
                new Point3D(1, 3, 25),
                new Point3D(1, 3, 5),
                new Point3D(4, 3, 6),
            };

            PathStorage.Save(points, "New_coordinates");

            var loadedPoints = PathStorage.Load("New_coordinates");
            var path = new Path3D(loadedPoints);

            Console.WriteLine(path);
        }
    }
}
