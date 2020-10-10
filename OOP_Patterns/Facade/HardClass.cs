using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HardClass
    {
        private string HardFuncFirst(string value) =>$"Something is happening {value}";
        private string HardFuncSecond(string value) =>$"And something else happened {value}";
        public string HardFuncThree(string valueFirst, string valueSecond) => HardFuncFirst(valueFirst) + Environment.NewLine + HardFuncSecond(valueSecond);

    }
}
