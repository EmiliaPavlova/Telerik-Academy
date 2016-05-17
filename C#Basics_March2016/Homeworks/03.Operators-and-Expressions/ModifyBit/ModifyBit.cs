namespace ModifyBit
{
    using System;

    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine()); // number
            int p = int.Parse(Console.ReadLine()); // position
            int v = int.Parse(Console.ReadLine()); // bit value
            ulong newNumber = new int();
            switch (v)
            {
                case 0:
                    newNumber = (ulong)~(1 << p) & n;
                    break;
                case 1:
                    newNumber = (ulong)1 << p | n;
                    break;
                default:
                    break;
            }

            Console.WriteLine(newNumber);
        }
    }
}
