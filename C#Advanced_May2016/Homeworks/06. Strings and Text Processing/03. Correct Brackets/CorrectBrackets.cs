namespace CorrectBrackets
{
    using System;
    using System.Linq;

    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int openBrecket = input.Count(x => x == '(');
            int closeBracket = input.Count(x => x == ')');

            Console.WriteLine(openBrecket == closeBracket ? "Correct" : "Incorrect");
        }
    }
}
