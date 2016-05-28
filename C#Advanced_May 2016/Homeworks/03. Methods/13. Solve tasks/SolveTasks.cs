namespace SolveTasks
{
    using System;
    using System.Linq;

    class SolveTasks
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Pick a task:");
            Console.WriteLine("  a - Reverses the digits of a number");
            Console.WriteLine("  b - Calculates the average of a sequence of integers");
            Console.WriteLine("  c - Solves a linear equation a * x + b = 0");
            string task = Console.ReadLine();
            switch (task)
            {
                case "a":
                    Console.WriteLine("Enter a number:");
                    string number = Console.ReadLine();
                    Console.WriteLine(double.Parse(number) > 0.0
                        ? ReverseDigits(number)
                        : "The number should not be negative");
                    break;
                case "b":
                    Console.WriteLine("Enter integers, separated by space:");
                    int[] numbers = Console.ReadLine()
                        .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    Console.WriteLine(numbers.Average());
                    break;
                case "c":
                    Console.Write("Enter a = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter b = ");
                    int b = int.Parse(Console.ReadLine());
                    if (a != 0)
                    {
                        Console.WriteLine(SolveLinearEquation(a, b));
                    }
                    else
                    {
                        Console.WriteLine("a should not be equal to 0");
                        goto start;
                    }
                    break;
                default:
                    Console.WriteLine("Pick a, b or c");
                    goto start;
            }
        }

        static string ReverseDigits(string number)
        {
            number = string.Join("", number.Reverse());

            return number;
        }

        static double SolveLinearEquation(int a, int b)
        {
            double x = -b / (double)a;

            return x;
        }
    }
}
