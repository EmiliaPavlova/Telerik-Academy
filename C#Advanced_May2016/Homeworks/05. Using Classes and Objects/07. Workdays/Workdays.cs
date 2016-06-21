namespace Workdays
{
    using System;
    using System.Globalization;
    using System.Linq;

    class Workdays
    {
        static DateTime[] holidays =
        {
            new DateTime(2016, 1, 1),
            new DateTime(2016, 3, 3),
            new DateTime(2016, 5, 1),
            new DateTime(2016, 5, 6),
            new DateTime(2016, 5, 24),
            new DateTime(2016, 9, 6),
            new DateTime(2016, 9, 22),
            new DateTime(2016, 12, 24),
            new DateTime(2016, 12, 25),
            new DateTime(2016, 12, 26),
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter future date in format D.M.YYYY");
            DateTime today = DateTime.Now;
            DateTime nextDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            int workDays = GetWorkDays(today, nextDate);

            Console.WriteLine("Work days until {0}: {1}", nextDate.ToString("D"), workDays);
        }

        private static int GetWorkDays(DateTime today, DateTime nextDate)
        {
            int workDays = 0;
            if (today > nextDate)
            {
                DateTime swap = today;
                today = nextDate;
                nextDate = swap;
            }

            while (today <= nextDate)
            {
                if (!holidays.Contains(today) && today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
                {
                    workDays++;
                }

                today = today.AddDays(1);
            }

            return workDays;
        }
    }
}
