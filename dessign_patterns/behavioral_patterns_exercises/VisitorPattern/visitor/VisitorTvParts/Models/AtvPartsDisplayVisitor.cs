namespace VisitorTvParts.Models
{
    using System;

    public class AtvPartsDisplayVisitor : ITvPartVisitor
    {

        public void Visit(Wheel wheel)
        {
            Console.WriteLine("We have a wheel.");
        }

        public void Visit(Fender fender)
        {
            Console.WriteLine("We have a fender.");

        }

        public void Visit(Oil oil)
        {
            Console.WriteLine("We have oil.");

        }

        public void Visit(PartsOrder partsOrder)
        {
            Console.WriteLine("We have an order.");

        }

    }

}
