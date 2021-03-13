using System;
using DesignPatterns.Bridge.Devices;
using DesignPatterns.Bridge.Conceptual;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction;
            // The client code should be able to work   with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);

            Console.Write("===============\n");
            Console.Write("----DEVICE-----\n");
            Console.Write("===============\n");
            TestDevice(new Tv());
            TestDevice(new Radio());

        }

        public static void TestDevice(IDevice device)
        {
            Console.Write("Tests with basic remote.");
            BasicRemote basicRemote = new BasicRemote(device);
            basicRemote.Power();
            device.PrintStatus();

            Console.Write("Tests with advanced remote.");
            AdvancedRemote advancedRemote = new AdvancedRemote(device);
            advancedRemote.Power();
            advancedRemote.Mute();
            device.PrintStatus();
        }
    }
}
