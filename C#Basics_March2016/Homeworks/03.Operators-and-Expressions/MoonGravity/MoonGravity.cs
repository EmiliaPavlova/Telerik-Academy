namespace MoonGravity
{
    using System;

    class MoonGravity
    {
        public const double MoonGravityIndex = 0.17;

        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double moonWeight = weight * MoonGravityIndex;

            Console.WriteLine("{0:F3}", moonWeight);
        }
    }
}
