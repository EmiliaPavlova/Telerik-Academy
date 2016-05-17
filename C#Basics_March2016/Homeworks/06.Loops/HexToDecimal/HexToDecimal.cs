namespace HexToDecimal
{
    using System;
    using System.Numerics;

    class HexToDecimal
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            BigInteger result = 0;
            int count = hex.Length - 1;

            for (int i = 0; i < hex.Length; i++)
            {
                int temp = 0;
                switch (hex[i])
                {
                    case 'A':
                        temp = 10;
                        break;
                    case 'B':
                        temp = 11;
                        break;
                    case 'C':
                        temp = 12;
                        break;
                    case 'D':
                        temp = 13;
                        break;
                    case 'E':
                        temp = 14;
                        break;
                    case 'F':
                        temp = 15;
                        break;
                    default:
                        temp = -48 + (int)hex[i];
                        break;
                }

                result += temp * (BigInteger)Math.Pow(16, count);
                count--;
            }

            Console.WriteLine(result);
        }
    }
}
