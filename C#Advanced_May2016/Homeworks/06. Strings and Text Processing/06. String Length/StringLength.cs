namespace StringLength
{
    using System;

    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace(@"\\", @"");
            Console.WriteLine(input.Length < 20 ? input.PadRight(20, '*') : input);
        }
    }
}
