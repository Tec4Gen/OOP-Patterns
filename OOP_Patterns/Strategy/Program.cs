using Strategy.Abstract;
using Strategy.Entityes;
using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractRocket rocketOne = new SlowRocket { Type = "Heavy",Name = "Falcon9" };

            AbstractRocket rocketSecodn = new FasterRocket { Type = "Not Heavy", Name = "Falcon1" };

            Console.WriteLine(rocketOne.Name);


            Console.WriteLine(rocketSecodn.Name);

            var rocket = rocketOne as IMove;
            var rocket1 = rocketSecodn as IMove;

            rocket.Moveble();


            rocket1.Moveble();
        }
    }
}
