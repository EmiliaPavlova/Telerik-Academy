namespace DecimalToBinary
{
    using System;

    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int remainder;
            string result = string.Empty;

            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                result = remainder.ToString() + result;
            }

            Console.WriteLine(result);
        }

    }
}
