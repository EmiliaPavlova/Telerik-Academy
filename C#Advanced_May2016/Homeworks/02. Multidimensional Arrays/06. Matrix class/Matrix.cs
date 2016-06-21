namespace MatrixClass
{
    public class Matrix
    {
        private int rows;
        private int cols;
        private readonly int[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new int[rows, cols];
        }

        public int Rows { get; set; }

        public int Cols { get; set; }

        public int this[int newRows, int newCols]
        {
            get
            {
                return this.matrix[rows, cols];
            }

            set
            {
                this.matrix[rows, cols] = value;
            }
        }

        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            var finalMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Rows; j++)
                {
                    finalMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return finalMatrix;
        }

        public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
        {
            var finalMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Rows; j++)
                {
                    finalMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return finalMatrix;
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            var finalMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);
            for (int i = 0; i < finalMatrix.Rows; i++)
            {
                for (int j = 0; j < finalMatrix.Cols; j++)
                {
                    for (int multiCol = 0; multiCol < firstMatrix.Cols; multiCol++)
                    {
                        for (int k = 0; k < firstMatrix.Cols; k++)
                        {
                            finalMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                        }
                    }
                }
            }

            return finalMatrix;
        }

        public override string ToString()
        {
            string endString = string.Empty;
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    endString = endString + this[i, j] + " ";
                }

                endString = endString + "\n";
            }

            return endString;
        }
    }
}