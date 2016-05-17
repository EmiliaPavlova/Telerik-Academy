namespace BiggestOf3
{
    using System;
    using System.Linq;

    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double[] numbers = new[] {a, b, c};
            Console.WriteLine(numbers.Max());
        }
    }
}
