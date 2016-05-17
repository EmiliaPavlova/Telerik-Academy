namespace A_nacci
{
    using System;

    class Program
    {
        public const int Shift = 64; // 'A' = 65;

        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            Console.WriteLine(letter1);

            int first = (int)letter1 - Shift;
            int second = (int) letter2 - Shift;

            if (lines > 1)
            {
                for (int i = 1; i < lines; i++)
                {
                    for (int j = 0; j <= 1; j++)
                    {
                        int next = first + second;

                        if (next > 26)
                        {
                            next %= 26;
                        }

                        first = second;
                        second = next;

                        if (j > 0)
                        {
                            Console.Write(new string(' ', i - 1));
                        }

                        Console.Write((char)(first + Shift));
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
