namespace _64BitArray
{
    using System;

    class BitArrayTest
    {
        static void Main(string[] args)
        {
            var bits = new BitArray64(1234);
            Console.WriteLine(bits.DecimalValue);

            foreach (var item in bits)
            {
                Console.Write(item);
            }

            var anotherBits = new BitArray64(1024 * 1024 * 1024);
            Console.WriteLine(anotherBits);
            Console.WriteLine(anotherBits.DecimalValue);
        }
    }
}
