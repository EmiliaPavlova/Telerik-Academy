namespace BitBall
{
    using System;

    class BitBall
    {
        static void Main(string[] args)
        {
            int field = 8;
            int[,] matrix = new int[field, field];
            // top players
            for (int row = 0; row < field; row++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < field; col++)
                {
                    int bit = (number >> col) & 1;

                    if (bit == 1)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            // bottom players
            for (int row = 0; row < field; row++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < field; col++)
                {
                    int bit = (number >> col) & 1;

                    if (bit == 1)
                    {
                        if (matrix[row, col] == 1)
                        {
                            matrix[row, col] = 0;
                        }
                        else
                        {
                            matrix[row, col] = 2;
                        }
                    }
                }
            }

            int topScore = 0;
            int bottomScore = 0;
            for (int col = 0; col < field; col++)
            {
                for (int row = 0; row < field; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        break;
                    }
                    else if (matrix[row, col] == 2)
                    {
                        bottomScore++;
                        break;
                    }
                }
            }

            for (int col = 0; col < field; col++)
            {
                for (int row = field - 1; row >= 0; row--)
                {
                    if (matrix[row, col] == 1)
                    {
                        topScore++;
                        break;
                    }
                    else if (matrix[row, col] == 2)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("{0}:{1}", topScore, bottomScore);
        }
    }
}
