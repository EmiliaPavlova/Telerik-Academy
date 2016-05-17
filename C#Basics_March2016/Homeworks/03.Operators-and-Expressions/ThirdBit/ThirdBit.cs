namespace ThirdBit
{
    using System;

    class ThirdBit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int thirdBit = number >> 3 & 1;
            Console.WriteLine(thirdBit);
        }
    }
}
