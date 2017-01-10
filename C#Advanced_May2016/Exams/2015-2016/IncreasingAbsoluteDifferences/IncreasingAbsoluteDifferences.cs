namespace IncreasingAbsoluteDifferences
{
    using System;
    using System.Linq;

    class IncreasingAbsoluteDifferences
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] sequence = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int diff = 0;
                int[] differences = new int[sequence.Length - 1];
                for (int j = 0; j < sequence.Length - 1; j++)
                {
                    diff = Math.Abs(sequence[j + 1] - sequence[j]);
                    differences[j] = diff;
                }

                bool isIncreasing = true;

                for (int k = 0; k < differences.Length - 1; k++)
                {
                    if (differences[k + 1] - differences[k] < 0 || 
                        differences[k + 1] - differences[k] > 1)
                    {
                        isIncreasing = false;
                    }
                }

                if (isIncreasing)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
