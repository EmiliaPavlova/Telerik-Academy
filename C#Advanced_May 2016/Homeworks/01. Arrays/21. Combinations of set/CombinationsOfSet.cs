namespace CombinationsOfSet
{
    using System;

    class CombinationsOfSet
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            Combinations(numbers, n, 0, 0);
        }

        private static void Combinations(int[] numbers, int n, int i, int next)
        {
            if (i == numbers.Length)
            {
                Print(numbers);
                return;
            }

            for (int j = next; j < n; j++)
            {
                numbers[i] = j;
                Combinations(numbers, n, i + 1, j + 1);
            }
        }

        private static void Print(int[] numbers)
        {
            Console.Write("{");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + 1 + (i == numbers.Length - 1 ? "}\r\n" : ", "));
            }
        }
    }
}