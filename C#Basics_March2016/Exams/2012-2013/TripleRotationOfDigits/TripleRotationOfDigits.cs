namespace TripleRotationOfDigits
{
    using System;

    class TripleRotationOfDigits
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                if (number > 9)
                {
                    int lastDigit = number % 10;
                    number /= 10;
                    number = int.Parse(lastDigit.ToString() + number);
                }
            }

            Console.WriteLine(number);
        }
    }
}
