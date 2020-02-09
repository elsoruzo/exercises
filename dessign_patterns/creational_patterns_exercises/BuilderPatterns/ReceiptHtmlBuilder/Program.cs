namespace CarBuilder
{
    using System;
    using CarBuilder.Models;
    class Program
    {
        static void Main(string[] args)
        {

            var director = new Director();
            var carBuilder = new ReceiptBuilder();
            director.Builder = carBuilder;

            Console.WriteLine("Standard basic Car:");
            director.buildMinimalViableCar();
            Console.WriteLine(carBuilder.GetCar().ToString());

            Console.WriteLine("Full featured Car:");
            director.buildFullFeaturedCar();
            Console.WriteLine(carBuilder.GetCar().ToString());

            Console.WriteLine("Custom product:");
            carBuilder.Reset();
            carBuilder.SetEngine("Electric Engine");
            carBuilder.SetSeats(3);
            carBuilder.SetTripComputer();
            Console.Write(carBuilder.GetCar().ToString());
            Console.ReadKey();
        }
    }
}
