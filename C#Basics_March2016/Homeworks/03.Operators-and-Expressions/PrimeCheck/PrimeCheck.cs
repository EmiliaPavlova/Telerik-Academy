namespace PrimeCheck
{
    using System;

    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            Console.WriteLine(isPrime.ToString().ToLower());
        }
    }
}
