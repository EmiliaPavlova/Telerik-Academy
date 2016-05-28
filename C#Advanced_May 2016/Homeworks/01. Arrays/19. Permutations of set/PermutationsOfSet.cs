namespace PermutationsOfSet
{
    using System;

    class PermutationsOfSet
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            bool[] used = new bool[numbers.Length];
            Permutation(numbers, used, 0);
        }

        private static void Permutation(int[] numbers, bool[] used, int i)
        {
            if (i == numbers.Length)
            {
                Print(numbers);
                return;
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                if (used[j])
                {
                    continue;
                }

                numbers[i] = j;
                used[j] = true;
                Permutation(numbers, used, i + 1);
                used[j] = false;
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
