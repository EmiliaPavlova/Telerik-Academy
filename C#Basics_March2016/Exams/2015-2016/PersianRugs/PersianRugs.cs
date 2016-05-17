namespace PersianRugs
{
    using System;

    class PersianRugs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int distance = int.Parse(Console.ReadLine());
            
            int dots = width - (2 * distance) - 4;
            int rows = 0;
            for (int i = 0, j = dots; i < n; i++, j -= 2)
            {
                if (dots < 0)
                {
                    break;
                }

                Console.WriteLine("{0}{1}{2}{1}{3}{4}{2}{4}{0}", 
                    new string('#', i),
                    '\\', 
                    new string(' ', distance), 
                    new string('.', dots), 
                    '/');
                dots -= 2;
                rows++;
                if (dots < 0)
                {
                    break;
                }
            }

            int space = width - (2 * rows) - 2;
            int height = 0;
            for (int i = 0, j = space; i < n - rows; i++, j -= 2)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('#', rows + i), '\\', new string(' ', j), '/');
                height++;
            }

            Console.WriteLine("{0}{1}{0}", new string('#', n), 'X');

            for (int i = n, j = 1; i > rows; i--, j += 2)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('#', i - 1), '/', new string(' ', j), '\\');
            }

            dots = 1;
            for (int i = rows - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{4}{2}{4}{0}", 
                    new string('#', i), 
                    '/', 
                    new string(' ', distance), 
                    new string('.', dots), 
                    '\\');
                dots += 2;
            }
        }
    }
}
