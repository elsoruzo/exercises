namespace VisitorTvParts.Models
{
    using System;
    using System.Collections.Generic;

    public class AtvPartsShippingVisitor : ITvPartVisitor
    {

        private double shippingAmount = 0;

        public void Visit(Wheel wheel)
        {
            Console.WriteLine("Wheels are bulky and expensive to ship.");
            shippingAmount += 15;
        }

        public void Visit(Fender fender)
        {
            Console.WriteLine("Fenders are light and cheap to ship.");
            shippingAmount += 3;
        }

        public void Visit(Oil oil)
        {
            Console.WriteLine("Oil is hazardous and has a fee to ship.");
            shippingAmount += 9;
        }


        public void Visit(PartsOrder order)
        {
            Console.WriteLine("If they bought more than 3 things we will give them a discount on shipping.");
            List<ITvPart> parts = order.GetParts();
            if (parts.Count > 3)
            {
                shippingAmount -= 5;
            }
            Console.WriteLine("Shipping amount is: " + shippingAmount);
        }
    }
}