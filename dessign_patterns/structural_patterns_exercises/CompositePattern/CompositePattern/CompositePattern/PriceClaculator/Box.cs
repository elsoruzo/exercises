using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite.PriceCalc
{

    class Box : Component
    {
        protected List<Component> _children = new List<Component>();
        
        public override void Add(Component component)
        {
            this._children.Add(component);
        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }

        public override int Operation()
        {
            int result = 0;

            foreach (Component component in this._children)
            {
                result += component.Operation();
            }
            
            return result;
        }
    }
}