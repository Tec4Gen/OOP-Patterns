﻿using Builder.Entitiyes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interface
{
    public interface IBuilder
    {
        void SetSalt();

        void SetCorn();

        void SerFlour();

        void SetCream();

        Bread GetBread();
    }
}
