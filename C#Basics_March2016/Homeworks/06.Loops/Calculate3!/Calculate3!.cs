namespace Calculate3_
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1; // n!/k!
            BigInteger difference = 1; // (n-k)!

            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            for (int j = (n - k); j > 0; j--)
            {
                difference *= j;
            }

            BigInteger output = result / difference;
            Console.WriteLine(output);
        }
    }
}
