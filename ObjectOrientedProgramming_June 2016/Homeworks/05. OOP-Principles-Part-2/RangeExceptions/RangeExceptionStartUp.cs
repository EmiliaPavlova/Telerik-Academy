namespace RangeExceptions
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = 101;
                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Invalid input", 1, 100);
                }
            }

            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                DateTime date = new DateTime(2016, 10, 10);
                if (date < new DateTime(1900, 01, 01) || date > DateTime.Now)
                {
                    throw new InvalidRangeException<DateTime>("Invalid date",
                    new DateTime(2016, 10, 10), DateTime.Now);
                }
            }

            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
