namespace SelectionSort
{
    using System;

    class SelectionSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int tempNumber = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        tempNumber = array[j];
                        array[j] = array[i];
                        array[i] = tempNumber;
                    }
                }

                Console.WriteLine(array[i]);
            }
        }
    }
}
