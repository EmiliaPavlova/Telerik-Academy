namespace PrintADeck
{
    using System;

    class PrintADeck
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] cards = new[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            int index = Array.IndexOf(cards, input);
            for (int i = 0; i <= index; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[i]);
            }
        }
    }
}
