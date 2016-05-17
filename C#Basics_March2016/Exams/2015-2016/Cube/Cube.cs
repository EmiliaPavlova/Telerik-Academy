namespace Cube
{
    using System;

    class Cube
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char top = '/';
            char border = ':';
            char side = 'X';
            char space = ' ';

            Console.WriteLine("{0}{1}", new string(space, n - 1), new string(border, n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}",new string(space, n - 2 - i), new string(border, 1), new string(top, n - 2), new string(side, i));
            }

            Console.WriteLine("{0}{1}{2}", new string(border, n), new string(side, n - 2), new string(border, 1));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}", new string(border, 1), new string(space, n - 2), new string(side, n - 3 - i));
            }

            Console.WriteLine("{0}", new string(border, n));
        }
    }
}
