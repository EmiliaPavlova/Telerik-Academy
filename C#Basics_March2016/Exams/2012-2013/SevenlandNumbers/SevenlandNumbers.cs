namespace SevenlandNumbers
{
    using System;

    class SevenlandNumbers
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            byte counter = 0;
            int decimalNumber = 0;

            while (k != 0)
            {
                byte lastDigit = (byte) (k % 10);
                decimalNumber += lastDigit * (int)Math.Pow(7, counter);
                counter++;
                k /= 10;
            }

            decimalNumber++;
            string result = string.Empty;

            while (decimalNumber != 0)
            {
                byte lastDigit = (byte)(decimalNumber % 7);
                result = lastDigit + result;
                decimalNumber /= 7;
            }

            Console.WriteLine(result);
        }
    }
}
