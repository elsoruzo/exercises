using System;
using design_patterns_exercises.FactoryModel;
using design_patterns_exercises.AdapterModel;

namespace design_patterns_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("START RUNNING FACTORY.");
            new FactoryClient().Main();
            Console.WriteLine("END RUNNING FACTORY.");

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













