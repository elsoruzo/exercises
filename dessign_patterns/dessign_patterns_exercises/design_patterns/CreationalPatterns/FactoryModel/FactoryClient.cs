using System;

namespace design_patterns_exercises.FactoryModel
{
    class FactoryClient
    {
        public void Main()
        {
            Console.WriteLine("To get the concrete product number 1 press 1");
            Console.WriteLine("To get the concrete product number 2 press 2");
            char key = Console.ReadKey().KeyChar;
           
            switch (key)
            {
                case '1':
                    Console.WriteLine("App: Launched with the ConcreteCreator1.");
                    ClientCode(new ConcreteCreator1());
                    break;
                case '2':
                    Console.WriteLine("App: Launched with the ConcreteCreator2.");
                    ClientCode(new ConcreteCreator2());
                    break;
                default:
                    Console.WriteLine("App: Launched with the ConcreteCreatorDefoult.");
                    ClientCode(new ConcreteCreatorDefoult());
                    break;
            }

        }


        /// <summary>
        /// The client code works with an instance of a concrete creator, albeit
        /// through its base interface. As long as the client keeps working with
        /// the creator via the base interface, you can pass it any creator's
        /// subclass.
        /// </summary>
        /// <param name="factoryCreator"></param>
        public void ClientCode(FactoryCreator factoryCreator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + factoryCreator.SomeOperation());
            // ...
        }
     }
}
