namespace Feathers
{
    using System;

    class Feathers
    {
        static void Main(string[] args)
        {
            int birdsInForest = int.Parse(Console.ReadLine());
            int feathersInForest = int.Parse(Console.ReadLine());

            double averageFeathersCountPerBird = (double)feathersInForest / birdsInForest;
            if (birdsInForest == 0)
            {
                averageFeathersCountPerBird = 0;
            }
            else
            {
                if (birdsInForest % 2 == 0)
                {
                    averageFeathersCountPerBird *= 123123123123;
                }
                else
                {
                    averageFeathersCountPerBird /= 317;
                }
            }
            

            Console.WriteLine("{0:F4}", averageFeathersCountPerBird);
        }
    }
}
