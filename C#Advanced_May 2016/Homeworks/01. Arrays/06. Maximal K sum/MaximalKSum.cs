namespace MaximalKSum
{
    using System;
    using System.Linq;

    class MaximalKSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            array = array.OrderByDescending(v => v).ToArray();
            int maxSum = 0;
            for (int j = 0; j < k; j++)
            {
                maxSum += array[j];
            }

            Console.WriteLine(maxSum);
        }
    }
}
