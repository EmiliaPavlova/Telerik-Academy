namespace NumberOfPages
{
    using System;

    class NumberOfPages
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            int temp = 0;
            int n = 0;

            if (digits <= 9)
            {
                n = digits;
                Console.WriteLine(n);
                return;
            }
            temp = 9;
            digits -= 9;

            if (digits <= 90 * 2)
            {
                n = digits / 2 + temp;
                Console.WriteLine(n);
                return;
            }

            temp += 90;
            digits -= 180;

            if (digits <= 900 * 3)
            {
                n = digits / 3 + temp;
                Console.WriteLine(n);
                return;
            }

            temp += 900;
            digits -= 2700;

            if (digits <= 9000 * 4)
            {
                n = digits / 4 + temp;
                Console.WriteLine(n);
                return;
            }

            temp += 9000;
            digits -= 36000;

            if (digits <= 90000 * 5)
            {
                n = digits / 5 + temp;
                Console.WriteLine(n);
                return;
            }

            temp += 90000;
            digits -= 450000;

            if (digits <= 900000 * 6)
            {
                n = digits / 6 + temp;
                Console.WriteLine(n);
            }
        }
    }
}
