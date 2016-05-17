namespace MatrixOfNumbers
{
    using System;

    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < n + row; col++)
                {
                    Console.Write(col + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
