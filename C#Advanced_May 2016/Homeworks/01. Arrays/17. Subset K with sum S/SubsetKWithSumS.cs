namespace SubsetKWithSumS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SubsetKWithSumS
    {
        private static int[] numbers;
        private static int sum;
        private static int k;
        private static bool hasSubset = false;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            sum = int.Parse(Console.ReadLine());
            numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> subsets = new List<int>();
            FindSubsets(0, k, subsets);

            if (!hasSubset)
            {
                Console.WriteLine("No matching subsets.");
            }
        }

        private static void FindSubsets(int index, int k, List<int> subsets)
        {
            if (subsets.Sum() == sum && subsets.Count == k)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", subsets), sum);
                hasSubset = true;
            }
            for (int i = index; i < numbers.Length; i++)
            {
                subsets.Add(numbers[i]);
                FindSubsets(i + 1, k, subsets);
                subsets.RemoveAt(subsets.Count - 1);
            }
        }
    }
}
