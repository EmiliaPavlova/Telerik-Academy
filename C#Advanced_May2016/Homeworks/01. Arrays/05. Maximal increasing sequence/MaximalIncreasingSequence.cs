namespace MaximalIncreasingSequence
{
    using System;

    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            int count = 1;
            int maxSeq = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] >= numbers[i - 1] + 1.0)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > maxSeq)
                {
                    maxSeq = count;
                }
            }

            Console.WriteLine(maxSeq);
        }
    }
}
