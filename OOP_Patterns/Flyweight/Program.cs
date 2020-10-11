using Flyweight.Abstract;
using Flyweight.Factory;
using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSpeed = 100;
            FactoryRocket rocketFactory = new FactoryRocket();

            for (int i = 0; i < 5; i++)
            {
                AbstractRocket fasterRocket = rocketFactory.GetRocket("Falcon9");
                if (fasterRocket != null)
                    fasterRocket.Build("V10", maxSpeed);
                maxSpeed++;
            }

            for (int i = 0; i < 5; i++)
            {
                AbstractRocket slowRocket= rocketFactory.GetRocket("Falcon10");
                if (slowRocket != null)
                    slowRocket.Build("V5", maxSpeed - 50);
                maxSpeed++;
            }



            Console.ReadLine();
        }
    }
}
