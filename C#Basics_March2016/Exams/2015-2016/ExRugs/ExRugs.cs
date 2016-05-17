namespace ExRugs
{
    using System;

    class ExRugs
    {
        const char Dot = '.';
        const char Dies = '#';
        const char Ex = 'X';
        const char LeftSym = '\\';
        const char RightSym = '/';

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int distance = int.Parse(Console.ReadLine());

            int designWidth = width - (2 * distance) - 4;
            int rows = 0;
            
        }
    }
}
