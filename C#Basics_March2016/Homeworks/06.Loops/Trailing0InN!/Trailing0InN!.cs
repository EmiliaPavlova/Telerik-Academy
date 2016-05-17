namespace Trailing0InN_
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            int countZeroes = 0;
            
            for (int i = 5; n / i >= 1; i *= 5)
            {
                countZeroes += n / i;
            }

            Console.WriteLine(countZeroes);
        }
    }
}
