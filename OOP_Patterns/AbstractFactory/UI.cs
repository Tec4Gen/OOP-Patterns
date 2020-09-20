using AbstractFactory.Factory;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory
{
    public class UI
    {
        public  void Run() 
        {
            Console.WriteLine("Where do you want to fly?" + 
                Environment.NewLine +
                "1) Mars" + 
                Environment.NewLine +
                "2) Moon" +
                Environment.NewLine +
                "3) Venus");
            int.TryParse(Console.ReadLine(), out int rocket);

            var factory = CreateRocket(rocket);

            Console.WriteLine("Fast or slow rocket?" +
               Environment.NewLine +
               "1) Faster" +
               Environment.NewLine +
               "2) Slow");


            int.TryParse(Console.ReadLine(), out int type);

            switch (type) 
            {
                case 1:
                    factory.CreateFaster();
                    Console.WriteLine("Rocket faster ready");
                    break;
                case 2:
                    factory.CreateSlow();
                    Console.WriteLine("Rocket slow ready");
                    break;
                default:
                    Console.WriteLine("Type rocket not found");
                    break;
            }
        }

        IFactory CreateRocket(int action) 
        {
            if (action == 1)
                return new FactoryRocketToMars();
            if(action == 2)
                return new FactoryRocketToMoon();
            if (action == 3)
                return new FactoryRocketToVenus();

            else return null;   
        }

    }
}
