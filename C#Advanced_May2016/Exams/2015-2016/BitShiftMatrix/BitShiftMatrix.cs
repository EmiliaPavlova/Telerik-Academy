namespace BitShiftMatrix
{
    using System;
    using System.Linq;
    using System.Numerics;

    class BitShiftMatrix
    {
        private static int rows;
        private static int cols;
        private static int coeff;

        static void Main(string[] args)
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var moves = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            coeff = Math.Max(rows, cols);
            int row = rows - 1;
            int col = 0;
            bool[,] visited = new bool[rows, cols];

            foreach (int move in moves)
            {
                int nextRow = move / coeff;
                int nextCol = move % coeff;

                while (col != nextCol)
                {
                    visited[row, col] = true;
                    if (col < nextCol)
                    {
                        col++;
                    }
                    else
                    {
                        col--;
                    }
                }

                while (row != nextRow)
                {
                    visited[row, col] = true;
                    if (row < nextRow)
                    {
                        row++;
                    }
                    else
                    {
                        row--;
                    }
                }

                visited[row, col] = true;
            }

            BigInteger sum = 0;
            for (int r = 0; r < visited.GetLength(0); r++)
            {
                for (int c = 0; c < visited.GetLength(1); c++)
                {
                    if (visited[r, c])
                    {
                        sum += (BigInteger)(Math.Pow(2, rows - 1 - r) * Math.Pow(2, c));
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
