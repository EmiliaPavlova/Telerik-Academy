namespace Age
{
    using System;

    class Age
    {
        static void Main(string[] args)
        {
            //Console.Write("Please enter your birthday in the format MM.DD.YYYY: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int years = now.Year - birthday.Year;
            if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day))
            {
                years--;
            }

            Console.WriteLine(years);
            Console.WriteLine(years + 10);
        }
    }
}
