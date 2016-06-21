namespace BinarySearch
{
    using System;

    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int x = int.Parse(Console.ReadLine());

            int min = 0;
            int max = n;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (x == array[mid])
                {
                    Console.WriteLine(mid);
                    return;
                }
                else if (x < array[mid])
                {
                    max = mid - 1;
                }
                else if (x > array[mid])
                {
                    min = mid + 1;
                }
            }

            Console.WriteLine(-1);
        }
    }
}
