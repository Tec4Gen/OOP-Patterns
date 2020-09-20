using AbstractFactory.Interface;
using System;

namespace AbstractFactory.Entities
{
    public class SlowRocket : ISlowRocket
    {
        public void FliesSlowly()
        {
            Console.WriteLine("Flies, flies, flies slowly");
        }
    }
}
