using Flyweight.Abstract;
using Flyweight.Entities;
using Flyweight.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Factory
{
   public class FactoryRocket: IFactory
    {
        Dictionary<string, AbstractRocket> rocketList = new Dictionary<string, AbstractRocket>();
        public FactoryRocket()
        {
            rocketList.Add("Falcon9", new FasterRocket());
            rocketList.Add("Falcon10", new SlowRocket());
        }

        public AbstractRocket GetRocket(string key)
        {
            if (rocketList.ContainsKey(key))
                return rocketList[key];
            else
                return null;
        }
    }
}
