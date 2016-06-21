namespace LeapYear
{
    using System;

    class LeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(year) ? "Leap" : "Common");
        }
    }
}
