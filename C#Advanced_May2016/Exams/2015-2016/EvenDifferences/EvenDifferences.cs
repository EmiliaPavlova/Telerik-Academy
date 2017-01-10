namespace EvenDifferences
{
    using System;
    using System.Linq;

    class EvenDifferences
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long evenNumbers = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                long difference = Math.Abs(numbers[i] - numbers[i - 1]);
                if (difference % 2 == 0)
                {
                    i++;
                    evenNumbers += difference;
                }
            }

            Console.WriteLine(evenNumbers);
        }
    }
}
