namespace ConsoleImplementationOfAdapter
{
    using System;
    using AdapterModel;
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("START RUNNING ADAPTER.");
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
            Console.WriteLine("END RUNNING ADAPTER.");
            Console.ReadKey();
        }
    }
}













