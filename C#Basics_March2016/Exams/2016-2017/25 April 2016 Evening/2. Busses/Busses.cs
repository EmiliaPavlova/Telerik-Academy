namespace Busses
{
    using System;

    class Busses
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            int groups = 1;
            int groupSpeed = int.Parse(Console.ReadLine()); 

            for (int i = 1; i < c; i++)
            {
                int speed = int.Parse(Console.ReadLine());

                if(speed <= groupSpeed)
                {
                    groupSpeed = speed;
                    groups++;
                }
            }

            Console.WriteLine(groups);
        }
    }
}
