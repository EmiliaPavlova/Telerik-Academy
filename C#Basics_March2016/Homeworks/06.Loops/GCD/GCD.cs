namespace GCD
{
    using System;
    using System.Linq;

    class GCD
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int a = numbers[0];
            int b = numbers[1];

            if (b > a)
            {
                int c = a;
                a = b;
                b = c;
            }

            while (b > 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }

            int gcd = a;
            Console.WriteLine(gcd);
        }
    }
}
