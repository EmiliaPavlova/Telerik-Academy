namespace BobbyAvokadoto
{
    using System;

    class BobbyAvokadoto
    {
        static void Main(string[] args)
        {
            uint head = uint.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int bestCombTeeth = 0;
            uint bestComb = 0;
            int lenght = Convert.ToString(head, 2).Length;

            for (int i = 0; i < n; i++)
            {
                uint comb = uint.Parse(Console.ReadLine());
                int teeth = 0;
                if (Convert.ToString(comb, 2).Length < lenght)
                {
                    lenght = Convert.ToString(comb, 2).Length;
                }

                for (int j = 0; j < lenght; j++)
                {
                    uint bitHead = (head >> j) & 1;
                    uint bitComb = (comb >> j) & 1;
                    if ((bitHead ^ bitComb) == 0)
                    {
                        break;
                    }
                    //if (bitComb == 1)
                    //{
                    //    teeth++;
                    //}
                }

                for (int j = 0; j < 32; j++)
                {
                    if (((comb >> j) & 1) == 1)
                    {
                        teeth++;
                    }
                }

                if (teeth < bestCombTeeth)
                {
                    continue;
                }
                bestCombTeeth = teeth;
                bestComb = comb;
            }

            Console.WriteLine(bestComb + " " + bestCombTeeth);
        }
    }
}
