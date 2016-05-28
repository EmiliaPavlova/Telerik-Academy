namespace DateInBulgarian
{
    using System;
    using System.Globalization;

    class DateInBulgarian
    {
        static void Main(string[] args)
        {
            // 22.05.2016 13:20:10
            Console.Write("Enter the first date in format dd.mm.yyyy HH:MM:SS: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime newDate = date.AddHours(6).AddMinutes(30);
            Console.WriteLine(newDate.ToString("dd.MM.yyyy HH:mm:ss, dddd", CultureInfo.CreateSpecificCulture("bg-BG")));
        }
    }
}
