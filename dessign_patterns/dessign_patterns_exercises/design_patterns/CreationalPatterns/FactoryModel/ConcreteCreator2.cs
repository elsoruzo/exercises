using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_exercises.FactoryModel
{
    class ConcreteCreator2 : FactoryCreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
