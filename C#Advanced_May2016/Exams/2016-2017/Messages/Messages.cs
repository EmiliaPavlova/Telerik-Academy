namespace Messages
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class Messages
    {
        static string[] GeorgeTheGreat =
            {
                "cad",
                "xoz",
                "nop",
                "cyk",
                "min",
                "mar",
                "kon",
                "iva",
                "ogi",
                "yan"
            };

        static void Main(string[] args)
        {
            BigInteger firstNumber = ConvertToNumber(Console.ReadLine());
            char @operator = Convert.ToChar(Console.ReadLine());
            BigInteger secondNumber = ConvertToNumber(Console.ReadLine());
            BigInteger result = 0;

            switch (@operator)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                default:
                    break;
            }

            Console.WriteLine(ConvertToString(result));
        }

        private static BigInteger ConvertToNumber(string word)
        {
            string number = string.Empty;
            string sub = string.Empty;
            for (int i = 0; i < word.Length; i += 3)
            {
                sub = word.Substring(i, 3);
                number += Array.FindIndex(GeorgeTheGreat, w => w == sub);
            }

            return BigInteger.Parse(number);
        }

        private static string ConvertToString(BigInteger number)
        {
            List<string> word = new List<string>();
            int reminder = 0;

            while (number > 0)
            {
                reminder = (int) (number % 10);
                number /= 10;
                word.Add(GeorgeTheGreat[reminder]);
            }

            word.Reverse();
            string result = string.Join("", word);

            return result;
        }
    }
}
