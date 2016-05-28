namespace NumberAsArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class NumberAsArray
    {
        static void Main(string[] args)
        {
            List<int> input = ReadArrayNumbers();
            List<int> array1 = new List<int>(input[0]);
            array1 = ReadArrayNumbers();
            List<int> array2 = new List<int>(input[1]);
            array2 = ReadArrayNumbers();

            int length = Math.Max(array1.Count, array2.Count);

            Console.WriteLine(string.Join(" ", AddLists(array1, array2, length)));
        }

        private static List<int> ReadArrayNumbers()
        {
            return Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToList();
        }

        public static int[] AddLists(List<int> array1, List<int> array2, int length)
        {
            var resultArray = new int[length];
            FillListCount(array1, array2);

            for (int i = 0; i < resultArray.Length; i++)
            {
                int sum = array1[i] + array2[i];
                if (sum >= 10)
                {
                    resultArray[i] = sum - 10;
                    if (i < length - 1)
                    {
                        array1[i + 1] += 1;
                    }
                }
                else
                {
                    resultArray[i] = sum;
                }
            }

            return resultArray;
        }

        public static void FillListCount(List<int> array1, List<int> array2)
        {
            int array1Length = array1.Count;
            int array2Length = array2.Count;

            if (array1Length > array2Length)
            {
                for (int i = array2Length; i < array1Length; i++)
                {
                    array2.Add(0);
                }
            }
            else
            {
                for (int i = array1Length; i < array2Length; i++)
                {
                    array1.Add(0);
                }
            }
        }
    }
}
