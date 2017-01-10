namespace LoverOf3
{
    using System;
    using System.Linq;
    using System.Numerics;

    class LoverOf3
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            int[] dRows = { -1, 1, 1, -1 };
            int[] dCols = { 1, 1, -1, -1 };

            bool[,] isVisited = new bool[rows, cols];
            //int[,] matrix = new int[rows,cols];
            BigInteger sum = 0;

            //FillMatrix(matrix);

            int n = int.Parse(Console.ReadLine());
            int row = rows - 1;
            int col = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                int direction = GetDirection(input[0]);
                int moves = int.Parse(input[1]) - 1;

                for (int j = 0; j < moves; j++)
                {
                    int nextRow = row + dRows[direction];
                    int nextCol = col + dCols[direction];
                    if (!InRange(nextRow, rows - 1) || !InRange(nextCol, cols - 1))
                    {
                        break;
                    }

                    row = nextRow;
                    col = nextCol;
                    isVisited[row, col] = true;
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (isVisited[r, c])
                    {
                        sum += (rows - r - 1 + c) * 3;
                    }
                }
            }

            Console.WriteLine(sum);
        }

        static void FillMatrix(int[,] matrix)
        {
            int colIndex = 0;
            int rowIndex = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colIndex + rowIndex;
                    colIndex += 3;
                }

                rowIndex += 3;
                colIndex -= 3 * (matrix.GetLength(0) - 1);
            }
        }

        static int GetDirection(string dirName)
        {
            switch (dirName)
            {
                case "UR":
                case "RU":
                    return 0;
                case "DR":
                case "RD":
                    return 1;
                case "DL":
                case "LD":
                    return 2;
                case "UL":
                case "LU":
                    return 3;
            }
            return -1;
        }

        private static bool InRange(int value, int max)
        {
            return 0 <= value && value <= max;
        }
    }
}
