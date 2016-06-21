namespace DayOfWeek
{
    using System;

    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.DayOfWeek);
        }
    }
}
