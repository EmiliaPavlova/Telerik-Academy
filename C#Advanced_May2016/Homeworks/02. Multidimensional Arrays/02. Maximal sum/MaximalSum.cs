namespace MaximalSum
{
    using System;

    class MaximalSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += array[j];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
