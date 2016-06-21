namespace FillTheMatrix
{
    using System;

    class FillTheMatrix
    {
        private static int n = int.Parse(Console.ReadLine());
        private static int index = 1;
        private static int[,] matrix = new int[n, n];


        static void Main(string[] args)
        {
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    FillMatrixA();
                    break;
                case 'b':
                    FillMatrixB();
                    break;
                case 'c':
                    FillMatrixC();
                    break;
                case 'd':
                    FillMatrixD();
                    break;
                default:
                    break;
            }

            PrintMatrix(matrix);
        }

        private static void FillMatrixA()
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = index;
                    index++;
                }
            }
        }

        private static void FillMatrixB()
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = index;
                        index++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = index;
                        index++;
                    }
                }
            }
        }

        private static void FillMatrixC()
        {
            int rows = 0;
            int cols = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[rows++, cols++] = index;
                    index++;
                }
            }

            for (int j = 1; j < n; j++)
            {
                rows = j;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[cols++, rows++] = index;
                    index++;
                }
            }
        }

        private static void FillMatrixD()
        {
            int row = 0;
            int col = 0;

            while (index <= matrix.Length)
            {
                // down
                while (row < n && matrix[row, col] == 0)
                {
                    matrix[row, col] = index;
                    row++;
                    index++;
                }

                row--;
                col++;

                // right
                while (col < n && matrix[row, col] == 0)
                {
                    matrix[row, col] = index;
                    col++;
                    index++;
                }

                row--;
                col--;

                // up
                while (row >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col] = index;
                    row--;
                    index++;
                }

                row++;
                col--;

                // left
                while (col > 0 && matrix[row, col] == 0)
                {
                    matrix[row, col] = index;
                    col--;
                    index++;
                }

                row++;
                col++;
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == matrix.GetLength(1) - 1)
                    {
                        Console.Write("{0}", matrix[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
