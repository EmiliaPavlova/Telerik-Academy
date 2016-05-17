namespace Fire
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int outside = n / 2 - 1; outside >= 0; outside--)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", 
                    new string('.', outside), '#', new string('.', n - 2 * outside - 2));
            }

            for (int inside = n - 2; inside >= n / 2; inside -= 2)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", 
                    new string('.', (n - inside - 2) / 2), '#', new string('.', inside));
            }

            Console.WriteLine(new string('-', n));

            for (int dots = 0; dots < n / 2; dots++)
            {
                Console.WriteLine("{0}{1}{2}{0}",
                    new string('.', dots), new string('\\', n / 2 - dots), new string('/', n / 2 - dots));
            }
        }
    }
}
