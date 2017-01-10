namespace DeCatCoding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    class DeCatCoding
    {
        private static int fromBase = 21;
        private static int toBase = 26;

        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            BigInteger result = 0;

            input.ForEach(x =>
            {
                result = ConvertFromBase(x);
                x = ConvertToBase(result);
                Console.Write(x + " ");
            });
        }

        private static BigInteger ConvertFromBase(string word)
        {
            BigInteger result = 0;
            for (int i = 0, power = word.Length - 1; i < word.Length; i++, power--)
            {
                result += (word[i] - 'a') * (BigInteger) Math.Pow(fromBase, power);
            }

            return result;
        }

        private static string ConvertToBase(BigInteger number)
        {
            List<char> word = new List<char>();
            BigInteger reminder = 0;

            while (number > 0)
            {
                reminder = number % toBase;
                number /= toBase;
                word.Add((char)(reminder + 'a'));
            }

            word.Reverse();
            string result = string.Join("", word);

            return result;
        }
    }
}
