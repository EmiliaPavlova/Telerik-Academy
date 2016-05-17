namespace ThirdDigit
{
    using System;

    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int thirdDigit = number / 100;
            thirdDigit %= 10;

            if (thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", thirdDigit);
            }
        }
    }
}
