namespace EncodeDecode
{
    using System;

    class EncodeDecode
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.Write("Enter code: ");
            string code = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(@"\u{0:x4}", text[i] ^ code[i % code.Length]);
            }
        }
    }
}
