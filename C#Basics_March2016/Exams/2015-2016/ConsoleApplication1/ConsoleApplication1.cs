namespace ConsoleApplication1
{
    using System;
    using System.Numerics;

    class ConsoleApplication1
    {
        static void Main(string[] args)
        {
            string input;
            int position = 0;
            BigInteger result1 = 1;
            BigInteger result2 = 1;
            while ((input = Console.ReadLine()) != "END")
            {
                BigInteger number = BigInteger.Parse(input);
                BigInteger productOfFirst10Digits = 1;
                BigInteger productOfOthersDicits = 1;

                if (position % 2 != 0 && number != 0)
                {
                    if (position <= 10)
                    {
                        productOfFirst10Digits = CalculateProduct(number);
                    }
                    else
                    {
                        productOfOthersDicits = CalculateProduct(number);
                    }
                }

                result1 *= productOfFirst10Digits;
                result2 *= productOfOthersDicits;
                position++;
            }

            Console.WriteLine(result1);
            if (position > 10)
            {
                Console.WriteLine(result2);
            }
        }

        static BigInteger CalculateProduct(BigInteger number)
        {
            BigInteger product = 1;
            while (number != 0)
            {
                BigInteger digit = number % 10;
                if (digit == 0)
                {
                    digit = 1;
                }
                product *= digit;
                number /= 10;
            }

            return product;
        }
    }
}
