namespace SubsetWithSumS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SubsetWithSumS
    {
        private static int[] numbers;
        private static int sum;
        private static bool hasSubset = false;

        static void Main(string[] args)
        {
            numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            sum = int.Parse(Console.ReadLine());

            List<int> subsets = new List<int>();
            FindSubsets(0, subsets);

            if (!hasSubset)
            {
                Console.WriteLine("No matching subsets.");
            }
        }

        private static void FindSubsets(int index, List<int> subsets)
        {
            if (subsets.Sum() == sum && subsets.Count > 0)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", subsets), sum);
                hasSubset = true;
            }
            for (int i = index; i < numbers.Length; i++)
            {
                subsets.Add(numbers[i]);
                FindSubsets(i + 1, subsets);
                subsets.RemoveAt(subsets.Count - 1);
            }
        }
    }
}
