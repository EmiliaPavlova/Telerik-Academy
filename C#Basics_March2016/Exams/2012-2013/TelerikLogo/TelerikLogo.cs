namespace TelerikLogo
{
    using System;

    class TelerikLogo
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = x / 2 + 1;

            int width = 2 * (x + z) - 3;
            int[,] matrix = new int[width, width];

            int currentRow = x / 2;
            int currentCol = 0;

            while (currentRow > 0)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow--;
                currentCol++;
            }

            while (currentRow < 2 * x - 2)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow++;
                currentCol++;
            }

            while (currentRow < width - 1)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow++;
                currentCol--;
            }

            while (currentCol > x / 2)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow--;
                currentCol--;
            }

            while (currentRow > 0)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow--;
                currentCol++;
            }

            while (currentCol < width)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow++;
                currentCol++;
            }

            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
