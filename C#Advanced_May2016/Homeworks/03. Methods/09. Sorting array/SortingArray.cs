namespace SortingArray
{
    using System;
    using System.Linq;

    class SortingArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            numbers = SortArray(numbers, "ascending");
            Console.WriteLine(string.Join(" ", numbers));
        }

        static int[] SortArray(int[] numbers, string direction)
        {
            int[] sortedNumbers = new int[numbers.Length];

            switch (direction)
            {
                case "ascending":
                    for (int i = numbers.Length - 1; i >= 0; i--)
                    {
                        sortedNumbers[i] = GetMaxElement(numbers, numbers.GetLowerBound(0), numbers.GetUpperBound(0));
                        numbers[Array.IndexOf(numbers, sortedNumbers[i])] = Int32.MinValue;
                    }
                    break;
                case "descending":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sortedNumbers[i] = GetMaxElement(numbers, numbers.GetLowerBound(0), numbers.GetUpperBound(0));
                        numbers[Array.IndexOf(numbers, sortedNumbers[i])] = Int32.MinValue;
                    }
                    break;
                default:
                    break;
            }

            return sortedNumbers;
        }

        static int GetMaxElement(int[] numbers, int start, int end)
        {
            int max = Int32.MinValue;
            for (int i = start; i <= end; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }
}
