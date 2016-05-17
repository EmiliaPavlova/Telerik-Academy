namespace DivideBy7And5
{
    using System;

    class DivideBy7And5
    {
        public const int Divider = 35;

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % Divider == 0)
            {
                Console.WriteLine("true {0}", number);
            }
            else
            {
                Console.WriteLine("false {0}", number);
            }
        }
    }
}
