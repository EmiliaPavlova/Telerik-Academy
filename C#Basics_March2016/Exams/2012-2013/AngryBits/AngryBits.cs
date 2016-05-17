namespace AngryBits
{
    using System;

    class AngryBits
    {
        static void Main(string[] args)
        {
            int rows = 8;
            int cols = 16;
            int[,] matrix = new int[rows, cols];
            int score = 0;

            for (int row = 0; row < rows; row++)
            {
                int input = int.Parse(Console.ReadLine());

                for (int col = 0; col < cols; col++)
                {
                    if ((input & (1 << cols - 1 - col)) != 0)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            for (int col = rows - 1; col >= 0; col--)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        int birdRow = row;
                        int birdCol = col;
                        bool moveUp = true;
                        int movesCount = 0;
                        int pigsCount = 0;

                        while (true)
                        {
                            movesCount++;

                            if (birdRow > 0 && moveUp)
                            {
                                birdRow--;
                            }
                            else
                            {
                                if (birdRow == rows - 1)
                                {
                                    break;
                                }
                                moveUp = false;
                                birdRow++;
                            }

                            if (birdCol == cols - 1)
                            {
                                break;
                            }
                            birdCol++;

                            if (matrix[birdRow, birdCol] == 1 && birdCol > 7)
                            {
                                pigsCount++;
                                matrix[birdRow, birdCol] = 0;
                                bool up = false;
                                bool down = false;

                                if (birdRow > 0)
                                {
                                    up = true;
                                    if (matrix[birdRow - 1, birdCol] == 1)
                                    {
                                        pigsCount++;
                                        matrix[birdRow - 1, birdCol] = 0;
                                    }
                                }

                                if (birdRow < rows - 1)
                                {
                                    down = true;
                                    if (matrix[birdRow + 1, birdCol] == 1)
                                    {
                                        pigsCount++;
                                        matrix[birdRow + 1, birdCol] = 0;
                                    }
                                }

                                if (birdCol < cols - 1)
                                {
                                    if (matrix[birdRow, birdCol + 1] == 1)
                                    {
                                        pigsCount++;
                                        matrix[birdRow, birdCol + 1] = 0;
                                    }

                                    if (up)
                                    {
                                        if (matrix[birdRow - 1, birdCol + 1] == 1)
                                        {
                                            pigsCount++;
                                            matrix[birdRow - 1, birdCol + 1] = 0;
                                        }
                                    }

                                    if (down)
                                    {
                                        if (matrix[birdRow + 1, birdCol + 1] == 1)
                                        {
                                            pigsCount++;
                                            matrix[birdRow + 1, birdCol + 1] = 0;
                                        }
                                    }
                                }

                                if (birdCol > 8)
                                {
                                    if (matrix[birdRow, birdCol - 1] == 1)
                                    {
                                        pigsCount++;
                                        matrix[birdRow, birdCol - 1] = 0;
                                    }

                                    if (up)
                                    {
                                        if (matrix[birdRow - 1, birdCol - 1] == 1)
                                        {
                                            pigsCount++;
                                            matrix[birdRow - 1, birdCol - 1] = 0;
                                        }
                                    }

                                    if (down)
                                    {
                                        if (matrix[birdRow + 1, birdCol - 1] == 1)
                                        {
                                            pigsCount++;
                                            matrix[birdRow + 1, birdCol - 1] = 0;
                                        }
                                    }
                                }

                                break;
                            }
                        }

                        score += pigsCount * movesCount;
                        break;
                    }
                }
            }

            bool gameIsWon = true;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 8; col < cols; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        gameIsWon = false;
                        break;
                    }
                }
            }

            Console.WriteLine(score + " " + (gameIsWon ? "Yes" : "No"));
        }
    }
}
