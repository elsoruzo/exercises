using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite.PriceCalc
{

    class Product : Component
    {
        private int _price{get;set;}  

        public Product(int price){
          _price = price;
        }
        
        public override int Operation()
        {
            return _price;
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}