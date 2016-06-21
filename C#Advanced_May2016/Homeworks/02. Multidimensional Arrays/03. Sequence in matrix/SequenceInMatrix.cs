namespace SequenceInMatrix
{
    using System;
    using System.Linq;

    class SequenceInMatrix
    {
        static int maxLength = 1;

        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = input[0];
            int m = input[1];
            string[,] matrix = new string[n, m];

            for (int rows = 0; rows < n; rows++)
            {
                string[] token = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.None);
                for (int cols = 0; cols < m; cols++)
                {
                    matrix[rows, cols] = token[cols];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                CheckDirections(matrix, 0, col);
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                CheckDirections(matrix, row, 0);
                CheckDirections(matrix, row, matrix.GetUpperBound(1));
            }

            Console.WriteLine(maxLength);
        }

        private static void CheckDirections(string[,] matrix, int row, int col)
        {
            int rowChange = 0;
            int colChange = 0;

            // directions 0 = right, 1 = rigthDownDiagonal, 2 = down, 3 = leftDownDiagonal
            for (int i = 0; i < 4; i++) 
            {
                string start = matrix[row, col];
                int length = 1;
                switch (i)
                {
                    case 0: rowChange = 0; colChange = 1; break;
                    case 1: rowChange = 1; colChange = 1; break;
                    case 2: rowChange = 1; colChange = 0; break;
                    case 3: rowChange = 1; colChange = -1; break;
                }

                int tempRow = row;
                int tempCol = col;

                while (true)
                {
                    tempRow += rowChange;
                    tempCol += colChange;

                    if (tempRow < 0 || tempRow > matrix.GetUpperBound(0) || 
                        tempCol < 0 || tempCol > matrix.GetUpperBound(1))
                    {
                        break;
                    }

                    string currentElement = matrix[tempRow, tempCol];
                    if (currentElement.Equals(start))
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                        start = currentElement;
                    }

                    if (length > maxLength)
                    {
                        maxLength = length;
                    }
                }
            }
        }
    }
}
