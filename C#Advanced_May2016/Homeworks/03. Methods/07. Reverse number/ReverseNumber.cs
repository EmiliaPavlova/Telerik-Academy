namespace ReverseNumber
{
    using System;
    using System.Linq;

    class ReverseNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            Console.WriteLine(GetReversedNumber(number));
        }

        private static string GetReversedNumber(string number)
        {
            number = string.Join("", number.Reverse());

            return number;
        }
    }
}
