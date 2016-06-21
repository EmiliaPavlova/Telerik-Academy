namespace CompareArrays
{
    using System;
    using System.Linq;

    class CompareArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(array1.SequenceEqual(array2) ? "Equal" : "Not equal");
        }
    }
}
