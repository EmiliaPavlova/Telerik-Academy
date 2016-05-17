namespace SumOf5Numbers
{
    using System;

    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }
    }
}
