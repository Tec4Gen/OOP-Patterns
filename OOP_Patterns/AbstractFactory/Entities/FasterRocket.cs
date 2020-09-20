
using AbstractFactory.Interface;
using System;

namespace AbstractFactory.Entities
{
    public class FasterRocket: IFasterRocket
    {
        public void FliesFast()
        {
            Console.WriteLine("Flies, flies, flies fast");
        }
    }
}
