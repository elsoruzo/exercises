namespace DecoratorModel
{
    using System;
    public class Client
    {
        public void ClientCode(WormerBaseInterface wormer, double baseTemperature)
        {
            Console.WriteLine("RESULT: " + wormer.WormUp(baseTemperature));
        }
    }
}
