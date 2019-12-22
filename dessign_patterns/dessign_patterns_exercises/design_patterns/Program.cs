using System;
using design_patterns_exercises.FactoryModel;
using design_patterns_exercises.AdapterModel;
using design_patterns_exercises.BehavioralPatterns.ChainOfResponsibilityModel;

namespace design_patterns_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Другая часть клиентского кода создает саму цепочку.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            // Клиент должен иметь возможность отправлять запрос любому
            // обработчику, а не только первому в цепочке.
            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            ChainOfResponsibilityClient.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            ChainOfResponsibilityClient.ClientCode(squirrel);

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













