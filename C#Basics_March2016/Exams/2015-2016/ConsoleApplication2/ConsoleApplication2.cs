namespace ConsoleApplication2
{
    using System;
    using System.Numerics;

    class ConsoleApplication2
    {
        static void Main(string[] args)
        {
            string input;
            int position = 0;
            BigInteger resultFirst10 = 1;
            BigInteger resultOthers = 1;

            while ((input = Console.ReadLine()) != "END")
            {
                BigInteger number = BigInteger.Parse(input);
                BigInteger productFirst10 = 1;
                BigInteger productOthers = 1;
                if (position % 2 == 0 && number != 0)
                {
                    if (position < 10)
                    {
                        productFirst10 = CalculateProduct(number);
                    }
                    else
                    {
                        productOthers = CalculateProduct(number);
                    }
                }

                resultFirst10 *= productFirst10;
                resultOthers *= productOthers;
                position++;
            }

            Console.WriteLine(resultFirst10);
            if (position >= 10)
            {
                Console.WriteLine(resultOthers);
            }
        }

        private static BigInteger CalculateProduct(BigInteger number)
        {
            BigInteger result = 1;
            while (number != 0)
            {
                BigInteger digit = number % 10;
                if (digit == 0)
                {
                    digit = 1;
                }

                result *= digit;
                number /= 10;
            }

            return result;
        }
    }
}
