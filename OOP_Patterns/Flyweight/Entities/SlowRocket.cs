using Flyweight.Abstract;
using System;

namespace Flyweight.Entities
{
    public class SlowRocket : AbstractRocket
    {
        public SlowRocket()
        {
            step = 5;
        }

        public override void Build(string engine, int maxSpeed)
        {
            Console.WriteLine($"Построена медленная ракета; с двигателем: {engine} и максимальной скоростью {maxSpeed}");
        }
    }
}
