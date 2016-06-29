namespace MutantSquirrels
{
    using System;

    class MutantSquirrels
    {
        static void Main(string[] args)
        {
            const int multiplier = 376439;
            const double divisor = 7.0;
            ulong trees = ulong.Parse(Console.ReadLine());
            uint branches = uint.Parse(Console.ReadLine());
            uint squirrels = uint.Parse(Console.ReadLine());
            uint tails = uint.Parse(Console.ReadLine());

            ulong count = trees * branches * squirrels * tails;
            Console.WriteLine("{0:F3}", count % 2 == 0 ? count * multiplier : count / divisor);
        }
    }
}
