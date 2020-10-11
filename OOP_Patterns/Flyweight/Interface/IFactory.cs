using Flyweight.Abstract;

namespace Flyweight.Interface
{
    public interface IFactory
    {
        AbstractRocket GetRocket(string key);
    }
}
