﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interface
{
    public interface IFactory
    {
        IFasterRocket CreateFaster();

        ISlowRocket CreateSlow(); 
    }
}
