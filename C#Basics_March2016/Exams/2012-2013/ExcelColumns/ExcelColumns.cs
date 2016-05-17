namespace ExcelColumns
{
    using System;
    using System.Text;

    class ExcelColumns
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder index = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                index.Append(Console.ReadLine());
            }

            long result = 0;
            for (int j = 0; j < n; j++)
            {
                result += (long)(index[j] - 'A' + 1) * (long)Math.Pow(26, (double) (n - j - 1));
            }

            Console.WriteLine(result);
        }
    }
}
