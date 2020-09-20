using AbstractFactory.Entities;
using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public class FactoryRocketToMoon : IFactory
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
