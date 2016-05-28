namespace DateDifference
{
    using System;

    class DateDifference
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first date in format dd.mm.yyyy: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the second date in format dd.mm.yyyy: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan daysDifference = firstDate - secondDate;
            Console.WriteLine(Math.Abs(daysDifference.TotalDays));
        }
    }
}
