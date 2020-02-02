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

            Console.WriteLine("Standard basic product:");
            director.buildMinimalViableProduct();
            Console.WriteLine(carBuilder.GetCar().GetResultingComplectation());

            Console.WriteLine("Standard full featured product:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(carBuilder.GetCar().GetResultingComplectation());

            var racingCar = true;
            var builderRacingCar = new CarBuilder(racingCar);
            director.Builder = builderRacingCar;

            Console.WriteLine("Racing basic product:");
            director.buildMinimalViableProduct();
            Console.WriteLine(builderRacingCar.GetCar().GetResultingComplectation());

            Console.WriteLine("Racing full featured product:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builderRacingCar.GetCar().GetResultingComplectation());

            Console.WriteLine("Custom product:");
            carBuilder.Reset();
            carBuilder.SetEngine();
            carBuilder.SetSeats();
            carBuilder.SetTripComputer();
            Console.Write(carBuilder.GetCar().GetResultingComplectation());
            Console.ReadKey();
        }
    }
}
