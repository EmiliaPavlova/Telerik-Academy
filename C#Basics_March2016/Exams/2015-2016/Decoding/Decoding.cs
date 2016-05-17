namespace Decoding
{
    using System;

    class Decoding
    {
        static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int position = -1;
            double result;

            foreach (char c in text)
            {
                if (c == '@')
                {
                    break;
                }
                else if (65 <= c && c <= 90 ||
                    97 <= c && c <= 122)
                {
                    result = c * salt + 1000;
                    position++;
                }
                else if (48 <= c && c <= 57)
                {
                    result = c + salt + 500;
                    position++;
                }
                else
                {
                    result = c - salt;
                    position++;
                }

                if (position % 2 == 0)
                {
                    result /= 100;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result *= 100;
                    Console.WriteLine(result);
                }
            }
        }
    }
}
