using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Model
{
    class ConcreteCreator2 : FactoryCreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
