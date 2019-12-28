using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_exercises.FactoryModel
{

    // The Product interface declares the operations that all concrete products
    // must implement.
    public interface IProduct
    {
        string Operation();
    }
}
