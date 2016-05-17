namespace Eggcelent
{
    using System;

    class Eggcelent
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n;
            int width = 3 * n - 1;
            int counterHeight = 0;

            //Top
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('*', width - n * 2));
            counterHeight++;

            //print slope top side:
            int loopSize = n - 2;
            int mask = n;

            if (loopSize >= 1)
            {
                for (int i = 0; i < loopSize; i++)
                {
                    if (mask < 1)
                    {
                        break;
                    }

                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', mask - 1), '*', new string('.', width - mask * 2 + 2));
                    mask -= 2;
                    counterHeight++;
                }
            }

            //print top sides:
            int maskWidth = (n * 2 - (counterHeight * 2) - 2) / 2;
            if (maskWidth > 0)
            {
                for (int i = 0; i < maskWidth; i++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", '.', '*', new string('.', width - 2));
                    counterHeight++;
                }
            }

            //Printing the middle:
            Console.Write("{0}{1}", '.', '*');

            for (int i = 0; i < width - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write('@');
                }
                else
                {
                    Console.Write('.');
                }
            }

            Console.WriteLine("{0}{1}", '*', '.');
            counterHeight++;

            //Second line of the middle:
            Console.Write("{0}{1}", '.', '*');
            for (int i = 0; i < width - 2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write('@');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine("{0}{1}", '*', '.');
            counterHeight++;

            //print bottom:
            //print bottom sides:
            for (int i = 0; i < maskWidth; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", '.', '*', new string('.', width - 2));
                counterHeight++;
            }

            int loopsLeft = height - counterHeight - 1;
            int z = 0;

            for (int i = 0; i < loopsLeft; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', z + 1), '*', new string('.', width - 2 * z - 2));
                z += 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('*', width - n * 2));
            counterHeight++;
        }
    }
}
