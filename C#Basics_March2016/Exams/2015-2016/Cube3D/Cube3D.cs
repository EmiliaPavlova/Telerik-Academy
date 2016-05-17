namespace Cube3D
{
    using System;

    class Cube3D
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char dots = ':';
            char pipe = '|';
            char minus = '-';
            char space = ' ';

            Console.WriteLine(new string(dots, n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}", 
                    dots, new string(space, n - 2), new string(pipe, i));
            }

            Console.WriteLine("{0}{1}{2}", new string(dots, n), new string(pipe, n - 2), dots);

            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}", 
                    new string(space, i), dots, new string(minus, n - 2), new string(pipe, n - 2 - i));
            }

            Console.WriteLine("{0}{1}", new string(space, n - 1), new string(dots, n));
        }
    }
}
