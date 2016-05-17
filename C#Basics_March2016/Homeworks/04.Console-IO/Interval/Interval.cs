namespace Interval
{
    using System;

    class Interval
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = n + 1; i < m; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
