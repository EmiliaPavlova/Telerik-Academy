namespace DivisibleBySevenAndThree
{
    using System;
    using System.Linq;

    //using System.Linq;

    class DivisibleBySevenAndThreeStartUp
    {
        private static int Divisor = 3 * 7;

        static void Main(string[] args)
        {
            var numbers = new int[100];
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            // using lambda
            foreach (int number in numbers.Where(n => n % Divisor == 0))
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            // using Linq
            var selectedNumbers = from number in numbers
                                  where number % Divisor == 0
                                  select number;

            foreach (int number in selectedNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
