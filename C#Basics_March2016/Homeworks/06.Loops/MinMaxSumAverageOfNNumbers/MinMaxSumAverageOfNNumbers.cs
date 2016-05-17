namespace MinMaxSumAverageOfNNumbers
{
    using System;
    using System.Linq;

    class MinMaxSumAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            Console.WriteLine("min={0:F2}\r\nmax={1:F2}\r\nsum={2:F2}\r\navg={3:F2}", 
                numbers.Min(), numbers.Max(), numbers.Sum(), numbers.Average());
        }
    }
}
