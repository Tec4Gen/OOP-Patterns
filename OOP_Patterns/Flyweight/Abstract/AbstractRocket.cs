using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Abstract
{
    public abstract class AbstractRocket
    {
        protected int step;

        public abstract void Build(string engine, int maxSpeed);
    }
}
