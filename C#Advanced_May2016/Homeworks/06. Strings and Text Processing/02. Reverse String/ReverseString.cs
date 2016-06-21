namespace ReverseString
{
    using System;
    using System.Linq;

    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversedString = new string(input.Reverse().ToArray());
            Console.WriteLine(reversedString);
        }
    }
}
