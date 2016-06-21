namespace PrimeNumbers
{
    using System;

    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] numbers = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                numbers[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (numbers[i])
                {
                    for (int j = 2; j * i <= n; j++)
                    {
                        numbers[j * i] = false;
                    }
                }
            }

            Console.WriteLine(Array.LastIndexOf(numbers, true));
        }
    }
}