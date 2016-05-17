namespace NextDate
{
    using System;

    class NextDate
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("bg-BG");
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            
            DateTime date = new DateTime(year, month, day);
            Console.WriteLine("{0:d.M.yyyy}", date.AddDays(1));
        }
    }
}
