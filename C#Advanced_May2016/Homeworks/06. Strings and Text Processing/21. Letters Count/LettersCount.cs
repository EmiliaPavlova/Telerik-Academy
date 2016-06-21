namespace LettersCount
{
    using System;
    using System.Collections.Generic;

    class LettersCount
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine().ToCharArray();

            var distinct = new Dictionary<char, int>();
            foreach (var c in letters)
            {
                if (!distinct.ContainsKey(c))
                {
                    distinct.Add(c, 1);
                }
                else
                {
                    distinct[c]++;
                }
            }

            foreach (KeyValuePair<char, int> pair in distinct)
            {
                Console.WriteLine(int.Parse(pair.Value.ToString()) == 1 
                    ? "{0} - {1} time" 
                    : "{0} - {1} times", pair.Key, pair.Value);
            }
        }
    }
}
