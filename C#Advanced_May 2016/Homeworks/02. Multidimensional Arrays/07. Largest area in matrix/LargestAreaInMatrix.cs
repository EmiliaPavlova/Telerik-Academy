namespace LargestAreaInMatrix
{
    using System;
    using System.Linq;

    class LargestAreaInMatrix
    {
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
                string[] token = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.None);
                for (int cols = 0; cols < m; cols++)
                {
                    matrix[rows, cols] = int.Parse(token[cols]);
                }
            }

            bool[,] calculated = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            int bestCount = 0;
            int indexRow = 0;
            int indexCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!calculated[row, col])
                    {
                        int count = DepthFirstSearch(matrix, row, col, calculated);
                        if (bestCount < count)
                        {
                            bestCount = count;
                            indexRow = row;
                            indexCol = col;
                        }
                    }

                }
            }

            //The len of largest area in matrix 
            Console.WriteLine(bestCount);
            //Console.WriteLine("The element is {2} on position {0},{1} ", indexRow, indexCol, matrix[indexRow, indexCol]);
        }

        static int DepthFirstSearch(int[,] array, int row, int col, bool[,] calc)
        {
            int result = 1;
            calc[row, col] = true;
            if ((row - 1 >= 0) && (array[row - 1, col] == array[row, col]) && !calc[row - 1, col])
            {
                result += DepthFirstSearch(array, row - 1, col, calc);
            }
            if ((row + 1 < array.GetLength(0)) && (array[row + 1, col] == array[row, col]) && !calc[row + 1, col])
            {
                result += DepthFirstSearch(array, row + 1, col, calc);
            }
            if ((col - 1 >= 0) && (array[row, col - 1] == array[row, col]) && !calc[row, col - 1])
            {
                result += DepthFirstSearch(array, row, col - 1, calc);
            }
            if ((col + 1 < array.GetLength(1)) && (array[row, col + 1] == array[row, col]) && !calc[row, col + 1])
            {
                result += DepthFirstSearch(array, row, col + 1, calc);
            }
            return result;
        }
    }
}
