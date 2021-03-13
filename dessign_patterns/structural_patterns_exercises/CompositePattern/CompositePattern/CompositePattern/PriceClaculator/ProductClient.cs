using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite.PriceCalc
{
    class ProductClient
    {

        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation().ToString()}\n");
        }


        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }
            
            Console.WriteLine($"RESULT: {component1.Operation().ToString()}");
        }
    }
}