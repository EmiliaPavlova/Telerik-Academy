namespace DecimalToBinary
{
    using System;
    using System.Numerics;

    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            string binary = string.Empty;
            while (n != 0)
            {
                BigInteger bit = n % 2;
                binary = bit + binary;
                n /= 2;
            }

            Console.WriteLine(binary);
        }
    }
}
