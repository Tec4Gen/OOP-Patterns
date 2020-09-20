using AbstractFactory.Entities;
using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public class FactoryRocketToVenus : IFactory
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
