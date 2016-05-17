namespace FibonacciNumbers
{
    using System;
    using System.Linq;

    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long[] fibNumbers = new long[number];
            long fib1 = 0;
            long fib2 = 1;

            if (number == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                fibNumbers[0] = 0;
                fibNumbers[1] = 1;
                for (int i = 2; i < number; i++)
                {
                    long numberFib = fib1 + fib2;
                    fibNumbers[i] = numberFib;
                    fib1 = fib2;
                    fib2 = numberFib;
                }

                Console.WriteLine(string.Join(", ", fibNumbers));
            }
        }
    }
}
