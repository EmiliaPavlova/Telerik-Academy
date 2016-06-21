namespace DecimalToHexadecimal
{
    using System;
    using System.Numerics;

    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            string result = string.Empty;
            string hex = "0123456789ABCDEF";

            while (n != 0)
            {
                BigInteger value = n % 16;
                result = hex[(int)value] + result;
                n /= 16;
            }

            Console.WriteLine(result);
        }
    }
}
