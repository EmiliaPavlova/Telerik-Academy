namespace VariationsOfSet
{
    using System;

    class VariationsOfSet
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            Variations(numbers, n, 0);
        }

        private static void Variations(int[] numbers, int n, int i)
        {
            if (i == numbers.Length)
            {
                Print(numbers);
                return;
            }

            for (int j = 0; j < n; j++)
            {
                numbers[i] = j;
                Variations(numbers, n, i + 1);
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
