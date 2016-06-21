namespace NumberCalculations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class NumberCalculations
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int min = GetMinimum(numbers);
            int max = GetMaximum(numbers);
            double avg = GetAverige(numbers);
            int sum = GetSum(numbers);
            long product = GetProduct(numbers);
            Console.WriteLine("{0}\r\n{1}\r\n{2:F2}\r\n{3}\r\n{4}",
                min, max, avg, sum, product);
        }

        private static T GetMinimum<T>(List<T> numbers)
        {
            T min = default(T);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Comparer<T>.Default.Compare(numbers[i], min) < 0)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        private static T GetMaximum<T>(List<T> numbers)
        {
            T max = default(T);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Comparer<T>.Default.Compare(numbers[i], max) > 0)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        private static T GetAverige<T>(List<T> numbers)
        {
            dynamic avg = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                avg += numbers[i];
            }

            return avg / numbers.Count;
        }

        private static T GetSum<T>(List<T> numbers)
        {
            dynamic sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static T GetProduct<T>(List<T> numbers)
        {
            dynamic product = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                product *= numbers[i];
            }

            return product;
        }
    }
}
