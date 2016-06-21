namespace FormatNumber
{
    using System;

    class FormatNumber
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15}", input);
            Console.WriteLine("{0,15:X}", input);
            Console.WriteLine("{0,15:P}", input);
            Console.WriteLine("{0,15:E5}", input);
        }
    }
}
