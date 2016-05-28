namespace MaximalSequence
{
    using System;

    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int count = 1;
            int maxSeq = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] == numbers[i - 1])
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
