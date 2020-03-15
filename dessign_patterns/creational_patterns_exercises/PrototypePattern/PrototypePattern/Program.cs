namespace PrototypePattern
{
    using System;
    using PrototypePattern.Models;

    public class Client
    {
        public static void Main(string[] args)
        {
            var originalObject = new MovieCharacteristics();
            var cLientConfigurator = new CLientConfigurator();
            var rottenTomatoesService = new RottenTomatoesService();
            var imdbService = new ImdbService();
            originalObject.GetData();
            Console.WriteLine("originalObject: " + originalObject);
            Console.WriteLine("*******************************************************");

            var clonedObject = originalObject.Clone();
            cLientConfigurator.ConfigureImdbData(clonedObject);
            Console.WriteLine("clonedObject.Ratings.Remove('IMDB: 9')=> change inmutable rating field which is deep cloned");
            cLientConfigurator.ConfigureGeneralGenre(clonedObject);
            Console.WriteLine("clonedObject.Genre.Add('SuperHero') = > change in genre which is shallow cloned");
            Console.WriteLine("clonedObject: " + clonedObject);
            Console.WriteLine(" clonedObject shows all above changes");
            Console.WriteLine("*******************************************************");

            Console.WriteLine("originalObject: " + originalObject);
            Console.WriteLine("Original Object shows changes in only genre as");
            Console.WriteLine("it was shallow cloned. Changes in rating will not occur in original onject as it is deep cloned.");
            Console.WriteLine("*******************************************************");

            imdbService.SendDataToImdb(clonedObject);
            cLientConfigurator.ConfigureRottenTomatoesData(originalObject);
            rottenTomatoesService.SendDataToRottenTomatoes(originalObject);


        }
    }
}
