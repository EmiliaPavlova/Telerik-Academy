namespace CalculationProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CalculationProblem
    {
        static int baseSystem = 23;

        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int result = 0;

            foreach (var word in words)
            {
                result += GetResult(word);
            }

            string converted = ConvertResultToBase(result);

            Console.WriteLine("{0} = {1}", converted, result);
        }

        private static int GetResult(string word)
        {
            int number = 0;
            for (int i = 0, power = word.Length - 1; i < word.Length; i++, power--)
            {
                number += (word[i] - 'a') * (int) Math.Pow(baseSystem, power);
            }

            return number;
        }

        private static string ConvertResultToBase(int number)
        {
            List<char> word = new List<char>();
            int reminder = 0;

            while (number > 0)
            {
                reminder = number % baseSystem;
                number /= baseSystem;
                word.Add((char) (reminder + 'a'));
            }

            word.Reverse();
            string result = string.Join("", word);

            return result;
        }
    }
}
