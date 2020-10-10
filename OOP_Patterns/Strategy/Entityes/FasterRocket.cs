using Strategy.Abstract;
using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Entityes
{
    class FasterRocket : AbstractRocket, IMove
    {
        public void Moveble()
        {
            Console.WriteLine("MegaFaster");
        }
    }
}
