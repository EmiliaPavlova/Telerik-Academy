namespace StringBuilderExtension
{
    using System;
    using System.Text;

    class StartUp
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            input.AppendLine("Implement an extension method");

            Console.WriteLine(input.Substring(5, 15).ToString());
            Console.WriteLine(input.Substring(5).ToString());
        }
    }
}
