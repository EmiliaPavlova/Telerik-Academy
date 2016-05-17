namespace UKFlag
{
    using System;

    class UKFlag
    {
        public static char Asterisk = '*';
        public static char Right = '\\';
        public static char Middle = '|';
        public static char Left = '/';
        public static char Dash = '-';
        public static char Dot = '.';

        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());

            for (int i = 0, inside = (width - 3) / 2; i < width / 2; i++, inside--)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{4}{0}",
                    new string(Dot, i),
                    Right,
                    new string(Dot, inside),
                    Middle,
                    Left);
            }

            Console.WriteLine("{0}{1}{0}", new string(Dash, width / 2), Asterisk);

            for (int i = width / 2 - 1, inside = 0; i >= 0; i--, inside++)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{4}{0}",
                    new string(Dot, i),
                    Left,
                    new string(Dot, inside),
                    Middle,
                    Right);
            }
        }
    }
}
