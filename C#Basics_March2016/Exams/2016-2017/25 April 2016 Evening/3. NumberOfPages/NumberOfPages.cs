namespace NumberOfPages
{
    using System;

    class NumberOfPages
    {
        private static int pageLengthDigit = 9; // after 9 there are 2 digits: 10, 11...

        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            int temp = 0;
            int n = 0;

            int index = 0;
            while (digits > 0)
            {
                n = digits / (index + 1) + temp;
                temp += pageLengthDigit * (int)Math.Pow(10, index);
                digits -= (index + 1) * pageLengthDigit * (int)Math.Pow(10, index);
                index++;
            }

            Console.WriteLine(n);
        }
    }
}
