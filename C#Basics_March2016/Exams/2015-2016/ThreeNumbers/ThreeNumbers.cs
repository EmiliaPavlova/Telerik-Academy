namespace ThreeNumbers
{
    using System;
    using System.Linq;

    class ThreeNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[] numbers = new[] {a, b, c};
            int biggestNum = numbers.Max();
            int smallestNum = numbers.Min();
            double mean = numbers.Sum() / (double)numbers.Length;
            Console.WriteLine(biggestNum);
            Console.WriteLine(smallestNum);
            Console.WriteLine("{0:F2}", mean);
        }
    }
}
