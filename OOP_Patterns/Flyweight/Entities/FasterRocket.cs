using Flyweight.Abstract;
using System;

namespace Flyweight.Entities
{
    public class FasterRocket : AbstractRocket
    {
        public FasterRocket()
        {
            step = 3;
        }

        public override void Build(string engine, int maxSpeed)
        {
            Console.WriteLine($"Построена быстрая ракета; с двигателем: {engine} и максимальной скоростью {maxSpeed}");
        }
    }
}
