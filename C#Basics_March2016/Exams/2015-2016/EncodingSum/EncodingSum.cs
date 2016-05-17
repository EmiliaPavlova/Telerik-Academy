namespace EncodingSum
{
    using System;

    class EncodingSum
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int result = 0;
            foreach (char ch in text)
            {
                if (ch == '@')
                {
                    break;
                }
                else if (ch >= '0' && ch <= '9')
                {
                    result *= (ch - '0');
                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    result += ch - 'A';
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    result += ch - 'a';
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
