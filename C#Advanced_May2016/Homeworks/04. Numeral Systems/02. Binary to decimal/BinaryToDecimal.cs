namespace BinaryToDecimal
{
    using System;
    using System.Numerics;

    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();

            BigInteger sum = 0;
            foreach (var bit in binary)
            {
                sum = (bit - '0') + sum * 2;
            }

            Console.WriteLine(sum);
        }
    }
}
