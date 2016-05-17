namespace FourDigits
{
    using System;

    class FourDigits
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = CalculateSum(number);
            Console.WriteLine(sum);

            string reversed = Reverse(number);
            Console.WriteLine(reversed);

            string lastDigitAtFirstPosition = PutLastDigitFirst(number);
            Console.WriteLine(lastDigitAtFirstPosition);

            string exchanged = ExchangeSecondAndThirdDigits(number);
            Console.WriteLine(exchanged);
        }

        private static int CalculateSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        private static string Reverse(int number)
        {
            char[] digits = number.ToString().ToCharArray();
            Array.Reverse(digits);

            return new string(digits);
        }

        private static string PutLastDigitFirst(int number)
        {
            int lastDigit = number % 10;
            number /= 10;

            return lastDigit.ToString() + number;
        }

        private static string ExchangeSecondAndThirdDigits(int number)
        {
            char[] digits = number.ToString().ToCharArray();
            char tempDigit = digits[1];
            digits[1] = digits[2];
            digits[2] = tempDigit;
            
            return new string(digits);
        }
    }
}
