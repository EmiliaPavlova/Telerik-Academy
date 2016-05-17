namespace AngryFemaleGPS
{
    using System;

    class AngryFemaleGPS
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long sumEven = 0;
            long sumOdd = 0;

            if (n < 0)
            {
                n *= -1;
            }

            while (n != 0)
            {
                long digit = n % 10;
                n /= 10;
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else
                {
                    sumOdd += digit;
                }
            }

            if (sumEven > sumOdd)
            {
                Console.WriteLine("right " + sumEven);
            }
            else if (sumEven < sumOdd)
            {
                Console.WriteLine("left " + sumOdd);
            }
            else
            {
                Console.WriteLine("straight " + sumEven);
            }
        }
    }
}
