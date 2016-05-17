namespace BitSwap
{
    using System;

    class BitSwap
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int q1 = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int p = 0;
            int q = 0;

            // p < q
            if (p1 > q1)
            {
                p = q1;
                q = p1;
            }
            else
            {
                p = p1;
                q = q1;
            }

            int maskPBits = CreateMask(p, k);
            int maskQBits = CreateMask(q, k);
            long pBits = n & maskPBits;
            long qBits = n & maskQBits;
            long switchedBits = (pBits << (q - p) | qBits >> (q - p));
            long nullBits = n & ~(maskPBits | maskQBits);
            long result = nullBits | switchedBits;
            Console.WriteLine(result);

        }

        public static int CreateMask(int p, int k)
        {
            int result = 0;
            for (int i = 0; i < k; i++)
            {
                result = result << 1 | 1;
            }

            result = result << p;
            return result;
        }
    }
}
