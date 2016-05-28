namespace SumIntegers
{
    using System;
    using System.Linq;

    class SumIntegers
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            Console.WriteLine(CalculateSum(values));
        }

        static int CalculateSum(string values)
        {
            int[] numbers = values
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sum = numbers.Sum();

            return sum;
        }
    }
}
