namespace DecoratorModel
{
    using System;
    public class Client
    {
        public void ClientCode(WormerBaseInterface wormer)
        {
            Console.WriteLine("RESULT: " + wormer.WormUp());
        }
    }
}
