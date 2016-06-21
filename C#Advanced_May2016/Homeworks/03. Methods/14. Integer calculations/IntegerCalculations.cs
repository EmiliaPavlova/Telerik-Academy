namespace IntegerCalculations
{
    using System;
    using System.Linq;

    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int min = GetMinimum(numbers);
            int max = GetMaximum(numbers);
            double avg = GetAverige(numbers);
            int sum = GetSum(numbers);
            long product = GetProduct(numbers);
            Console.WriteLine("{0}\r\n{1}\r\n{2:F2}\r\n{3}\r\n{4}",
                min, max, avg, sum, product);
        }

        private static int GetMinimum(int[] numbers)
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        private static int GetMaximum(int[] numbers)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        private static double GetAverige(int[] numbers)
        {
            double avg = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                avg += numbers[i];
            }

            return avg / numbers.Length;
        }

        private static int GetSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static long GetProduct(int[] numbers)
        {
            long product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }
    }
}
