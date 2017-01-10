namespace Matrix
{
    using System;

    class MatrixMain
    {
        static void Main(string[] args)
        {
            var firstMatrix = new Matrix<int>(3, 3);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    firstMatrix[i, j] = i + j;
                }
            }
            Console.WriteLine(firstMatrix);
            Console.WriteLine(new string('-', 5));

            var secondMatrix = new Matrix<int>(3, 3);
            for (int i = 0; i < secondMatrix.Rows; i++)
            {
                for (int j = 0; j < secondMatrix.Cols; j++)
                {
                    secondMatrix[i, j] = i + j + 2;
                }
            }

            Console.WriteLine(secondMatrix);
            Console.WriteLine(new string('-', 5));

            var sumMatrices = firstMatrix + secondMatrix;
            Console.WriteLine(sumMatrices);
        }
    }
}
