namespace NFactorial
{
    using System;
    using System.Numerics;

    class NFactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FindFactorial(n));
        }

        static BigInteger FindFactorial(int n)
        {
            BigInteger number = 1;
            for (int i = 1; i <= n; i++)
            {
                number *= i;
            }

            return number;
        }
    }
}
