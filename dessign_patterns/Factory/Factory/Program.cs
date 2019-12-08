using System;
using Factory.Model;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;

            new Client().Main();
            Console.ReadKey();
        }
    }
}













