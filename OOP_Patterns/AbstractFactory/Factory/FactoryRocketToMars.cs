using AbstractFactory.Entities;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory.Factory
{
    public class FactoryRocketToMars : IFactory
    {
        public IFasterRocket CreateFaster()
        {
           return new FasterRocket();
        }

        public ISlowRocket CreateSlow()
        {
            return new SlowRocket();
        }
    }
}
