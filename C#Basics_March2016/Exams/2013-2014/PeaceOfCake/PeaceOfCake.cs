namespace PeaceOfCake
{
    using System;

    class PeaceOfCake
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());
            decimal denominator = b * d;
            decimal nominator = a * d + c * b;
            decimal fraction = nominator / denominator;

            if (fraction >= 1)
            {
                Console.WriteLine((long)fraction);
            }
            else
            {
                Console.WriteLine("{0:F22}", (decimal)fraction);
            }

            Console.WriteLine("{0}/{1}", nominator, denominator);
        }
    }
}
