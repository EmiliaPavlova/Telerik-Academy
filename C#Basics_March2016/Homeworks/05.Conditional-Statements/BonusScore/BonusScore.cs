namespace BonusScore
{
    using System;

    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            if (1 <= score && score <= 3)
            {
                score *= 10;
            }
            else if (4 <= score && score <= 6)
            {
                score *= 100;
            }
            else if (7 <= score && score <= 9)
            {
                score *= 1000;
            }
            else
            {
                Console.WriteLine("invalid score");
                return;
            }

            Console.WriteLine(score);
        }
    }
}
