namespace PlayCard
{
    using System;
    using System.Linq;

    class PlayCard
    {
        static void Main(string[] args)
        {
            string cardFace = Console.ReadLine();
            string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            if (cards.Contains(cardFace))
            {
                Console.WriteLine("yes " + cardFace);
            }
            else
            {
                Console.WriteLine("no " + cardFace);
            }
        }
    }
}
