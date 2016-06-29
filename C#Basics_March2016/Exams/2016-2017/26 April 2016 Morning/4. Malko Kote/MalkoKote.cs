namespace MalkoKote
{
    using System;

    class MalkoKote
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            char c = Char.Parse(Console.ReadLine());

            // ears
            Console.WriteLine("{0}{1}{2}{1}{0}", ' ', c, new  string(' ', s / 4 - 1));

            // head
            for (int i = 0; i < s / 4 - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", ' ', new string(c, s / 4 + 1));
            }

            // neck
            for (int i = 0; i < s / 4 - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string(' ', 2), new string(c, s / 4 - 1));
            }

            //body + tail
            for (int i = 0; i < s / 4 - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string(' ', 1), new string(c, s / 4 + 1));
            }

            Console.WriteLine("{0}{1}{2}{3}", new string(' ', 1), new string(c, s / 4 + 1), 
                                              new string(' ', 3), new string(c, s / 4));

            for (int i = 0; i < s / 4 + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}", new string(c, s / 4 + 3), new string(' ', 2), c);
            }

            Console.WriteLine("{0}{1}{2}", new string(c, s / 4 + 3), ' ', new string(c, 2));

            Console.WriteLine("{0}{1}{0}", ' ', new string(c, s / 4 + 4));
        }
    }
}
