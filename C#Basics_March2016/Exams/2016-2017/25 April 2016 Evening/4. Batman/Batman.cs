namespace Batman
{
    using System;
    using System.Globalization;

    class Batman
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char empty = ' ';
            int outside = 0;
            int wing = size;

            // wings
            for (int i = 0; i < size / 2 - 1; i++, wing--)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(empty, i), new string(c, wing), new string(empty, size));
                outside = i;
            }

            // head
            outside++;
            Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}",
                new string(empty, outside), new string(c, wing), new string(empty, size / 2 - 1), c, empty);

            // body
            outside++;
            for (int i = 0; i < size / 3; i++)
            {
                Console.WriteLine("{0}{1}{0}", 
                    new string(empty, outside), new string(c, (size * 3) - outside * 2));
            }

            // tail
            int tail = size - 2;
            outside = (size * 3 - tail) / 2;
            for (int i = tail; i > 0; i -= 2, outside++)
            {
                Console.WriteLine("{0}{1}{0}", new string(empty, outside), new string(c, i));
            }
        }
    }
}
