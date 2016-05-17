namespace A_BAndC
{
    using System;
    using System.Linq;

    class ABAndC
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[] numbers = new[] {a, b, c};

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine("{0:F3}", numbers.Average());
        }
    }
}
