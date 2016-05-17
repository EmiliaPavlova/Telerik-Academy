namespace FormulaBit1
{
    using System;

    class FormulaBit1
    {
        static void Main(string[] args)
        {
            bool[,] track = new bool[8, 8];
            for (int i = 0; i < 8; i++)
            {
                int number = int.Parse(Console.ReadLine());

                for (int j = 0; j < 8; j++)
                {
                    track[i, j] = ((number >> j) & 1) != 0;
                }
            }

            int row = 0;
            int col = 0;

            string direction = "South";
            string lastDirection = "South";

            int pathCount = 0;
            int directionCount = 0;
            bool exitFound = false;

            while (true)
            {
                if (track[row, col])
                {
                    break;
                }

                pathCount++;

                if (row == 7 && col == 7)
                {
                    exitFound = true;
                    break;
                }

                if (direction == "South" && (row + 1 > 7 || track[row + 1, col]))
                {
                    direction = "West";
                    lastDirection = "South";
                    directionCount++;

                    if (col + 1 > 7 || track[row, col + 1])
                    {
                        break;
                    }
                }
                else if (direction == "North" && (row - 1 < 0 || track[row - 1, col]))
                {
                    direction = "West";
                    lastDirection = "North";
                    directionCount++;

                    if (col + 1 > 7 || track[row, col + 1])
                    {
                        break;
                    }
                }
                else if (direction == "West" && lastDirection == "South" && (col + 1 > 7 || track[row, col + 1]))
                {
                    direction = "North";
                    directionCount++;

                    if (row - 1 < 0 || track[row - 1, col])
                    {
                        break;
                    }
                }
                else if (direction == "West" && lastDirection == "North" && (col + 1 > 7 || track[row, col + 1]))
                {
                    direction = "South";
                    directionCount++;

                    if (row + 1 > 7 || track[row + 1, col])
                    {
                        break;
                    }
                }

                if (direction == "South")
                {
                    row++;
                }
                else if (direction == "West")
                {
                    col++;
                }
                else if (direction == "North")
                {
                    row--;
                }
            }

            if (exitFound)
            {
                Console.WriteLine(pathCount + " " + directionCount);
            }
            else
            {
                Console.WriteLine("No " + pathCount);
            }
        }
    }
}
