namespace TextToNumber
{
    using System;

    class TextToNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char[] text = Console.ReadLine()
                .ToCharArray();
            long result = 0;

            foreach (var ch in text)
            {
                if (ch == '@')
                {
                    break;
                }
                // char '0' == 48
                else if ('0' <= ch && ch <= '9')
                {
                    result *= ch - 48;
                }
                // char 'A' == 65
                else if ('A' <= ch && ch <= 'Z')
                {
                    result += ch - 65;
                }
                // char 'a' == 97
                else if ('a' <= ch && ch <= 'z')
                {
                    result += ch - 97;
                }
                else
                {
                    result %= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}
