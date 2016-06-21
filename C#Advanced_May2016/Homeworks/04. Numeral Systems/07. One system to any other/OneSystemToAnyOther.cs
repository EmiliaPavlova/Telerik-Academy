namespace OneSystemToAnyOther
{
    using System;
    using System.Numerics;

    class OneSystemToAnyOther
    {
        static string hexKey = "0123456789ABCDEF";

        static void Main(string[] args)
        {
            int fromBase = int.Parse(Console.ReadLine());
            string number = Console.ReadLine().ToUpper();
            int toBase = int.Parse(Console.ReadLine());
            string result = string.Empty;

            result = ConvertToDec(number, fromBase);
            result = ConvertFromDec(result, toBase);

            Console.WriteLine(result);
        }

        private static string ConvertToDec(string number, int fromBase)
        {
            BigInteger sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum = (BigInteger) hexKey.IndexOf(number[i]) + sum * fromBase;
            }

            return sum.ToString();
        }

        private static string ConvertFromDec(string number, int toBase)
        {
            BigInteger decimalNumber = BigInteger.Parse(number);
            string converted = string.Empty;
            while (decimalNumber != 0)
            {
                converted = hexKey[(int) (decimalNumber % toBase)] + converted;
                decimalNumber /= toBase;
            }

            return converted;
        }
    }
}
