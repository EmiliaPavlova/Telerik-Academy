namespace HexadecimalToDecimal
{
    using System;
    using System.Numerics;

    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int currentChar = 0;
            BigInteger dec = 0;
            int count = hex.Length - 1;

            for(int i = 0; i < hex.Length; i++)
            {
                if (char.IsDigit(hex[i]))
                {
                    currentChar = hex[i] - '0';
                }
                else
                {
                    currentChar = hex[i] - 'A' + 10;
                }

                dec += currentChar * (BigInteger) Math.Pow(16, count);
                count--;
            }

            Console.WriteLine(dec);
        }
    }
}
