﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new FacadeHardClass(new HardClass()).Mediator("@here@", "@and here@"));
        }
    }
}
