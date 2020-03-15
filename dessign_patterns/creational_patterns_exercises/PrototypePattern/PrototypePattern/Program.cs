namespace PrototypePattern
{
    using System;
    using PrototypePattern.Models;

    public class Client
    {
        public static void Main(string[] args)
        {
            MovieCharacteristics originalObject = new MovieCharacteristics();
            originalObject.GetData();
            Console.WriteLine("originalObject: " + originalObject);
            Console.WriteLine("*******************************************************");
            MovieCharacteristics clonedObject = originalObject.Clone();
            clonedObject.Ratings.Remove("IMDB:9");
            Console.WriteLine("clonedObject.Ratings.Remove('IMDB: 9')=> change inmutable rating field which is deep cloned");
            clonedObject.Genre.Add("SuperHero");
            Console.WriteLine("clonedObject.Genre.Add('SuperHero') = > change in genre which is shallow cloned");
            Console.WriteLine("clonedObject: " + clonedObject);
            Console.WriteLine(" clonedObject shows all above changes");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("originalObject: " + originalObject);
            Console.WriteLine("Original Object shows changes in only genre as");
            Console.WriteLine("it was shallow cloned. Changes in rating will not occur in original onject as it is deep cloned.");
            Console.WriteLine("*******************************************************");
        }
    }
}
