namespace MultiplicationSign
{
    using System;

    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            char sign = new char();

            if (a == 0.0 || b == 0.0 || c == 0.0)
            {
                sign = '0';
            }
            else if (a > 0 && b > 0 && c > 0 || 
                     a > 0 && b < 0 && c < 0 ||
                     a < 0 && b > 0 && c < 0 ||
                     a < 0 && b < 0 && c > 0)
            {
                sign = '+';
            }
            else
            {
                sign = '-';
            }

            Console.WriteLine(sign);
        }
    }
}
