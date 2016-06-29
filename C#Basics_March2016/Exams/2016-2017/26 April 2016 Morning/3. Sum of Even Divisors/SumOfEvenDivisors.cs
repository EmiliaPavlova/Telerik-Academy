namespace SumOfEvenDivisors
{
    using System;
    using System.Collections.Generic;

    class SumOfEvenDivisors
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            List<int> factors = new List<int>();
            for (int i = a; i <= b; i++)
            {
                factors.AddRange(GetAllFactors(i));
            }
            
            int evenSum = 0;
            factors.ForEach(f =>
            {
                if (f % 2 == 0)
                {
                    evenSum += f;
                }
            });

            Console.WriteLine(evenSum);
        }

        private static List<int> GetAllFactors(int number)
        {
            List<int> factors = new List<int>();
            int max = (int)Math.Sqrt(number);
            for (int factor = 1; factor <= max; ++factor)
            {
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    {
                        factors.Add(number / factor);
                    }
                }
            }
            return factors;
        }
    }
}
