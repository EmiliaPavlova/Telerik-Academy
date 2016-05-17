namespace IntDoubleAndString
{
    using System;

    class IntDoubleAndString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "integer":
                    int typeInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(typeInt + 1);
                    break;
                case "real":
                    double typeDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", typeDouble + 1);
                    break;
                case "text":
                    Console.WriteLine(Console.ReadLine() + '*');
                    break;
                default:
                    break;
            }
        }
    }
}
