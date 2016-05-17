namespace QuadronacciRectangle
{
    using System;
    using System.Collections.Generic;

    class QuadronacciRectangle
    {
        static void Main(string[] args)
        {
            List<long> numbers = new List<long>();
            for (int i = 0; i < 4; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows * cols - 4; i++)
            {
                long next = numbers[i] + numbers[i + 1] + numbers[i + 2] + numbers[i + 3];
                numbers.Add(next);
            }

            int index = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col < cols - 1)
                    {
                        Console.Write("{0} ", numbers[index]);
                        index++;
                    }
                    else
                    {
                        Console.Write("{0}", numbers[index]);
                        index++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
