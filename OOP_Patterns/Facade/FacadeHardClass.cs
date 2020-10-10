using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class FacadeHardClass
    {
        private HardClass _hardClass;
        public FacadeHardClass(HardClass hardClass)
        {
            _hardClass = hardClass;
        }
        public string Mediator(string valueFirst, string valueSecond) => _hardClass.HardFuncThree(valueFirst, valueSecond);
        
    }
}
