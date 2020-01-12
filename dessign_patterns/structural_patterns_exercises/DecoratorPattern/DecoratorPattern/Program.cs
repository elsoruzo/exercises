namespace ConsoleImplementationOfDecorator
{
    using System;
    using DecoratorModel;
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client();
            var person1 = new ConcretePerson1();

            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(person1);
            Console.WriteLine();
            Console.WriteLine("It's getting cold outside");
            person1.BodyTemperature -= 1.7;
            person1.BodyTemperature -= 1.2;
            Console.WriteLine($"The current BodyTemperature of the person is: {person1.BodyTemperature:F}");

            PantsDecorator personInPants = new PantsDecorator(person1);
            TshirtDecorator personInPantsAndTshirt = new TshirtDecorator(personInPants);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(personInPantsAndTshirt);
            Console.ReadKey();
        }
    }
}













