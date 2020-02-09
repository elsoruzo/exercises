namespace CarBuilder
{
    using System;
    using CarBuilder.Models;
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var carBuilder = new CarBuilder();
            director.Builder = carBuilder;

            Console.WriteLine("Standard basic Car:");
            Console.WriteLine(director.buildMinimalViableCar());

            Console.WriteLine("Full featured Car:");
            Console.WriteLine(director.buildFullFeaturedCar());

            Console.WriteLine("Custom product:");
            carBuilder.Init()
                      .SetEngine("Electric Engine")
                      .SetSeats(3)
                      .SetTripComputer();
            Console.Write(carBuilder.GetResult());
            Console.ReadKey();
        }
    }
}
