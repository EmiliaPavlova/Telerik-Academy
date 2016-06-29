namespace BobbyAvokadoto
{
    using System;

    class BobbyAvokadoto
    {
        static void Main(string[] args)
        {
            uint head = uint.Parse(Console.ReadLine());
            uint c = uint.Parse(Console.ReadLine());
            int bestCombTeeth = 0;
            uint bestComb = 0;

            for (int i = 0; i < c; i++)
            {
                uint comb = uint.Parse(Console.ReadLine());
                int teeth = 0;

                for (int j = 0; j < 32; j++)
                {
                    uint bitHead = (head >> j) & 1;
                    uint bitComb = (comb >> j) & 1;
                    if ((bitHead ^ bitComb) == 1)
                    {
                        teeth++;
                    }
                    else if(bitComb == 1 && bitHead == 1)
                    {
                        break;
                    }
                }

                if (teeth > bestCombTeeth)
                {
                    bestCombTeeth = teeth;
                    bestComb = comb;
                }
            }

            Console.WriteLine(bestComb);
        }
    }
}
