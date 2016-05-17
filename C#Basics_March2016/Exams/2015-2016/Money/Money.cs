namespace Money
{
    using System;

    class Money
    {
        static void Main(string[] args)
        {
            int realm = 400;
            int students = int.Parse(Console.ReadLine());
            int sheetsPerStudent = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal savedMoney = students * sheetsPerStudent / (decimal)realm * price;
            Console.WriteLine("{0:F3}", savedMoney);
        }
    }
}
