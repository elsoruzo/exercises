namespace ConsoleImplementationOfFactoryPattern
{
    using System;
    using FactoryModel;
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("START RUNNING FACTORY.");
            new FactoryClient().Main();
            Console.WriteLine("END RUNNING FACTORY.");

        }
    }
}













