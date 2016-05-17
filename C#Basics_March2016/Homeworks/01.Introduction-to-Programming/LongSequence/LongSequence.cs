namespace LongSequence
{
    using System;

    class LongSequence
    {
        static void Main(string[] args)
        {
            double value;
            //Console.BufferHeight = 1001;

            for (int i = 2; i < 1002; i++)
            {
                value = i * Math.Pow(-1, i);
                Console.WriteLine(value);
            }
        }
    }
}
