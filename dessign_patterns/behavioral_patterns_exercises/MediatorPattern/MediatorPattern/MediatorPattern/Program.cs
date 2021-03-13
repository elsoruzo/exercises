using System;
using DesignPatterns.Mediator.Conceptual;
using DesignPatterns.Mediator.Concrete;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Console.WriteLine("DesignPatterns.Mediator.Conceptual");
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggets operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();

            Console.WriteLine("DesignPatterns.Mediator.Concrete");

            var stationManager = new StationManager();
            var passengerTrain = new PassengerTrain(stationManager);
            var freightTrain = new FreightTrain(stationManager);

            passengerTrain.Arrive();
            freightTrain.Arrive();
            passengerTrain.Depart();
        }
    }
}
