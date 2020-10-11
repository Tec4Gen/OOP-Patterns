using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Entitiyes
{
    public class Bread
    {
        public Salt Salt { get; set; }

        public Flour Flour { get; set; }

        public Corn Corn { get; set; }

        public Cream Cream { get; set; }
    }
}
