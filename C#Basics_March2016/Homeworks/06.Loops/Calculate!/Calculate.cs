namespace Calculate
{
    using System;

    class Program
    {
        private static double[] arr = new double[10000];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += (Factorial(i) / Math.Pow(x, i));
            }

            Console.WriteLine("{0:F5}", sum);
        }

        public static double Factorial(double number)
        {
            
            if (number <= 1)
            {
                return 1;
            }
            
            return number * Factorial(number - 1);
        }
    }
}
