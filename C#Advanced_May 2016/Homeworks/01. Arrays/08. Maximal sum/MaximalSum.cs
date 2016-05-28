namespace MaximalSumMatrix
{
    using System;
    using System.Linq;

    class MaximalSum
    {
        private const int Size = 3;

        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = input[0];
            int m = input[1];
            int[,] matrix = new int[n, m];

            for (int rows = 0; rows < n; rows++)
            {
                string[] rowOfMatrix = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int cols = 0; cols < m; cols++)
                {
                    matrix[rows, cols] = int.Parse(rowOfMatrix[cols]);
                }
            }

            int bestSum = int.MinValue;
            int[,] matrixMaxSum = new int[Size, Size];
            int sum = 0;
            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < m - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        for (int i = 0; i < matrixMaxSum.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixMaxSum.GetLength(1); j++)
                            {
                                matrixMaxSum[i, j] = matrix[row + i, col + j];
                            }
                        }
                    }
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
