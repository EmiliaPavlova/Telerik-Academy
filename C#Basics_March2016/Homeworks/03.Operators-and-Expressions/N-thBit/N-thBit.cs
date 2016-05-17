namespace N_thBit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long p = int.Parse(Console.ReadLine()); // number
            int n = int.Parse(Console.ReadLine());

            long bit = p >> n & 1;
            Console.WriteLine(bit);
        }
    }
}
