namespace Printing
{
    using System;

    class Printing
    {
        static void Main(string[] args)
        {
            int sheetsInRealm = 500;
            int studentsCount = int.Parse(Console.ReadLine());
            int sheetsToPrint = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());
            
            decimal savedMoney = (studentsCount * sheetsToPrint) / (decimal)sheetsInRealm * price;
            Console.WriteLine("{0:f2}", savedMoney);
        }
    }
}
