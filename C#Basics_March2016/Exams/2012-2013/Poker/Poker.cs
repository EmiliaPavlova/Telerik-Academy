namespace Poker
{
    using System;

    class Poker
    {
        static void Main(string[] args)
        {
            int[] Cards = new int[5];
            int i = 0, pair = 0, straight = 0;
            while (i < 5)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "J": card = "11"; break;
                    case "Q": card = "12"; break;
                    case "K": card = "13"; break;
                    case "A": card = "14"; break;
                }

                Cards[i] = int.Parse(card);
                i++;
            }

            Array.Sort(Cards);
            for (i = 0; i < Cards.Length - 1; i++)
            {
                if ((Cards[i] + 1 == Cards[i + 1] ||
                     (Cards[4] == 14 && Cards[0] == 2 && Cards[1] == 3 && Cards[2] == 4 && Cards[3] == 5)))
                {
                    straight++;
                }

                if (straight == 4)
                {
                    Console.WriteLine("Straight");
                }

                for (int j = 1; j < Cards.Length; j++)
                {
                    if (i != j && i < j && Cards[i] == Cards[j])
                    {
                        pair++;
                    }
                }
            }

            switch (pair)
            {
                case 1: Console.WriteLine("One Pair"); break;
                case 2: Console.WriteLine("Two Pairs"); break;
                case 3: Console.WriteLine("Three of a Kind"); break;
                case 4: Console.WriteLine("Full House"); break;
                case 6: Console.WriteLine("Four of a Kind"); break;
                case 10: Console.WriteLine("Impossible"); break;
                default:
                    if (straight != 4)
                    {
                        Console.WriteLine("Nothing");
                    }
                    break;
            }
        }
    }
}
