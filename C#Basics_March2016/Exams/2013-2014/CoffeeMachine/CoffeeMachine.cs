namespace CoffeeMachine
{
    using System;

    class CoffeeMachine
    {
        const decimal Tray1 = 0.05m;
        const decimal Tray2 = 0.10m;
        const decimal Tray3 = 0.20m;
        const decimal Tray4 = 0.50m;
        const decimal Tray5 = 1.00m;

        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            decimal amount = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal moneyTotal = n1 * Tray1 + n2 * Tray2 + n3 * Tray3 + n4 * Tray4 + n5 * Tray5;
            decimal change = amount - price;

            if (price <= amount && change <= moneyTotal)
            {
                Console.WriteLine("Yes " + (moneyTotal - change));
            }
            else if (price > amount)
            {
                Console.WriteLine("More " + Math.Abs(amount - price));
            }
            else
            {
                Console.WriteLine("No " + Math.Abs(change - moneyTotal));
            }
        }
    }
}
