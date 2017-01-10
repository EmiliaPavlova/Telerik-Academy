namespace HarryPotter4D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HarryPotter4D
    {
        static int movesHarry = 0;

        static void Main(string[] args)
        {
            var sizes = ReadInput();
            var coordinatesHarry = ReadInput();
            var hypercube = new Dictionary<char, List<int>>();
            hypercube['@'] = new List<int>();
            hypercube['@'].Add(coordinatesHarry[0]);
            hypercube['@'].Add(coordinatesHarry[1]);
            hypercube['@'].Add(coordinatesHarry[2]);
            hypercube['@'].Add(coordinatesHarry[3]);

            int s = int.Parse(Console.ReadLine()); // basilisk count
            for (int i = 0; i < s; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                char name = Convert.ToChar(data[0]);
                int A = int.Parse(data[1]);
                int B = int.Parse(data[2]);
                int C = int.Parse(data[3]);
                int D = int.Parse(data[4]);
                hypercube[name] = new List<int>();
                hypercube[name].Add(A);
                hypercube[name].Add(B);
                hypercube[name].Add(C);
                hypercube[name].Add(D);
            }

            // instructions
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] line = input.Split(' ');
                char nameToMove = Convert.ToChar(line[0]);
                char dimension = Convert.ToChar(line[1]);
                int moves = int.Parse(line[2]);

                if (nameToMove == '@')
                {
                    movesHarry++;
                }

                if (hypercube.Keys.Contains(nameToMove))
                {
                    switch (dimension)
                    {
                        case 'A':
                            hypercube[nameToMove][0] += moves;
                            CheckForEnd(nameToMove, hypercube);
                            break;
                        case 'B':
                            hypercube[nameToMove][1] += moves;
                            CheckForEnd(nameToMove, hypercube);
                            break;
                        case 'C':
                            hypercube[nameToMove][2] += moves;
                            CheckForEnd(nameToMove, hypercube);
                            break;
                        case 'D':
                            hypercube[nameToMove][3] += moves;
                            CheckForEnd(nameToMove, hypercube);
                            break;
                    }
                }
            }
        }

        private static void CheckForEnd(char name, Dictionary<char, List<int>> hypercube)
        {
            if (name == '@')
            {
                for (int i = 1; i < hypercube.Count; i++)
                {
                    if (hypercube[(char) 0].SequenceEqual(hypercube[(char) i]))
                    {
                        Console.WriteLine("{0}: \"Step {1} was the worst you ever made.\" " +
                                          "{0}: \"You will regret until the rest of your life...All 3 seconds of it!\"",
                                          hypercube[(char) i][0], movesHarry);
                    }
                }
            }
            else if (name != '@')
            {
                for (int i = 0; i <= hypercube.Count; i++)
                {
                    if (hypercube.Where(h => h.Key != '@').SequenceEqual(hypercube.Where(h => h.Key == '@')))
                    {
                        Console.WriteLine(string.Format("{0}: \"You thought you could escape, didn't you?\" - {1}",
                            hypercube[(char)i][0], movesHarry));
                    }
                }
            }
            else
            {
                Console.WriteLine(string.Format("{0}: \"I am the chosen one!\" - {1}", '@', movesHarry));
            }
        }

        private static int[] ReadInput()
        {
            int[] array = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            return array;
        }
    }
}
