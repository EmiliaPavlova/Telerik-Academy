namespace NumbersComparer
{
    using System;

    class NumbersComparer
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine((a.CompareTo(b) > 0) ? a : b);
        }
    }
}
