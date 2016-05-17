namespace BitExchange
{
    using System;

    class BitExchange
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint mask345 = (1 << 3 | 1 << 4 | 1 << 5);
            uint mask242526 = (1 << 24 | 1 << 25 | 1 << 26);
            uint bits345 = number & mask345;
            uint bits242526 = number & mask242526;
            uint switchedBits = (bits345 << 21 | bits242526 >> 21);
            uint nullBits = number & ~(mask345 | mask242526);
            uint result = nullBits | switchedBits;
            Console.WriteLine(result);
        }
    }
}
