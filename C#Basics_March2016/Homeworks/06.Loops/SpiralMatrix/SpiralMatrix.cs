namespace SpiralMatrix
{
    using System;

    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 0;
            int col = 0;
            char dir = 'r';
            int[,] mass = new int[n, n];

            for (int st = 1; st <= n * n; st++)
            {
                if (dir == 'r' && (col > n - 1 || mass[row, col] != 0))
                {
                    dir = 'd';
                    col--;
                    row++;
                }

                if (dir == 'd' && (row > n - 1 || mass[row, col] != 0))
                {
                    dir = 'l';
                    row--;
                    col--;
                }

                if (dir == 'l' && (col < 0 || mass[row, col] != 0))
                {
                    dir = 'u';
                    col++;
                    row--;
                }

                if (dir == 'u' && (row < 0 || mass[row, col] != 0))
                {
                    dir = 'r';
                    row++;
                    col++;
                }

                mass[row, col] = st;

                switch (dir)
                {
                    case 'u':
                        row--;
                        break;
                    case 'd':
                        row++;
                        break;
                    case 'l':
                        col--;
                        break;
                    case 'r':
                        col++;
                        break;
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(mass[r, c] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
