﻿using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_exercises.FactoryModel
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
