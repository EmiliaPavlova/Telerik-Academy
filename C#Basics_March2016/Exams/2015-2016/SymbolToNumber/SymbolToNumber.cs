namespace SymbolToNumber
{
    using System;

    class SymbolToNumber
    {
        static void Main(string[] args)
        {
            int secret = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int position = 1;
            double output;

            foreach (char ch in text)
            {
                if (ch == '@')
                {
                    break;
                }
                else if ((65 <= ch && ch <= 90) || (97 <= ch && ch <= 122))
                {
                    output = ch * secret + 1000;
                    position++;
                }
                else if (48 <= ch && ch <= 57)
                {
                    output = ch + secret + 500;
                    position++;
                }
                else
                {
                    output = ch - secret;
                    position++;
                }

                if (position % 2 == 0)
                {
                    output /= 100;
                    Console.WriteLine("{0:F2}", output);
                }
                else
                {
                    output *= 100;
                    Console.WriteLine(output);
                }
            }
        }
    }
}
