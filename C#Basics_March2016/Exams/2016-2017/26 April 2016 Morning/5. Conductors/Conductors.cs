namespace Conductors
{
    using System;

    class Conductors
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int length = Convert.ToString(p, 2).Length;
            int perforator = (1 << length) - 1 ;


            for (int i = 0; i < m; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int pattern = p;
                int mask = perforator;

                do
                {
                    if ((n & mask) == pattern)
                    {
                        n &= ~mask;
                    }

                    mask <<= 1;
                    pattern <<= 1;
                } while ((pattern & (1 << 31)) == 0);

                Console.WriteLine(n);
            }
        }
    }
}
